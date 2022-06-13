using MahApps.Metro.Controls.Dialogs;
using MicroResolver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WinClientWPF.Behaviors
{
    /// <summary>
    /// 画面アクションクラス
    /// </summary>
    public class WindowAction
    {
        /// <summary>
        /// 閉じるためのアクション
        /// </summary>
        private Action windowClose;

        /// <summary>
        /// 変更があったかどうか
        /// </summary>
        private static bool IsChanged { get; set; }

        /// <summary>
        /// ダイアログヘルパー
        /// </summary>
        private IDialogCoordinator dialogCoordinator;

        public WindowAction()
        {
            var resolver = ObjectResolver.Create();

            // Register interface->type map, default is transient(instantiate every request)
            resolver.Register<IDialogCoordinator, DialogCoordinator>();

            // Compile and Verify container(this is required step)
            resolver.Compile();

            // Get instance from container
            dialogCoordinator = resolver.Resolve<IDialogCoordinator>();
        }

        /// <summary>
        /// 変更
        /// </summary>
        public void ChangeProperty()
        {
            IsChanged = true;
        }

        /// <summary>
        /// Get
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static bool GetEnableWindowClosing(DependencyObject obj)
        {
            return (bool)obj.GetValue(CloseProperty);
        }

        /// <summary>
        /// Set
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="value"></param>
        public static void SetEnableWindowClosing(DependencyObject obj, bool value)
        {
            obj.SetValue(CloseProperty, value);
        }

        // Using a DependencyProperty as the backing store for Close.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CloseProperty =
            DependencyProperty.RegisterAttached("EnableWindowClosing", typeof(bool), typeof(WindowAction), new PropertyMetadata(false, OnEnableWindowClosingChanged));

        public static void OnEnableWindowClosingChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Window window)
            {
                window.Loaded += (s, a) =>
                {
                    if (window.DataContext is WindowAction vm)
                    {
                        vm.windowClose += () =>
                        {
                            window.Close();
                        };
                    }
                };

                window.Closing += (s, a) =>
                {
                    if (IsChanged)
                    {
                       var result =  MessageBox.Show("データが変更されています。編集画面を閉じてもよろしいでしょうか？", "警告", MessageBoxButton.YesNoCancel);

                        if (result == MessageBoxResult.No || result == MessageBoxResult.Cancel)
                        {
                            a.Cancel = true;
                        }
                    }
                };

            }
        }

        /// <summary>
        /// 画面を閉じる
        /// </summary>
        public void CloseWindow()
        {
            windowClose?.Invoke();
        }

        /// <summary>
        /// データベース関連の例外メッセージを表示する
        /// </summary>
        /// <param name="message"></param>
        public void ShowDataBaseExceptionDialog(string message)
        {
            dialogCoordinator.ShowMessageAsync(this, "データベース例外", message);

        }

        /// <summary>
        /// 画面を閉じる(メッセージ表示付き)
        /// </summary>
        /// <param name="message">ダイアログに表示するメッセージ</param>
        /// <param name="title">ダイアログに表示するタイトル</param>
        public async Task CloseWindow(string message, string title)
        {
            var result = await dialogCoordinator.ShowMessageAsync(this, title, message);

            if (result == MessageDialogResult.Affirmative)
            {
                IsChanged = false;
                windowClose?.Invoke();
            }
        }

        /// <summary>
        /// 削除確認
        /// </summary>
        /// <returns>選択結果</returns>
        public async Task<bool> DeleteConfirm()
        {
            var result = await dialogCoordinator.ShowMessageAsync(this, "確認", "本当に削除してもよろしいですか？", MessageDialogStyle.AffirmativeAndNegative);

            return result == MessageDialogResult.Affirmative ? true : false;
        }
    }
}
