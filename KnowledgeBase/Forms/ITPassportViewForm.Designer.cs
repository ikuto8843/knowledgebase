namespace KnowledgeBase.Forms
{
    partial class ITPassportViewForm
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
            this.txtKoumokuName = new System.Windows.Forms.TextBox();
            this.lblKoumokuName = new System.Windows.Forms.Label();
            this.lblKoumokuNo = new System.Windows.Forms.Label();
            this.txtKoumokuNoFrom = new System.Windows.Forms.TextBox();
            this.txtKoumokuNoTo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSearchdNumbers = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbImportance = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxCategory = new System.Windows.Forms.CheckBox();
            this.checkBoxJuuyoudo = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxCategory);
            this.groupBox1.Controls.Add(this.checkBoxJuuyoudo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbCategory);
            this.groupBox1.Controls.Add(this.cmbImportance);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtKoumokuNoTo);
            this.groupBox1.Controls.Add(this.txtKoumokuNoFrom);
            this.groupBox1.Controls.Add(this.lblKoumokuNo);
            this.groupBox1.Controls.Add(this.lblKoumokuName);
            this.groupBox1.Controls.Add(this.txtKoumokuName);
            this.groupBox1.Location = new System.Drawing.Point(17, 15);
            this.groupBox1.Size = new System.Drawing.Size(700, 190);
            this.groupBox1.Text = "検索条件";
            this.groupBox1.Controls.SetChildIndex(this.txtKoumokuName, 0);
            this.groupBox1.Controls.SetChildIndex(this.lblKoumokuName, 0);
            this.groupBox1.Controls.SetChildIndex(this.lblKoumokuNo, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtKoumokuNoFrom, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtKoumokuNoTo, 0);
            this.groupBox1.Controls.SetChildIndex(this.label1, 0);
            this.groupBox1.Controls.SetChildIndex(this.cmbImportance, 0);
            this.groupBox1.Controls.SetChildIndex(this.cmbCategory, 0);
            this.groupBox1.Controls.SetChildIndex(this.label2, 0);
            this.groupBox1.Controls.SetChildIndex(this.label3, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxJuuyoudo, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxCategory, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnShowDatatable, 0);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Location = new System.Drawing.Point(13, 582);
            this.groupBox2.Size = new System.Drawing.Size(783, 61);
            this.groupBox2.Text = "";
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRegister.Location = new System.Drawing.Point(549, 19);
            this.btnRegister.Size = new System.Drawing.Size(109, 36);
            // 
            // btnShowDatatable
            // 
            this.btnShowDatatable.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnShowDatatable.Location = new System.Drawing.Point(565, 135);
            this.btnShowDatatable.Size = new System.Drawing.Size(127, 36);
            this.btnShowDatatable.TabIndex = 12;
            // 
            // btnRevise
            // 
            this.btnRevise.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRevise.Location = new System.Drawing.Point(666, 19);
            this.btnRevise.Size = new System.Drawing.Size(99, 36);
            // 
            // txtKoumokuName
            // 
            this.txtKoumokuName.Location = new System.Drawing.Point(121, 67);
            this.txtKoumokuName.Name = "txtKoumokuName";
            this.txtKoumokuName.Size = new System.Drawing.Size(262, 35);
            this.txtKoumokuName.TabIndex = 5;
            // 
            // lblKoumokuName
            // 
            this.lblKoumokuName.AutoSize = true;
            this.lblKoumokuName.Location = new System.Drawing.Point(39, 70);
            this.lblKoumokuName.Name = "lblKoumokuName";
            this.lblKoumokuName.Size = new System.Drawing.Size(78, 28);
            this.lblKoumokuName.TabIndex = 4;
            this.lblKoumokuName.Text = "項目名";
            // 
            // lblKoumokuNo
            // 
            this.lblKoumokuNo.AutoSize = true;
            this.lblKoumokuNo.Location = new System.Drawing.Point(33, 33);
            this.lblKoumokuNo.Name = "lblKoumokuNo";
            this.lblKoumokuNo.Size = new System.Drawing.Size(85, 28);
            this.lblKoumokuNo.TabIndex = 0;
            this.lblKoumokuNo.Text = "項目No";
            // 
            // txtKoumokuNoFrom
            // 
            this.txtKoumokuNoFrom.Location = new System.Drawing.Point(121, 30);
            this.txtKoumokuNoFrom.Name = "txtKoumokuNoFrom";
            this.txtKoumokuNoFrom.Size = new System.Drawing.Size(70, 35);
            this.txtKoumokuNoFrom.TabIndex = 1;
            // 
            // txtKoumokuNoTo
            // 
            this.txtKoumokuNoTo.Location = new System.Drawing.Point(237, 30);
            this.txtKoumokuNoTo.Name = "txtKoumokuNoTo";
            this.txtKoumokuNoTo.Size = new System.Drawing.Size(70, 35);
            this.txtKoumokuNoTo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "～";
            // 
            // lblSearchdNumbers
            // 
            this.lblSearchdNumbers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchdNumbers.AutoSize = true;
            this.lblSearchdNumbers.Location = new System.Drawing.Point(701, 210);
            this.lblSearchdNumbers.Name = "lblSearchdNumbers";
            this.lblSearchdNumbers.Size = new System.Drawing.Size(78, 28);
            this.lblSearchdNumbers.TabIndex = 2;
            this.lblSearchdNumbers.Text = "検索数";
            this.lblSearchdNumbers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 237);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(782, 337);
            this.dataGridView1.TabIndex = 3;
            // 
            // cmbImportance
            // 
            this.cmbImportance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbImportance.FormattingEnabled = true;
            this.cmbImportance.Location = new System.Drawing.Point(121, 104);
            this.cmbImportance.Name = "cmbImportance";
            this.cmbImportance.Size = new System.Drawing.Size(150, 36);
            this.cmbImportance.TabIndex = 7;
            this.cmbImportance.SelectedIndexChanged += new System.EventHandler(this.cmbImportance_SelectedIndexChanged);
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(121, 141);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(150, 36);
            this.cmbCategory.TabIndex = 10;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "分野";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "重要度";
            // 
            // checkBoxCategory
            // 
            this.checkBoxCategory.AutoSize = true;
            this.checkBoxCategory.Location = new System.Drawing.Point(277, 141);
            this.checkBoxCategory.Name = "checkBoxCategory";
            this.checkBoxCategory.Size = new System.Drawing.Size(218, 32);
            this.checkBoxCategory.TabIndex = 11;
            this.checkBoxCategory.Text = "分野別を無効にする";
            this.checkBoxCategory.UseVisualStyleBackColor = true;
            this.checkBoxCategory.CheckedChanged += new System.EventHandler(this.checkBoxCategory_CheckedChanged);
            // 
            // checkBoxJuuyoudo
            // 
            this.checkBoxJuuyoudo.AutoSize = true;
            this.checkBoxJuuyoudo.Location = new System.Drawing.Point(276, 106);
            this.checkBoxJuuyoudo.Name = "checkBoxJuuyoudo";
            this.checkBoxJuuyoudo.Size = new System.Drawing.Size(218, 32);
            this.checkBoxJuuyoudo.TabIndex = 8;
            this.checkBoxJuuyoudo.Text = "重要度を無効にする";
            this.checkBoxJuuyoudo.UseVisualStyleBackColor = true;
            this.checkBoxJuuyoudo.CheckedChanged += new System.EventHandler(this.checkBoxJuuyoudo_CheckedChanged);
            // 
            // ITPassportViewForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(816, 658);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblSearchdNumbers);
            this.Name = "ITPassportViewForm";
            this.Text = "一覧 - ITパスポート試験";
            this.Load += new System.EventHandler(this.ITPassportViewForm_Load);
            this.Controls.SetChildIndex(this.lblSearchdNumbers, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKoumokuNoTo;
        private System.Windows.Forms.TextBox txtKoumokuNoFrom;
        private System.Windows.Forms.Label lblKoumokuNo;
        private System.Windows.Forms.Label lblKoumokuName;
        private System.Windows.Forms.TextBox txtKoumokuName;
        private System.Windows.Forms.Label lblSearchdNumbers;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbImportance;
        private System.Windows.Forms.CheckBox checkBoxCategory;
        private System.Windows.Forms.CheckBox checkBoxJuuyoudo;
    }
}