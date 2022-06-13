using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace WinClientWPF.Common
{
    public class EnumExtension : MarkupExtension
    {
        public Type EnumType { get; set; }

        public EnumExtension(Type enumType)
        {
            if(enumType is null || !enumType.IsEnum)
            {
                throw new Exception("値がEnumではありません");
            }

            EnumType = enumType;
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return Enum.GetValues(this.EnumType);
        }
    }
}
