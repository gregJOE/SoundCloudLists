using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SoundCloudLists.API;
using SoundCloudLists.WebUtil;
using System.Net;
using System.Configuration;

namespace SoundCloudLists.API
{
    public static class SoundCloudRestAPI
    {
        static string _clientID = ConfigurationManager.AppSettings["SoundCloudClientID"];
        static string _secretKey = ConfigurationManager.AppSettings["SoundCloudSecretKey"];
        static string _redirectUrl = ConfigurationManager.AppSettings["SoundCloudRedirectURL"];

        public static string retriveMe(HttpRequestBase request)
        {
            /* check if logged in*/

            /* need to pass in oauth ID */
            string command = SoundCloudAPIConstants.SoundCloudCommands["Me"];
            string parameters = "?oauth_token=" + CookieHandler.getCookie(request, "SoundCloudToken").Value;

            return HttpUtil.HttpGet(command, parameters);

        }
        public static string retriveUser(int userID)
        {
            /* check if logged in*/

            /* need to pass in oauth ID */
            string command = SoundCloudAPIConstants.SoundCloudCommands["Users"] + "/" + userID;
            string parameters = "?client_id=" + _clientID;

            return HttpUtil.HttpGet(command, parameters);
        }   

        public static string retriveOAuthToken(HttpRequestBase request)
        {
            var parameters = "?client_id=" + _clientID
                           + "&client_secret=" + _secretKey
                           + "&redirect_uri=" + _redirectUrl
                           + "grant_type=authorization_code"
                           + "&code=" + CookieHandler.getCookie(request, "SoundCloudToken").Value;

            // decrypt token string

            return HttpUtil.HttpPost("https://api.soundcloud.com/oauth2/token", parameters);

        }
        public static string retriveUserFollowers(int userID)
        {
            string command = SoundCloudAPIConstants.SoundCloudCommands["Users"] + "/" + userID + "/followers";
            string parameters = "?client_id=" + _clientID;

            return HttpUtil.HttpGet(command, parameters);
        }
        public static string retriveUserFollowing(int userID)
        {
            string command = SoundCloudAPIConstants.SoundCloudCommands["Users"] + "/" + userID + "/followings";
            string parameters = "?client_id=" + _clientID;

            return HttpUtil.HttpGet(command, parameters);
        }
    }
}