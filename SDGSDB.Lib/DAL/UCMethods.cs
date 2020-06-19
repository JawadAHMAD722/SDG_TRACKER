using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDGSDB.Models;
using System.Net.Mail;
using System.Runtime.Remoting.Metadata.W3cXsd2001;


namespace SDGSDB.Lib.DAL
{
    public class UCMethods
    {
        #region Post Method
        //UC Initial Registration
        public static int[] Insert_UCRegistration(UCInitialRegistration UC, string UserId)
        {
            int OrgID;
            bool status;
            int[] Result = new int[2];
            using (SqlCommand cmd_insertion = new SqlCommand())
            {
                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_insertion.Connection = _Con;
                _Con.Open();
                cmd_insertion.CommandType = System.Data.CommandType.StoredProcedure;
                cmd_insertion.CommandText = "AddInitialUCSP";
                cmd_insertion.Parameters.AddWithValue("@Organization_Name", UC.Organization_Name);
                cmd_insertion.Parameters.AddWithValue("@Name", UC.Name);
                cmd_insertion.Parameters.AddWithValue("@ProvinceId", UC.ProvinceId);
                cmd_insertion.Parameters.AddWithValue("@DivisionId", UC.DivisionId);
                cmd_insertion.Parameters.AddWithValue("@DistrictId", UC.DistrictId);
                cmd_insertion.Parameters.AddWithValue("@Tehsil_Id", UC.Tehsil_Id);
                cmd_insertion.Parameters.AddWithValue("@Contact_Number", UC.Contact_Number);
                cmd_insertion.Parameters.AddWithValue("@Email_Id", UC.Email_Id);
                cmd_insertion.Parameters.AddWithValue("@Additional_Comments", UC.Additional_Comments);
                cmd_insertion.Parameters.AddWithValue("@UserID", UserId);
                cmd_insertion.Parameters.Add("@OrgOfficeID", SqlDbType.Int).Direction = ParameterDirection.Output;
                SqlParameter retreval = cmd_insertion.Parameters.Add("@org_id", SqlDbType.VarChar);
                retreval.Direction = ParameterDirection.ReturnValue;
                cmd_insertion.ExecuteNonQuery();
                OrgID = (int)cmd_insertion.Parameters["@org_id"].Value;
                int OfficeId = Convert.ToInt32(cmd_insertion.Parameters["@OrgOfficeID"].Value);
                _Con.Close();
                cmd_insertion.Parameters.Clear();
                Result[0] = OrgID;
                Result[1] = OfficeId;
                status = true;
            }
            return Result;
        }
        //Post UC Registration Complete
        public static bool UCRegistrationComplete_Insertion(UCPCompleteRegistrationModel UCP, string UserID)
        {
            bool status;
            string Area = UCP.Area;
            string Population = UCP.Population;
            string MalePopulation = UCP.MalePopulation;
            string FemalePopulation = UCP.FemalePopulation;
            string Other_Locality = UCP.Other_Locality;
            string Climate = UCP.Climate;
            string RoadInfrastructure = UCP.RoadInfrastructure;
            bool IS_Active = true;
            DateTime CreaetdOn = DateTime.Now;
            string CreatedBy = UserID;
            DateTime UpdatedOn = DateTime.Now;
            string UpdatedBy = UserID;

            using (SqlCommand cmd_insertion = new SqlCommand())
            {
                conn c = new conn();
                SqlConnection _Con = c.conect();
                SqlParameter SQP = new SqlParameter("@returnVal", SqlDbType.Int);
                cmd_insertion.Connection = _Con;
                _Con.Open();
                cmd_insertion.CommandType = CommandType.StoredProcedure;
                cmd_insertion.CommandText = "AddUCProfileComplete";//Stored procedure name
                cmd_insertion.Parameters.AddWithValue("@Area", Area);//(name in sp,modal attribute)
                cmd_insertion.Parameters.AddWithValue("@Population", Population);
                cmd_insertion.Parameters.AddWithValue("@MalePopulation", MalePopulation);
                cmd_insertion.Parameters.AddWithValue("@FemalePopulation", FemalePopulation);
                cmd_insertion.Parameters.AddWithValue("@Other_Locality", Other_Locality);
                cmd_insertion.Parameters.AddWithValue("@Climate", Climate);
                cmd_insertion.Parameters.AddWithValue("@RoadInfrastructure", RoadInfrastructure);
                cmd_insertion.Parameters.AddWithValue("@CreaetdOn ", CreaetdOn);
                cmd_insertion.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                cmd_insertion.Parameters.AddWithValue("@Is_active", IS_Active);
                cmd_insertion.Parameters.AddWithValue("@UserID", UserID);
                cmd_insertion.Parameters.AddWithValue("@UpdatedOn", UpdatedOn);
                cmd_insertion.Parameters.AddWithValue("@UpdatedBy", UpdatedBy);
                SQP.Direction = ParameterDirection.ReturnValue;
                cmd_insertion.Parameters.Add(SQP);
                cmd_insertion.ExecuteNonQuery();
                status = true;
                _Con.Close();
                cmd_insertion.Parameters.Clear();
                int OfficeId = Convert.ToInt32(SQP.Value);

                status = true;
            }
            return status;
        }

        //Post UC Registration Complete
        public static bool UCRegistrationComplete_Updation(UCPCompleteRegistrationModel UCP, string UserID)
        {
            bool status;
            string Area = UCP.Area;
            string Population = UCP.Population;
            string MalePopulation = UCP.MalePopulation;
            string FemalePopulation = UCP.FemalePopulation;
            string Other_Locality = UCP.Other_Locality;
            string Climate = UCP.Climate;
            string RoadInfrastructure = UCP.RoadInfrastructure;
            bool IS_Active = true;
            DateTime UpdatedOn = DateTime.Now;
            string UpdatedBy = UserID;

            using (SqlCommand cmd_insertion = new SqlCommand())
            {
                conn c = new conn();
                SqlConnection _Con = c.conect();
                SqlParameter SQP = new SqlParameter("@returnVal", SqlDbType.Int);
                cmd_insertion.Connection = _Con;
                _Con.Open();
                cmd_insertion.CommandType = CommandType.StoredProcedure;
                cmd_insertion.CommandText = "UpdateUCProfileComplete";//Stored procedure name
                cmd_insertion.Parameters.AddWithValue("@Area", Area);//(name in sp,modal attribute)
                cmd_insertion.Parameters.AddWithValue("@Population", Population);
                cmd_insertion.Parameters.AddWithValue("@MalePopulation", MalePopulation);
                cmd_insertion.Parameters.AddWithValue("@FemalePopulation", FemalePopulation);
                cmd_insertion.Parameters.AddWithValue("@Other_Locality", Other_Locality);
                cmd_insertion.Parameters.AddWithValue("@Climate", Climate);
                cmd_insertion.Parameters.AddWithValue("@RoadInfrastructure", RoadInfrastructure);
                cmd_insertion.Parameters.AddWithValue("@Is_active", IS_Active);
                cmd_insertion.Parameters.AddWithValue("@UserID", UserID);
                cmd_insertion.Parameters.AddWithValue("@UpdatedOn", UpdatedOn);
                cmd_insertion.Parameters.AddWithValue("@UpdatedBy", UpdatedBy);
                SQP.Direction = ParameterDirection.ReturnValue;
                cmd_insertion.Parameters.Add(SQP);
                cmd_insertion.ExecuteNonQuery();
                status = true;
                _Con.Close();
                cmd_insertion.Parameters.Clear();
                int OfficeId = Convert.ToInt32(SQP.Value);

                status = true;
            }
            return status;
        }
        //Post UC Organizations/Institutions Detail
        public static bool UCOrg_Insertion(UCOrgInstitutionsModel UCI, string UserID)
        {
            bool status;
            int SectorId = UCI.Sector_Id;
            int SectorCategoryId = UCI.Sector_Category_Id;
            string Organization = UCI.Organization;
            string OrganizationNature = UCI.OrganizationNature;
            string Locality = UCI.Locality;
            string Address = UCI.Address;
            string ContactNumber = UCI.ContactNumber;
            string ContactPersonName = UCI.ContactPersonName;
            string FaxNumber = UCI.FaxNumber;
            string EmailAddress = UCI.EmailAddress;
            DateTime CreaetdOn = DateTime.Now;
            string CreatedBy = UserID;

            using (SqlCommand cmd_insertion = new SqlCommand())
            {
                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_insertion.Connection = _Con;
                _Con.Open();
                cmd_insertion.CommandType = CommandType.StoredProcedure;
                cmd_insertion.CommandText = "Sp_Add_UCOrganization";//Stored procedure name
                cmd_insertion.Parameters.AddWithValue("@Sector_Id", SectorId);//(name in sp,modal attribute)
                cmd_insertion.Parameters.AddWithValue("@Sector_Category_Id", SectorCategoryId);
                cmd_insertion.Parameters.AddWithValue("@Organization", Organization);
                cmd_insertion.Parameters.AddWithValue("@OrganizationNature", OrganizationNature);
                cmd_insertion.Parameters.AddWithValue("@Locality", Locality);
                cmd_insertion.Parameters.AddWithValue("@Address", Address);
                cmd_insertion.Parameters.AddWithValue("@ContactPersonName", ContactPersonName);
                cmd_insertion.Parameters.AddWithValue("@ContactNumber", ContactNumber);
                cmd_insertion.Parameters.AddWithValue("@FaxNumber ", FaxNumber);
                cmd_insertion.Parameters.AddWithValue("@EmailAddress", EmailAddress);
                cmd_insertion.Parameters.AddWithValue("@CreatedOn", CreaetdOn);
                cmd_insertion.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                cmd_insertion.Parameters.AddWithValue("@UserID", UserID);
                cmd_insertion.ExecuteNonQuery();
                status = true;
                _Con.Close();
                status = true;
            }
            return status;
        }
        //Post for Delete UC Organization
        public static bool UCOrg_Delete(int UC_OrganizationId, string UserID)
        {
            bool status;
            DateTime UpdatedOn = DateTime.Now;
            string UpdatedBy = UserID;
            int UCOrganizationId = UC_OrganizationId;

            using (SqlCommand cmd_insertion = new SqlCommand())
            {

                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_insertion.Connection = _Con;
                _Con.Open();
                cmd_insertion.CommandType = CommandType.StoredProcedure;
                cmd_insertion.CommandText = "SP_DeleteUCOrg";//Stored procedure name
                cmd_insertion.Parameters.AddWithValue("@UC_OrganizationId", UCOrganizationId);
                cmd_insertion.Parameters.AddWithValue("@UpdatedOn ", UpdatedOn);
                cmd_insertion.Parameters.AddWithValue("@UpdatedBy", UpdatedBy);

                cmd_insertion.ExecuteNonQuery();
                status = true;
                _Con.Close();
            }
            return status;
        }

        //Post UC Staff
        public static bool UCStaff_Insertion(UCStaffModel UCStaff, string UserID)
        {
            bool status;
            string UC_Staff_Category = UCStaff.UC_Staff_Category;
            string US_StaffFirstName = UCStaff.US_StaffFirstName;
            string UC_StaffLastName = UCStaff.UC_StaffLastName;

            string FatherName = UCStaff.FatherName;
            string CNIC = UCStaff.CNIC;
            string DOB = UCStaff.DOB;
            string BirthPlace = UCStaff.BirthPlace;
            string Gender = UCStaff.Gender;
            string Religion = UCStaff.Religion;
            string Address = UCStaff.Address;
            bool Educated = UCStaff.Educated;
            string LastDegree = UCStaff.LastDegree;

            string StartingTerm = UCStaff.StartingTerm;
            string EndingTerm = UCStaff.EndingTerm;
            string EmailAddress = UCStaff.EmailAddress;
            string ContactNumber = UCStaff.ContactNumber;
            string FaxNumber = UCStaff.FaxNumber;
            string OfficeAddress = UCStaff.OfficeAddress;
            DateTime CraatedOn = DateTime.Now;
            string CreatedBy = UserID;

            using (SqlCommand cmd_insertion = new SqlCommand())
            {
                conn c = new conn();
                SqlConnection _Con = c.conect();
                SqlParameter SQP = new SqlParameter("@returnVal", SqlDbType.Int);
                cmd_insertion.Connection = _Con;
                _Con.Open();
                cmd_insertion.CommandType = CommandType.StoredProcedure;
                cmd_insertion.CommandText = "Sp_Add_UCStaff";//Stored procedure name
                cmd_insertion.Parameters.AddWithValue("@UC_Staff_Category", UC_Staff_Category);//(name in sp,modal attribute)
                cmd_insertion.Parameters.AddWithValue("@US_StaffFirstName", US_StaffFirstName);
                cmd_insertion.Parameters.AddWithValue("@UC_StaffLastName", UC_StaffLastName);

                cmd_insertion.Parameters.AddWithValue("@FatherName", FatherName);
                cmd_insertion.Parameters.AddWithValue("@CNIC", CNIC);
                cmd_insertion.Parameters.AddWithValue("@DOB", DOB);
                cmd_insertion.Parameters.AddWithValue("@BirthPlace", BirthPlace);
                cmd_insertion.Parameters.AddWithValue("@Gender", Gender);
                cmd_insertion.Parameters.AddWithValue("@Religion", Religion);
                cmd_insertion.Parameters.AddWithValue("@Address", Address);
                cmd_insertion.Parameters.AddWithValue("@Educated", Educated);
                cmd_insertion.Parameters.AddWithValue("@LastDegree", LastDegree);

                cmd_insertion.Parameters.AddWithValue("@StartingTerm", StartingTerm);
                cmd_insertion.Parameters.AddWithValue("@EndingTerm", EndingTerm);
                cmd_insertion.Parameters.AddWithValue("@EmailAddress", EmailAddress);
                cmd_insertion.Parameters.AddWithValue("@ContactNumber", ContactNumber);
                cmd_insertion.Parameters.AddWithValue("@FaxNumber", FaxNumber);
                cmd_insertion.Parameters.AddWithValue("@OfficeAddress", OfficeAddress);
                cmd_insertion.Parameters.AddWithValue("@CraatedOn", CraatedOn);
                cmd_insertion.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                cmd_insertion.Parameters.AddWithValue("@UserID", UserID);
                cmd_insertion.ExecuteNonQuery();
                status = true;
                _Con.Close();
            }
            return status;
        }

        //Update UC Staff 
        public static bool UCStaff_Updation(UCStaffModel UCStaff, string UserID,int UC_Concil_StaffId)
        {
            bool status;
            string UC_Staff_Category = UCStaff.UC_Staff_Category;
            string US_StaffFirstName = UCStaff.US_StaffFirstName;
            string UC_StaffLastName = UCStaff.UC_StaffLastName;
            string FatherName = UCStaff.FatherName;
            string CNIC = UCStaff.CNIC;
            string DOB = UCStaff.DOB;
            string BirthPlace = UCStaff.BirthPlace;
            string Gender = UCStaff.Gender;
            string Religion = UCStaff.Religion;
            string Address = UCStaff.Address;
            bool Educated = UCStaff.Educated;
            string LastDegree = UCStaff.LastDegree;

            string StartingTerm = UCStaff.StartingTerm;
            string EndingTerm = UCStaff.EndingTerm;
            string EmailAddress = UCStaff.EmailAddress;
            string ContactNumber = UCStaff.ContactNumber;
            string FaxNumber = UCStaff.FaxNumber;
            string OfficeAddress = UCStaff.OfficeAddress;
            DateTime CraatedOn = DateTime.Now;
            string CreatedBy = UserID;

            using (SqlCommand cmd_insertion = new SqlCommand())
            {
                conn c = new conn();
                SqlConnection _Con = c.conect();
                SqlParameter SQP = new SqlParameter("@returnVal", SqlDbType.Int);
                cmd_insertion.Connection = _Con;
                _Con.Open();
                cmd_insertion.CommandType = CommandType.StoredProcedure;
                cmd_insertion.CommandText = "Sp_Update_UCStaff";//Stored procedure name
                cmd_insertion.Parameters.AddWithValue("@UC_Concil_StaffId", UC_Concil_StaffId);
                cmd_insertion.Parameters.AddWithValue("@UC_Staff_Category", UC_Staff_Category);//(name in sp,modal attribute)
                cmd_insertion.Parameters.AddWithValue("@US_StaffFirstName", US_StaffFirstName);
                cmd_insertion.Parameters.AddWithValue("@UC_StaffLastName", UC_StaffLastName);

                cmd_insertion.Parameters.AddWithValue("@FatherName", FatherName);
                cmd_insertion.Parameters.AddWithValue("@CNIC", CNIC);
                cmd_insertion.Parameters.AddWithValue("@DOB", DOB);
                cmd_insertion.Parameters.AddWithValue("@BirthPlace", BirthPlace);
                cmd_insertion.Parameters.AddWithValue("@Gender", Gender);
                cmd_insertion.Parameters.AddWithValue("@Religion", Religion);
                cmd_insertion.Parameters.AddWithValue("@Address", Address);
                cmd_insertion.Parameters.AddWithValue("@Educated", Educated);
                cmd_insertion.Parameters.AddWithValue("@LastDegree", LastDegree);

                cmd_insertion.Parameters.AddWithValue("@StartingTerm", StartingTerm);
                cmd_insertion.Parameters.AddWithValue("@EndingTerm", EndingTerm);
                cmd_insertion.Parameters.AddWithValue("@EmailAddress", EmailAddress);
                cmd_insertion.Parameters.AddWithValue("@ContactNumber", ContactNumber);
                cmd_insertion.Parameters.AddWithValue("@FaxNumber", FaxNumber);
                cmd_insertion.Parameters.AddWithValue("@OfficeAddress", OfficeAddress);
                cmd_insertion.Parameters.AddWithValue("@UpdatedOn", CraatedOn);
                cmd_insertion.Parameters.AddWithValue("@UpdatedBy", CreatedBy);
                cmd_insertion.Parameters.AddWithValue("@UserID", UserID);
                cmd_insertion.ExecuteNonQuery();
                status = true;
                _Con.Close();
            }
            return status;
        }
        //Delete UC Staff 
        public static bool UCStaff_Deletion(string UserID, int UC_Concil_StaffId)
        {
            bool status;
            DateTime CraatedOn = DateTime.Now;
            string CreatedBy = UserID;

            using (SqlCommand cmd_insertion = new SqlCommand())
            {
                conn c = new conn();
                SqlConnection _Con = c.conect();
                SqlParameter SQP = new SqlParameter("@returnVal", SqlDbType.Int);
                cmd_insertion.Connection = _Con;
                _Con.Open();
                cmd_insertion.CommandType = CommandType.StoredProcedure;
                cmd_insertion.CommandText = "Sp_Delete_UCStaff";//Stored procedure name
                cmd_insertion.Parameters.AddWithValue("@UC_Concil_StaffId", UC_Concil_StaffId);
                cmd_insertion.Parameters.AddWithValue("@UpdatedOn", CraatedOn);
                cmd_insertion.Parameters.AddWithValue("@UpdatedBy", CreatedBy);
                cmd_insertion.Parameters.AddWithValue("@UserID", UserID);
                cmd_insertion.ExecuteNonQuery();
                status = true;
                _Con.Close();
            }
            return status;
        }
        #endregion
        #region Get Methods
        //Get All UCOrganization
        public static List<UCOrgInstitutionsModel> Get_AllOrganizationByUC(string UserID)
        {

            using (SqlCommand cmd_Get = new SqlCommand())
            {
                List<UCOrgInstitutionsModel> UCOrg = new List<UCOrgInstitutionsModel>();
                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_Get.Connection = _Con;
                _Con.Open();
                cmd_Get.CommandType = System.Data.CommandType.StoredProcedure;
                cmd_Get.CommandText = "SP_GetALLOrganizationByUcId";//Stored procedure name
                cmd_Get.Parameters.AddWithValue("@UserID", UserID);
                SqlDataAdapter da = new SqlDataAdapter(cmd_Get);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);
                dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    UCOrg.Add(new UCOrgInstitutionsModel
                    {
                        UC_OrganizationId = Convert.ToInt32(row["UC_OrganizationId"]),
                        Sector_Name = Convert.ToString(row["SectorName"]),
                        Category_Name = Convert.ToString(row["Category_Name"]),
                        Organization = Convert.ToString(row["Organization"]),
                        OrganizationNature = Convert.ToString(row["OrganizationNature"]),
                        Locality = Convert.ToString(row["Locality"]),
                        Address = Convert.ToString(row["Address"]),
                        ContactNumber = Convert.ToString(row["ContactNumber"]),
                        FaxNumber = Convert.ToString(row["FaxNumber"]),
                        EmailAddress = Convert.ToString(row["EmailAddress"])
                    });

                }
                _Con.Close();
                _Con.Dispose();
                da.Dispose();
                return UCOrg;
            }
        }

        //Get All UCOrganization By Sector Category
        public static List<UCOrgInstitutionsModel> Get_AllOrganizationByUCSectorCat(string UserID,int Sector_Category_Id)
        {

            using (SqlCommand cmd_Get = new SqlCommand())
            {
                List<UCOrgInstitutionsModel> UCOrg = new List<UCOrgInstitutionsModel>();
                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_Get.Connection = _Con;
                _Con.Open();
                cmd_Get.CommandType = System.Data.CommandType.StoredProcedure;
                cmd_Get.CommandText = "SP_GetALLUCOrganizationBySectorCategory";//Stored procedure name
                cmd_Get.Parameters.AddWithValue("@UserID", UserID);
                cmd_Get.Parameters.AddWithValue("@Sector_Category_Id", Sector_Category_Id);
                SqlDataAdapter da = new SqlDataAdapter(cmd_Get);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);
                dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    UCOrg.Add(new UCOrgInstitutionsModel
                    {
                        UC_OrganizationId = Convert.ToInt32(row["UC_OrganizationId"]),
                        Sector_Name = Convert.ToString(row["SectorName"]),
                        Category_Name = Convert.ToString(row["Category_Name"]),
                        Organization = Convert.ToString(row["Organization"]),
                        OrganizationNature = Convert.ToString(row["OrganizationNature"]),
                        Locality = Convert.ToString(row["Locality"]),
                        Address = Convert.ToString(row["Address"]),
                        ContactPersonName = Convert.ToString(row["ContactPersonName"]),
                        ContactNumber = Convert.ToString(row["ContactNumber"]),
                        FaxNumber = Convert.ToString(row["FaxNumber"]),
                        EmailAddress = Convert.ToString(row["EmailAddress"])
                    });

                }
                _Con.Close();
                _Con.Dispose();
                da.Dispose();
                return UCOrg;
            }
        }

        //Get All UCSectors
        public static List<DDLSectorsModel> Get_AllUCSectors(string UserID)
        {

            using (SqlCommand cmd_Get = new SqlCommand())
            {
                List<DDLSectorsModel> UCSec = new List<DDLSectorsModel>();
                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_Get.Connection = _Con;
                _Con.Open();
                cmd_Get.CommandType = System.Data.CommandType.StoredProcedure;
                cmd_Get.CommandText = "SP_Get_UCSectors";//Stored procedure name
                cmd_Get.Parameters.AddWithValue("@UserID", UserID);
                SqlDataAdapter da = new SqlDataAdapter(cmd_Get);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);
                dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    UCSec.Add(new DDLSectorsModel
                    {
                        Sector_ID = Convert.ToString(row["Sector_Id"]),
                        SectorName = Convert.ToString(row["SectorName"])
                    });

                }
                _Con.Close();
                _Con.Dispose();
                da.Dispose();
                return UCSec;
            }
        }

        //Get All UCSector's Categories
        public static List<DDLSectorsCategoryModel> Get_AllUCSectorsCategories(string UserID,int Sector_ID)
        {

            using (SqlCommand cmd_Get = new SqlCommand())
            {
                List<DDLSectorsCategoryModel> UCSec = new List<DDLSectorsCategoryModel>();
                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_Get.Connection = _Con;
                _Con.Open();
                cmd_Get.CommandType = System.Data.CommandType.StoredProcedure;
                cmd_Get.CommandText = "SP_Get_UCSectorsCategory";//Stored procedure name
                cmd_Get.Parameters.AddWithValue("@UserID", UserID);
                cmd_Get.Parameters.AddWithValue("@Sector_ID", Sector_ID);
                SqlDataAdapter da = new SqlDataAdapter(cmd_Get);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);
                dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    UCSec.Add(new DDLSectorsCategoryModel
                    {
                        Sector_Id = Convert.ToString(row["Sector_Id"]),
                        Sector_Category_Id = Convert.ToString(row["Sector_Category_Id"]),
                        Category_Name = Convert.ToString(row["Category_Name"]),
                        Total_Categories = Convert.ToString(row["Total_Categories"])
                    });

                }
                _Con.Close();
                _Con.Dispose();
                da.Dispose();
                return UCSec;
            }
        }

        //Get Organization by UC ORGID
        public static List<UCOrgInstitutionsModel> Get_UCOrgByID(int UC_OrganizationId)
        {

            using (SqlCommand cmd_Get = new SqlCommand())
            {
                List<UCOrgInstitutionsModel> UCOrg = new List<UCOrgInstitutionsModel>();
                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_Get.Connection = _Con;
                _Con.Open();
                cmd_Get.CommandType = System.Data.CommandType.StoredProcedure;
                cmd_Get.CommandText = "SP_GetALLOrganizationByUcOrgId";//Stored procedure name
                cmd_Get.Parameters.AddWithValue("@UC_OrganizationId", UC_OrganizationId);
                SqlDataAdapter da = new SqlDataAdapter(cmd_Get);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);
                dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    UCOrg.Add(new UCOrgInstitutionsModel
                    {
                        UC_OrganizationId = Convert.ToInt32(row["UC_OrganizationId"]),
                        Sector_Id = Convert.ToInt32(row["Sector_Id"]),
                        Sector_Category_Id = Convert.ToInt32(row["Sector_Category_Id"]),
                        Organization = Convert.ToString(row["Organization"]),
                        OrganizationNature = Convert.ToString(row["OrganizationNature"]),
                        Locality = Convert.ToString(row["Locality"]),
                        Address = Convert.ToString(row["Address"]),
                        ContactNumber = Convert.ToString(row["ContactNumber"]),
                        FaxNumber = Convert.ToString(row["FaxNumber"]),
                        EmailAddress = Convert.ToString(row["EmailAddress"])
                    });
                }
                _Con.Close();
                _Con.Dispose();
                da.Dispose();
                return UCOrg;
            }
        }

        //Get UC Profile
        public static List<UCProfile> Get_UCProfile(string UserID)
        {

            using (SqlCommand cmd_Get = new SqlCommand())
            {
                List<UCProfile> UCProfile = new List<UCProfile>();
                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_Get.Connection = _Con;
                _Con.Open();
                cmd_Get.CommandType = System.Data.CommandType.StoredProcedure;
                cmd_Get.CommandText = "SP_Get_UCProfile";//Stored procedure name
                cmd_Get.Parameters.AddWithValue("@UserID", UserID);
                SqlDataAdapter da = new SqlDataAdapter(cmd_Get);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);
                dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    UCProfile.Add(new UCProfile
                    {          
                        UC_Id = Convert.ToInt32(row["UC_Id"]),
                        UC_Name = Convert.ToString(row["UC_Name"]),
                        Province_Name = Convert.ToString(row["Province_Name"]),
                        Division_Name = Convert.ToString(row["Division_Name"]),
                        District_Name = Convert.ToString(row["District_Name"]),
                        Tehsil_Name = Convert.ToString(row["Tehsil_Name"]),
                        Area = Convert.ToString(row["Area"]),
                        Population = Convert.ToString(row["Population"]),
                        MalePopulation = Convert.ToString(row["MalePopulation"]),
                        FemalePopulation = Convert.ToString(row["FemalePopulation"]),
                        OtherLocality = Convert.ToString(row["OtherLocality"]),
                        Climate = Convert.ToString(row["Climate"]),
                        RoadInfrastructure = Convert.ToString(row["RoadInfrastructure"]),
                        Organization_Type_Id = Convert.ToString(row["Organization_Type_Id"]),
                        Name = Convert.ToString(row["Name"]),
                        Person_Contat_Number = Convert.ToString(row["Person_Contat_Number"]),
                        Person_Contat_Email = Convert.ToString(row["Person_Contat_Email"])
                    });
                }
                _Con.Close();
                _Con.Dispose();
                da.Dispose();
                return UCProfile;
            }
        }

        //Get UC Staff
        public static List<UCStaffModel> Get_UCStaff(string UserID)
        {

            using (SqlCommand cmd_Get = new SqlCommand())
            {
                List<UCStaffModel> UCStaff = new List<UCStaffModel>();
                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_Get.Connection = _Con;
                _Con.Open();
                cmd_Get.CommandType = System.Data.CommandType.StoredProcedure;
                cmd_Get.CommandText = "SP_GetALLUCStaff";//Stored procedure name
                cmd_Get.Parameters.AddWithValue("@UserID", UserID);
                SqlDataAdapter da = new SqlDataAdapter(cmd_Get);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);
                dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    UCStaff.Add(new UCStaffModel
                    {
                        UC_Concil_StaffId = Convert.ToInt32(row["UC_Concil_StaffId"]),
                        US_StaffFirstName = Convert.ToString(row["US_StaffFirstName"]),
                        UC_StaffLastName = Convert.ToString(row["UC_StaffLastName"]),
                        UC_Staff_Category = Convert.ToString(row["UC_Staff_Category"]),
                        ContactNumber = Convert.ToString(row["ContactNumber"]),
                        EmailAddress = Convert.ToString(row["EmailAddress"]),
                        FaxNumber = Convert.ToString(row["FaxNumber"]),
                        OfficeAddress = Convert.ToString(row["OfficeAddress"])
                    });
                }
                _Con.Close();
                _Con.Dispose();
                da.Dispose();
                return UCStaff;
            }
        }

        //Get UC Staff By Staff ID
        public static List<UCStaffModel> Get_UCStaffByStaffID(string UserID, int UC_Concil_StaffId)
        {

            using (SqlCommand cmd_Get = new SqlCommand())
            {
                List<UCStaffModel> UCStaff = new List<UCStaffModel>();
                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_Get.Connection = _Con;
                _Con.Open();
                cmd_Get.CommandType = System.Data.CommandType.StoredProcedure;
                cmd_Get.CommandText = "SP_GetUCStaffByStaffID";//Stored procedure name
                cmd_Get.Parameters.AddWithValue("@UserID", UserID);
                cmd_Get.Parameters.AddWithValue("@UC_Concil_StaffId", UC_Concil_StaffId);
                SqlDataAdapter da = new SqlDataAdapter(cmd_Get);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);
                dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    UCStaff.Add(new UCStaffModel
                    {
                        UC_Concil_StaffId = Convert.ToInt32(row["UC_Concil_StaffId"]),
                        US_StaffFirstName = Convert.ToString(row["US_StaffFirstName"]),
                        UC_StaffLastName = Convert.ToString(row["UC_StaffLastName"]),
                        FatherName = Convert.ToString(row["FatherName"]),
                        CNIC = Convert.ToString(row["CNIC"]),
                        DOB = Convert.ToString(row["DOB"]),
                        BirthPlace = Convert.ToString(row["BirthPlace"]),
                        Gender = Convert.ToString(row["Gender"]),
                        Religion = Convert.ToString(row["Religion"]),
                        Address = Convert.ToString(row["Address"]),
                        Educated = Convert.ToBoolean(row["Educated"]),
                        LastDegree = Convert.ToString(row["LastDegree"]),
                        UC_Staff_Category = Convert.ToString(row["UC_Staff_Category"]),
                        StartingTerm = Convert.ToString(row["StartingTerm"]),
                        EndingTerm = Convert.ToString(row["EndingTerm"]),
                        ContactNumber = Convert.ToString(row["ContactNumber"]),
                        EmailAddress = Convert.ToString(row["EmailAddress"]),
                        FaxNumber = Convert.ToString(row["FaxNumber"]),
                        OfficeAddress = Convert.ToString(row["OfficeAddress"])
                    });
                }
                _Con.Close();
                _Con.Dispose();
                da.Dispose();
                return UCStaff;
            }
        }
        #endregion
    }

}
