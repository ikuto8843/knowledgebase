using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KnowledgeBase.Const;

namespace KnowledgeBase.Settings
{
    /// <summary>
    /// システムの権限を定義するクラス
    /// </summary>
    public class SystemAuthority
    {
        /// <summary>
        /// アクセス権限
        /// </summary>
        public static Authority AccessAuthority { get; set; }

        /// <summary>
        /// アクセス権限ステータス
        /// </summary>
        public static string AccessAuthorityStatus { get; set; }
    }
}
