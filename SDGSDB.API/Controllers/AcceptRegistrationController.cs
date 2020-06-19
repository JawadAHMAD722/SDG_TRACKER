using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using SDGSDB.Lib.DAL;
using SDGSDB.Models;

namespace SDGSDB.API.Controllers
{
    [Route("api/[controller]")]
    public class AcceptRegistrationController : ApiController
    {
        [Route("Accept")]
        [HttpPost]
        public void Accept(Registration reg)
        {
           
            Organization_CRUD.ConfirmReg(reg);
            
        }

        [Route("Reject")]
        [HttpPost]
        public void Reject(Registration reg)
        {
           
            Organization_CRUD.ConfirmReg(reg);
        }
    }
}
