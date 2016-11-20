using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Mvc;

namespace SoundCloudLists.Controllers
{
    public class UserController : Controller
    {
        // GET: api/User
        public ActionResult Index()
        {
            return View();
        }

        // GET: api/User/5
        public ActionResult Detail(int? userID)
        {
            return View();
        }

        // POST: api/User
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/User/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/User/5
        public void Delete(int id)
        {
        }
    }
}
