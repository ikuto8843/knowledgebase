namespace KnowledgeBase.Forms
{
    partial class KihonJouhouViewForm
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
            this.lblSearchdNumbers = new System.Windows.Forms.Label();
            this.dgRowList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRating = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkIsRatingEnabled = new System.Windows.Forms.CheckBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkIsCategoryEnabled = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRowList)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.chkIsCategoryEnabled);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblSearchdNumbers);
            this.groupBox1.Controls.Add(this.cmbCategory);
            this.groupBox1.Controls.Add(this.chkIsRatingEnabled);
            this.groupBox1.Controls.Add(this.cmbRating);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblKoumokuName);
            this.groupBox1.Controls.Add(this.txtKoumokuName);
            this.groupBox1.Size = new System.Drawing.Size(600, 180);
            this.groupBox1.Text = "検索条件";
            this.groupBox1.Controls.SetChildIndex(this.btnShowDatatable, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtKoumokuName, 0);
            this.groupBox1.Controls.SetChildIndex(this.lblKoumokuName, 0);
            this.groupBox1.Controls.SetChildIndex(this.label2, 0);
            this.groupBox1.Controls.SetChildIndex(this.cmbRating, 0);
            this.groupBox1.Controls.SetChildIndex(this.chkIsRatingEnabled, 0);
            this.groupBox1.Controls.SetChildIndex(this.cmbCategory, 0);
            this.groupBox1.Controls.SetChildIndex(this.lblSearchdNumbers, 0);
            this.groupBox1.Controls.SetChildIndex(this.label3, 0);
            this.groupBox1.Controls.SetChildIndex(this.chkIsCategoryEnabled, 0);
            this.groupBox1.Controls.SetChildIndex(this.label4, 0);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Location = new System.Drawing.Point(13, 591);
            this.groupBox2.Size = new System.Drawing.Size(932, 90);
            this.groupBox2.Text = "";
            // 
            // btnRevise
            // 
            this.btnRevise.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRevise.Location = new System.Drawing.Point(774, 32);
            this.btnRevise.Size = new System.Drawing.Size(150, 45);
            this.btnRevise.Text = "修正";
            this.btnRevise.Visible = false;
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRegister.Location = new System.Drawing.Point(616, 32);
            this.btnRegister.Size = new System.Drawing.Size(150, 45);
            // 
            // btnShowDatatable
            // 
            this.btnShowDatatable.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnShowDatatable.Location = new System.Drawing.Point(452, 120);
            this.btnShowDatatable.Size = new System.Drawing.Size(140, 50);
            this.btnShowDatatable.TabIndex = 12;
            this.btnShowDatatable.Click += new System.EventHandler(this.btnShowDatatable_Click);
            // 
            // txtKoumokuName
            // 
            this.txtKoumokuName.Location = new System.Drawing.Point(76, 33);
            this.txtKoumokuName.Name = "txtKoumokuName";
            this.txtKoumokuName.Size = new System.Drawing.Size(262, 19);
            this.txtKoumokuName.TabIndex = 5;
            // 
            // lblKoumokuName
            // 
            this.lblKoumokuName.AutoSize = true;
            this.lblKoumokuName.Location = new System.Drawing.Point(16, 36);
            this.lblKoumokuName.Name = "lblKoumokuName";
            this.lblKoumokuName.Size = new System.Drawing.Size(41, 12);
            this.lblKoumokuName.TabIndex = 4;
            this.lblKoumokuName.Text = "項目名";
            // 
            // lblSearchdNumbers
            // 
            this.lblSearchdNumbers.AutoSize = true;
            this.lblSearchdNumbers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSearchdNumbers.Location = new System.Drawing.Point(4, 163);
            this.lblSearchdNumbers.Name = "lblSearchdNumbers";
            this.lblSearchdNumbers.Size = new System.Drawing.Size(41, 12);
            this.lblSearchdNumbers.TabIndex = 2;
            this.lblSearchdNumbers.Text = "検索数";
            this.lblSearchdNumbers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgRowList
            // 
            this.dgRowList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgRowList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgRowList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgRowList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRowList.Location = new System.Drawing.Point(12, 19);
            this.dgRowList.Name = "dgRowList";
            this.dgRowList.ReadOnly = true;
            this.dgRowList.RowHeadersWidth = 62;
            this.dgRowList.RowTemplate.Height = 27;
            this.dgRowList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRowList.Size = new System.Drawing.Size(914, 345);
            this.dgRowList.TabIndex = 0;
            this.dgRowList.AutoGenerateColumns = true;
            this.dgRowList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "重要度";
            // 
            // cmbRating
            // 
            this.cmbRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRating.FormattingEnabled = true;
            this.cmbRating.Location = new System.Drawing.Point(76, 65);
            this.cmbRating.Name = "cmbRating";
            this.cmbRating.Size = new System.Drawing.Size(180, 20);
            this.cmbRating.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dgRowList);
            this.groupBox3.Location = new System.Drawing.Point(14, 203);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(932, 370);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // chkIsRatingEnabled
            // 
            this.chkIsRatingEnabled.AutoSize = true;
            this.chkIsRatingEnabled.Location = new System.Drawing.Point(262, 64);
            this.chkIsRatingEnabled.Name = "chkIsRatingEnabled";
            this.chkIsRatingEnabled.Size = new System.Drawing.Size(128, 21);
            this.chkIsRatingEnabled.TabIndex = 8;
            this.chkIsRatingEnabled.Text = "重要度を無効にする";
            this.chkIsRatingEnabled.UseVisualStyleBackColor = true;
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(76, 98);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(180, 20);
            this.cmbCategory.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "分野別";
            // 
            // chkIsCategoryEnabled
            // 
            this.chkIsCategoryEnabled.AutoSize = true;
            this.chkIsCategoryEnabled.Location = new System.Drawing.Point(262, 100);
            this.chkIsCategoryEnabled.Name = "chkIsCategoryEnabled";
            this.chkIsCategoryEnabled.Size = new System.Drawing.Size(128, 21);
            this.chkIsCategoryEnabled.TabIndex = 11;
            this.chkIsCategoryEnabled.Text = "分野別を無効にする";
            this.chkIsCategoryEnabled.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(401, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "基本情報技術者ドットコム";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // KihonJouhouViewForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(959, 696);
            this.Controls.Add(this.groupBox3);
            this.MinimumSize = new System.Drawing.Size(628, 662);
            this.Name = "KihonJouhouViewForm";
            this.Text = "一覧 - 基本情報技術者試験";
            this.Load += new System.EventHandler(this.KihonJouhouViewForm_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRowList)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblKoumokuName;
        private System.Windows.Forms.TextBox txtKoumokuName;
        private System.Windows.Forms.Label lblSearchdNumbers;
        private System.Windows.Forms.DataGridView dgRowList;
        private System.Windows.Forms.ComboBox cmbRating;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkIsRatingEnabled;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.CheckBox chkIsCategoryEnabled;
        private System.Windows.Forms.Label label4;
    }
}