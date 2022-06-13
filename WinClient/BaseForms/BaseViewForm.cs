using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KnowledgeBase.Const;
using KnowledgeBase.Settings;

namespace KnowledgeBase.BaseForms
{
    public partial class BaseViewForm : BaseMainForm
    {
        #region プロパティ

        /// <summary>
        /// 編集画面
        /// </summary>
        public BaseEditForm EditForm { get; set; }

        /// <summary>
        /// メニュー選択画面
        /// </summary>
        public Form SelectionForm { get; set; }

        /// <summary>
        /// データの登録または更新が行われたか
        /// True:データの登録・更新が行われた
        /// False:データの登録・更新が行われなかった
        /// </summary>
        public bool IsTransacted { get; set; }

        /// <summary>
        /// フォームの高さの最小値
        /// </summary>
        public int minimumHeight { get; set; }

        /// <summary>
        /// フォームの幅の最小値
        /// </summary>
        public int minimumWidth { get; set; }

        #endregion

        #region フィールド

        /// <summary>
        /// フォームがアクティブになったかどうか
        /// True:1回でもアクティブになった場合
        /// False;一回もアクティブになってない場合
        /// </summary>
        private bool isShowned;

        #endregion

        #region コンストラクタ

        public BaseViewForm()
        {
            InitializeComponent();
            isShowned = false;
            EditForm = new BaseEditForm();
        }

        #endregion

        #region イベントハンドラ

        /// <summary>
        /// このフォームがアクティブになったときのイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BaseViewForm_Activated(object sender, EventArgs e)
        {
            if (!isShowned && IsTransacted) {

                ShowData();
                isShowned = true;
            }
        }

        /// <summary>
        /// ショートカットキーの入力イベント
        /// </summary>
        /// <param name="e"></param>
        public override void PressShortcutKeys(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    SelectionForm.Show();
                    this.Close();
                    break;

                case Keys.F3:
                    ShowData();
                    break;
                case Keys.F5:
                    ShowEditFormForReister();
                    break;

                case Keys.F9:
                    ShowEditFormForRevise();
                    break;
            }
        }

        /// <summary>
        /// フォームロードイベント
        /// </summary>
        /// <param name="sender">イベント発生元</param>
        /// <param name="e">イベント引数</param>
        private void BaseViewForm_Load(object sender, EventArgs e)
        {
            //初期表示サイズのモードを決定する
            if (FormSize.ViewFormSizeMode == FormSizeMode.ViewForm.maxsize)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }

            //権限ステータスを表示
            if(SystemAuthority.AccessAuthority == Authority.edit)
            {
                this.lblAuthorityStatus.Text = AuthorityStatus.edit;
            }
            else if(SystemAuthority.AccessAuthority == Authority.readOnly)
            {
                this.lblAuthorityStatus.Text = AuthorityStatus.readOnly;
            }
        }

        /// <summary>
        /// 検索ボタンイベントハンドラ
        /// </summary>
        /// <param name="sender">イベント発生元</param>
        /// <param name="e">イベント引数</param>
        private void btnShowDatatable_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        /// <summary>
        /// 登録・更新ボタンイベントハンドラ
        /// </summary>
        /// <param name="sender">イベント発生元</param>
        /// <param name="e">イベント引数</param>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            ShowEditFormForReister();
        }

        /// <summary>
        /// サイズ変更がされたときに発生するイベント
        /// </summary>
        /// <param name="sender">イベント発生元</param>
        /// <param name="e">イベント引数</param>
        private void BaseViewForm_SizeChanged(object sender, EventArgs e)
        {
            //フォームの幅が最小値よりも小さくなった場合は規定の最小値まで戻す
            if (this.Width < this.minimumWidth)
            {
                this.Width = this.minimumWidth;
            }

            //フォームの高さが最小値よりも小さくなった場合は規定の最小値まで戻す
            if (this.Height < this.minimumHeight)
            {
                this.Height = this.minimumHeight;
            }
        }

        #endregion

        #region メソッド

        /////////////////////////////////
        ///オーバーライド用メソッド群
        /////////////////////////////////

        /// <summary>
        /// データグリッドビューにデータを表示する
        /// </summary>
        public virtual void ShowData() { }

        /// <summary>
        /// 編集画面を表示する（データ登録用）
        /// </summary>
        public virtual void ShowEditFormForReister() { }

        /// <summary>
        /// 編集画面を表示する（データ更新、削除用）
        /// </summary>
        public virtual void ShowEditFormForRevise() { }

        #endregion
    }
}
