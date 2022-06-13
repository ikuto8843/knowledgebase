namespace KnowledgeBase.Forms
{
    partial class SelectionForm
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
            this.checkBoxEditForm = new System.Windows.Forms.CheckBox();
            this.checkBoxViewForm = new System.Windows.Forms.CheckBox();
            this.btnShowKihonJouhou = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowTransactionViewForm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxEditForm
            // 
            this.checkBoxEditForm.AutoSize = true;
            this.checkBoxEditForm.Location = new System.Drawing.Point(8, 65);
            this.checkBoxEditForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxEditForm.Name = "checkBoxEditForm";
            this.checkBoxEditForm.Size = new System.Drawing.Size(178, 24);
            this.checkBoxEditForm.TabIndex = 3;
            this.checkBoxEditForm.TabStop = false;
            this.checkBoxEditForm.Text = "編集画面を最大化する";
            this.checkBoxEditForm.UseVisualStyleBackColor = true;
            this.checkBoxEditForm.CheckedChanged += new System.EventHandler(this.checkBoxEditForm_CheckedChanged);
            // 
            // checkBoxViewForm
            // 
            this.checkBoxViewForm.AutoSize = true;
            this.checkBoxViewForm.Location = new System.Drawing.Point(8, 31);
            this.checkBoxViewForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxViewForm.Name = "checkBoxViewForm";
            this.checkBoxViewForm.Size = new System.Drawing.Size(178, 24);
            this.checkBoxViewForm.TabIndex = 2;
            this.checkBoxViewForm.TabStop = false;
            this.checkBoxViewForm.Text = "一覧画面を最大化する";
            this.checkBoxViewForm.UseVisualStyleBackColor = true;
            this.checkBoxViewForm.CheckedChanged += new System.EventHandler(this.checkBoxViewForm_CheckedChanged);
            // 
            // btnShowKihonJouhou
            // 
            this.btnShowKihonJouhou.Location = new System.Drawing.Point(23, 34);
            this.btnShowKihonJouhou.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowKihonJouhou.Name = "btnShowKihonJouhou";
            this.btnShowKihonJouhou.Size = new System.Drawing.Size(221, 33);
            this.btnShowKihonJouhou.TabIndex = 0;
            this.btnShowKihonJouhou.Text = "基本情報技術者試験";
            this.btnShowKihonJouhou.UseVisualStyleBackColor = true;
            this.btnShowKihonJouhou.Click += new System.EventHandler(this.btnShowKihonJouhou_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "ESC ： アプリ終了";
            // 
            // btnShowTransactionViewForm
            // 
            this.btnShowTransactionViewForm.Location = new System.Drawing.Point(252, 35);
            this.btnShowTransactionViewForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowTransactionViewForm.Name = "btnShowTransactionViewForm";
            this.btnShowTransactionViewForm.Size = new System.Drawing.Size(221, 32);
            this.btnShowTransactionViewForm.TabIndex = 1;
            this.btnShowTransactionViewForm.Text = "ITパスポート試験";
            this.btnShowTransactionViewForm.UseVisualStyleBackColor = true;
            this.btnShowTransactionViewForm.Visible = false;
            this.btnShowTransactionViewForm.Click += new System.EventHandler(this.btnShowTransactionViewForm_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxEditForm);
            this.groupBox1.Controls.Add(this.checkBoxViewForm);
            this.groupBox1.Location = new System.Drawing.Point(23, 77);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(253, 110);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "画面の初期表示設定";
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 211);
            this.Controls.Add(this.btnShowKihonJouhou);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowTransactionViewForm);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SelectionForm";
            this.Text = "選択画面";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxEditForm;
        private System.Windows.Forms.CheckBox checkBoxViewForm;
        private System.Windows.Forms.Button btnShowKihonJouhou;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowTransactionViewForm;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}