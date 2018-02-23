using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Shadowsocks.Util
{
    public class TipHelper
    {
        /// <summary>
        /// 弹出提示框
        /// </summary>
        /// <param name="text"></param>
        public static void Alert(string text)
        {
            MessageBox.Show(text, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
