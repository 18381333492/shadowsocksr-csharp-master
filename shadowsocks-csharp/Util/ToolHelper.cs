using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shadowsocks.Util
{
    /// <summary>
    /// 常用方法帮助类
    /// </summary>
    public class ToolHelper
    {
        /// <summary>
        /// Ascii码转中文
        /// </summary>
        /// <param name="textAscii"></param>
        /// <returns></returns>
        public static string GetText(string textAscii)
        {
            string textStr = string.Empty;
            int k = 0;//字节移动偏移量
            byte[] buffer = new byte[textAscii.Length / 2];//存储变量的字节
            for (int i = 0; i < textAscii.Length / 2; i++)
            {
                //每两位合并成为一个字节
                buffer[i] = byte.Parse(textAscii.Substring(k, 2),System.Globalization.NumberStyles.HexNumber);
                k = k + 2;
            }
            //将字节转化成汉字
            textStr = Encoding.Default.GetString(buffer);
            return textStr;
        }
    }
}
