using KnowledgeBase.NewBaseForms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.Utilities
{
    public static class SubFormDispatcher
    {
        /// <summary>
        /// 編集画面をモーダルフォームで表示します
        /// </summary>
        /// <typeparam name="TClass"></typeparam>
        /// <param name="searchCondition"></param>
        public static void ShowEditFormDialog<TClass>(this Form callerForm, object searchCondition = null) where TClass : class, new()
        {
            var memberInfo = Assembly
            .GetAssembly(typeof(BaseEditForm<TClass>))
                .GetTypes()
                .Where(t =>
                {
                    return t.IsSubclassOf(typeof(BaseEditForm<TClass>)) && !t.IsAbstract;
                }).FirstOrDefault();

            callerForm.Hide();

            var form = (BaseEditForm<TClass>)Activator.CreateInstance(memberInfo);

            var controls = GetAllControlsAndType(form);

            form.ShowDialogForm(callerForm, searchCondition, controls);
        }

        /// <summary>
        /// 編集画面をモードレスフォームで表示します
        /// </summary>
        /// <typeparam name="TClass"></typeparam>
        /// <param name="searchCondition"></param>
        public static void ShowEditForm<TClass>(this Form callerForm, object searchCondition = null) where TClass : class, new()
        {
            var memberInfo = Assembly
            .GetAssembly(typeof(BaseEditForm<TClass>))
                .GetTypes()
                .Where(t =>
                {
                    return t.IsSubclassOf(typeof(BaseEditForm<TClass>)) && !t.IsAbstract;
                }).FirstOrDefault();

            callerForm.Hide();

            var form = (BaseEditForm<TClass>)Activator.CreateInstance(memberInfo);

            var controls = GetAllControlsAndType(form);

            form.ShowForm(callerForm, searchCondition, controls);
        }

        /// <summary>
        /// 一覧画面をモーダルフォームで表示します
        /// </summary>
        /// <typeparam name="TClass"></typeparam>
        /// <param name="searchCondition"></param>
        public static void ShowFormDialog<TClass>(this Form callerForm) where TClass : class, new()
        {
            var memberInfo = Assembly
            .GetAssembly(typeof(BaseViewForm<TClass>))
                .GetTypes()
                .Where(t =>
                {
                    return t.IsSubclassOf(typeof(BaseViewForm<TClass>)) && !t.IsAbstract;
                }).FirstOrDefault();

            callerForm.Hide();

            var form = (BaseViewForm<TClass>)Activator.CreateInstance(memberInfo);

            var controls = GetAllControlsAndType(form);

            form.ShowDialogForm(callerForm, controls);
        }

        #region コントロール設定メソッド

        /// <summary>
        /// コントロールを列挙
        /// </summary>
        /// <param name="top"></param>
        /// <returns>
        /// Key → コントロール
        /// Value.Item1 → コントロールのプロパティ名
        /// Value.Item2 → バインド先のプロパティのプロパティ名
        /// </returns>
        private static Dictionary<Control, Tuple<string, string>> GetAllControlsAndType(Control top)
        {
            Dictionary<Control, Tuple<string, string>> result = new Dictionary<Control, Tuple<string, string>>();

            var controls = GetAllControls<Control>(top);

            foreach (Control c in controls)
            {
                if (c.GetType() != typeof(Label))
                {
                    var data = GetControlTypeAndName(c);
                    result.Add(c, data);
                }
            }

            return result;
        }

        /// <summary>
        /// コントロールタイプを取得
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        private static Tuple<string, string> GetControlTypeAndName(Control control)
        {
            string typeName = "";

            switch (control)
            {
                case TextBox text:
                    typeName = "Text";
                    break;

                case PictureBox pictureBox:
                    typeName = "ImageLocation";
                    break;

                case ComboBox comboBox:
                    typeName = "SelectedItem";
                    break;

                case DataGridView dataGridView:
                    typeName = "DataSource";
                    break;

                case CheckBox checkBox:
                    typeName = "Checked";
                    break;
            }

            var controlName = control.Name.Replace("txt", "").Replace("pb", "").Replace("cmb", "").Replace("dg","").Replace("chk","");

            return new Tuple<string, string>(typeName, controlName);
        }

        /// <summary>
        /// 指定のコントロール上の全てのジェネリック型 Tコントロールを取得する。
        /// </summary>
        /// <typeparam name="T">対象となる型</typeparam>
        /// <param name="top">指定のコントロール</param>
        /// <returns>指定のコントロール上の全てのジェネリック型 Tコントロールのインスタンス</returns>
        public static List<T> GetAllControls<T>(Control top) where T : Control
        {
            List<T> buf = new List<T>();
            foreach (Control ctrl in top.Controls)
            {
                if (ctrl is T) buf.Add((T)ctrl);
                buf.AddRange(GetAllControls<T>(ctrl));
            }
            return buf;
        }

        #endregion
    }
}
