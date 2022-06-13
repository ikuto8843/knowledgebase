using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnowledgeBase.NewBaseForms
{
    public class BaseForm<T> : Form where T : class, new()
    {
        /*
        ラベル→lbl
        テキストボックス→txt
        */

        /// <summary>
        /// バインディングソース
        /// </summary>
        public T BindingData { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public BaseForm()
        {
            InitializeComponent();
        }

        protected void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BaseForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "BaseForm";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.ResumeLayout(false);

        }

        /// <summary>
        /// フォーム読み込みイベント
        /// </summary>
        /// <param name="sender">イベント発生元</param>
        /// <param name="e">イベント引数</param>
        private void BaseForm_Load(object sender, EventArgs e)
        {
            var controls = GetAllControls(this);

            this.BindingData = new T();

            foreach (var control in controls)
            {
                if(typeof(T).GetProperty(control.Value.Item2) != null)
                {
                    var test = control.Key.Name;
                    control.Key.DataBindings.Add(control.Value.Item1, this.BindingData, control.Value.Item2);
                }
            }
        }

        /// <summary>
        /// コントロールを列挙
        /// </summary>
        /// <param name="top"></param>
        /// <returns>
        /// Key → コントロール
        /// Value.Item1 → コントロールのプロパティ名
        /// Value.Item2 → バインド先のプロパティのプロパティ名
        /// </returns>
        private Dictionary<Control,Tuple<string,string>> GetAllControls(Control top)
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
        private Tuple<string,string> GetControlTypeAndName(Control control)
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

            var test = controlName.Replace("txt","");
            var test2 = test.Replace("pb", "");
            var test3 = test2.Replace("lbl", "");

            return new Tuple<string, string>(typeName,test3);
        }
    }
}
