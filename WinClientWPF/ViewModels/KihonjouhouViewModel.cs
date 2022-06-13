using Business.Services;
using KnowledgeBase.Business;
using KnowledgeBase.Common;
using KnowledgeBase.Const;
using KnowledgeBase.Dtos;
using Prism.Navigation;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WinClientWPF.ViewModels
{
    public class KihonjouhouViewModel : ViewModelBase
    {

        /// <summary>
        /// 基本情報サービス
        /// </summary>
        public KihonJouhouService KihonJouhouService { get; set; }

        /// <summary>
        /// 検索コマンド
        /// </summary>
        public DelegateCommand SearchCommand { get; set; }

        /// <summary>
        /// 編集画面表示コマンド
        /// </summary>
        public DelegateCommand ShowEditView { get; set; }

        /// <summary>
        /// 新規登録画面表示コマンド
        /// </summary>
        public DelegateCommand ShowRegisterView { get; set; }

        /// <summary>
        /// 検索条件
        /// </summary>
        public KihonJouhouView.SearchCondition SearchCondition { get; set; }

        /// <summary>
        /// 結果一覧
        /// </summary>
        public ObservableCollection<KihonJouhouView.DataRow> ViewList { get; set; } = new ObservableCollection<KihonJouhouView.DataRow>();

        /// <summary>
        /// 選択行
        /// </summary>
        public KihonJouhouView.DataRow SelectedItem { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public KihonjouhouViewModel()
        {
            this.KihonJouhouService = new KihonJouhouService();
            this.SearchCondition = new KihonJouhouView.SearchCondition();

            this.SearchCommand = new DelegateCommand(
                () => { this.FillViewModel(); },
                () => { return true; }
            ) ;

            this.ShowEditView = new DelegateCommand(
                () => { this.ShowEditForm(); },
                () => { return true; }
            );

            this.ShowRegisterView = new DelegateCommand(
                () => { this.ShowRegisterForm(); },
                () => { return true; }
            );
        }

        /// <summary>
        /// 検索処理
        /// </summary>
        public void FillViewModel()
        {
            this.ViewList.Clear();

            var viewData = this.KihonJouhouService.GetViewData(this.SearchCondition);

            foreach(var data in viewData)
            {
                this.ViewList.Add(data);
            }
        }

        public void ShowEditForm()
        {
            if(this.SelectedItem != null)
            {
                var detail = this.KihonJouhouService.GetEditData(this.SelectedItem.ID);

                KihonjouhouEditModel editModel = new KihonjouhouEditModel() { EditData = new ReactiveProperty<KihonJouhouDetail>(detail) };

                App.ShowView<KihonjouhouEditModel>(editModel);
            }
        }

        public void ShowRegisterForm()
        {
            KihonjouhouEditModel editModel = new KihonjouhouEditModel() { EditData = new ReactiveProperty<KihonJouhouDetail>() };

            App.ShowView<KihonjouhouEditModel>(editModel);
        }
    }
}
