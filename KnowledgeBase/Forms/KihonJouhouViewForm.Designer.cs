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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KihonJouhouViewForm));
            this.txtKoumokuName = new System.Windows.Forms.TextBox();
            this.lblKoumokuName = new System.Windows.Forms.Label();
            this.lblKoumokuNo = new System.Windows.Forms.Label();
            this.txtKoumokuNoFrom = new System.Windows.Forms.TextBox();
            this.txtKoumokuNoTo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSearchdNumbers = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRating = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxJuuyoudo = new System.Windows.Forms.CheckBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxCategory = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Location = new System.Drawing.Point(13, 591);
            this.groupBox2.Size = new System.Drawing.Size(932, 90);
            this.groupBox2.Text = "";
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
            this.btnShowDatatable.Location = new System.Drawing.Point(452, 140);
            this.btnShowDatatable.Size = new System.Drawing.Size(140, 50);
            this.btnShowDatatable.TabIndex = 12;
            // 
            // btnRevise
            // 
            this.btnRevise.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRevise.Location = new System.Drawing.Point(774, 32);
            this.btnRevise.Size = new System.Drawing.Size(150, 45);
            this.btnRevise.Text = "修正";
            this.btnRevise.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.checkBoxCategory);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblSearchdNumbers);
            this.groupBox1.Controls.Add(this.cmbCategory);
            this.groupBox1.Controls.Add(this.checkBoxJuuyoudo);
            this.groupBox1.Controls.Add(this.cmbRating);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtKoumokuNoTo);
            this.groupBox1.Controls.Add(this.txtKoumokuNoFrom);
            this.groupBox1.Controls.Add(this.lblKoumokuNo);
            this.groupBox1.Controls.Add(this.lblKoumokuName);
            this.groupBox1.Controls.Add(this.txtKoumokuName);
            this.groupBox1.Size = new System.Drawing.Size(600, 200);
            this.groupBox1.Text = "検索条件";
            this.groupBox1.Controls.SetChildIndex(this.btnShowDatatable, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtKoumokuName, 0);
            this.groupBox1.Controls.SetChildIndex(this.lblKoumokuName, 0);
            this.groupBox1.Controls.SetChildIndex(this.lblKoumokuNo, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtKoumokuNoFrom, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtKoumokuNoTo, 0);
            this.groupBox1.Controls.SetChildIndex(this.label1, 0);
            this.groupBox1.Controls.SetChildIndex(this.label2, 0);
            this.groupBox1.Controls.SetChildIndex(this.cmbRating, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxJuuyoudo, 0);
            this.groupBox1.Controls.SetChildIndex(this.cmbCategory, 0);
            this.groupBox1.Controls.SetChildIndex(this.lblSearchdNumbers, 0);
            this.groupBox1.Controls.SetChildIndex(this.label3, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxCategory, 0);
            this.groupBox1.Controls.SetChildIndex(this.label4, 0);
            // 
            // txtKoumokuName
            // 
            this.txtKoumokuName.Location = new System.Drawing.Point(77, 65);
            this.txtKoumokuName.Name = "txtKoumokuName";
            this.txtKoumokuName.Size = new System.Drawing.Size(262, 26);
            this.txtKoumokuName.TabIndex = 5;
            // 
            // lblKoumokuName
            // 
            this.lblKoumokuName.AutoSize = true;
            this.lblKoumokuName.Location = new System.Drawing.Point(17, 68);
            this.lblKoumokuName.Name = "lblKoumokuName";
            this.lblKoumokuName.Size = new System.Drawing.Size(54, 19);
            this.lblKoumokuName.TabIndex = 4;
            this.lblKoumokuName.Text = "項目名";
            // 
            // lblKoumokuNo
            // 
            this.lblKoumokuNo.AutoSize = true;
            this.lblKoumokuNo.Location = new System.Drawing.Point(12, 36);
            this.lblKoumokuNo.Name = "lblKoumokuNo";
            this.lblKoumokuNo.Size = new System.Drawing.Size(59, 19);
            this.lblKoumokuNo.TabIndex = 0;
            this.lblKoumokuNo.Text = "項目No";
            // 
            // txtKoumokuNoFrom
            // 
            this.txtKoumokuNoFrom.Location = new System.Drawing.Point(77, 33);
            this.txtKoumokuNoFrom.Name = "txtKoumokuNoFrom";
            this.txtKoumokuNoFrom.Size = new System.Drawing.Size(100, 26);
            this.txtKoumokuNoFrom.TabIndex = 1;
            // 
            // txtKoumokuNoTo
            // 
            this.txtKoumokuNoTo.Location = new System.Drawing.Point(213, 33);
            this.txtKoumokuNoTo.Name = "txtKoumokuNoTo";
            this.txtKoumokuNoTo.Size = new System.Drawing.Size(100, 26);
            this.txtKoumokuNoTo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "～";
            // 
            // lblSearchdNumbers
            // 
            this.lblSearchdNumbers.AutoSize = true;
            this.lblSearchdNumbers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSearchdNumbers.Location = new System.Drawing.Point(4, 176);
            this.lblSearchdNumbers.Name = "lblSearchdNumbers";
            this.lblSearchdNumbers.Size = new System.Drawing.Size(54, 19);
            this.lblSearchdNumbers.TabIndex = 2;
            this.lblSearchdNumbers.Text = "検索数";
            this.lblSearchdNumbers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(914, 345);
            this.dataGridView1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "重要度";
            // 
            // cmbRating
            // 
            this.cmbRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRating.FormattingEnabled = true;
            this.cmbRating.Location = new System.Drawing.Point(77, 97);
            this.cmbRating.Name = "cmbRating";
            this.cmbRating.Size = new System.Drawing.Size(180, 27);
            this.cmbRating.TabIndex = 7;
            this.cmbRating.SelectedValueChanged += new System.EventHandler(this.cmbRating_SelectedValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(13, 223);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(932, 370);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // checkBoxJuuyoudo
            // 
            this.checkBoxJuuyoudo.AutoSize = true;
            this.checkBoxJuuyoudo.Location = new System.Drawing.Point(263, 96);
            this.checkBoxJuuyoudo.Name = "checkBoxJuuyoudo";
            this.checkBoxJuuyoudo.Size = new System.Drawing.Size(150, 23);
            this.checkBoxJuuyoudo.TabIndex = 8;
            this.checkBoxJuuyoudo.Text = "重要度を無効にする";
            this.checkBoxJuuyoudo.UseVisualStyleBackColor = true;
            this.checkBoxJuuyoudo.CheckedChanged += new System.EventHandler(this.checkBoxJuuyoudo_CheckedChanged);
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(77, 130);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(180, 27);
            this.cmbCategory.TabIndex = 10;
            this.cmbCategory.SelectedValueChanged += new System.EventHandler(this.cmbCategory_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "分野別";
            // 
            // checkBoxCategory
            // 
            this.checkBoxCategory.AutoSize = true;
            this.checkBoxCategory.Location = new System.Drawing.Point(263, 132);
            this.checkBoxCategory.Name = "checkBoxCategory";
            this.checkBoxCategory.Size = new System.Drawing.Size(150, 23);
            this.checkBoxCategory.TabIndex = 11;
            this.checkBoxCategory.Text = "分野別を無効にする";
            this.checkBoxCategory.UseVisualStyleBackColor = true;
            this.checkBoxCategory.CheckedChanged += new System.EventHandler(this.checkBoxCategory_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(401, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 19);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ComboBox cmbRating;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxJuuyoudo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.CheckBox checkBoxCategory;
        private System.Windows.Forms.Label label4;
    }
}