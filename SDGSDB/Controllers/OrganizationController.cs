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
    public class OrganizationController : Controller
    {
        [Authorize(Roles = "ORGANIZATION_ADMIN,APP_USER")]
        // GET: Organization
        public ActionResult OrganizationDetailGrid()
        {
            var GUID = HttpContext.User.Identity.GetUserId();
            ViewBag.CurrentUserID = GUID;
            //DropDown Bind RegisterationAuthority
            var RegisterationAuthority = new List<drpRegisterationAuthority>();
            RegisterationAuthority.Add(new drpRegisterationAuthority() { Value = "Null", Text = "Select Registeration Authority" });
            RegisterationAuthority.Add(new drpRegisterationAuthority() { Value = "SECP", Text = "SECP" });
            RegisterationAuthority.Add(new drpRegisterationAuthority() { Value = "Voluntary Social Welfare Agencies Registration and Control Ordinance 1961", Text = "Voluntary Social Welfare Agencies Registration and Control Ordinance 1961" });
            RegisterationAuthority.Add(new drpRegisterationAuthority() { Value = "Baitul Maal", Text = "Baitul Maal" });

            RegisterationAuthority.Add(new drpRegisterationAuthority() { Value = "Income Tax Ordinance, 2001", Text = "Income Tax Ordinance, 2001" });
            RegisterationAuthority.Add(new drpRegisterationAuthority() { Value = "The Societies Registration Act, 1860", Text = "The Societies Registration Act, 1860" });
            RegisterationAuthority.Add(new drpRegisterationAuthority() { Value = "The Cooperative Society Act, 1925", Text = "The Cooperative Society Act, 1925" });
            RegisterationAuthority.Add(new drpRegisterationAuthority() { Value = "The Companies Ordinance, 1984(section 42)", Text = "The Companies Ordinance, 1984(section 42)" });
            RegisterationAuthority.Add(new drpRegisterationAuthority() { Value = "The Trust Act, 1882", Text = "The Trust Act, 1882" });
            ViewBag.drpRegisterationAuthority = RegisterationAuthority;

            //DropDown Bind RegisterationAuthority
            var CompanyCategory = new List<drpCompanyCategory>();
            CompanyCategory.Add(new drpCompanyCategory() { Value = "Null", Text = "Select Company Category" });
            CompanyCategory.Add(new drpCompanyCategory() { Value = "Single", Text = "Single" });
            CompanyCategory.Add(new drpCompanyCategory() { Value = "Partnership", Text = "Partnership" });
            ViewBag.drpCompanyCategory = CompanyCategory;
            return View();
        }
        //Get Org Profile
        public ActionResult OrganizationsProfile(int OrgID, int OfficeID)
        {
            ViewBag.OrgID = OrgID;
            ViewBag.OfficeID = OfficeID;
            return View();
        }
        //Organization Employees
        [Authorize(Roles = "ORGANIZATION_ADMIN,APP_USER,UC_ADMIN")]
        public ActionResult OrgEmployees()
        {
            var GUID = HttpContext.User.Identity.GetUserId();
            ViewBag.CurrentUserID = GUID;
            return View();
        }
        //Employee Detail Grid
        [Authorize(Roles = "ORGANIZATION_ADMIN,APP_USER,UC_ADMIN")]
        public ActionResult EmployeesDetail()
        {
            var GUID = HttpContext.User.Identity.GetUserId();
            ViewBag.CurrentUserID = GUID;
            string ApiBaseUrl = System.Web.Configuration.WebConfigurationManager.AppSettings["ApiBaseUrl"];
            try
            {
                var result = "";
                HttpClient client = new HttpClient();
                var response = client.GetAsync(ApiBaseUrl + "/GetAllEmployee?UserID=" + GUID).Result;
                if (response.IsSuccessStatusCode)
                {
                    result = response.Content.ReadAsStringAsync().Result;
                }
                EmployeeModel[] items = JsonConvert.DeserializeObject<EmployeeModel[]>(result);
                ViewBag.AllEmployees = items;
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                throw;
            }
            return View();
        }
    }
}