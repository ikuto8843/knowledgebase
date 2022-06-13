using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using KnowledgeBase.BaseForms;
using KnowledgeBase.Settings;
using KnowledgeBase.Const;
using System.Web.Hosting;
using Core.Utilities;
using KnowledgeBase.Dtos;

namespace KnowledgeBase.Forms
{
    public partial class SelectionForm : BaseMainForm
    {
        /// <summary>
        /// ログインフォーム
        /// </summary>
        public Form LoginForm { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public SelectionForm()
        {
            InitializeComponent();

            FormSize.ViewFormSizeMode = FormSizeMode.ViewForm.normal;
            FormSize.EditFormSizeMode = FormSizeMode.EditForm.normal;
        }

        /// <summary>
        /// キーダウンイベント
        /// </summary>
        /// <param name="sender">イベント発生元</param>
        /// <param name="e">イベント引数</param>
        public override void PressShortcutKeys(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:

                    LoginForm.Show();
                    this.Close();
                    break;
            }
        }

        /// <summary>
        /// ITパスポート試験のボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowTransactionViewForm_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //form.SelectionForm = this;
            //form.Show();
        }

        /// <summary>
        /// 基本情報技術者試験のボタン
        /// </summary>
        /// <param name="sender">イベント発生元</param>
        /// <param name="e">イベント引数</param>
        private void btnShowKihonJouhou_Click(object sender, EventArgs e)
        {
            SubFormDispatcher.ShowFormDialog<KihonJouhouView>(this);
        }

        /// <summary>
        /// チェックボックスのイベント（一覧画面用）
        /// </summary>
        /// <param name="sender">イベント発生元</param>
        /// <param name="e">イベント引数</param>
        private void checkBoxViewForm_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxViewForm.Checked)
            {
                FormSize.ViewFormSizeMode = FormSizeMode.ViewForm.maxsize;
            }
            else
            {
                FormSize.ViewFormSizeMode = FormSizeMode.ViewForm.normal;
            }
        }

        /// <summary>
        /// チェックボックスのイベント（編集画面用）
        /// </summary>
        /// <param name="sender">イベント発生元</param>
        /// <param name="e">イベント引数</param>
        private void checkBoxEditForm_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxEditForm.Checked)
            {
                FormSize.EditFormSizeMode = FormSizeMode.EditForm.maxsize;
            }
            else
            {
                FormSize.EditFormSizeMode = FormSizeMode.EditForm.normal;
            }
        }
    }
}
