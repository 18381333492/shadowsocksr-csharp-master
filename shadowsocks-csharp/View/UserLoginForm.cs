using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Shadowsocks.Util;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Shadowsocks.View
{
    public partial class UserLoginForm : Form
    {
        //接口域名
        private static readonly string domin="http://ss.stongyun.com";
        /// <summary>
        /// 登录窗口的初始化
        /// </summary>
        public UserLoginForm()
        {
            InitializeComponent();
            GetImagesCode();
            this.UserName.Text = "abcd";
            this.UserPwd.Text = "111111";
        }

        /// <summary>
        /// 获取图片验证码
        /// </summary>
        private void GetImagesCode()
        {
            string sUrl= domin+"/index.php/Appclt/getVerfyCode";
            Stream stream=HttpHelper.GetHttpStream(sUrl);
            Image codePic = Image.FromStream(stream);
            this.PictureCode.Image = codePic;
        }

        /// <summary>
        /// 登录操作
        /// </summary>
        /// <param name="own_mob_no"></param>
        /// <param name="own_pwd"></param>
        /// <param name="vercode"></param>
        private void LoginOperate(string own_mob_no,string own_pwd, string vercode)
        {
            string sUrl =string.Format(domin+ "/index.php/Appclt/login?own_mob_no={0}&own_pwd={1}&vercode={2}", own_mob_no, own_pwd, vercode);
            string result = HttpHelper.HttpGet(sUrl);
            JObject job = JObject.Parse(result);
            if (job["code"].ToString() == "200")
            {
                TipHelper.Alert(job.ToString());
            }
            else
            {
                this.LoginBtn.Enabled = true;//启用按钮
                TipHelper.Alert(Convert.ToString(job["msg"]));
                //登录失败更新验证码
                GetImagesCode();
            }
        }

        /// <summary>
        /// 用户登录操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.UserName.Text))
            {
                TipHelper.Alert("用户名不能为空!");
                return;
            }
            if (string.IsNullOrWhiteSpace(this.UserPwd.Text))
            {
                TipHelper.Alert("密码不能为空!");
                return;
            }
            if (string.IsNullOrWhiteSpace(this.Code.Text))
            {
                TipHelper.Alert("验证码不能为空!");
                return;
            }
            this.LoginBtn.Enabled = false;//禁用按钮
            LoginOperate(this.UserName.Text, this.UserPwd.Text, this.Code.Text);
        }


        /// <summary>
        /// 重置按钮操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reset(object sender, EventArgs e)
        {
            this.UserName.Text = string.Empty;
            this.UserPwd.Text = string.Empty;
            this.Code.Text = string.Empty;
            GetImagesCode();
        }

        /// <summary>
        /// 点击切换图片验证码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureCode_Click(object sender, EventArgs e)
        {
            GetImagesCode();
        }
    }
}
