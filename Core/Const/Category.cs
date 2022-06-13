using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KnowledgeBase.Utilities;

namespace KnowledgeBase.Const
{
    [TypeConverter(typeof(EnumDescriptionConverter))]
    public enum CategoryEnum
    {
        [Description("ストラテジ系")]
        strategy = 1,

        [Description("マネジメント系")]
        management = 2,

        [Description("テクノロジ系")]
        technology = 3,
    }
}
