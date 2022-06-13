using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnowledgeBase.NewBaseForms
{
    public class BaseViewForm<T> : Form where T : class, new()
    {
        #region コントロール

        public GroupBox groupBox1;
        protected GroupBox groupBox2;
        private Label lblAuthorityStatus;
        public Button btnRevise;
        public Button btnRegister;
        public Button btnShowDatatable;

        #endregion

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowDatatable = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAuthorityStatus = new System.Windows.Forms.Label();
            this.btnRevise = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShowDatatable);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(770, 152);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnShowDatatable
            // 
            this.btnShowDatatable.Location = new System.Drawing.Point(575, 106);
            this.btnShowDatatable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowDatatable.Name = "btnShowDatatable";
            this.btnShowDatatable.Size = new System.Drawing.Size(187, 36);
            this.btnShowDatatable.TabIndex = 2;
            this.btnShowDatatable.Text = "F3 検索";
            this.btnShowDatatable.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblAuthorityStatus);
            this.groupBox2.Controls.Add(this.btnRevise);
            this.groupBox2.Controls.Add(this.btnRegister);
            this.groupBox2.Location = new System.Drawing.Point(13, 403);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(770, 93);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // lblAuthorityStatus
            // 
            this.lblAuthorityStatus.AutoSize = true;
            this.lblAuthorityStatus.Location = new System.Drawing.Point(11, 29);
            this.lblAuthorityStatus.Name = "lblAuthorityStatus";
            this.lblAuthorityStatus.Size = new System.Drawing.Size(62, 12);
            this.lblAuthorityStatus.TabIndex = 2;
            this.lblAuthorityStatus.Text = "権限を表示";
            // 
            // btnRevise
            // 
            this.btnRevise.Enabled = false;
            this.btnRevise.Location = new System.Drawing.Point(629, 29);
            this.btnRevise.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRevise.Name = "btnRevise";
            this.btnRevise.Size = new System.Drawing.Size(133, 36);
            this.btnRevise.TabIndex = 1;
            this.btnRevise.Text = "F9 修正";
            this.btnRevise.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(485, 29);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(136, 36);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "F5 登録";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // BaseViewForm
            // 
            this.ClientSize = new System.Drawing.Size(818, 523);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "BaseViewForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
