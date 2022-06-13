using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeBase.Const
{
    /// <summary>
    /// 権限を定義する列挙
    /// </summary>
    public enum Authority
    {
        /// <summary>
        /// 編集可能
        /// </summary>
        edit = 0,

        /// <summary>
        /// 読み取り専用
        /// </summary>
        readOnly = 1
    }
}
