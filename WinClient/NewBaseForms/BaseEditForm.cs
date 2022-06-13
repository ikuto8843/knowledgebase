using KnowledgeBase.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnowledgeBase.NewBaseForms
{
    public partial class BaseEditForm<T> : Form where T : class, new()
    {
        #region フィールド

        Dictionary<Control, Tuple<string, string>> controls;

        #endregion

        #region プロパティ

        /// <summary>
        /// モード名
        /// </summary>
        public ModeSelection ModeSelection { get; set; }

        /// <summary>
        /// 前回表示した画面
        /// </summary>
        public Form PreviewForm { get; set; }

        /// <summary>
        /// 検索条件
        /// </summary>
        public object SearchCondtion { get; set; }

        /// <summary>
        /// バインディングソース
        /// </summary>
        public T BindingData { get; set; }

        #endregion

        public BaseEditForm()
        {
            this.BindingData = new T();
            InitializeComponent();
        }

        public void ShowDialogForm(Form form, object searchCondition, Dictionary<Control, Tuple<string, string>> controls)
        {
            this.SearchCondtion = searchCondition;
            this.PreviewForm = form;
            this.controls = controls;
            this.ShowDialog();
        }

        public void ShowForm(Form form, object searchCondition, Dictionary<Control, Tuple<string, string>> controls)
        {
            this.SearchCondtion = searchCondition;
            this.PreviewForm = form;
            this.controls = controls;
            this.Show();
        }

        #region フォーム設定
        public Button btnDelete;
        public Button btnEnd;
        public Button btnRegister;

        #region コントロール

        #endregion

        private void InitializeComponent()
        {
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(11, 126);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 35);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "削除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(273, 126);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(125, 35);
            this.btnEnd.TabIndex = 10;
            this.btnEnd.Text = "終了";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(142, 126);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(125, 35);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "登録";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // BaseEditForm
            // 
            this.ClientSize = new System.Drawing.Size(410, 183);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnRegister);
            this.Name = "BaseEditForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BaseEditForm_FormClosed);
            this.Shown += new System.EventHandler(this.BaseEditForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        #region イベント

        /// <summary>
        /// フォームが初めて表示されるたびに発生
        /// </summary>
        /// <param name="sender">イベント発生元</param>
        /// <param name="e">イベント引数</param>
        private void BaseEditForm_Shown(object sender, EventArgs e)
        {
            this.SetControls(this.controls);
        }

        /// <summary>
        /// フォームを閉じた後に発生
        /// </summary>
        /// <param name="sender">イベント発生元</param>
        /// <param name="e">イベント引数</param>
        private void BaseEditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            PreviewForm.Show();
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
        public virtual void UpdateOrRegister() {

            this.Close();

            this.PreviewForm.Show();
        }

        /// <summary>
        /// データを削除します
        /// </summary>
        public virtual void Delete() {

            this.Close();

            this.PreviewForm.Show();
        }

        /// <summary>
        /// コントロールの設定を行う
        /// </summary>
        /// <param name="controls"></param>

        public void SetControls(Dictionary<Control, Tuple<string, string>> controls)
        {
            Type type = this.BindingData.GetType();

            var properties = type.GetProperties();
            var nestedTypes = type.GetNestedTypes();

            foreach(var property in properties)
            {
                foreach (var control in controls)
                {
                    var info = nestedTypes.Where(d => d.Name == property.PropertyType.Name).First()
                        .GetProperties().Where(d => d.Name == control.Value.Item2).FirstOrDefault();

                    if(info != null)
                    {
                        var propertyInfo = this.BindingData.GetType().GetProperty(property.Name);
                        var data = propertyInfo.GetValue(this.BindingData);
                        control.Key.DataBindings.Add(control.Value.Item1, data, control.Value.Item2);
                    }
                }
            }
        }

        #endregion
    }
}
