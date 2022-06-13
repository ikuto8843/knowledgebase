using Business.Services;
using DatabaseExtension;
using KnowledgeBase.Business;
using KnowledgeBase.Common;
using KnowledgeBase.Const;
using KnowledgeBase.Dtos;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MicroResolver;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WinClientWPF.Behaviors;

namespace WinClientWPF.ViewModels
{
    public class KihonjouhouEditModel : ViewModelBase
    {

        /// <summary>
        /// 基本情報サービス
        /// </summary>
        public KihonJouhouService KihonJouhouService { get; set; }

        /// <summary>
        /// 保存コマンド
        /// </summary>
        public DelegateCommand SaveCommand { get; set; }

        /// <summary>
        /// 削除コマンド
        /// </summary>
        public DelegateCommand DeleteCommand { get; set; }

        /// <summary>
        /// 編集データ
        /// </summary>
        public ReactiveProperty<KihonJouhouDetail> EditData { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public KihonjouhouEditModel()
        {
            this.KihonJouhouService = new KihonJouhouService();

            this.SaveCommand = new DelegateCommand(
                () => { this.Save(); },
                () => { return true; }
            );

            this.DeleteCommand = new DelegateCommand(
                () => { this.Delete(); },
                () => { return true; }
            );

            this.EditData = new ReactiveProperty<KihonJouhouDetail>();

            this.EditData.Subscribe(_ => this.ChangeProperty());
        }

        /// <summary>
        /// 保存
        /// </summary>
        public async Task Save()
        {
            if(this.EditData != null)
            {
                try
                {
                    this.KihonJouhouService.Save(this.EditData.Value);

                    await this.CloseWindow("データの保存が完了しました。", "完了通知");
                }
                catch(DatabaseException ex)
                {
                    this.ShowDataBaseExceptionDialog(ex.Message);
                }
            }
        }

        /// <summary>
        /// 削除
        /// </summary>
        public async Task Delete()
        {
            if (this.EditData != null)
            {
                var result = await this.DeleteConfirm();

                if (!result) return;

                this.KihonJouhouService.Delete(this.EditData.Value.Key.ID);

                await this.CloseWindow("データの保存が完了しました。", "完了通知");
            }
        }
    }
}
