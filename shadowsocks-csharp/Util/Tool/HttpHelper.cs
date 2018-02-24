using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace Shadowsocks.Util
{
    /// <summary>
    /// http请求的封装
    /// </summary>
    public class HttpHelper
    {
        public static CookieContainer cookies = new CookieContainer();
        private static string cookieStr = string.Empty;

        public static Stream GetHttpStream(string sUrl)
        {
            HttpWebRequest webRequest = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(sUrl);
            webRequest.ProtocolVersion = HttpVersion.Version10;
            webRequest.Timeout = 30000;
            webRequest.Method = WebRequestMethods.Http.Post;
            HttpWebResponse webResponse = (System.Net.HttpWebResponse)webRequest.GetResponse();
            //获取服务端返回的cookie
            cookieStr= webResponse.Headers["Set-Cookie"].Split(';')[0];
            return webResponse.GetResponseStream();
        }

        public static string HttpGet(string sUrl)
        {
            string sResult = string.Empty;
            try
            {
                HttpWebRequest webRequest = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(sUrl);
                webRequest.ProtocolVersion = HttpVersion.Version10;
                webRequest.Timeout = 30000;
                webRequest.Method = WebRequestMethods.Http.Get;
                webRequest.Headers.Add("Accept-Encoding", "gzip, deflate");
                webRequest.Headers.Add("Cookie", cookieStr);

                HttpWebResponse webResponse = (System.Net.HttpWebResponse)webRequest.GetResponse();
                if (webResponse.ContentEncoding.ToLower() == "gzip")//如果使用了GZip则先解压
                {
                    using (System.IO.Stream streamReceive = webResponse.GetResponseStream())
                    {
                        using (var zipStream = new System.IO.Compression.GZipStream(streamReceive, System.IO.Compression.CompressionMode.Decompress))
                        {
                            using (StreamReader sr = new System.IO.StreamReader(zipStream))
                            {
                                sResult = sr.ReadToEnd();
                            }
                        }
                    }
                }
                else if (webResponse.ContentEncoding.ToLower() == "deflate")//如果使用了deflate则先解压
                {
                    using (System.IO.Stream streamReceive = webResponse.GetResponseStream())
                    {
                        using (var deflateStream = new System.IO.Compression.DeflateStream(streamReceive, System.IO.Compression.CompressionMode.Decompress))
                        {
                            using (StreamReader sr = new System.IO.StreamReader(deflateStream))
                            {
                                sResult = sr.ReadToEnd();
                            }
                        }
                    }
                }
                else
                {
                    using (System.IO.Stream streamReceive = webResponse.GetResponseStream())
                    {
                        using (System.IO.StreamReader sr = new System.IO.StreamReader(streamReceive))
                        {
                            sResult = sr.ReadToEnd();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                sResult = e.Message;
            }
            return sResult;
        }

        /// <summary>
        /// Post请求
        /// </summary>
        /// <param name="sUrl">请求的链接</param>
        /// <param name="PostData">请求的参数</param>
        /// <returns></returns>
        public static string HttpPost(string sUrl, string PostData)
        {
            byte[] bPostData = System.Text.Encoding.UTF8.GetBytes(PostData);
            string sResult = string.Empty;

            HttpWebRequest webRequest = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(sUrl);
            webRequest.ProtocolVersion = HttpVersion.Version10;
            webRequest.Timeout = 30000;
            webRequest.Method = "POST";
            webRequest.Headers.Add("Accept-Encoding", "gzip, deflate");
            webRequest.ContentType = "application/x-www-form-urlencoded";
            webRequest.Headers.Add("Cookie", cookieStr);

            if (bPostData != null)
            {
                Stream postDataStream = webRequest.GetRequestStream();
                postDataStream.Write(bPostData, 0, bPostData.Length);
            }
            HttpWebResponse webResponse = (System.Net.HttpWebResponse)webRequest.GetResponse();
            if (webResponse.ContentEncoding.ToLower() == "gzip")//如果使用了GZip则先解压
            {
                using (System.IO.Stream streamReceive = webResponse.GetResponseStream())
                {
                    using (var zipStream =
                        new System.IO.Compression.GZipStream(streamReceive, System.IO.Compression.CompressionMode.Decompress))
                    {
                        using (StreamReader sr = new System.IO.StreamReader(zipStream))
                        {
                            sResult = sr.ReadToEnd();
                        }
                    }
                }
            }
            else if (webResponse.ContentEncoding.ToLower() == "deflate")//如果使用了deflate则先解压
            {
                using (System.IO.Stream streamReceive = webResponse.GetResponseStream())
                {
                    using (var deflateStream = new System.IO.Compression.DeflateStream(streamReceive, System.IO.Compression.CompressionMode.Decompress))
                    {
                        using (StreamReader sr = new System.IO.StreamReader(deflateStream))
                        {
                            sResult = sr.ReadToEnd();
                        }
                    }
                }
            }
            else
            {
                using (System.IO.Stream streamReceive = webResponse.GetResponseStream())
                {
                    using (System.IO.StreamReader sr = new System.IO.StreamReader(streamReceive))
                    {
                        sResult = sr.ReadToEnd();
                    }
                }
            }
            return sResult;
        }
    }
}
