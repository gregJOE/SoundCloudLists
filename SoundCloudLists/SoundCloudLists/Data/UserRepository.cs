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

        public User createUserFromJson(string jsonString)
        {
            User newUser = JsonConvert.DeserializeObject<User>(jsonString);

            return newUser;
        }
        public UserList createUsersFromJson(string jsonString)
        {
            var userList = JsonConvert.DeserializeObject<UserList>(jsonString);

            return userList;
        }
    }
}