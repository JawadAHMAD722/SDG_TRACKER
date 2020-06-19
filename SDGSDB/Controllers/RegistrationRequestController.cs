using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SDGSDB.Controllers
{
    public class RegistrationRequestController : Controller
    {
        // GET: RegistrationRequest
        [Authorize(Roles = "APP_USER")]
        public ActionResult Index()
        {
            return View();
        }
    }
}