using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace AuthorizeTool
{
    public partial class FrmMain : Form
    {


        string url = "http://118.24.14.231:22222/iot/company/authorize?name=langchuang";
        string result = "";
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {

            result = Get(url);
            this.lblAuthorize.Text = result;
        }



        /// <summary>
        /// 指定Url地址使用Get 方式获取全部字符串
        /// </summary>
        /// <param name="url">请求链接地址</param>
        /// <returns></returns>
        public static string Get(string url)
        {
            string result = "";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            Stream stream = resp.GetResponseStream();
            try
            {
                //获取内容
                using (StreamReader reader = new StreamReader(stream))
                {
                    result = reader.ReadToEnd();
                }
            }
            finally
            {
                stream.Close();
            }
            return result;

        }
    }
    }
