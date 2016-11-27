using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoundCloudLists.API
{
    public interface ISoundcloudRESTService
    {
        string retriveUser(int userID);
        string retriveOAuthToken(HttpRequestBase request);
    }
}