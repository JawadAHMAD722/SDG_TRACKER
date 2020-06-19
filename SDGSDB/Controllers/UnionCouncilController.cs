using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Newtonsoft.Json;
using SDGSDB.Models;

namespace SDGSDB.Controllers
{
    public class UnionCouncilController : Controller
    {
        //New Union Council
        [Authorize(Roles = "APP_USER,UC_ADMIN")]
        public ActionResult UnionCouncil(int UCID)
        {
            var GUID = HttpContext.User.Identity.GetUserId();
            ViewBag.CurrentUserID = GUID;
            ViewBag.UCID = UCID;
            return View();
        }
        [Authorize(Roles = "APP_USER,UC_ADMIN")]
        public ActionResult UnionCouncilOrg()
        {
            var GUID = HttpContext.User.Identity.GetUserId();
            ViewBag.CurrentUserID = GUID;
            string ApiBaseUrl = System.Web.Configuration.WebConfigurationManager.AppSettings["ApiBaseUrl"];
            try
            {
                var result = "";
                HttpClient client = new HttpClient();
                var response = client.GetAsync(ApiBaseUrl + "/GetAllUCInstitutionByUC?UserID=" + GUID).Result;
                if (response.IsSuccessStatusCode)
                {
                    result = response.Content.ReadAsStringAsync().Result;
                }
                UCOrgInstitutionsModel[] items = JsonConvert.DeserializeObject<UCOrgInstitutionsModel[]>(result);
                ViewBag.AllUCInstitution = items;
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                throw;
            }
            return View();
        }
        [Authorize(Roles = "APP_USER,UC_ADMIN")]
        public ActionResult UnionCouncilOrgInstitutions(int Sector_Category_Id)
        {
            var GUID = HttpContext.User.Identity.GetUserId();
            ViewBag.CurrentUserID = GUID;
            string ApiBaseUrl = System.Web.Configuration.WebConfigurationManager.AppSettings["ApiBaseUrl"];
            try
            {
                var result = "";
                HttpClient client = new HttpClient();
                var response = client.GetAsync(ApiBaseUrl + "/GetAllUCInstitutionByUCSectorsCat?UserID=" + GUID+ "&Sector_Category_Id="+ Sector_Category_Id).Result;
                if (response.IsSuccessStatusCode)
                {
                    result = response.Content.ReadAsStringAsync().Result;
                }
                UCOrgInstitutionsModel[] items = JsonConvert.DeserializeObject<UCOrgInstitutionsModel[]>(result);
                ViewBag.AllUCInstitutionsBySectors = items;
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                throw;
            }
            return View();
        }
        [Authorize(Roles = "APP_USER,UC_ADMIN")]
        public ActionResult UCRegistration()
        {
            var GUID = HttpContext.User.Identity.GetUserId();
            ViewBag.CurrentUserID = GUID;
            return View();
        }
        [Authorize(Roles = "APP_USER,UC_ADMIN")]
        public ActionResult UCProfileView()
        {
            var GUID = HttpContext.User.Identity.GetUserId();
            ViewBag.CurrentUserID = GUID;
            return View();
        }
        [Authorize(Roles = "APP_USER,UC_ADMIN")]
        public ActionResult UCStaff()
        {
            var GUID = HttpContext.User.Identity.GetUserId();
            ViewBag.CurrentUserID = GUID;
            return View();
        }
        [Authorize(Roles = "APP_USER,UC_ADMIN")]
        public ActionResult TourismSpot()
        {
            var GUID = HttpContext.User.Identity.GetUserId();
            ViewBag.CurrentUserID = GUID;
            return View();
        }
    }

}