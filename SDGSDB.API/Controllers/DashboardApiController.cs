using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using SDGSDB.Lib.Common;
using SDGSDB.Models;

namespace SDGSDB.API.Controllers
{
    [Route("api/[controller]")]
    public class DashboardApiController : ApiController
    {
        //Get Total Registered Organizations
        [Route("GetTotalRegisteredNGOS")]
        [HttpGet]
        public HttpResponseMessage Get_TotalNGO()
        {
            try
            {
                int Result;
                Result = Lib.DAL.Dashboard.Get_TotalRegNGO();
                string jsonesult = JsonConvert.SerializeObject(Result);
                return Request.CreateResponse(HttpStatusCode.OK, jsonesult);
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }
        //Get Total Registeration Request
        [Route("GetTotalRegisterationRequest")]
        [HttpGet]
        public HttpResponseMessage Get_TotalRegRequest()
        {
            try
            {
                int Result;
                Result = Lib.DAL.Dashboard.Get_TotalRegRequest();
                string jsonesult = JsonConvert.SerializeObject(Result);
                return Request.CreateResponse(HttpStatusCode.OK, jsonesult);
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }
        //Get Login Organization and Office Information
        [Route("GetLoginNGOOfficeInfo")]
        [HttpGet]
        public HttpResponseMessage Get_LoginOrgOfficeInfo(string UserID)
        {
            try
            {
                List<LoginOrgAndOfficeInfoModel> Result = new List<LoginOrgAndOfficeInfoModel>();
                Result = Lib.DAL.Dashboard.Get_LoginOrgOfficeInfo(UserID);
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
