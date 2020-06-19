using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SDGSDB.Lib.DAL;

namespace SDGSDB.API.Controllers
{
    //[Route("api/[controller]")]
    public class ConfirmMailController : ApiController
    {

       // [Route("EMailConfirmation")]
        [HttpGet]
        public IHttpActionResult ConfirmEmail(string id)
        {
            string BaseUrl = System.Web.Configuration.WebConfigurationManager.AppSettings["baseUrl"];
            bool status;
            status = Organization_CRUD.Confirm_Email(id);
            if (status.Equals(true))
            {
                string url = BaseUrl + "/Home/ConfirmEmail";
                System.Uri uri = new System.Uri(url);
                return Redirect(uri);
            }
            else
                return Ok("Not valid");

        }
    }
}
