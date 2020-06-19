using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using Newtonsoft.Json;
using SDGSDB.Models;

namespace SDGSDB.API.Controllers
{
    [Route("api/[controller]")]
    public class OrganizationApiController : ApiController
    {
        [Route("GetOrganizationProfile")]
        [HttpGet]
        public HttpResponseMessage GetOrgProfile(string UserID)
        {
            try
            {
                List<OrganizationProfileModel> Result = new List<OrganizationProfileModel>();
                Result = Lib.DAL.OrganizationsMethod.Get_Org_Profile(UserID);
                string jsonesult = JsonConvert.SerializeObject(Result);
                return Request.CreateResponse(HttpStatusCode.OK, jsonesult);
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }
        //Get Org Profile ByID

        [Route("GetOrganizationProfileBYID")]
        [HttpGet]
        public HttpResponseMessage GetOrgProfileByID(int OrgID, int OfficeID)
        {
            try
            {
                List<OrganizationProfileModel> Result = new List<OrganizationProfileModel>();
                Result = Lib.DAL.OrganizationsMethod.Get_Org_ProfileByID(OrgID, OfficeID);
                string jsonesult = JsonConvert.SerializeObject(Result);
                return Request.CreateResponse(HttpStatusCode.OK, jsonesult);
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }
        [Route("GetAllRegisteredOrganization")]
        [HttpGet]
        public IHttpActionResult GetAllRegOrganization()
        {
            try
            {
                List<GridGetAllRegisteredOrg> Result = new List<GridGetAllRegisteredOrg>();
                Result = Lib.DAL.OrganizationsMethod.Get_AllRegisteredOrg();
                string jsonesult = JsonConvert.SerializeObject(Result);
                return Ok(Result);
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }
        //Get All Employee
        [Route("GetAllEmployee")]
        [HttpGet]
        public IHttpActionResult GetAllEmployee(string UserID)
        {
            try
            {
                List<EmployeeModel> Result = new List<EmployeeModel>();
                Result = Lib.DAL.OrganizationsMethod.Get_AllEmployee(UserID);
                string jsonesult = JsonConvert.SerializeObject(Result);
                return Ok(Result);
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }
        //Add Employee
        [Route("AddEmployee")]
        [HttpPost]
        public IHttpActionResult ADD_Employee(EmployeeModel Emp, string UserID)
        {
            try
            {
                bool status = false;
                var a = Emp;
                var b = UserID;
                status = Lib.DAL.OrganizationsMethod.Add_Employee(Emp, UserID);
                //string Json = JsonConvert.ToString(result);
                return Json(status);
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }
    }
}
