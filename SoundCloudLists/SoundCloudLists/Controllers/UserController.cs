using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Mvc;
using SoundCloudLists.Models;
using SoundCloudLists.Data;
using System.IO;
using SoundCloudLists.WebUtil;
using SoundCloudLists.API;

namespace SoundCloudLists.Controllers
{
    public class UserController : Controller
    {
        private UserRepository _userRepository = null;

        public UserController()
        {
            _userRepository = new UserRepository();
        }

        //TODO WRAP AROUND TRY/CATCH
        public ActionResult Index()
        {
            //obtain cookie
            var authToken = CookieHandler.retriveValueFromCookie(Request, "SoundCloudToken");
            
            /* wrap this function */
            if (authToken == null)
            {
                return RedirectToAction("Index", "Login");
            }
            var responseFromServer = SoundCloudRestAPI.retriveMe(Request);

            User user = _userRepository.createUserFromJson(responseFromServer);
            return View(user);
        }

        // GET: api/User/5

        //TODO WRAP AROUND TRY/CATCH
        public ActionResult Detail(int? id)
        {
            if (id   == null)
            {
                //HttpError("404");
                return new HttpNotFoundResult("User Not Found");
            }

            /* wrap this function 
            if (authToken == null)
            {
                return RedirectToAction("Index", "Login");
            }
            */
            var responseFromServer = SoundCloudRestAPI.retriveUser((int)id);
            
            if (responseFromServer == null)
            {
                return new HttpNotFoundResult("User Not Found");
            }
            User user = _userRepository.createUserFromJson(responseFromServer);

            return View(user);
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
            
        public ActionResult Followers(int? id)
        {
            if (id == null)
            {
                //HttpError("404");
                return new HttpNotFoundResult("User Not Found");
            }

            var responseFromServer = SoundCloudRestAPI.retriveUserFollowers((int)id);
            UserList users = _userRepository.createUsersFromJson(responseFromServer);

            return PartialView(users);

        }
        public ActionResult Following(int? id)
        {
            if (id == null)
            {
                //HttpError("404");
                return new HttpNotFoundResult("User Not Found");
            }


            // should this be a view model instead?
            var responseFromServer = SoundCloudRestAPI.retriveUserFollowing((int)id);
            UserList users = _userRepository.createUsersFromJson(responseFromServer);

            return PartialView(users);
        }
    }
}
