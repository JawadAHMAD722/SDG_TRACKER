using SDGSDB.Lib.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SDGSDB.API.Controllers
{
    public class FetchPrimaryEmailController : ApiController
    {
        public string Get_Email(int id)
        {
            string email = Organization_CRUD.FetchEmailForReg(id);

            return email;

        }
    }
}
