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
using SDGSDB.Lib.DAL;
using SDGSDB.Models;

namespace SDGSDB.API.Controllers
{
    [Route("api/[controller]")]
    public class UCApiController : ApiController
    {
        #region Post Methods
        [Route("Insert_UCInitial_Registration")]
        [HttpPost]
        public IHttpActionResult UCRegistration(UCInitialRegistration UC, string UserId)
        {
            try
            {
                int[] result;
                result = UCMethods.Insert_UCRegistration(UC, UserId);
                return Json(result);

            }
            catch (Exception ex)
            {
                var message = ex.Message;
                throw;
            }

        }
        [Route("UCCompleteRegestration")]
        [HttpPost]
        //UC Profile Complete Registration
        public IHttpActionResult UC_ProfileCompleteRegistration(UCPCompleteRegistrationModel UCP, string UserID)
        {
            try
            {
                bool status = false;
                status = Lib.DAL.UCMethods.UCRegistrationComplete_Insertion(UCP, UserID);
                string JSONStatus = JsonConvert.SerializeObject(status);
                return Ok(JSONStatus);
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }

        [Route("UCUpdateProfile")]
        [HttpPost]
        //UC Profile Complete Registration
        public IHttpActionResult UC_ProfileUpdation(UCPCompleteRegistrationModel UCP, string UserID)
        {
            try
            {
                bool status = false;
                status = Lib.DAL.UCMethods.UCRegistrationComplete_Updation(UCP, UserID);
                string JSONStatus = JsonConvert.SerializeObject(status);
                return Ok(JSONStatus);
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }
        //UC Organization/Instituions Post
        [Route("UCOrganization")]
        [HttpPost]
        public IHttpActionResult UC_OrgInstitution_Insertion(UCOrgInstitutionsModel UCI, string UserID)
        {
            try
            {
                bool status = false;
                status = Lib.DAL.UCMethods.UCOrg_Insertion(UCI, UserID);
                string JSONStatus = JsonConvert.SerializeObject(status);
                return Ok(JSONStatus);
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }
        //Delete UCOrg
        [Route("DeleteUCOrg")]
        [HttpPost]
        public bool Delete_UCOrg(int UC_OrganizationId, string UserID)
        {
            try
            {
                bool status = false;
                status = Lib.DAL.UCMethods.UCOrg_Delete(UC_OrganizationId, UserID);
                return status;
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }

        //UC Staff
        [Route("UCStaff")]
        [HttpPost]
        public IHttpActionResult UC_Staff_Insertion(UCStaffModel UCS, string UserID)
        {
            try
            {
                bool status = false;
                status = Lib.DAL.UCMethods.UCStaff_Insertion(UCS, UserID);
                string JSONStatus = JsonConvert.SerializeObject(status);
                return Ok(JSONStatus);
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }

        //UC Staff
        [Route("UCStaffUpdation")]
        [HttpPost]
        public IHttpActionResult UC_Staff_Updation(UCStaffModel UCS, string UserID,int UC_Concil_StaffId)
        {
            try
            {
                bool status = false;
                status = Lib.DAL.UCMethods.UCStaff_Updation(UCS, UserID, UC_Concil_StaffId);
                string JSONStatus = JsonConvert.SerializeObject(status);
                return Ok(JSONStatus);
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }
        //UC Staff
        [Route("UCStaffDeletion")]
        [HttpPost]
        public IHttpActionResult UC_Staff_Deletion(string UserID, int UC_Concil_StaffId)
        {
            try
            {
                bool status = false;
                status = Lib.DAL.UCMethods.UCStaff_Deletion(UserID, UC_Concil_StaffId);
                string JSONStatus = JsonConvert.SerializeObject(status);
                return Ok(JSONStatus);
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }
        #endregion
        #region Get Methods
        //Get All Organizations By UC
        [Route("GetAllUCInstitutionByUC")]
        [HttpGet]
        public IHttpActionResult GetAllUCInstitutionByUC(string UserID)
        {
            try
            {
                List<UCOrgInstitutionsModel> Result = new List<UCOrgInstitutionsModel>();
                Result = Lib.DAL.UCMethods.Get_AllOrganizationByUC(UserID);
                string jsonesult = JsonConvert.SerializeObject(Result);
                return Ok(Result);
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }
        //Get All Institutions By UC Sectors Categories
        [Route("GetAllUCInstitutionByUCSectorsCat")]
        [HttpGet]
        public IHttpActionResult GetAllUCInstitutionByUCSectCat(string UserID, int Sector_Category_Id)
        {
            try
            {
                List<UCOrgInstitutionsModel> Result = new List<UCOrgInstitutionsModel>();
                Result = Lib.DAL.UCMethods.Get_AllOrganizationByUCSectorCat(UserID,Sector_Category_Id);
                string jsonesult = JsonConvert.SerializeObject(Result);
                return Ok(Result);
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }
        //Get UCSectors
        [Route("UCSectors")]
        [HttpGet]
        public HttpResponseMessage Get_UCSectors(string UserID)
        {
            try
            {
                List<DDLSectorsModel> status = new List<DDLSectorsModel>();
                status = Lib.DAL.UCMethods.Get_AllUCSectors(UserID);
                string json = JsonConvert.SerializeObject(status);
                return Request.CreateResponse(HttpStatusCode.OK, json);
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }
        //Get UCSector's Categories
        [Route("UCSectorsCategories")]
        [HttpGet]
        public HttpResponseMessage Get_UCSectorsCategories(string UserID,int Sector_ID)
        {
            try
            {
                List<DDLSectorsCategoryModel> status = new List<DDLSectorsCategoryModel>();
                status = Lib.DAL.UCMethods.Get_AllUCSectorsCategories(UserID, Sector_ID);
                string json = JsonConvert.SerializeObject(status);
                return Request.CreateResponse(HttpStatusCode.OK, json);
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }
        //Get UCOrganizatio by UC OrgID
        [Route("UCOrgByID")]
        [HttpGet]
        public HttpResponseMessage Get_UCORGByID(int UC_OrganizationId)
        {
            try
            {
                List<UCOrgInstitutionsModel> status = new List<UCOrgInstitutionsModel>();
                status = Lib.DAL.UCMethods.Get_UCOrgByID(UC_OrganizationId);
                string json = JsonConvert.SerializeObject(status);
                return Request.CreateResponse(HttpStatusCode.OK, json);
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }
        //Get UC Profile
        [Route("GetUCProfile")]
        [HttpGet]
        public IHttpActionResult GetUCProfile(string UserID)
        {
            try
            {
                List<UCProfile> Result = new List<UCProfile>();
                Result = Lib.DAL.UCMethods.Get_UCProfile(UserID);
                string jsonesult = JsonConvert.SerializeObject(Result);
                return Ok(Result);
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }

        //Get UC Profile
        [Route("GetUCStaff")]
        [HttpGet]
        public IHttpActionResult GetUCStaff(string UserID)
        {
            try
            {
                List<UCStaffModel> Result = new List<UCStaffModel>();
                Result = Lib.DAL.UCMethods.Get_UCStaff(UserID);
                string jsonesult = JsonConvert.SerializeObject(Result);
                return Ok(Result);
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }

        //Get UC Profile
        [Route("GetUCStaffBYStaffID")]
        [HttpGet]
        public IHttpActionResult GetUCStaffBYStaffID(string UserID,int UC_Concil_StaffId)
        {
            try
            {
                List<UCStaffModel> Result = new List<UCStaffModel>();
                Result = Lib.DAL.UCMethods.Get_UCStaffByStaffID(UserID,UC_Concil_StaffId);
                string jsonesult = JsonConvert.SerializeObject(Result);
                return Ok(Result);
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }
        #endregion

    }
}
