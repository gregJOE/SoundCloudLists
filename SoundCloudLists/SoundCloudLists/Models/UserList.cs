using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoundCloudLists.Models
{
    public class UserList
    {
        [JsonProperty("collection")]
        User[] _content;

        public UserList(User[] content)
        {
            _content = content;
        }

        public User[] getContent()
        {
            return _content;
        }
    }
}