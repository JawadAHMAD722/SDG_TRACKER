using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SDGSDB.Models;
using SDGSDB.API;
using Newtonsoft.Json;

namespace SDGSDB.API.Controllers
{
    [Route("api/[controller]")]
    public class RegisterOrgEmailFetchController : ApiController
    {
        [Route("GetRegistrOrgEmail")]
        [HttpGet]
        public HttpResponseMessage GetRegistrOrgEmail(int Organization_Id,int Office_Id)
        {
            try
            {
                List<GetRegisteredOrgEmailModel> Result = new List<GetRegisteredOrgEmailModel>();
                Result = Lib.DAL.Organization_CRUD.Get_RegisterOrgEmails(Organization_Id,Office_Id);
                string jsonesult = JsonConvert.SerializeObject(Result);
                return Request.CreateResponse(HttpStatusCode.OK, jsonesult);
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }
    }
}
