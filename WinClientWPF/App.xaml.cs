using KnowledgeBase.Dtos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WinClientWPF
{
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application
    {
        public static Dictionary<string, Type> WindowSet = new Dictionary<string, Type>()
        {
            {"KihonjouhouEditModel", typeof(KihonjouhouEdit) }
        };

        public static void ShowView<T>(object dataContext) where T : class
        {
            Window window = (Window)Activator.CreateInstance(WindowSet[typeof(T).Name]);

            window.DataContext = dataContext;

            window.ShowDialog();
        }
    }
}
