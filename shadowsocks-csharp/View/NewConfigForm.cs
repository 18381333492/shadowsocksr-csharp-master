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
using Shadowsocks.Controller;
using Shadowsocks.Model;

namespace Shadowsocks.View
{
    public partial class NewConfigForm : Form
    {
        //接口域名
        private static readonly string domin = "http://ss.stongyun.com";

        //缓存的服务器列表
        private static List<ServerItem> serverList = new List<ServerItem>();

        private ShadowsocksController controller;
        private UpdateChecker updateChecker;
        public NewConfigForm()
        {
            InitializeComponent();
            GetServerList();
            this.TipValue.Text = "请尽量选择当前接入用户比较少的服务器,便于网络流畅性体验";
            this.TipValue.Enabled = false;//只读

            //执行代理相关逻辑
            this.controller = new ShadowsocksController();
            this.updateChecker = new UpdateChecker();
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

        /// <summary>
        /// 接入服务操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ServerBtn_Click(object sender, EventArgs e)
        {
            string sUrl = domin + "/index.php/Appclt/accessact";
            var item = this.ServerlistBox.SelectedItem as ServerTextValue;//获取当前的选中的服务器
            string body= "serverid="+item.value;
            string result=HttpHelper.HttpPost(sUrl, body);
            JObject job = JObject.Parse(result);
            if (job["code"].ToString() == "200")
            {
                //创建服务
                Server server = new Server();
                RunServer(server);
            }
            else
            {
                TipHelper.Alert(Convert.ToString(job["msg"]));
            }
        }


        /// <summary>
        /// 接入服务
        /// </summary>
        public void RunServer(Server server)
        {
            //server.
        }
    }
}
