using System;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace SoundCloudLists.WebUtil
{
    public static class CookieHandler
    {
        public static void generateCookie(HttpCookieCollection cookies, string key, string value)
        {
            try
            {
                var cookie = new HttpCookie(
                    //"SoundCloudToken",
                    key,
                    value)
                //authToken) // ENCRYPT THIS!
                {
                    Expires = DateTime.Now.AddDays(1)
                };

                cookies.Add(cookie);
            }
            catch
            {
                new HttpError("Cookie Could Not Be Created");
            }
        }
        public static HttpCookie getCookie(HttpRequestBase request, string key)
        {
            return request.Cookies[key];
        }
        
        public static HttpCookieCollection getCookies(HttpRequestBase request)
        {
            return request.Cookies;
        }

        public static object retriveValueFromCookie(HttpRequestBase request, string key)
        {
            return request.Cookies[key];
        }

        public static void clearCookies(HttpRequestBase request)
        {

        }
        public static HttpCookie updateValue(HttpRequestBase request, string key, string newValue)
        {
            HttpCookie cookie = request.Cookies.Get(key);
            cookie[key] = newValue;
            return cookie;
        }
    }
}