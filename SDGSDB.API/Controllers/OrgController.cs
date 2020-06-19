using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Web.Http;
using SDGSDB.API.Models;
using SDGSDB.API.ViewModels;
using System.Web.Http.Results;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using  SDGSDB.Lib.DAL;
using SDGSDB.Models;


namespace SDGSDB.API.Controllers
{
    [Route("api/[controller]")]
    public class OrgController : ApiController
    {
        [Route("Insert_Initial_Organization")]
        [HttpPost]
        public string DB_Insert(Organization org)
        {
            try
            {
                //int[] result;
                int OrgID = Organization_CRUD.Organization_Insertion(org);
                //result =Organization_CRUD.Organization_Insertion(org);
                return System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(OrgID.ToString()));

            }
            catch (Exception ex)
            {
                var message = ex.Message;
                throw;
            }
            
        }
        [Route("Pending_Request")]
        [HttpGet]
        public IHttpActionResult Get_Data()
        {
            try
            {
                List<FetchOrg> org = Organization_CRUD.Get_Pending_Organization_Data();

                return Json(org);
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                throw;
            }
           

        }
        [Route("Accepted_Request")]
        [HttpGet]
        public IHttpActionResult Get_Accepted_Data()
        {
            List<FetchOrg> org = Organization_CRUD.Get_Accepted_Organization_Data();

            return Json(org);

        }
        [Route("Rejected_Request")]
        [HttpGet]
        public IHttpActionResult Get_Rejected_Data()
        {
            List<FetchOrg> org = Organization_CRUD.Get_Rejected_Organization_Data();

            return Json(org);

        }

    }
}


