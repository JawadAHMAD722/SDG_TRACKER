using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;

namespace SDGSDB.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        [Authorize(Roles = "ORGANIZATION_ADMIN,APP_USER")]
        public ActionResult OrganizationAdminDashboard()
        {
            var GUID = HttpContext.User.Identity.GetUserId();
            ViewBag.CurrentUserID = GUID;
            return View();
        }

        // GET: App Admin Dashboard
        [Authorize(Roles = "APP_USER")]
        public ActionResult AdminDashboard()
        {
            var GUID = HttpContext.User.Identity.GetUserId();
            ViewBag.CurrentUserID = GUID;
            return View();
        }

        // GET: Dashboard
        [Authorize(Roles = "OFFICE_ADMIN,ORGANIZATION_ADMIN,APP_USER")]
        public ActionResult OfficeAdminDashboard()
        {
            var GUID = HttpContext.User.Identity.GetUserId();
            ViewBag.CurrentUserID = GUID;
            ViewBag.CurrentUserID1 = GUID;
            return View();
        }
    }
}