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

namespace KnowledgeBase.NewBaseForms
{
    public partial class BaseEditFormA<T> : Form where T : class, new()
    {
        #region プロパティ

        /// <summary>
        /// モード名
        /// </summary>
        public ModeSelection ModeSelection { get; set; }

        /// <summary>
        /// 一覧画面
        /// </summary>
        public Form ViewForm { get; set; }

        /// <summary>
        /// データが登録・更新されたかどうか
        /// </summary>
        public bool IsTransacted { get; set; }

        /// <summary>
        /// 検索条件
        /// </summary>
        public object SearchCondtion { get; set; }

        #endregion

        public BaseEditFormA()
        {
            this.BindingData = new T();
            InitializeComponent();
        }

        public void ShowDialogForm()
        {
            this.ShowDialog();
        }

        #region フォーム設定

        private Label lblAuthorityStatus;
        public Button btnDelete;
        public Label label1;
        public Button btnEnd;
        public Button btnRegister;
        public GroupBox groupBox2;
        public GroupBox groupBox1;

        #region コントロール

        #endregion

        private void InitializeComponent()
        {
            this.lblAuthorityStatus = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // lblAuthorityStatus
            // 
            this.lblAuthorityStatus.AutoSize = true;
            this.lblAuthorityStatus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblAuthorityStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAuthorityStatus.Location = new System.Drawing.Point(149, 9);
            this.lblAuthorityStatus.Name = "lblAuthorityStatus";
            this.lblAuthorityStatus.Size = new System.Drawing.Size(62, 12);
            this.lblAuthorityStatus.TabIndex = 13;
            this.lblAuthorityStatus.Text = "権限を表示";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(8, 565);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 35);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "削除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(270, 565);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(125, 35);
            this.btnEnd.TabIndex = 10;
            this.btnEnd.Text = "終了";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(139, 565);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(125, 35);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "登録";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(12, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 363);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "データ部";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 166);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "検索部";
            // 
            // BaseEditForm
            // 
            this.ClientSize = new System.Drawing.Size(410, 617);
            this.Controls.Add(this.lblAuthorityStatus);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "BaseEditForm";
            this.Load += new System.EventHandler(this.BaseEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        #region イベント

        /// <summary>
        /// フォーム読み込みイベント
        /// </summary>
        /// <param name="sender">イベント発生元</param>
        /// <param name="e">イベント引数</param>
        private void BaseEditForm_Load(object sender, EventArgs e)
        {
            var controls = GetAllControls(this);

            this.BindingData = new T();

            foreach (var control in controls)
            {
                if (typeof(T).GetProperty(control.Value.Item2) != null)
                {
                    var test = control.Key.Name;
                    control.Key.DataBindings.Add(control.Value.Item1, this.BindingData, control.Value.Item2);
                }
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

        #region 拡張要素

        /*
        ラベル→lbl
        テキストボックス→txt
        */

        /// <summary>
        /// バインディングソース
        /// </summary>
        public T BindingData { get; set; }

        /// <summary>
        /// コントロールを列挙
        /// </summary>
        /// <param name="top"></param>
        /// <returns>
        /// Key → コントロール
        /// Value.Item1 → コントロールのプロパティ名
        /// Value.Item2 → バインド先のプロパティのプロパティ名
        /// </returns>
        private Dictionary<Control, Tuple<string, string>> GetAllControls(Control top)
        {
            Dictionary<Control, Tuple<string, string>> contols = new Dictionary<Control, Tuple<string, string>>();

            foreach (Control c in top.Controls)
            {
                var data = GetControlTypeAndName(c);
                contols.Add(c, data);
            }

            return contols;
        }

        /// <summary>
        /// コントロールタイプを取得
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        private Tuple<string, string> GetControlTypeAndName(Control control)
        {
            string typeName = "";

            switch (control)
            {
                case TextBox text:
                    typeName = "Text";
                    break;

                case Label label:
                    typeName = "Text";
                    break;

                case PictureBox pictureBox:
                    typeName = "ImageLocation";
                    break;
            }

            var controlName = control.Name;

            var test = controlName.Replace("txt", "");
            var test2 = test.Replace("pb", "");
            var test3 = test2.Replace("lbl", "");

            return new Tuple<string, string>(typeName, test3);
        }

        #endregion
    }
}
