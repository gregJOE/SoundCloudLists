using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoundCloudLists.WebUtil
{
    public interface IBrowserUtil
    {
        HttpCookie getCookie();
        HttpCookie getCookies();
        HttpCookie retriveValueFromCookie(string key);
        HttpCookie clearCookies();
        HttpCookie updateValue(string key, string newValue);
    }
}