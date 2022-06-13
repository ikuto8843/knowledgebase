using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KnowledgeBase.BaseForms;
using KnowledgeBase.Const;
using KnowledgeBase.Settings;

namespace KnowledgeBase.Forms
{
    public partial class LoginForm : BaseMainForm
    {
        public LoginForm()
        {
            InitializeComponent();

            //ログイン用IDとパスワードの設定
            this.txtId.Text = LoginConst.EditUser.id;
            this.txtPass.Text = LoginConst.EditUser.pass;
        }

        /// <summary>
        /// フォーム表示イベント
        /// </summary>
        /// <param name="sender">イベント発生元</param>
        /// <param name="e">イベント引数</param>
        private void LoginForm_Shown(object sender, EventArgs e)
        {
            DoLoginProcess();
        }

        /// <summary>
        /// キーダウンイベント
        /// </summary>
        /// <param name="sender">イベント発生元</param>
        /// <param name="e">イベント引数</param>
        public override void PressShortcutKeys(object sender, KeyEventArgs e)
        {
            //base.PressShortcutKeys(sender, e);

            if(e.KeyCode == Keys.Escape)
            {
                DialogResult result = MessageBox.Show("アプリケーションを終了します。よろしいですか？", "アプリケーション終了メッセージ", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    this.Close();
                    Environment.Exit(0);
                }
            }
        }

        /// <summary>
        /// ボタン押下イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            DoLoginProcess();
        }

        /// <summary>
        /// ログイン処理を行う
        /// </summary>
        private void DoLoginProcess()
        {
            if (this.txtId.Text == LoginConst.EditUser.id && this.txtPass.Text == LoginConst.EditUser.pass)
            {
                //編集可能な権限を与える
                SystemAuthority.AccessAuthority = Authority.edit;

                this.Hide();
                SelectionForm form = new SelectionForm();
                form.LoginForm = this;
                form.Show();

            }
            else if (this.txtId.Text == LoginConst.ReadOnlyUser.id && this.txtPass.Text == LoginConst.ReadOnlyUser.pass)
            {
                //閲覧専用の権限を与える
                SystemAuthority.AccessAuthority = Authority.readOnly;

                this.Hide();
                SelectionForm form = new SelectionForm();
                form.LoginForm = this;
                form.Show();
            }
            else
            {

                MessageBox.Show("IDまたはパスワードが間違っています。");
            }
        }
    }
}
