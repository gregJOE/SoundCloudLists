using SoundCloudLists.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using SoundCloudLists.Data;

namespace SoundCloudLists.Controllers
{
    public class LoginController : Controller
    {
        private UserRepository _userRepository = null;

        public LoginController()
        {
            _userRepository = new UserRepository();
        }
        // GET: Login
        public ActionResult Index()
        {
            // check if user is already logged in

            // if he's not, return partial view with sign up button
            return PartialView();
        }

        // GET: Login/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Login/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Login/Create
        [HttpPost]
        public ActionResult SignIn(FormCollection collection)
        {
            try
            {
                // soundcloud already athenticated user. Create new user object given user info and direct to
                // user detail screen

                var jsonString = (collection.Get("scdata"));

                //Dictionary<String, object> mapJsonObjects = (Dictionary<String, object>)new JavaScriptSerializer().Deserialize(jsonString, Map<String, object>.class;
                int userID = _userRepository.createUserFromJson(jsonString);

                return RedirectToAction("Detail", "User", new { id = userID });
            }
            catch
            {
                return View();
                //return RedirectToAction("Index");
            }
        }

        // GET: Login/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Login/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Login/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Login/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
