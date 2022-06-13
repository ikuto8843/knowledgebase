using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeBase.Entities
{
    public class ITPassportHeaderEntity
    {
        /// <summary>
        /// 項目Noを取得、または設定する
        /// </summary>
        public string KoumokuNo { get; set; }

        /// <summary>
        /// 項目名を取得、または設定する
        /// </summary>
        public string KoumokuName { get; set; }

        /// <summary>
        /// 重要度を取得、または設定する
        /// </summary>
        public int? Rating { get; set; }

        /// <summary>
        /// 分野を取得、または設定する
        /// </summary>
        public int? Category { get; set; }
    }
}
