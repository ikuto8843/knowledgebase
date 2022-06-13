using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KnowledgeBase.Utilities;

namespace KnowledgeBase.Const
{
    [TypeConverter(typeof(EnumDescriptionConverter))]
    public enum RatingEnum
    {
        [Description(" ")]
        [Display(Name = " ")]
        uncategorized = -1,

        [Description("☆☆☆")]
        [Display(Name = "☆☆☆")]
        notImportant = 0,

        [Description("★☆☆")]
        [Display(Name = "★☆☆")]
        aLittleImportant = 1,

        [Description("★★☆")]
        [Display(Name = "★★☆")]
        wellImportant = 2,

        [Description("★★★")]
        [Display(Name = "★★★")]
        veryImportant = 3
    }
}
