using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoundCloudLists.Controllers
{
    public class ListController : Controller
    {
        //TODO this should return all the lists associated with the current user logged in
        public ActionResult Index()
        {
            return View();
        }

        //TODO this should direct to a screen that asks for confirmation to remove a selected list.
        public ActionResult RemoveList(int listID)
        {
            return View();
        }

        public ActionResult Detail(int listID)
        {
            return View();
        }
        /*
        public ActionResult UpdateList(int listID, object formData)
        {
            return View();
        }
        */


    }
}