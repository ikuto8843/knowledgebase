namespace KnowledgeBase.BaseForms
{
    public partial class BaseViewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
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
            this.groupBox1.Location = new System.Drawing.Point(14, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(770, 152);
            this.groupBox1.TabIndex = 0;
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
            this.btnShowDatatable.Click += new System.EventHandler(this.btnShowDatatable_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblAuthorityStatus);
            this.groupBox2.Controls.Add(this.btnRevise);
            this.groupBox2.Controls.Add(this.btnRegister);
            this.groupBox2.Location = new System.Drawing.Point(2, 923);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1352, 93);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // lblAuthorityStatus
            // 
            this.lblAuthorityStatus.AutoSize = true;
            this.lblAuthorityStatus.Location = new System.Drawing.Point(11, 29);
            this.lblAuthorityStatus.Name = "lblAuthorityStatus";
            this.lblAuthorityStatus.Size = new System.Drawing.Size(80, 19);
            this.lblAuthorityStatus.TabIndex = 2;
            this.lblAuthorityStatus.Text = "権限を表示";
            // 
            // btnRevise
            // 
            this.btnRevise.Enabled = false;
            this.btnRevise.Location = new System.Drawing.Point(1116, 38);
            this.btnRevise.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRevise.Name = "btnRevise";
            this.btnRevise.Size = new System.Drawing.Size(187, 36);
            this.btnRevise.TabIndex = 1;
            this.btnRevise.Text = "F9 修正";
            this.btnRevise.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(904, 38);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(191, 36);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "F5 登録";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // BaseViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1368, 1061);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Meiryo UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BaseViewForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "BaseViewForm";
            this.Activated += new System.EventHandler(this.BaseViewForm_Activated);
            this.Load += new System.EventHandler(this.BaseViewForm_Load);
            this.SizeChanged += new System.EventHandler(this.BaseViewForm_SizeChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button btnRegister;
        public System.Windows.Forms.Button btnShowDatatable;
        public System.Windows.Forms.Button btnRevise;
        private System.Windows.Forms.Label lblAuthorityStatus;
        public System.Windows.Forms.GroupBox groupBox1;
    }
}