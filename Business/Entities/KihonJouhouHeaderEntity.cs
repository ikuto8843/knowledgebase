using CustomAttribute;
using KnowledgeBase.Const;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeBase.Entities
{
    [Serializable]
    public class KihonJouhouH
    {
        /// <summary>
        /// IDを取得、または設定する
        /// </summary>
        [Data(DataType.ID)]
        public long ID { get; set; }

        /// <summary>
        /// 項目名を取得、または設定する
        /// </summary>
        public string Name { get; set; }
    }
}
