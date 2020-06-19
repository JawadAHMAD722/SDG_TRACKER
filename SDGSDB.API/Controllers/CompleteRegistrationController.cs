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
    public class CompleteRegistrationController : ApiController
    {
        #region Get Methods
        //Get Register NGO's Detail
        
        [Route("GetRegistrNGO")]
        [HttpGet]
        public HttpResponseMessage GetRegistrNGO(string UserID)
        {
            try
            {
                List<GetRegistrationModel> Result = new List<GetRegistrationModel>();
                Result = Lib.DAL.CompleteRegistration.Get_Registration(UserID);
                string jsonesult = JsonConvert.SerializeObject(Result);
                return Request.CreateResponse(HttpStatusCode.OK, jsonesult);
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }
        //Get Register NGO's Contact Detail
        [Route("GetRegistrNGOContacts")]
        [HttpGet]
        public HttpResponseMessage GetRegistrNGOContacts(string UserID)
        {
            try
            {
                List<GetRegisteredNGOContact> Result = new List<GetRegisteredNGOContact>();
                Result = Lib.DAL.CompleteRegistration.Get_RegisterNGOContacts(UserID);
                string jsonesult = JsonConvert.SerializeObject(Result);
                return Request.CreateResponse(HttpStatusCode.OK, jsonesult);
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }

        //Get Organizatio Head Office Email by ID
        [Route("ORGHeadOfficeEmailByID")]
        [HttpGet]
        public HttpResponseMessage Get_ORGHeadOfficeEmailByID(int Email_Address_Id)
        {
            try
            {
                List<GetRegisteredNGOEmailsModel> status = new List<GetRegisteredNGOEmailsModel>();
                status = Lib.DAL.CompleteRegistration.Get_OrgEmailBYID(Email_Address_Id);
                string json = JsonConvert.SerializeObject(status);
                return Request.CreateResponse(HttpStatusCode.OK, json);
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }
        //Get Register NGO's Email Detail
        [Route("GetRegistrNGOEmails")]
        [HttpGet]
        public HttpResponseMessage GetRegistrNGOEmails(string UserID)
        {
            try
            {
                List<GetRegisteredNGOEmailsModel> Result = new List<GetRegisteredNGOEmailsModel>();
                Result = Lib.DAL.CompleteRegistration.Get_RegisterNGOEmails(UserID);
                string jsonesult = JsonConvert.SerializeObject(Result);
                return Request.CreateResponse(HttpStatusCode.OK, jsonesult);
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }
        //Get Organizatio Head Office Contacts by ID
        [Route("ORGHeadOfficeContactByID")]
        [HttpGet]
        public HttpResponseMessage Get_ORGOrgContactByID(int Contact_Id)
        {
            try
            {
                List<RegesterNGOContactInsertionModel> status = new List<RegesterNGOContactInsertionModel>();
                status = Lib.DAL.CompleteRegistration.Get_OrgContact(Contact_Id);
                string json = JsonConvert.SerializeObject(status);
                return Request.CreateResponse(HttpStatusCode.OK, json);
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }
        #endregion

        #region Post Methods
        //Add CompleteRegestration
        [Route("UpdateCompleteRegestration")]
        [HttpPost]
        public IHttpActionResult ADD_OrgRegistration(CompleteRegistrationModel org,string UserID)
        {
            try
            {
                bool status = false;
                status = Lib.DAL.CompleteRegistration.OrganizationRegistration_Insertion(org,UserID);
                string JSONStatus = JsonConvert.SerializeObject(status);
                return Ok(JSONStatus);
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }
        //Add OfficeRegestration
        [Route("AddOfficeRegestration")]
        [HttpPost]
        public IHttpActionResult ADD_OrgOfficeRegistration(OrgOfficeRegistrationModel Office,string UserID)
        {
            try
            {
                int[] result;
                result = Lib.DAL.CompleteRegistration.OfficeRegistration_Insertion(Office, UserID);
                //string Json = JsonConvert.ToString(result);
                return Json(result);
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }
        //Add Register NGO Email
        [Route("ADDORegisterNGOEmail")]
        [HttpPost]
        public bool ADD_ORegisterNGOEmail(RegesterNGOEmailModel Email,string UserID)
        {
            try
            {
                bool status = false;
                status = Lib.DAL.CompleteRegistration.RegisterNGOEmails_Insertion(Email,UserID);
                return status;
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }

        //Add Register NGO Contacts
        [Route("ADDORegisterNGOContact")]
        [HttpPost]
        public bool ADD_ORegisterNGOContact(RegesterNGOContactInsertionModel Cont,string UserID)
        {
            try
            {
                bool status = false;
                status = Lib.DAL.CompleteRegistration.RegisterNGOContact_Insertion(Cont,UserID);
                return status;
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }
        //Update Register NGO Email
        [Route("UpdateRegisterOrgEmail")]
        [HttpPost]
        public bool Update_ORegisterNGOEmail(RegesterNGOEmailInsertionModel Email,int EmailAddressId,string UserID)
        {
            try
            {
                bool status = false;
                status = Lib.DAL.CompleteRegistration.RegisterOrgEmails_Update(Email,EmailAddressId,UserID);
                return status;
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }

        //Update Register NGO Contacts
        [Route("UpdateRegisterOrgContact")]
        [HttpPost]
        public bool Update_ORegisterNGOContact(RegesterNGOContactInsertionModel Cont, int Contact_Id,string UserID)
        {
            try
            {
                bool status = false;
                status = Lib.DAL.CompleteRegistration.RegisterOrgContact_Update(Cont, Contact_Id,UserID);
                return status;
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }

        //Delete Register NGO Email
        [Route("DeleteRegisterOrgEmail")]
        [HttpPost]
        public bool Delete_ORegisterNGOEmail(int Email_Address_Id,string UserID)
        {
            try
            {
                bool status = false;
                status = Lib.DAL.CompleteRegistration.RegisterOrgEmails_Delete(Email_Address_Id,UserID);
                return status;
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }

        //Delete Register NGO Contacts
        [Route("DeleteRegisterOrgContact")]
        [HttpPost]
        public bool Delete_ORegisterNGOContact(int Contact_Id, string UserID)
        {
            try
            {
                bool status = false;
                status = Lib.DAL.CompleteRegistration.RegisterOrgContact_Delete(Contact_Id,UserID);
                return status;
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }
        #endregion
        #region Office Contact Get Method
        //Get Register Office Contact Detail
        [Route("GetRegistrOfficeContacts")]
        [HttpGet]
        public HttpResponseMessage GetRegistrOfficeContacts(string UserID)
        {
            try
            {
                List<GetRegisteredOfficeContact> Result = new List<GetRegisteredOfficeContact>();
                Result = Lib.DAL.CompleteRegistration.Get_RegisterOfficeContacts(UserID);
                string jsonesult = JsonConvert.SerializeObject(Result);
                return Request.CreateResponse(HttpStatusCode.OK, jsonesult);
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }
        //Get Register Office Contact By ID
        [Route("ORGOfficeContact")]
        [HttpGet]
        public HttpResponseMessage Get_ORGOfficeContactByID(int Contact_Id)
        {
            try
            {
                List<CompoundModelOfficeContactEmail.RegesterOfficeContactModel> status = new List<CompoundModelOfficeContactEmail.RegesterOfficeContactModel>();
                status = Lib.DAL.CompleteRegistration.Get_OfficeContactByID(Contact_Id);
                string json = JsonConvert.SerializeObject(status);
                return Request.CreateResponse(HttpStatusCode.OK, json);
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }
        #endregion
        #region Office Contact Add Method
        //Add Register Office Contacts
        [Route("ADDRegisterOfficeContact")]
        [HttpPost]
        public bool ADD_RegisterOfficeContact(RegesterOfficeContactModel Cont,string UserID)
        {
            try
            {
                bool status = false;
                status = Lib.DAL.CompleteRegistration.RegisterOfficeContact_Insertion(Cont,UserID);
                return status;
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }

        //Update Register Office Contacts
        [Route("UpdateRegisterOfficeContact")]
        [HttpPost]
        public bool Update_RegisterOfficeContact(RegesterOfficeContactModel Cont, int Contact_Id,string UserID)
        {
            try
            {
                bool status = false;
                status = Lib.DAL.CompleteRegistration.RegisterOfficeContact_Update(Cont, Contact_Id,UserID);
                return status;
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }
        //Delete Register Office Contacts
        [Route("DeleteRegisterOfficeContact")]
        [HttpPost]
        public bool Delete_RegisterOfficeContact(int Contact_Id,string UserID)
        {
            try
            {
                bool status = false;
                status = Lib.DAL.CompleteRegistration.RegisterOfficeContact_Delete(Contact_Id,UserID);
                return status;
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }
        #endregion

        #region Office Email
        #region Get Method
        //Get Office All Email Detail
        [Route("GetOfficeAllEmails")]
        [HttpGet]
        public HttpResponseMessage GetOfficeAllEmails(string UserID)
        {
            try
            {
                List<CompoundModelOfficeContactEmail.RegesterOfficeEmailModel> Result =
                    new List<CompoundModelOfficeContactEmail.RegesterOfficeEmailModel>();
                Result = Lib.DAL.CompleteRegistration.Get_OfficeAllEmails(UserID);
                string jsonesult = JsonConvert.SerializeObject(Result);
                return Request.CreateResponse(HttpStatusCode.OK, jsonesult);
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }
        //Get Office Email by ID
        [Route("OfficeEmailByID")]
        [HttpGet]
        public HttpResponseMessage Get_OfficeEmailByID(int EmailAddressId)
        {
            try
            {
                List<CompoundModelOfficeContactEmail.RegesterOfficeEmailModel> status = 
                    new List<CompoundModelOfficeContactEmail.RegesterOfficeEmailModel>();
                status = Lib.DAL.CompleteRegistration.Get_OfficeEmailBYID(EmailAddressId);
                string json = JsonConvert.SerializeObject(status);
                return Request.CreateResponse(HttpStatusCode.OK, json);
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }
        #endregion

        #region Post Method
        //Add Office Email
        [Route("ADDOfficeEmail")]
        [HttpPost]
        public bool ADD_Officemail(CompoundModelOfficeContactEmail.RegesterOfficeEmailModel Email, string UserID)
        {
            try
            {
                bool status = false;
                status = Lib.DAL.CompleteRegistration.OfficeEmails_Insertion(Email, UserID);
                return status;
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }

        //Update Office Email
        [Route("UpdateOfficeEmail")]
        [HttpPost]
        public bool Update_OfficeEmail(CompoundModelOfficeContactEmail.RegesterOfficeEmailModel Email, int EmailAddressId, string UserID)
        {
            try
            {
                bool status = false;
                status = Lib.DAL.CompleteRegistration.OfficeEmails_Update(Email, EmailAddressId,UserID);
                return status;
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }

        //Delete Office Email
        [Route("DeleteOfficeEmail")]
        [HttpPost]
        public bool Delete_OOfficeEmail(int Email_Address_Id,string UserID)
        {
            try
            {
                bool status = false;
                status = Lib.DAL.CompleteRegistration.OfficeEmails_Delete(Email_Address_Id,UserID);
                return status;
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;
            }

        }
        #endregion

        #endregion

        #region API Image Save to Folder
        [Route("ImageSave")]
        [HttpPost]
        public IHttpActionResult ImageSave()
        {
            try
            {
                string CreateFolder = HttpContext.Current.Server.MapPath("~/NGOLogos/");
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
                        var SaveImgeges = Path.Combine(HttpContext.Current.Server.MapPath("~/NGOLogos/"), FileUpload.FileName);
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
    }
}
