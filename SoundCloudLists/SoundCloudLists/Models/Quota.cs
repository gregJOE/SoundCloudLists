using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoundCloudLists.Models
{
    public class Quota
    {
        public bool unlimited_upload_quota { get; set; }
        public int upload_seconds_used { get; set; }
        public int upload_seconds_left { get; set; }
    }

}