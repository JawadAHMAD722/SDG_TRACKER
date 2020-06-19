using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using System.Web.Mvc;

namespace SDGSDB.Controllers
{
    public class AppAdminController : Controller
    {
        // GET: AppAdmin
        [Authorize(Roles = "APP_USER")]
        public ActionResult PendingRequest()
        {
            var GUID = HttpContext.User.Identity.GetUserId();
            ViewBag.CurrentUserID = GUID;
            return View();
        }
        //Accepted Request View Controller
        [Authorize(Roles = "APP_USER")]
        public ActionResult AcceptedRequest()
        {
            var GUID = HttpContext.User.Identity.GetUserId();
            ViewBag.CurrentUserID = GUID;
            return View();
        }
        //Rejeted Request View Controller
        [Authorize(Roles = "APP_USER")]
        public ActionResult RejectedRequest()
        {
            var GUID = HttpContext.User.Identity.GetUserId();
            ViewBag.CurrentUserID = GUID;
            return View();
        }
    }
}