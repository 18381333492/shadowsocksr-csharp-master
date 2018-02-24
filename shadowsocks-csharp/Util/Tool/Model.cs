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

    /// <summary>
    /// 返回的结果
    /// </summary>
    public class ServerItem
    {
        /// <summary>
        /// 服务器id
        /// </summary>
        public int serverid
        {
            get;
            set;
        }

        /// <summary>
        /// 名字 
        /// </summary>
        public string name
        {
            get;
            set;
        }

        /// <summary>
        /// 状态 
        /// </summary>
        public string status
        {
            get;
            set;
        }

        /// <summary>
        /// /速度 
        /// </summary>
        public string traffic_rate
        {
            get;
            set;
        }

        /// <summary>
        /// 接入用户数
        /// </summary>
        public string node_connector
        {
            get;
            set;
        }
    }

    public class ServerTextValue
    {
        public string text
        {
            get;
            set;
        }

        public string value
        {
            get;
            set;
        }
    }
}
