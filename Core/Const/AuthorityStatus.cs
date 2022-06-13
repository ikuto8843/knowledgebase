using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeBase.Const
{
    /// <summary>
    /// 権限ステータスを定義したクラス
    /// </summary>
    public class AuthorityStatus
    {
        /// <summary>
        /// 読み取り専用ステータス
        /// </summary>
        public static string readOnly = "読み取り専用モードです。";

        /// <summary>
        /// 編集可能ステータス
        /// </summary>
        public static string edit = "編集可能モードです。";
    }
}
