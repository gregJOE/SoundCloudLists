using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoundCloudLists.Models
{
    public class List
    {
        public string listname { get; set; }
        public string description { get; set; }

        int listid;
        // should be saved when a new list is created

        string addusername { get; }
        int adduserid;

        IList<User> usersFollowing;


        public List()
        {

        }
        public IEnumerable<User> addAccountToList(User newUser)
        {
            usersFollowing.Add(newUser);

            return usersFollowing.AsEnumerable<User>();
        }

        public int GetFollowingCount()
        {
            return usersFollowing.Count;
        }
        
    }
}