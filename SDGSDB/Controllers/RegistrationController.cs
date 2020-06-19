using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using SDGSDB.Models;

namespace SDGSDB.Controllers
{
   
    public class RegistrationController : Controller
    {
        // GET: Registration
        [Authorize(Roles = "ORGANIZATION_ADMIN,APP_USER")]
        public ActionResult CreateRegistration(CompleteRegistrationModel Model)
        {
            var GUID = HttpContext.User.Identity.GetUserId();
            ViewBag.CurrentUserID = GUID;
            //DropDown Bind RegisterationAuthority
            var RegisterationAuthority = new List<drpRegisterationAuthority>();
            RegisterationAuthority.Add(new drpRegisterationAuthority() { Value = "Null", Text = "Select Registeration Authority" });
            RegisterationAuthority.Add(new drpRegisterationAuthority() { Value = "SECP", Text = "SECP" });
            RegisterationAuthority.Add(new drpRegisterationAuthority() { Value = "Voluntary Social Welfare Agencies Registration and Control Ordinance 1961", Text = "Voluntary Social Welfare Agencies Registration and Control Ordinance 1961" });
            RegisterationAuthority.Add(new drpRegisterationAuthority() { Value = "Baitul Maal", Text = "Baitul Maal" });

            RegisterationAuthority.Add(new drpRegisterationAuthority() { Value = "Income Tax Ordinance, 2001", Text = "Income Tax Ordinance, 2001" });
            RegisterationAuthority.Add(new drpRegisterationAuthority() { Value = "The Societies Registration Act, 1860", Text = "The Societies Registration Act, 1860" });
            RegisterationAuthority.Add(new drpRegisterationAuthority() { Value = "The Cooperative Society Act, 1925", Text = "The Cooperative Society Act, 1925" });
            RegisterationAuthority.Add(new drpRegisterationAuthority() { Value = "The Companies Ordinance, 1984(section 42)", Text = "The Companies Ordinance, 1984(section 42)" });
            RegisterationAuthority.Add(new drpRegisterationAuthority() { Value = "The Trust Act, 1882", Text = "The Trust Act, 1882" });
               ViewBag.drpRegisterationAuthority = RegisterationAuthority;

            //DropDown Bind RegisterationAuthority
            var CompanyCategory = new List<drpCompanyCategory>();
            CompanyCategory.Add(new drpCompanyCategory() { Value = "Null", Text = "Select Company Category" });
            CompanyCategory.Add(new drpCompanyCategory() { Value = "Single", Text = "Single" });
            CompanyCategory.Add(new drpCompanyCategory() { Value = "Partnership", Text = "Partnership" });
            ViewBag.drpCompanyCategory = CompanyCategory;
            try
            {
                if (ModelState.IsValid)
                {
                    if (Model.Logo_Image != null)
                    {
                        //string Image = Model.Logo_Image == null ? PModel.P_Image2 : PModel.P_Image;
                        HttpPostedFileBase LogoImage = Request.Files[0];
                        if (LogoImage.ContentLength > 0)
                        {
                            var fileName = Path.GetFileName(LogoImage.FileName);
                            string path = Server.MapPath("~/Images/NGOLogos/");
                            if (!Directory.Exists(path))
                            {
                                Directory.CreateDirectory(path);
                            }
                            var SavePath = Path.Combine(Server.MapPath("~/Images/NGOLogos/"), fileName);
                            LogoImage.SaveAs(SavePath);
                            //PModel.P_ImageUpload.SaveAs(path + fileName);

                        }
                    }
                    // ModelState.AddModelError("keyName", "Form is not valid");
                    return View();
                }
                //MembersManager.RegisterMember(Model);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("keyName", ex.Message);
                
            }
            return View();
        }
        //Office Registration
        [Authorize(Roles = "ORGANIZATION_ADMIN,APP_USER")]
        public ActionResult OfficeRegistration(CompleteRegistrationModel Model)
        {
            var GUID = HttpContext.User.Identity.GetUserId();
            ViewBag.CurrentUserID = GUID;
            try
            {
                if (ModelState.IsValid)
                {
                    // ModelState.AddModelError("keyName", "Form is not valid");
                    return View();
                }
                //MembersManager.RegisterMember(Model);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("keyName", ex.Message);

            }
            return View();
        }


        // Org ContactEmail
        [Authorize(Roles = "ORGANIZATION_ADMIN,APP_USER")]
        public ActionResult OrgContactEmail(NGOCompoundModel Model)
        {
            var GUID = HttpContext.User.Identity.GetUserId();
            ViewBag.CurrentUserID = GUID;
            //DropDown Bind Email Type
            var DrpEmailType = new List<Cmb_Types>();
            DrpEmailType.Add(new Cmb_Types() { Value = "Null", Text = "Select Email Type" });
            DrpEmailType.Add(new Cmb_Types() { Value = "Official", Text = "Official" });
            DrpEmailType.Add(new Cmb_Types() { Value = "Private", Text = "Private" });
            ViewBag.Cmb_Types = DrpEmailType;
            try
            {
                if (ModelState.IsValid)
                {
                    // ModelState.AddModelError("keyName", "Form is not valid");
                    return View();
                }
                //MembersManager.RegisterMember(Model);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("keyName", ex.Message);

            }
            return View();
        }


        //Office contact email
        [Authorize(Roles = "ORGANIZATION_ADMIN,APP_USER,OFFICE_ADMIN")]
        public ActionResult OfficeContactEmail()
        {
            var GUID = HttpContext.User.Identity.GetUserId();
            ViewBag.CurrentUserID = GUID;
            //DropDown Bind Email Type
            var DrpEmailType = new List<Cmb_Types>();
            DrpEmailType.Add(new Cmb_Types() { Value = "Null", Text = "Select Email Type" });
            DrpEmailType.Add(new Cmb_Types() { Value = "Official", Text = "Official" });
            DrpEmailType.Add(new Cmb_Types() { Value = "Private", Text = "Private" });
            ViewBag.Cmb_Types = DrpEmailType;
            try
            {
                    return View();
            }
            catch (Exception ex)
            {
                var message = ex.Message;

                throw ex;

            }
        }
    }
}