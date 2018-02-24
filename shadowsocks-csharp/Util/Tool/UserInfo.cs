using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shadowsocks.Util
{
    [Serializable]
    public class UserInfo
    {
        public int id
        {
            get;
            set;
        }

        /// <summary>
        /// 有效期时间
        /// </summary>
        public DateTime expire_in
        {
            get;
            set;
        }

        public string inv_code
        {
            get;
            set;
        }

        /// <summary>
        /// 账户名称
        /// </summary>
        public string acc_name
        {
            get;
            set;
        }

        /// <summary>
        /// 账户注册时间
        /// </summary>
        public DateTime reg_date
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public string acsecry
        {
            get;
            set;
        }
    }
}
