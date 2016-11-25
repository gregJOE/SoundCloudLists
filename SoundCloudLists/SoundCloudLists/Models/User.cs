using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoundCloudLists.Models
{
    public class User
    {
        [JsonProperty("id")]
        int _id;

        [JsonProperty("kind")]
        string _userType;

        [JsonProperty("permalink")]
        string _permalink;

        [JsonProperty("username")]
        string _username;

        [JsonProperty("uri")]
        string _uri;

        [JsonProperty("permalink_url")]
        string _permalink_url;

        [JsonProperty("avatar_url")]
        string _avatar_url;

        [JsonProperty("country")]
        string _country;

        [JsonProperty("description")]
        string _description;

        [JsonProperty("city")]
        string _city;

        [JsonProperty("track_count")]
        int _track_count;

        [JsonProperty("followers_count")]
        int _followers_count;

        [JsonProperty("followings_count")]
        int _followings_count;

        public User(int id, string userType, string permalink, string username, string uri, string permalink_url, string avatar_url, string country, string description, string city, int track_count, int followers_count, int followings_count)
        {
            _id = id;
            _userType = userType;
            _permalink = permalink;
            _username = username;
            _uri = uri;
            _permalink_url = permalink_url;
            _avatar_url = avatar_url;
            _country = country;
            _description = description;
            _city = city;
            _track_count = track_count;
            _followers_count = followers_count;
            _followings_count = followings_count;
        }

        public User()
        {

        }

        public int getID() { return _id; }
        public string getUserName() { return _username; }
        public string permalink() { return _permalink; }
        public string avatar() { return _avatar_url; }
        public int Followers() { return _followers_count; }
        public int Following() { return _followings_count; }
    }
}