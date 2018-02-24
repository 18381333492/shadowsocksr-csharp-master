using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Shadowsocks.Util;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Shadowsocks.View
{
    public partial class NewConfigForm : Form
    {
        //接口域名
        private static readonly string domin = "http://ss.stongyun.com";

        //缓存的服务器列表
        private static List<ServerItem> serverList = new List<ServerItem>();

        public NewConfigForm()
        {
            InitializeComponent();
            GetServerList();
        }

        /// <summary>
        /// 显示服务器信息
        /// </summary>
        /// <param name="Server"></param>
        public void ShowServerInfo(ServerItem Server)
        {
            this.ServerValue.Text = Server.name;
            this.PeopleValue.Text = Server.node_connector+"人";
            this.InternetValue.Text = Server.traffic_rate+"M/秒";
        }

        /// <summary>
        /// 获取服务器列表
        /// </summary>
        private void GetServerList()
        {
            string sUrl = domin + "/index.php/Appclt/getOpSerLst";
            string result =HttpHelper.HttpPost(sUrl, string.Empty);
            JObject job = JObject.Parse(result);
            if (job["code"].ToString() == "200")
            {
                serverList = JsonConvert.DeserializeObject<List<ServerItem>>(Convert.ToString(job["entity"]));
                var showList = new List<ServerTextValue>();
                foreach (var item in serverList)
                {
                    showList.Add(new ServerTextValue()
                    {
                        value = item.serverid.ToString(),
                        text = string.Format("{0} ({1}人在线) {2}M/秒", item.name, item.node_connector, item.traffic_rate)
                    });
                }
                this.ServerlistBox.DataSource = showList;
            }
            else
                TipHelper.Alert(Convert.ToString(job["msg"]));
        }

        private void ServerlistBox_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 选择服务器列表动作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ServerlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = this.ServerlistBox.SelectedItem as ServerTextValue;
            var showItem = serverList.FirstOrDefault(m => m.serverid.ToString() == item.value);
            ShowServerInfo(showItem);
        }

        //关闭窗口退出应用程序
        private void NewConfigForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
