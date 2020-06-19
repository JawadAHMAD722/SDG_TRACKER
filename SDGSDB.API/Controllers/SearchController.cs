using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SDGSDB.Models;
using SDGSDB.Lib;

namespace SDGSDB.API.Controllers
{
    [Route("api/[controller]")]
    public class SearchController : ApiController
    {
        [Route("SearchSdgs")]
        [HttpGet]
        public IHttpActionResult FetchSdgByOrg(string name)
        {
            try
            {
                List<SDGs> sdg = Lib.DAL.Search.Get_Sdg_by_org(name);
                return Json(sdg);
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                throw;
            }
            
        }

        [Route("GetOrg")]
        [HttpGet]
        public IHttpActionResult Fetch_Org()
        {
            List<ORG> org = Lib.DAL.Search.Get_org();
            return Json(org);
        }

        [Route("GetOrgBySDG")]
        [HttpGet]
        public IHttpActionResult Fetch_Org_By_SDG(int id)
        {
            List<ORG> org = Lib.DAL.Search.Get_org_By_SDG(id);
            return Json(org);
        }
    }
}
