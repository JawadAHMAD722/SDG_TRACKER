using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SDGSDB.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project
        public ActionResult InitiateProject()
        {
            return View();
        }
        public ActionResult AddMembersToTeam()
        {
            return View();
        }
        public ActionResult AddTeams()
        {
            return View();
        }
    }
}