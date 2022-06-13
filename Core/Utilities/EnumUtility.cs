using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeBase.Utilities
{
    public class EnumUtility
    {
        /// <summary>
        /// 列挙体フィールドのDescriptionを取得する。
        /// </summary>
        /// <param name="value">列挙体値</param>
        /// <returns>Description文字列</returns>
        public static string GetEnumDescription(object value) {

            string description = null;

            try
            {
                if (value != null)
                {
                    string strValue = value.ToString();
                    if (0 < strValue.Length)
                    {
                        FieldInfo fi = value.GetType().GetField(strValue);
                        Attribute attr = Attribute.GetCustomAttribute(fi, typeof(DescriptionAttribute));
                        if (attr != null)
                        {
                            DescriptionAttribute descAttr = (DescriptionAttribute)attr;
                            description = descAttr.Description;
                        }
                    }
                }
            }
            catch
            {
                description = value.ToString();
            }

            return description;
        }
    }
}
