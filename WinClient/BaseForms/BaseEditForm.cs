using KnowledgeBase.Const;
using KnowledgeBase.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnowledgeBase.BaseForms
{
    public partial class BaseEditForm : BaseMainForm
    {
        #region プロパティ

        /// <summary>
        /// モード名
        /// </summary>
        public ModeSelection ModeSelection { get; set; }

        /// <summary>
        /// 一覧画面
        /// </summary>
        public BaseViewForm ViewForm { get; set; }

        /// <summary>
        /// データが登録・更新されたかどうか
        /// </summary>
        public bool IsTransacted { get; set; }

        /// <summary>
        /// 検索条件
        /// </summary>
        public object SearchCondtion { get; set; }

        #endregion

        #region コンストラクタ

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public BaseEditForm()
        {
            InitializeComponent();
        }

        #endregion

        #region イベントハンドラ

        /// <summary>
        /// フォームキーダウンイベント
        /// </summary>
        /// <param name="sender">イベント発生元</param>
        /// <param name="e">イベント引数</param>
        private void BaseEditForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //if (e.Shift)
                //{
                //    ProcessTabKey(false);
                //}
                //else
                //{
                //    ProcessTabKey(true);
                //}
            }
        }

        /// <summary>
        /// ボタンキーダウンイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override void PressShortcutKeys(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:

                    if (ModeSelection == ModeSelection.register) {

                        var dialogResult = MessageBox.Show("フォームを本当に閉じますか？？", "確認", MessageBoxButtons.YesNoCancel);

                        if (dialogResult != DialogResult.Yes) return;
                    }

                    ViewForm.Show();
                    this.Close();
                    break;

                case Keys.F5:
                    UpdateOrRegister();
                    break;
            }
        }

        /// <summary>
        /// フォームロードイベント
        /// </summary>
        /// <param name="sender">イベント発生元</param>
        /// <param name="e">イベント引数</param>
        private void BaseEditForm_Load(object sender, EventArgs e)
        {
            //初期表示サイズのモードを決定する
            if (FormSize.EditFormSizeMode == FormSizeMode.EditForm.maxsize)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }

            //権限が閲覧専用の場合はコントロールをオフにする
            if (SystemAuthority.AccessAuthority == Authority.readOnly)
            {
                this.Enabled = false;
            }

            //権限ステータスを表示
            if (SystemAuthority.AccessAuthority == Authority.edit)
            {
                this.lblAuthorityStatus.Text = AuthorityStatus.edit;
            }
            else if (SystemAuthority.AccessAuthority == Authority.readOnly)
            {
                this.lblAuthorityStatus.Text = AuthorityStatus.readOnly;
            }
        }

        /// <summary>
        /// 登録ボタン押下イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            UpdateOrRegister();
        }

        /// <summary>
        /// 終了ボタン押下イベント
        /// </summary>
        /// <param name="sender">イベント発生元</param>
        /// <param name="e">イベント引数</param>
        private void btnEnd_Click(object sender, EventArgs e)
        {
            ViewForm.Show();
            ViewForm.EditForm = this;
            this.Close();
        }

        /// <summary>
        /// 削除ボタン押下イベント
        /// </summary>
        /// <param name="sender">イベント発生元</param>
        /// <param name="e">イベント引数</param>
        private void btnDelete_Click(object sender, EventArgs e)
        {

            Delete();
        }

        #endregion

        #region メソッド

        /// <summary>
        /// データを登録または更新します
        /// </summary>
        public virtual void UpdateOrRegister() { }

        /// <summary>
        /// データを削除します
        /// </summary>
        public virtual void Delete() { }

        #endregion
    }
}
