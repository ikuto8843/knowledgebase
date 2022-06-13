using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KnowledgeBase.Const;

namespace KnowledgeBase.Dtos
{
    public class ITPassportDetail
    {
        /// <summary>
        /// 項目No
        /// </summary>
        public string No { get; set; }

        /// <summary>
        /// 項目名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 項目名略称
        /// </summary>
        public string Abbr { get; set; }

        /// <summary>
        /// 項目に対する詳細説明
        /// </summary>
        public string Detail { get; set; }

        /// <summary>
        /// 重要度
        /// </summary>
        public RatingEnum Rating { get; set; }

        /// <summary>
        /// 分野
        /// </summary>
        public CategoryEnum Category { get; set; }
    }
}
