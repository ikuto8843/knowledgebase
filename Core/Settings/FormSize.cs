using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KnowledgeBase.Settings;
using KnowledgeBase.Const;

namespace KnowledgeBase.Settings
{
    /// <summary>
    /// フォームサイズを定義するクラス
    /// </summary>
    public static class FormSize
    {
        /// <summary>
        /// 一覧画面の初期フォームサイズ
        /// </summary>
        public static FormSizeMode.ViewForm ViewFormSizeMode { get; set; }

        /// <summary>
        /// 編集画面の初期フォームサイズ
        /// </summary>
        public static FormSizeMode.EditForm EditFormSizeMode { get; set; }
    }
}
