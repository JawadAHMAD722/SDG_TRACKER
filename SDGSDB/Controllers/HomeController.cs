using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SDGSDB.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace SDGSDB.Controllers
{
    
    public class HomeController : Controller
    {
        public ActionResult Index(Organization org)
        {
            if(ModelState.IsValid)
            {

            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View("Index");
            
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Initial_Registration()
        {
            return View();
        }
        public ActionResult No_Poverty()
        {
            return View();
        }
        public ActionResult Zero_Hunger()
        {
            return View();
        }
        public ActionResult Good_Health()
        {
            return View();
        }
        public ActionResult Quality_Education()
        {
            return View();
        }
        public ActionResult Gender_Equality()
        {
            return View();
        }
        public ActionResult Clean_Water()
        {
            return View();
        }
        public ActionResult Affordable_Clean_Energy()
        {
            return View();
        }
        public ActionResult Decent_Work()
        {
            return View();
        }
        public ActionResult Industry_Innovation_Infrastructure()
        {
            return View();
        }
        public ActionResult Reduced_Inequalities()
        {
            return View();
        }
        public ActionResult Sustainable_Cities()
        {
            return View();
        }
        public ActionResult Responsible_Consuption_Production()
        {
            return View();
        }
        public ActionResult Climate_Action()
        {
            return View();
        }
        public ActionResult Life_Below_Water()
        {
            return View();
        }
        public ActionResult Life_On_Land()
        {
            return View();
        }
        public ActionResult Peace_Justice()
        {
            return View();
        }
        public ActionResult Partnership()
        {
            return View();
        }
        public ActionResult data_visualization()
        {
            return View();
        }
        public ActionResult Registered_organizations()
        {
            string ApiBaseUrl = System.Web.Configuration.WebConfigurationManager.AppSettings["ApiBaseUrl"];
            try
            {
                var result = "";
                HttpClient client = new HttpClient();
                var response = client.GetAsync(ApiBaseUrl + "/GetAllRegisteredOrganization").Result;
                if (response.IsSuccessStatusCode)
                {
                    result = response.Content.ReadAsStringAsync().Result;
                }
                GridGetAllRegisteredOrg[] items = JsonConvert.DeserializeObject<GridGetAllRegisteredOrg[]>(result);
                ViewBag.AllRegisteredOrg = items;
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                throw;
            }
            return View();
        }
        public ActionResult top_ratedorganizations()
        {
            string ApiBaseUrl = System.Web.Configuration.WebConfigurationManager.AppSettings["ApiBaseUrl"];
            try
            {
                var result = "";
                HttpClient client = new HttpClient();
                var response = client.GetAsync(ApiBaseUrl + "/GetAllRegisteredOrganization").Result;
                if (response.IsSuccessStatusCode)
                {
                    result = response.Content.ReadAsStringAsync().Result;
                }
                GridGetAllRegisteredOrg[] items = JsonConvert.DeserializeObject<GridGetAllRegisteredOrg[]>(result);
                ViewBag.AllRegisteredOrg = items;
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                throw;
            }
            return View();
        }
        public ActionResult survey_data()
        {
            return View();
        }
        public ActionResult survey_published()
        {
            return View();
        }
        public ActionResult sdg_tracker()
        {
            return View();
        }
        public ActionResult investment_oppertunities()
        {
            return View();
        }
        public ActionResult ConfirmEmail()
        {
            return View();
        }
    }
}