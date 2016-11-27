using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.IO;

namespace SoundCloudLists.WebUtil
{
    public static class HttpUtil
    {
        // methods written by Scott Hanselman
        public static string HttpPost(string URI, string Parameters)
        {
            WebRequest req = WebRequest.Create(URI);
            //req.Proxy = new System.Net.WebProxy(ProxyString, true);
            //Add these, as we're doing a POST
            req.ContentType = "application/x-www-form-urlencoded";
            req.Method = "POST";
            //We need to count how many bytes we're sending. 
            //Post'ed Faked Forms should be name=value&

            byte[] bytes = System.Text.Encoding.ASCII.GetBytes(Parameters);
            req.ContentLength = bytes.Length;
            Stream os = req.GetRequestStream();
            os.Write(bytes, 0, bytes.Length); //Push it out there
            os.Close();
            WebResponse resp = req.GetResponse();
            if (resp == null)
            {
                return null;
            }
            StreamReader sr = new StreamReader(resp.GetResponseStream());
            return sr.ReadToEnd().Trim();
        }

        public static string HttpGet(string Uri, string Parameters)
        {
            WebRequest req = WebRequest.Create(Uri + Parameters);
            //req.Proxy = new System.Net.WebProxy(ProxyString, true); //true means no proxy
            WebResponse resp = req.GetResponse();
            StreamReader sr = new StreamReader(resp.GetResponseStream());
            return sr.ReadToEnd().Trim();
        }
    }
}