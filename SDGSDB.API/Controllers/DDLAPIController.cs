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
    public class DDLAPIController : ApiController
    {
        [Route("GetProvince")]
        [HttpGet]
        public HttpResponseMessage Get_Province()
        {
            try
            {
                List<ProvinceModel> Result = new List<ProvinceModel>();
                Result = DDL.Get_Province();
                string jsonesult = JsonConvert.SerializeObject(Result);
                return Request.CreateResponse(HttpStatusCode.OK, jsonesult);
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }
        //Get Tourism Spot DDL
        [Route("GetTourismSpots")]
        [HttpGet]
        public HttpResponseMessage Get_TourismSpots()
        {
            try
            {
                List<DDLTourismSpotModel> Result = new List<DDLTourismSpotModel>();
                Result = DDL.Get_TourismSpot();
                string jsonesult = JsonConvert.SerializeObject(Result);
                return Request.CreateResponse(HttpStatusCode.OK, jsonesult);
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }
        //Get Tourism Spot Category DDL
        [Route("GetTourismSpotsCategories")]
        [HttpGet]
        public HttpResponseMessage Get_TourismSpotsCategories()
        {
            try
            {
                List<DDLTourismSpotCatModel> Result = new List<DDLTourismSpotCatModel>();
                Result = DDL.Get_TourismSpotCategories();
                string jsonesult = JsonConvert.SerializeObject(Result);
                return Request.CreateResponse(HttpStatusCode.OK, jsonesult);
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }

        //Organization_Type_API
        [Route("GetOrganizationType")]
        [HttpGet]
        public HttpResponseMessage Get_OrganizationType()
        {
            try
            {
                List<DDLOrganizationTypeModel> status = new List<DDLOrganizationTypeModel>();
                status = DDL.GetOrganization_Types();
                string json = JsonConvert.SerializeObject(status);
                return Request.CreateResponse(HttpStatusCode.OK, json);
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }

        //Divisions API
        [Route("GetDivisionsByID")]
        [HttpGet]
        public HttpResponseMessage Get_DivisionsByID(int Province_Id)
        {
            try
            {
                List<DDLDivisionsModel> status = new List<DDLDivisionsModel>();
                status = DDL.Get_Divisions(Province_Id);
                string json = JsonConvert.SerializeObject(status);
                return Request.CreateResponse(HttpStatusCode.OK, json);
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }

        //Districts API
        [Route("GetDistrictsByDivisions")]
        [HttpGet]
        public HttpResponseMessage Get_DistrictsByDivisionID(int Division_Id)
        {
            try
            {
                List<DDLDistrictModel> status = new List<DDLDistrictModel>();
                status = DDL.Get_Districts(Division_Id);
                string json = JsonConvert.SerializeObject(status);
                return Request.CreateResponse(HttpStatusCode.OK, json);
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }

        //Tehsils API
        [Route("GetTehsilsByDistricts")]
        [HttpGet]
        public HttpResponseMessage Get_TehsilsByDistricts(int DistrictID)
        {
            try
            {
                List<DDLTehsilsModel> status = new List<DDLTehsilsModel>();
                status = DDL.Get_Tehsils(DistrictID);
                string json = JsonConvert.SerializeObject(status);
                return Request.CreateResponse(HttpStatusCode.OK, json);
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }

        //Union Councils API
        [Route("GetUnionCouncilsByDistricts")]
        [HttpGet]
        public HttpResponseMessage Get_Union_CouncilsByDistricts(int DistrictID)
        {
            try
            {
                List<DDLUnionCouncilModel> status = new List<DDLUnionCouncilModel>();
                status = DDL.Get_Union_Councils(DistrictID);
                string json = JsonConvert.SerializeObject(status);
                return Request.CreateResponse(HttpStatusCode.OK, json);
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }

        //GET SDGS Dropdown API
        [Route("GetSDGS")]
        [HttpGet]
        public HttpResponseMessage Get_SDGS()
        {
            try
            {
                List<DDLSDGModel> Result = new List<DDLSDGModel>();
                Result = DDL.Get_SDGS();
                string jsonesult = JsonConvert.SerializeObject(Result);
                return Request.CreateResponse(HttpStatusCode.OK, jsonesult);
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }

        //GET Targets Dropdown API
        [Route("GetTargets")]
        [HttpGet]
        public HttpResponseMessage Get_TargetsBySDG(int SDG_Id)
        {
            try
            {
                List<DDLTargetModel> status = new List<DDLTargetModel>();
                status = DDL.Get_Targets(SDG_Id);
                string json = JsonConvert.SerializeObject(status);
                return Request.CreateResponse(HttpStatusCode.OK, json);
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }

        //GET Indicators Dropdown API
        [Route("GetIndicators")]
        [HttpGet]
        public HttpResponseMessage Get_IndicatorsByTargets(int Target_Id)
        {
            try
            {
                List<DDLIndicatorsModel> status = new List<DDLIndicatorsModel>();
                status = DDL.Get_Indicators(Target_Id);
                string json = JsonConvert.SerializeObject(status);
                return Request.CreateResponse(HttpStatusCode.OK, json);
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }

        [Route("GetSectors")]
        [HttpGet]
        public HttpResponseMessage Get_Sectors()
        {
            try
            {
                List<DDLSectorsModel> Result = new List<DDLSectorsModel>();
                Result = DDL.Get_Sectors();
                string jsonesult = JsonConvert.SerializeObject(Result);
                return Request.CreateResponse(HttpStatusCode.OK, jsonesult);
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }
        [Route("GetSectorsCategories")]
        [HttpGet]
        public HttpResponseMessage Get_SectorsCategoriesBySectorID(int Sector_ID)
        {
            try
            {
                List<DDLSectorsCategoryModel> status = new List<DDLSectorsCategoryModel>();
                status = DDL.Get_SectorsCategoryBySectors(Sector_ID);
                string json = JsonConvert.SerializeObject(status);
                return Request.CreateResponse(HttpStatusCode.OK, json);
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }
    }
}
