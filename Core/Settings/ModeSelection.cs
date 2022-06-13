using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeBase.Settings
{
    /// <summary>
    /// 編集モード
    /// </summary>
    public enum  ModeSelection
    {
        [Description("更新モード")]
        update = 0,

        [Description("登録モード")]
        register = 1,

        [Description("削除モード")]
        delete = 2
    }
}
