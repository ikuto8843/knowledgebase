using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeBase.Const
{
    /// <summary>
    /// ログイン用定数クラス
    /// </summary>
    public class LoginConst
    {
        /// <summary>
        /// 編集可能ユーザー
        /// </summary>
        public class EditUser {

            /// <summary>
            /// ログインID
            /// </summary>
            public static string id = "ikuto";

            /// <summary>
            /// ログインPASS
            /// </summary>
            public static string pass = "ikuto1910";
        }

        /// <summary>
        /// 閲覧のみのユーザー
        /// </summary>
        public class ReadOnlyUser
        {
            /// <summary>
            /// ログインID
            /// </summary>
            public static string id = "9999";

            /// <summary>
            /// ログインPASS
            /// </summary>
            public static string pass = "9999";
        }
    }
}
