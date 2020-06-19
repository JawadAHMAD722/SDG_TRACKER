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
    public class OfficeApiController : ApiController
    {
        [Route("GetAllRegisteredOfficesByOrg")]
        [HttpGet]
        public HttpResponseMessage GetAllRegOOfficesByOrg(int OrgID)
        {
            try
            {
                List<GridGetAllRegisteredOfficesByOrg> Result = new List<GridGetAllRegisteredOfficesByOrg>();
                Result = Lib.DAL.OfficesMethod.Get_AllRegisteredOfficesByOrg(OrgID);
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
