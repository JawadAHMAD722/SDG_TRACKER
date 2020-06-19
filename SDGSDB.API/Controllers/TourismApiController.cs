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
    public class TourismApiController : ApiController
    {
        #region Post Methods

        //UC TourismSpot Insertion
        [Route("AddUCTourismSpot")]
        [HttpPost]
        public IHttpActionResult UC_TourismSpot_Insertion(UCTourismSpotModel UCT, string UserID)
        {
            try
            {
                bool status = false;
                status = Lib.DAL.TourismMethods.UCTourismSpot_Insertion(UCT, UserID);
                string JSONStatus = JsonConvert.SerializeObject(status);
                return Ok(JSONStatus);
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }

        //UC TourismSpot Insertion
        [Route("UpdateUCTourismSpot")]
        [HttpPost]
        public IHttpActionResult UC_TourismSpot_Updation(UCTourismSpotModel UCT, string UserID, int TouristSpotId)
        {
            try
            {
                bool status = false;
                status = Lib.DAL.TourismMethods.UCTourismSpot_Updation(UCT, UserID, TouristSpotId);
                string JSONStatus = JsonConvert.SerializeObject(status);
                return Ok(JSONStatus);
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }
        //UC TourismSpot Deletion
        [Route("DeleteUCTourismSpot")]
        [HttpPost]
        public IHttpActionResult UC_TourismSpot_Deletion(string UserID, int TouristSpotId)
        {
            try
            {
                bool status = false;
                status = Lib.DAL.TourismMethods.UCTourismSpot_Deletion(UserID, TouristSpotId);
                string JSONStatus = JsonConvert.SerializeObject(status);
                return Ok(JSONStatus);
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }

        //UC TourismSpot Gallary Insertion
        [Route("AddUCTourismSpotGallary")]
        [HttpPost]
        public IHttpActionResult UC_TourismSpotGallary_Insertion(UCTourismSpotGallaryModel UCTSG, string UserID)
        {
            try
            {
                bool status = false;
                status = Lib.DAL.TourismMethods.UCTourismSpotGallary_Insertion(UCTSG, UserID);
                string JSONStatus = JsonConvert.SerializeObject(status);
                return Ok(JSONStatus);
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }
        #region API Image Save to Folder
        [Route("TourismSpotImageSave")]
        [HttpPost]
        public IHttpActionResult ImageSave()
        {
            try
            {
                string CreateFolder = HttpContext.Current.Server.MapPath("~/TourismSpot/");
                var Image = HttpContext.Current;
                var fileName = HttpContext.Current.Request.Files["Imgpathsave"].FileName;
                var i = Image.Request.Files.Count;
                if (!Directory.Exists(CreateFolder))
                {
                    Directory.CreateDirectory(CreateFolder);
                }
                if (HttpContext.Current.Request.Files.AllKeys.Any())
                {
                    var FileUpload = HttpContext.Current.Request.Files["Imgpathsave"];
                    if (FileUpload != null)
                    {
                        var SaveImgeges = Path.Combine(HttpContext.Current.Server.MapPath("~/TourismSpot/"), FileUpload.FileName);
                        FileUpload.SaveAs(SaveImgeges);
                    }
                }
                return Json(fileName);
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                throw;
            }
        }
        #endregion
        //Delete UCOrg
        [Route("DeleteUCOr")]
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
        #endregion
        #region Get Methods
        //Get All All UCTourism Spots By UC
        [Route("GetAllUCTourismSpotsByUC")]
        [HttpGet]
        public IHttpActionResult GetAllUCTourismSpotsByUC(string UserID)
        {
            try
            {
                List<UCTourismSpotModel> Result = new List<UCTourismSpotModel>();
                Result = Lib.DAL.TourismMethods.Get_AllTourismSpotByUC(UserID);
                string jsonesult = JsonConvert.SerializeObject(Result);
                return Ok(Result);
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }
        //Get All All UCTourism Spots By TourismSpot
        [Route("GetUCTourismSpotsByID")]
        [HttpGet]
        public IHttpActionResult GetUCTourismSpotsByTourismSpot(string UserID, int TouristSpotId)
        {
            try
            {
                List<UCTourismSpotModel> Result = new List<UCTourismSpotModel>();
                Result = Lib.DAL.TourismMethods.Get_TourismSpotByTourismSpot(UserID, TouristSpotId);
                string jsonesult = JsonConvert.SerializeObject(Result);
                return Ok(Result);
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }
        //Get All All UCTourism Spots Gallery By UC
        [Route("GetAllUCTourismSpotsGalleryByUC")]
        [HttpGet]
        public IHttpActionResult GetAllUCTourismSpotsGalleryByUC(string UserID)
        {
            try
            {
                List<UCTourismSpotGallaryModel> Result = new List<UCTourismSpotGallaryModel>();
                Result = Lib.DAL.TourismMethods.Get_AllTourismSpotGalleryByUC(UserID);
                string jsonesult = JsonConvert.SerializeObject(Result);
                return Ok(Result);
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }
        //Get UCOrganizatio by UC OrgID
        //[Route("U")]
        //[HttpGet]
        //public HttpResponseMessage Get_UCORGByID(int UC_OrganizationId)
        //{
        //    try
        //    {
        //        List<UCOrgInstitutionsModel> status = new List<UCOrgInstitutionsModel>();
        //        status = Lib.DAL.UCMethods.Get_UCOrgByID(UC_OrganizationId);
        //        string json = JsonConvert.SerializeObject(status);
        //        return Request.CreateResponse(HttpStatusCode.OK, json);
        //    }
        //    catch (Exception ex)
        //    {
        //        var message = ex.Message;

        //        throw ex;
        //    }

        //}
        #endregion

    }
}
