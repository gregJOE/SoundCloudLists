using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoundCloudLists.API
{
    public static class SoundCloudAPIConstants
    {
        public static readonly Dictionary<string, string> SoundCloudCommands  = new Dictionary<string, string>()
        {
            { "Me", "https://api.soundcloud.com/me" },
            { "Users", "https://api.soundcloud.com/users" },
            { "Tracks", "https://api.soundcloud.com/tracks" },
            { "Playlists", "https://api.soundcloud.com/playlist" },
            { "Comments", "https://api.soundcloud.com/comments" },
            { "Connections", "https://api.soundcloud.com/me/connections" },
            { "Activities", "https://api.soundcloud.com/me/activities" },

        };
    }
}