using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Mvc;
using SoundCloudLists.Models;
using SoundCloudLists.Data;

namespace SoundCloudLists.Controllers
{
    public class UserController : Controller
    {
        private UserRepository _userRepository = null;

        public UserController()
        {
            _userRepository = new UserRepository();
        }

        public ActionResult Index()
        {
            return View();
        }

        // GET: api/User/5
        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                //HttpError("404");
                return new HttpNotFoundResult("User Not Found");
            }

            //TODO have a user repo object create a new user object
            User currentUser = _userRepository.getUser((int)id.Value);

            return View(currentUser);
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
            
        public void GetFollowers(int userID)
        {

        }
    }
}
