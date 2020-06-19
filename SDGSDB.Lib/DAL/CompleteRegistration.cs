using System;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Web;
using System.Web.Mvc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDGSDB.Models;
using SDGSDB.Controllers;

namespace SDGSDB.Lib.DAL
{
    public class CompleteRegistration
    {
   #region Get Methods
        //Get Organization_Name,Type,Email,Contact
        public static List<GetRegistrationModel> Get_Registration(string UserID)
        {
            using (SqlCommand cmd_Get = new SqlCommand())
            {
                List<GetRegistrationModel> ORG = new List<GetRegistrationModel>();
                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_Get.Connection = _Con;
                _Con.Open();
                cmd_Get.CommandType = System.Data.CommandType.StoredProcedure;
                cmd_Get.CommandText = "SP_GetRegisteredOrg";//Stored procedure name
                cmd_Get.Parameters.AddWithValue("@UserID", UserID);
                SqlDataAdapter da = new SqlDataAdapter(cmd_Get);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);
                dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    ORG.Add(new GetRegistrationModel
                    {
                        Organization_Name = Convert.ToString(row["Organization_Name"]),
                        Organization_Type_Id = Convert.ToString(row["Organization_Type_Id"]),
                        Email_Id = Convert.ToString(row["Email_Id"]),
                        Contact_Number = Convert.ToString(row["Contact_Number"]),
                        BusinessType = Convert.ToString(row["Type_of_business"]),
                        Planned_Activities = Convert.ToString(row["Planed_Activity"]),
                        Additional_Comments = Convert.ToString(row["Additional_Comments"])
                    });
                }
                _Con.Close();
                _Con.Dispose();
                da.Dispose();
                return ORG;
            }
        }

        //Get Registered NGO's Contacts
        public static List<GetRegisteredNGOContact> Get_RegisterNGOContacts(string UserID)
        {
            
            using (SqlCommand cmd_Get = new SqlCommand())
            {
                List<GetRegisteredNGOContact> Contact = new List<GetRegisteredNGOContact>();
                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_Get.Connection = _Con;
                _Con.Open();
                cmd_Get.CommandType = System.Data.CommandType.StoredProcedure;
                cmd_Get.CommandText = "SP_GetRegisteredOrgContact";//Stored procedure name
                cmd_Get.Parameters.AddWithValue("@UserID", UserID);
                SqlDataAdapter da = new SqlDataAdapter(cmd_Get);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);
                dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    Contact.Add(new GetRegisteredNGOContact
                    {
                        Contact_Id = Convert.ToInt32(row["Contact_Id"]),
                        Contact_Number = Convert.ToString(row["Contact_Number"]),
                        Fax = Convert.ToString(row["Fax"]),
                        Website_URL = Convert.ToString(row["Website_URL"])
                    });
                }
                _Con.Close();
                _Con.Dispose();
                da.Dispose();
                return Contact;
            }
        }

        //Get Organizatio Head Office Contacts by ID
        public static List<RegesterNGOContactInsertionModel> Get_OrgContact(int Contact_Id)
        {

            using (SqlCommand cmd_Get = new SqlCommand())
            {
                List<RegesterNGOContactInsertionModel> OrgContact = new List<RegesterNGOContactInsertionModel>();
                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_Get.Connection = _Con;
                _Con.Open();
                cmd_Get.CommandType = System.Data.CommandType.StoredProcedure;
                cmd_Get.CommandText = "SP_GetOrgContactByID";//Stored procedure name
                cmd_Get.Parameters.AddWithValue("@Contact_Id", Contact_Id);
                SqlDataAdapter da = new SqlDataAdapter(cmd_Get);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);
                dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    OrgContact.Add(new RegesterNGOContactInsertionModel
                    {
                        Contact_Number = Convert.ToString(row["Contact_Number"]),
                        Fax = Convert.ToString(row["Fax"]),
                        Website_URL = Convert.ToString(row["Website_URL"])
                    });
                }
                _Con.Close();
                _Con.Dispose();
                da.Dispose();
                return OrgContact;
            }
        }
        //Get Registered NGO's Emails
        public static List<GetRegisteredNGOEmailsModel> Get_RegisterNGOEmails(string UserID)
        {
            
            using (SqlCommand cmd_Get = new SqlCommand())
            {
                List<GetRegisteredNGOEmailsModel> Emails = new List<GetRegisteredNGOEmailsModel>();
                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_Get.Connection = _Con;
                _Con.Open();
                cmd_Get.CommandType = System.Data.CommandType.StoredProcedure;
                cmd_Get.CommandText = "SP_GetOrgEmails";//Stored procedure name
                cmd_Get.Parameters.AddWithValue("@UserID", UserID);
                SqlDataAdapter da = new SqlDataAdapter(cmd_Get);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);
                dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    Emails.Add(new GetRegisteredNGOEmailsModel
                    {
                        Email_Address_Id = Convert.ToString(row["Email_Address_Id"]),
                        Email_Id = Convert.ToString(row["Email_Id"]),
                        Email_Type = Convert.ToString(row["Email_Type"])
                    });
                }
                _Con.Close();
                _Con.Dispose();
                da.Dispose();
                return Emails;
            }
        }
        //Get Organizatio Head Office Email by ID
        public static List<GetRegisteredNGOEmailsModel> Get_OrgEmailBYID(int Email_Address_Id)
        {

            using (SqlCommand cmd_Get = new SqlCommand())
            {
                List<GetRegisteredNGOEmailsModel> OrgEmail = new List<GetRegisteredNGOEmailsModel>();
                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_Get.Connection = _Con;
                _Con.Open();
                cmd_Get.CommandType = System.Data.CommandType.StoredProcedure;
                cmd_Get.CommandText = "SP_GetOrgEmailByID";//Stored procedure name
                cmd_Get.Parameters.AddWithValue("@Email_Address_Id", Email_Address_Id);
                SqlDataAdapter da = new SqlDataAdapter(cmd_Get);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);
                dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    OrgEmail.Add(new GetRegisteredNGOEmailsModel
                    {
                        Email_Id = Convert.ToString(row["Email_Id"]),
                        Email_Type = Convert.ToString(row["Email_Type"])
                    });
                }
                _Con.Close();
                _Con.Dispose();
                da.Dispose();
                return OrgEmail;
            }
        }
        #endregion

        #region Post Methods

        //Post Organization Complete Registration
        public static bool OrganizationRegistration_Insertion(CompleteRegistrationModel org,string UserID)
        {
            bool status;
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
            string Logo_Image = (org.Logo_Image).Remove(0,12);
            string Country = "Pakistan";
            string Logo_Image2 = (org.Logo_Image).Remove(0, 12);
            int Province_Id = org.Province_Id;
            int Division_Id = org.Division_Id;
            int District_Id = org.District_Id;
            int Tehsil_Id = org.Tehsil_Id;
            int UC_Id = org.UC_Id;
            string Street = org.Street;
            string House = org.House;
            int PostalCode = org.PostalCode;
            DateTime CreaetdOn = DateTime.Now;
            string CreatedBy = UserID;

            DateTime dtydt5 = new DateTime();
            DateTime.TryParse(Registeration_Date, new CultureInfo("en-GB", true), DateTimeStyles.None, out dtydt5);
            var st1 = dtydt5.ToString("dd/MM/yyyy hh:mm:ss tt");
           
            
            using (SqlCommand cmd_insertion = new SqlCommand())
            {
                conn c = new conn();
                SqlConnection _Con = c.conect();
                SqlParameter SQP = new SqlParameter("@returnVal", SqlDbType.Int);
                cmd_insertion.Connection = _Con;
                _Con.Open();
                cmd_insertion.CommandType = CommandType.StoredProcedure;
                cmd_insertion.CommandText = "AddOrganizationRegistration";//Stored procedure name
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
                cmd_insertion.Parameters.AddWithValue("@Tehsil_Id", Tehsil_Id);
                cmd_insertion.Parameters.AddWithValue("@UC_Id", UC_Id);
                cmd_insertion.Parameters.AddWithValue("@Street", Street);
                cmd_insertion.Parameters.AddWithValue("@House", House);
                cmd_insertion.Parameters.AddWithValue("@PostalCode", PostalCode);
                cmd_insertion.Parameters.AddWithValue("@CreaetdOn", CreaetdOn);
                cmd_insertion.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                cmd_insertion.Parameters.AddWithValue("@Is_active", true);
                cmd_insertion.Parameters.AddWithValue("@UserID", UserID);
                SQP.Direction = ParameterDirection.ReturnValue;
                cmd_insertion.Parameters.Add(SQP);
                cmd_insertion.ExecuteNonQuery();
                status = true;
                _Con.Close();
                cmd_insertion.Parameters.Clear();
                int OfficeId =  Convert.ToInt32(SQP.Value);

                foreach (var item in org.SDGSLIST)
                {
                    var SDGSID = item == "" ? "0" : item;
                    if (Convert.ToInt32(SDGSID) > 0)
                    {
                        _Con.Open();
                        cmd_insertion.CommandType = CommandType.StoredProcedure;
                        cmd_insertion.CommandText = "Sp_Add_ORG_SDGS";//Stored procedure name
                        cmd_insertion.Parameters.AddWithValue("@SDG_Id", Convert.ToInt32(SDGSID));//(name in sp,modal attribute)
                        cmd_insertion.Parameters.AddWithValue("@CreaetdOn", CreaetdOn);
                        cmd_insertion.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                        cmd_insertion.Parameters.AddWithValue("@Is_active", true);
                        cmd_insertion.Parameters.AddWithValue("@UserID", UserID);

                        cmd_insertion.ExecuteNonQuery();
                        status = true;
                        _Con.Close();
                        cmd_insertion.Parameters.Clear();
                    }
                }
                //Org Indicators Insertion
                foreach (var item in org.SDGSINDLIST)
                {
                    var Indicator_Id = item == "" ? "0" : item;
                    if (Convert.ToInt32(Indicator_Id) > 0)
                    {
                        _Con.Open();
                        cmd_insertion.CommandType = CommandType.StoredProcedure;
                        cmd_insertion.CommandText = "Sp_Add_Office_SDGS_Indicators";//Stored procedure name
                        //cmd_insertion.Parameters.AddWithValue("@SDG_Id", Convert.ToInt32(SDGSID));//(name in sp,modal attribute)
                        cmd_insertion.Parameters.AddWithValue("@Indicator_Id", Convert.ToInt32(Indicator_Id));
                        cmd_insertion.Parameters.AddWithValue("@CreaetdOn", CreaetdOn);
                        cmd_insertion.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                        cmd_insertion.Parameters.AddWithValue("@Is_active", true);
                        cmd_insertion.Parameters.AddWithValue("@UserID", UserID);
                        cmd_insertion.Parameters.AddWithValue("@Office_Id", OfficeId);
                        cmd_insertion.ExecuteNonQuery();
                        status = true;
                        _Con.Close();
                        cmd_insertion.Parameters.Clear();
                    }
                }
                status = true;
            }
            return status;
        }

        //Post Office Registration
        public static int[] OfficeRegistration_Insertion(OrgOfficeRegistrationModel org,string UserID)
        {
            bool status;
            int[] Result = new int[2];
            string Office_Name = org.Office_Name;
            string Person_Contact_Name = org.Person_Contact_Name;
            string Person_Contact_Title = org.Person_Contact_Title;
            string Person_Contat_Number = org.Person_Contat_Number;
            string Person_Contat_Email = org.Person_Contat_Email;
            int Province_Id = org.Province_Id;
            int Division_Id = org.Division_Id;
            int District_Id = org.District_Id;
            int Tehsil_Id = org.Tehsil_Id;
            int UC_Id = org.UC_Id;
            string Street = org.Street;
            string House = org.House;
            int PostalCode = org.PostalCode;
            DateTime CreaetdOn = DateTime.Now;
            string CreatedBy = UserID;

            using (SqlCommand cmd_insertion = new SqlCommand())
            {

                conn c = new conn();
                SqlConnection _Con = c.conect();
                SqlParameter SQP = new SqlParameter("@returnVal", SqlDbType.Int);
                cmd_insertion.Connection = _Con;
                _Con.Open();
                cmd_insertion.CommandType = CommandType.StoredProcedure;
                cmd_insertion.CommandText = "Sp_AddOrgOfficeRegistration";//Stored procedure name
                cmd_insertion.Parameters.AddWithValue("@Office_Name", Office_Name);//(name in sp,modal attribute)
                cmd_insertion.Parameters.AddWithValue("@Person_Contact_Name", Person_Contact_Name);
                cmd_insertion.Parameters.AddWithValue("@Person_Contact_Title", Person_Contact_Title);
                cmd_insertion.Parameters.AddWithValue("@Person_Contat_Number", Person_Contat_Number);
                cmd_insertion.Parameters.AddWithValue("@Person_Contat_Email", Person_Contat_Email);
                cmd_insertion.Parameters.AddWithValue("@Province_Id", Province_Id);
                cmd_insertion.Parameters.AddWithValue("@Division_Id", Division_Id);
                cmd_insertion.Parameters.AddWithValue("@District_Id", District_Id);
                cmd_insertion.Parameters.AddWithValue("@Tehsil_Id", Tehsil_Id);
                cmd_insertion.Parameters.AddWithValue("@UC_Id", UC_Id);
                cmd_insertion.Parameters.AddWithValue("@Street", Street);
                cmd_insertion.Parameters.AddWithValue("@House", House);
                cmd_insertion.Parameters.AddWithValue("@PostalCode", PostalCode);
                cmd_insertion.Parameters.AddWithValue("@CreaetdOn", CreaetdOn);
                cmd_insertion.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                cmd_insertion.Parameters.AddWithValue("@Is_active", true);
                cmd_insertion.Parameters.AddWithValue("@UserID", UserID);
                cmd_insertion.Parameters.Add("@OfficeOrgID", SqlDbType.Int).Direction = ParameterDirection.Output;
                SQP.Direction = ParameterDirection.ReturnValue;
                cmd_insertion.Parameters.Add(SQP);
                cmd_insertion.ExecuteNonQuery();
                int OrgID = Convert.ToInt32(cmd_insertion.Parameters["@OfficeOrgID"].Value);
                _Con.Close();
                cmd_insertion.Parameters.Clear();
                int OfficeId = Convert.ToInt32(SQP.Value);
                //Org SDGS Insertion
                foreach (var item in org.SDGSLIST)
                {
                    var SDGSID = item == "" ? "0" : item;
                    if (Convert.ToInt32(SDGSID) > 0)
                    {
                        _Con.Open();
                        cmd_insertion.CommandType = CommandType.StoredProcedure;
                        cmd_insertion.CommandText = "Sp_Add_Office_SDGS";//Stored procedure name
                        cmd_insertion.Parameters.AddWithValue("@SDG_Id", Convert.ToInt32(SDGSID));//(name in sp,modal attribute)
                        cmd_insertion.Parameters.AddWithValue("@CreaetdOn", CreaetdOn);
                        cmd_insertion.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                        cmd_insertion.Parameters.AddWithValue("@Is_active", true);
                        cmd_insertion.Parameters.AddWithValue("@UserID", UserID);
                        cmd_insertion.Parameters.AddWithValue("@Office_Id", OfficeId);
                        cmd_insertion.ExecuteNonQuery();
                        status = true;
                        _Con.Close();
                        cmd_insertion.Parameters.Clear();
                    }
                }

                //Org Indicators Insertion
                foreach (var item in org.SDGSINDLIST)
                {
                    var Indicator_Id = item == "" ? "0" : item;
                    if (Convert.ToInt32(Indicator_Id) > 0)
                    {
                        _Con.Open();
                        cmd_insertion.CommandType = CommandType.StoredProcedure;
                        cmd_insertion.CommandText = "Sp_Add_Office_SDGS_Indicators";//Stored procedure name
                        //cmd_insertion.Parameters.AddWithValue("@SDG_Id", Convert.ToInt32(SDGSID));//(name in sp,modal attribute)
                        cmd_insertion.Parameters.AddWithValue("@Indicator_Id", Convert.ToInt32(Indicator_Id));
                        cmd_insertion.Parameters.AddWithValue("@CreaetdOn", CreaetdOn);
                        cmd_insertion.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                        cmd_insertion.Parameters.AddWithValue("@Is_active", true);
                        cmd_insertion.Parameters.AddWithValue("@UserID", UserID);
                        cmd_insertion.Parameters.AddWithValue("@Office_Id", OfficeId);
                        cmd_insertion.ExecuteNonQuery();
                        status = true;
                        _Con.Close();
                        cmd_insertion.Parameters.Clear();
                    }
                }
                status = true;
                 Result[0]=OrgID;
                Result[1] = OfficeId;
            }
            return Result;
        }

        //Post Registered NGO's Email
        public static bool RegisterNGOEmails_Insertion(RegesterNGOEmailModel Email, string UserID)
        {
            bool status;
            string Email_Id = Email.Email_Id;
            string Email_Type = Email.Email_Type;
            DateTime CreatedOn = DateTime.Now;
            string CreatedBy = UserID;

            using (SqlCommand cmd_insertion = new SqlCommand())
            {
             
                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_insertion.Connection = _Con;
                _Con.Open();
                cmd_insertion.CommandType = CommandType.StoredProcedure;
                cmd_insertion.CommandText = "Sp_AddRegisterOrgEmail";//Stored procedure name
                cmd_insertion.Parameters.AddWithValue("@Email_Id", Email_Id);//(name in sp,modal attribute)
                cmd_insertion.Parameters.AddWithValue("@Email_Type", Email_Type);
                cmd_insertion.Parameters.AddWithValue("@CreatedOn", CreatedOn);
                cmd_insertion.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                cmd_insertion.Parameters.AddWithValue("@Is_active", true);
                cmd_insertion.Parameters.AddWithValue("@Is_Deleted", false);
                cmd_insertion.Parameters.AddWithValue("@UserID", UserID);

                cmd_insertion.ExecuteNonQuery();
                status = true;
                _Con.Close();
            }
            return status;
        }
        //Post Registered NGO's Contact
        public static bool RegisterNGOContact_Insertion(RegesterNGOContactInsertionModel Cont,string UserID)
        {
            bool status;
            string Contact_Number = Cont.Contact_Number;
            string Fax = Cont.Fax;
            string Website_URL = Cont.Website_URL;
            DateTime CreatedOn = DateTime.Now;
            string CreatedBy = UserID;

            using (SqlCommand cmd_insertion = new SqlCommand())
            {
               
                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_insertion.Connection = _Con;
                _Con.Open();
                cmd_insertion.CommandType = CommandType.StoredProcedure;
                cmd_insertion.CommandText = "Sp_AddRegisterOrgContacts";//Stored procedure name
                cmd_insertion.Parameters.AddWithValue("@Contact_Number", Contact_Number);//(name in sp,modal attribute)
                cmd_insertion.Parameters.AddWithValue("@Fax", Fax);
                cmd_insertion.Parameters.AddWithValue("@Website_URL", Website_URL);
                cmd_insertion.Parameters.AddWithValue("@CreatedOn", CreatedOn);
                cmd_insertion.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                cmd_insertion.Parameters.AddWithValue("@Is_active", true);
                cmd_insertion.Parameters.AddWithValue("@Is_Deleted", false);
                cmd_insertion.Parameters.AddWithValue("@UserID", UserID);

                cmd_insertion.ExecuteNonQuery();
                status = true;
                _Con.Close();
            }
            return status;
        }


        //Post for Update Registered NGO's Head Office Emails
        public static bool RegisterOrgEmails_Update(RegesterNGOEmailInsertionModel Email,int Email_Address_Id,string UserID)
        {
            bool status;
            string Email_Id = Email.Email_Id;
            string Email_Type = Email.Email_Type;
            DateTime UpdatedOn = DateTime.Now;
            string UpdatedBy = UserID;
            int EmailAddressId = Email_Address_Id;

            using (SqlCommand cmd_insertion = new SqlCommand())
            {

                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_insertion.Connection = _Con;
                _Con.Open();
                cmd_insertion.CommandType = CommandType.StoredProcedure;
                cmd_insertion.CommandText = "SP_UpdateOrgEmail";//Stored procedure name
                cmd_insertion.Parameters.AddWithValue("@Email_Address_Id", EmailAddressId);
                cmd_insertion.Parameters.AddWithValue("@Email_Id", Email_Id);//(name in sp,modal attribute)
                cmd_insertion.Parameters.AddWithValue("@Email_Type", Email_Type);
                cmd_insertion.Parameters.AddWithValue("@UpdatedOn ", UpdatedOn);
                cmd_insertion.Parameters.AddWithValue("@UpdatedBy", UpdatedBy);

                cmd_insertion.ExecuteNonQuery();
                status = true;
                _Con.Close();
            }
            return status;
        }
        //Post for Update Registered NGO's Contact
        public static bool RegisterOrgContact_Update(RegesterNGOContactInsertionModel Cont,int Contact_Id,string UserID)
        {
            bool status;
            string Contact_Number = Cont.Contact_Number;
            string Fax = Cont.Fax;
            string Website_URL = Cont.Website_URL;
            DateTime UpdatedOn = DateTime.Now;
            string UpdatedBy = UserID;
            int ContactId = Contact_Id;

            using (SqlCommand cmd_insertion = new SqlCommand())
            {

                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_insertion.Connection = _Con;
                _Con.Open();
                cmd_insertion.CommandType = CommandType.StoredProcedure;
                cmd_insertion.CommandText = "SP_UpdateOrgContact";//Stored procedure name
                cmd_insertion.Parameters.AddWithValue("@Contact_Id", ContactId);
                cmd_insertion.Parameters.AddWithValue("@Contact_Number", Contact_Number);//(name in sp,modal attribute)
                cmd_insertion.Parameters.AddWithValue("@Fax", Fax);
                cmd_insertion.Parameters.AddWithValue("@Website_URL", Website_URL);
                cmd_insertion.Parameters.AddWithValue("@UpdatedOn", UpdatedOn);
                cmd_insertion.Parameters.AddWithValue("@UpdatedBy ", UpdatedBy);

                cmd_insertion.ExecuteNonQuery();
                status = true;
                _Con.Close();
            }
            return status;
        }

        //Post for Delete Registered NGO's Head Office Emails
        public static bool RegisterOrgEmails_Delete(int Email_Address_Id,string UserID)
        {
            bool status;
            DateTime UpdatedOn = DateTime.Now;
            string UpdatedBy = UserID;
            int EmailAddressId = Email_Address_Id;

            using (SqlCommand cmd_insertion = new SqlCommand())
            {

                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_insertion.Connection = _Con;
                _Con.Open();
                cmd_insertion.CommandType = CommandType.StoredProcedure;
                cmd_insertion.CommandText = "SP_DeleteOrgEmail";//Stored procedure name
                cmd_insertion.Parameters.AddWithValue("@Email_Address_Id", EmailAddressId);
                cmd_insertion.Parameters.AddWithValue("@UpdatedOn ", UpdatedOn);
                cmd_insertion.Parameters.AddWithValue("@UpdatedBy", UpdatedBy);

                cmd_insertion.ExecuteNonQuery();
                status = true;
                _Con.Close();
            }
            return status;
        }
        //Post for Delete Registered NGO's Contact
        public static bool RegisterOrgContact_Delete(int Contact_Id,string UserID)
        {
            bool status;
            DateTime UpdatedOn = DateTime.Now;
            string UpdatedBy = UserID;
            int ContactId = Contact_Id;

            using (SqlCommand cmd_insertion = new SqlCommand())
            {

                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_insertion.Connection = _Con;
                _Con.Open();
                cmd_insertion.CommandType = CommandType.StoredProcedure;
                cmd_insertion.CommandText = "SP_DeleteOrgContact";//Stored procedure name
                cmd_insertion.Parameters.AddWithValue("@Contact_Id", ContactId);
                cmd_insertion.Parameters.AddWithValue("@UpdatedOn", UpdatedOn);
                cmd_insertion.Parameters.AddWithValue("@UpdatedBy ", UpdatedBy);

                cmd_insertion.ExecuteNonQuery();
                status = true;
                _Con.Close();
            }
            return status;
        }
        #endregion
        #region Register Office Get Method
        //Get Registered Office Contacts
        public static List<GetRegisteredOfficeContact> Get_RegisterOfficeContacts(string UserID)
        {

            using (SqlCommand cmd_Get = new SqlCommand())
            {
                List<GetRegisteredOfficeContact> Contact = new List<GetRegisteredOfficeContact>();
                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_Get.Connection = _Con;
                _Con.Open();
                cmd_Get.CommandType = System.Data.CommandType.StoredProcedure;
                cmd_Get.CommandText = "SP_GetRegisteredOfficeContact";//Stored procedure name
                cmd_Get.Parameters.AddWithValue("@UserID", UserID);
                SqlDataAdapter da = new SqlDataAdapter(cmd_Get);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);
                dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    Contact.Add(new GetRegisteredOfficeContact
                    {
                        Contact_Id = Convert.ToInt32(row["Contact_Id"]),
                        Contact_Number = Convert.ToString(row["Contact_Number"]),
                        Fax = Convert.ToString(row["Fax"]),
                        Website_URL = Convert.ToString(row["Website_URL"])
                    });
                }
                _Con.Close();
                _Con.Dispose();
                da.Dispose();
                return Contact;
            }
        }

        //Get Office Contacts by ID
        public static List<CompoundModelOfficeContactEmail.RegesterOfficeContactModel> Get_OfficeContactByID(int Contact_Id)
        {

            using (SqlCommand cmd_Get = new SqlCommand())
            {
                List<CompoundModelOfficeContactEmail.RegesterOfficeContactModel> OrgContact = new List<CompoundModelOfficeContactEmail.RegesterOfficeContactModel>();
                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_Get.Connection = _Con;
                _Con.Open();
                cmd_Get.CommandType = System.Data.CommandType.StoredProcedure;
                cmd_Get.CommandText = "SP_GetOfficeContactByID";//Stored procedure name
                cmd_Get.Parameters.AddWithValue("@Contact_Id", Contact_Id);
                SqlDataAdapter da = new SqlDataAdapter(cmd_Get);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);
                dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    OrgContact.Add(new CompoundModelOfficeContactEmail.RegesterOfficeContactModel
                    {
                        Contact_Number = Convert.ToString(row["Contact_Number"]),
                        Fax = Convert.ToString(row["Fax"]),
                        Website_URL = Convert.ToString(row["Website_URL"])
                    });
                }
                _Con.Close();
                _Con.Dispose();
                da.Dispose();
                return OrgContact;
            }
        }
        #endregion
        #region Register Office Post Method
        //Post Registered Office's Contact
        public static bool RegisterOfficeContact_Insertion(RegesterOfficeContactModel Cont,string UserID)
        {
            bool status;
            string Contact_Number = Cont.Contact_Number;
            string Fax = Cont.Fax;
            string Website_URL = Cont.Website_URL;
            DateTime CreatedOn = DateTime.Now;
            string CreatedBy = UserID;

            using (SqlCommand cmd_insertion = new SqlCommand())
            {

                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_insertion.Connection = _Con;
                _Con.Open();
                cmd_insertion.CommandType = CommandType.StoredProcedure;
                cmd_insertion.CommandText = "Sp_AddRegisterOfficeContacts";//Stored procedure name
                cmd_insertion.Parameters.AddWithValue("@Contact_Number", Contact_Number);//(name in sp,modal attribute)
                cmd_insertion.Parameters.AddWithValue("@Fax", Fax);
                cmd_insertion.Parameters.AddWithValue("@Website_URL", Website_URL);
                cmd_insertion.Parameters.AddWithValue("@CreatedOn", CreatedOn);
                cmd_insertion.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                cmd_insertion.Parameters.AddWithValue("@Is_active", true);
                cmd_insertion.Parameters.AddWithValue("@Is_Deleted", false);
                cmd_insertion.Parameters.AddWithValue("@UserID", UserID);

                cmd_insertion.ExecuteNonQuery();
                status = true;
                _Con.Close();
            }
            return status;
        }

        //Post for Update Registered NGO's Contact
        public static bool RegisterOfficeContact_Update(RegesterOfficeContactModel Cont, int Contact_Id,string UserID)
        {
            bool status;
            string Contact_Number = Cont.Contact_Number;
            string Fax = Cont.Fax;
            string Website_URL = Cont.Website_URL;
            DateTime UpdatedOn = DateTime.Now;
            string UpdatedBy = UserID;
            int ContactId = Contact_Id;

            using (SqlCommand cmd_insertion = new SqlCommand())
            {

                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_insertion.Connection = _Con;
                _Con.Open();
                cmd_insertion.CommandType = CommandType.StoredProcedure;
                cmd_insertion.CommandText = "SP_UpdateOfficeContact";//Stored procedure name
                cmd_insertion.Parameters.AddWithValue("@Contact_Id", ContactId);
                cmd_insertion.Parameters.AddWithValue("@Contact_Number", Contact_Number);//(name in sp,modal attribute)
                cmd_insertion.Parameters.AddWithValue("@Fax", Fax);
                cmd_insertion.Parameters.AddWithValue("@Website_URL", Website_URL);
                cmd_insertion.Parameters.AddWithValue("@UpdatedOn", UpdatedOn);
                cmd_insertion.Parameters.AddWithValue("@UpdatedBy ", UpdatedBy);

                cmd_insertion.ExecuteNonQuery();
                status = true;
                _Con.Close();
            }
            return status;
        }

        //Post for Delete Registered Office's Contact
        public static bool RegisterOfficeContact_Delete(int Contact_Id,string UserID)
        {
            bool status;
            DateTime UpdatedOn = DateTime.Now;
            string UpdatedBy = UserID;
            int ContactId = Contact_Id;

            using (SqlCommand cmd_insertion = new SqlCommand())
            {

                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_insertion.Connection = _Con;
                _Con.Open();
                cmd_insertion.CommandType = CommandType.StoredProcedure;
                cmd_insertion.CommandText = "SP_DeleteOfficeContact";//Stored procedure name
                cmd_insertion.Parameters.AddWithValue("@Contact_Id", ContactId);
                cmd_insertion.Parameters.AddWithValue("@UpdatedOn", UpdatedOn);
                cmd_insertion.Parameters.AddWithValue("@UpdatedBy ", UpdatedBy);

                cmd_insertion.ExecuteNonQuery();
                status = true;
                _Con.Close();
            }
            return status;
        }
        #endregion
        #region Office Email
        //Get Office all Emails
        public static List<CompoundModelOfficeContactEmail.RegesterOfficeEmailModel> Get_OfficeAllEmails(string UserID)
        {

            using (SqlCommand cmd_Get = new SqlCommand())
            {
                List<CompoundModelOfficeContactEmail.RegesterOfficeEmailModel> Emails =
                    new List<CompoundModelOfficeContactEmail.RegesterOfficeEmailModel>();
                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_Get.Connection = _Con;
                _Con.Open();
                cmd_Get.CommandType = System.Data.CommandType.StoredProcedure;
                cmd_Get.CommandText = "SP_GetOfficeAllEmails";//Stored procedure name
                cmd_Get.Parameters.AddWithValue("@UserID", UserID);
                SqlDataAdapter da = new SqlDataAdapter(cmd_Get);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);
                dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    Emails.Add(new CompoundModelOfficeContactEmail.RegesterOfficeEmailModel
                    {
                        Email_Address_Id = Convert.ToString(row["Email_Address_Id"]),
                        Email_Id = Convert.ToString(row["Email_Id"]),
                        Email_Type = Convert.ToString(row["Email_Type"])
                    });
                }
                _Con.Close();
                _Con.Dispose();
                da.Dispose();
                return Emails;
            }
        }
        //Get Office Email by ID
        public static List<CompoundModelOfficeContactEmail.RegesterOfficeEmailModel> Get_OfficeEmailBYID(int Email_Address_Id)
        {

            using (SqlCommand cmd_Get = new SqlCommand())
            {
                List<CompoundModelOfficeContactEmail.RegesterOfficeEmailModel> OfficeEmail = 
                    new List<CompoundModelOfficeContactEmail.RegesterOfficeEmailModel>();
                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_Get.Connection = _Con;
                _Con.Open();
                cmd_Get.CommandType = System.Data.CommandType.StoredProcedure;
                cmd_Get.CommandText = "SP_GetOfficeEmailByID";//Stored procedure name
                cmd_Get.Parameters.AddWithValue("@Email_Address_Id", Email_Address_Id);
                SqlDataAdapter da = new SqlDataAdapter(cmd_Get);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);
                dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    OfficeEmail.Add(new CompoundModelOfficeContactEmail.RegesterOfficeEmailModel
                    {
                        Email_Id = Convert.ToString(row["Email_Id"]),
                        Email_Type = Convert.ToString(row["Email_Type"])
                    });
                }
                _Con.Close();
                _Con.Dispose();
                da.Dispose();
                return OfficeEmail;
            }
        }
        //Add Office Email
        public static bool OfficeEmails_Insertion(CompoundModelOfficeContactEmail.RegesterOfficeEmailModel Email, string UserID)
        {
            bool status;
            string Email_Id = Email.Email_Id;
            string Email_Type = Email.Email_Type;
            DateTime CreatedOn = DateTime.Now;
            string CreatedBy = UserID;

            using (SqlCommand cmd_insertion = new SqlCommand())
            {

                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_insertion.Connection = _Con;
                _Con.Open();
                cmd_insertion.CommandType = CommandType.StoredProcedure;
                cmd_insertion.CommandText = "Sp_AddRegisterOfficeEmail";//Stored procedure name
                cmd_insertion.Parameters.AddWithValue("@Email_Id", Email_Id);//(name in sp,modal attribute)
                cmd_insertion.Parameters.AddWithValue("@Email_Type", Email_Type);
                cmd_insertion.Parameters.AddWithValue("@CreatedOn", CreatedOn);
                cmd_insertion.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                cmd_insertion.Parameters.AddWithValue("@Is_active", true);
                cmd_insertion.Parameters.AddWithValue("@Is_Deleted", false);
                cmd_insertion.Parameters.AddWithValue("@UserID", UserID);

                cmd_insertion.ExecuteNonQuery();
                status = true;
                _Con.Close();
            }
            return status;
        }

        //Update Office Emails
        public static bool OfficeEmails_Update(CompoundModelOfficeContactEmail.RegesterOfficeEmailModel Email, int Email_Address_Id,string UserID)
        {
            bool status;
            string Email_Id = Email.Email_Id;
            string Email_Type = Email.Email_Type;
            DateTime UpdatedOn = DateTime.Now;
            string UpdatedBy = UserID;
            int EmailAddressId = Email_Address_Id;

            using (SqlCommand cmd_insertion = new SqlCommand())
            {

                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_insertion.Connection = _Con;
                _Con.Open();
                cmd_insertion.CommandType = CommandType.StoredProcedure;
                cmd_insertion.CommandText = "SP_UpdateOfficeEmail";//Stored procedure name
                cmd_insertion.Parameters.AddWithValue("@Email_Address_Id", EmailAddressId);
                cmd_insertion.Parameters.AddWithValue("@Email_Id", Email_Id);//(name in sp,modal attribute)
                cmd_insertion.Parameters.AddWithValue("@Email_Type", Email_Type);
                cmd_insertion.Parameters.AddWithValue("@UpdatedOn ", UpdatedOn);
                cmd_insertion.Parameters.AddWithValue("@UpdatedBy", UpdatedBy);

                cmd_insertion.ExecuteNonQuery();
                status = true;
                _Con.Close();
            }
            return status;
        }

        //Delete Registered NGO's Head Office Emails
        public static bool OfficeEmails_Delete(int Email_Address_Id, string UserID)
        {
            bool status;
            DateTime UpdatedOn = DateTime.Now;
            string UpdatedBy = UserID;
            int EmailAddressId = Email_Address_Id;

            using (SqlCommand cmd_insertion = new SqlCommand())
            {

                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_insertion.Connection = _Con;
                _Con.Open();
                cmd_insertion.CommandType = CommandType.StoredProcedure;
                cmd_insertion.CommandText = "SP_DeleteOfficeEmail";//Stored procedure name
                cmd_insertion.Parameters.AddWithValue("@Email_Address_Id", EmailAddressId);
                cmd_insertion.Parameters.AddWithValue("@UpdatedOn ", UpdatedOn);
                cmd_insertion.Parameters.AddWithValue("@UpdatedBy", UpdatedBy);

                cmd_insertion.ExecuteNonQuery();
                status = true;
                _Con.Close();
            }
            return status;
        }
        #endregion
    }
}
