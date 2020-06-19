using System;
using System.Collections.Generic;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SDGSDB.Models;

namespace SDGSDB.Lib.DAL
{
    public class OrganizationRegistrationController:Controller
    {
        public ActionResult OrganizationRegistration_Insertion(CompleteRegistrationModel org)
        {
            string status = "";
            string HeadOffice_Name = org.HeadOffice_Name;
            string Registeration_Authority = org.Registeration_Authority;
            string Registeration_Date = org.Registeration_Date;
            string LicenseNo = org.LicenseNo;
            string CompanyCategory = org.CompanyCategory;
            string Person_Contact_Name = org.Person_Contact_Name;
            string Person_Contact_Title = org.Person_Contact_Title;
            string Person_Contat_Number = org.Person_Contat_Number;
            string Person_Contat_Email = org.Person_Contat_Email;
            string BusinessType = org.BusinessType;
            string Planned_Activities = org.Planned_Activities;
            string Additional_Comments = org.Additional_Comments;
            string Logo_Image = org.Logo_Image;
            string Country = "Pakistan";
            int Province_Id = org.Province_Id;
            int Division_Id = org.Division_Id;
            int District_Id = org.District_Id;
            string Street = org.Street;
            string House = org.House;
            int PostalCode = org.PostalCode;
            DateTime CreaetdOn = DateTime.Now;
            string CreatedBy = "User";

            DateTime dtydt5 = new DateTime();
            DateTime.TryParse(Registeration_Date, new CultureInfo("en-GB", true), DateTimeStyles.None, out dtydt5);
            var st1 = dtydt5.ToString("dd/MM/yyyy hh:mm:ss tt");


            using (SqlCommand cmd_insertion = new SqlCommand())
            {
                if (org.Logo_Image != null)
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
                conn c = new conn();
                SqlConnection _Con = c.conect();
                SqlParameter SQP = new SqlParameter("@returnVal", SqlDbType.Int);
                cmd_insertion.Connection = _Con;
                _Con.Open();
                cmd_insertion.CommandType = CommandType.StoredProcedure;
                cmd_insertion.CommandText = "UpdateOrganizationRegistration";//Stored procedure name
                cmd_insertion.Parameters.AddWithValue("@HeadOffice_Name", HeadOffice_Name);//(name in sp,modal attribute)
                cmd_insertion.Parameters.AddWithValue("@Registeration_Authority", Registeration_Authority);
                cmd_insertion.Parameters.AddWithValue("@Registeration_Date", dtydt5);
                cmd_insertion.Parameters.AddWithValue("@LicenseNo", LicenseNo);
                cmd_insertion.Parameters.AddWithValue("@CompanyCategory", CompanyCategory);
                cmd_insertion.Parameters.AddWithValue("@Person_Contact_Name", Person_Contact_Name);
                cmd_insertion.Parameters.AddWithValue("@Person_Contact_Title", Person_Contact_Title);
                cmd_insertion.Parameters.AddWithValue("@Person_Contat_Number", Person_Contat_Number);
                cmd_insertion.Parameters.AddWithValue("@Person_Contat_Email", Person_Contat_Email);
                cmd_insertion.Parameters.AddWithValue("@BusinessType", BusinessType);
                cmd_insertion.Parameters.AddWithValue("@Planned_Activities", Planned_Activities);
                cmd_insertion.Parameters.AddWithValue("@Additional_Comments", Additional_Comments);
                cmd_insertion.Parameters.AddWithValue("@Logo_Image", Logo_Image);

                cmd_insertion.Parameters.AddWithValue("@Country", Country);
                cmd_insertion.Parameters.AddWithValue("@Province_Id", Province_Id);
                cmd_insertion.Parameters.AddWithValue("@Division_Id", Division_Id);
                cmd_insertion.Parameters.AddWithValue("@District_Id", District_Id);
                cmd_insertion.Parameters.AddWithValue("@Street", Street);
                cmd_insertion.Parameters.AddWithValue("@House", House);
                cmd_insertion.Parameters.AddWithValue("@PostalCode", PostalCode);
                cmd_insertion.Parameters.AddWithValue("@CreaetdOn", CreaetdOn);
                cmd_insertion.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                cmd_insertion.Parameters.AddWithValue("@Is_active", true);
                cmd_insertion.Parameters.AddWithValue("@Organization_Id", 1010);
                SQP.Direction = ParameterDirection.ReturnValue;
                cmd_insertion.Parameters.Add(SQP);
                cmd_insertion.ExecuteNonQuery();
                status = "OK";
                _Con.Close();
                cmd_insertion.Parameters.Clear();
                int OfficeId = Convert.ToInt32(SQP.Value);

                foreach (var item in org.SDGSLIST)
                {
                    var SDGSID = item == "" ? "0" : item;
                    if (Convert.ToInt32(SDGSID) > 0)
                    {
                        _Con.Open();
                        cmd_insertion.CommandType = CommandType.StoredProcedure;
                        cmd_insertion.CommandText = "Sp_Add_ORG_SDGS";//Stored procedure name
                        cmd_insertion.Parameters.AddWithValue("@Organization_Id", 1010);
                        cmd_insertion.Parameters.AddWithValue("@SDG_Id", Convert.ToInt32(SDGSID));//(name in sp,modal attribute)

                        cmd_insertion.Parameters.AddWithValue("@CreaetdOn", CreaetdOn);
                        cmd_insertion.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                        cmd_insertion.Parameters.AddWithValue("@Is_active", true);
                        cmd_insertion.Parameters.AddWithValue("@Office_Id", OfficeId);

                        cmd_insertion.ExecuteNonQuery();
                        status = "OK";
                        _Con.Close();
                        cmd_insertion.Parameters.Clear();
                    }
                }
                status = "OK";
            }
            return Json("true") ;
        }
    }
}
