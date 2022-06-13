using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeBase.Const
{
    public class FormSizeMode
    {
        public enum ViewForm
        {
            /// <summary>
            /// 一覧フォームを最大化の状態で表示
            /// </summary>
            maxsize = 0,

            /// <summary>
            /// 一覧フォームを最大化のしないで表示
            /// </summary>
            normal = 1
        }

        public enum EditForm
        {
            //編集フォームを最大化の状態で表示
            maxsize = 0,

            /// <summary>
            /// 編集フォームを最大化のしないで表示
            /// </summary>
            normal = 1
        }
    }
}
