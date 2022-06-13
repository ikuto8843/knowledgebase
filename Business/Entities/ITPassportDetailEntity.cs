using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeBase.Entities
{
    public class ITPassportDetailEntity
    {
        /// <summary>
        /// 項目Noを取得、または設定します
        /// </summary>
        public string No { get; set; }

        /// <summary>
        /// 項目名を取得、または設定します
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 詳細を取得、または設定します
        /// </summary>
        public string Detail { get; set; }

        /// <summary>
        /// 重要度を取得、または設定します
        /// </summary>
        public int? Rating { get; set; }

        /// <summary>
        /// 分野を取得、または設定します
        /// </summary>
        public int? Category { get; set; }
    }
}
