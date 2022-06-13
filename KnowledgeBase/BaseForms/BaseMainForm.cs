using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnowledgeBase.BaseForms
{
    public partial class BaseMainForm : Form
    {
        #region プロパティ

        /// <summary>
        /// 閉じるボタンを無効にする
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_NOCLOSE = 0x200;

                CreateParams createParams = base.CreateParams;
                createParams.ClassStyle |= CS_NOCLOSE;

                return createParams;
            }
        }

        #endregion

        public BaseMainForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        /// <summary>
        /// ショートカットキーの入力イベント
        /// </summary>
        /// <param name="e"></param>
        public virtual void PressShortcutKeys(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    break;

                case Keys.F5:
                    break;

                case Keys.F9:
                    break;
            }
        }
    }
}
