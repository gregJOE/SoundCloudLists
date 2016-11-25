using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SoundCloudLists.Models;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace SoundCloudLists.Data
{
    public class UserRepository
    {
        private static Dictionary<int, User> _loggedInUsers = new Dictionary<int, User>();

        public User getUser(int id)
        {
            return _loggedInUsers[id];
        }

        public int createUserFromJson(string jsonString)
        {
            User newloggedinUser = JsonConvert.DeserializeObject<User>(jsonString);

            _loggedInUsers.Add(newloggedinUser.getID(), newloggedinUser);

            return newloggedinUser.getID();
        }
    }
}