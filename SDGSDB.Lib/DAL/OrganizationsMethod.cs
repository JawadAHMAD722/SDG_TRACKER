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
    public class OrganizationsMethod
    {
        //Get Organization Profile detail
        public static List<OrganizationProfileModel> Get_Org_Profile(string UserID)
        {

            using (SqlCommand cmd_Get = new SqlCommand())
            {
                List<OrganizationProfileModel> Profile = new List<OrganizationProfileModel>();
                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_Get.Connection = _Con;
                _Con.Open();
                cmd_Get.CommandType = System.Data.CommandType.StoredProcedure;
                cmd_Get.CommandText = "SP_GetOrgDetailGrid";//Stored procedure name
                cmd_Get.Parameters.AddWithValue("@UserID", UserID);
                SqlDataAdapter da = new SqlDataAdapter(cmd_Get);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                DataTable dt1 = new DataTable();
                DataTable dt2 = new DataTable();
                da.Fill(ds);
                dt = ds.Tables[0];
                dt1 = ds.Tables[1];
                dt2 = ds.Tables[2];
                
                foreach (DataRow row in dt.Rows)
                {
                    foreach (DataRow row1 in dt1.Rows)
                    {
                        foreach (DataRow row2 in dt2.Rows)
                        {
                            Profile.Add(new OrganizationProfileModel
                            {
                                Organization_Name = Convert.ToString(row["Organization_Name"]),
                                Office_Name = Convert.ToString(row["Office_Name"]),
                                Registeration_Date = Convert.ToString(row["Registeration_Date"]),
                                Person_Contact_Name = Convert.ToString(row["Person_Contact_Name"]),
                                Organization_Type_Id = Convert.ToString(row["Organization_Type_Id"]),
                                Registeration_Authority = Convert.ToString(row["Registeration_Authority"]),
                                LicenseNo = Convert.ToString(row["LicenseNo"]),
                                CompanyCategory = Convert.ToString(row["CompanyCategory"]),
                                Province_Id = Convert.ToString(row["Province_Id"]),
                                Division_Id = Convert.ToString(row["Division_Id"]),
                                District_Id = Convert.ToString(row["District_Id"]),
                                Person_Contact_Title = Convert.ToString(row["Person_Contact_Title"]),
                                Person_Contact_Number = Convert.ToString(row["Person_Contact_Number"]),
                                Person_Contact_Email = Convert.ToString(row["Person_Contact_Email"]),
                                Type_of_Business = Convert.ToString(row["Type_of_Business"]),
                                Planed_Activity = Convert.ToString(row["Planed_Activity"]),
                                Additional_Comments = Convert.ToString(row["Additional_Comments"]),
                                Logo_Image = Convert.ToString(row["Logo_Image"]),
                                Province_Name = Convert.ToString(row["Province_Name"]),
                                Division_Name = Convert.ToString(row["Division_Name"]),
                                District_Name = Convert.ToString(row["District_Name"]),
                                Street = Convert.ToString(row["Street"]),
                                House = Convert.ToString(row["House"]),
                                PostalCode = Convert.ToString(row["PostalCode"]),
                                SDG_Id = Convert.ToString(row1["SDG_Id"]).Split(','),
                                Total_Offices = Convert.ToInt32(row2["Total_Offices"])
                            });
                        }
                    }
                    

                }
                _Con.Close();
                _Con.Dispose();
                da.Dispose();
                return Profile;
            }
        }
        //Get All Employee
        public static List<EmployeeModel> Get_AllEmployee(string UserID)
        {

            using (SqlCommand cmd_Get = new SqlCommand())
            {
                List<EmployeeModel> Org = new List<EmployeeModel>();
                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_Get.Connection = _Con;
                _Con.Open();
                cmd_Get.CommandType = System.Data.CommandType.StoredProcedure;
                cmd_Get.CommandText = "SP_GetALLEmployees";//Stored procedure name
                cmd_Get.Parameters.AddWithValue("@UserID", UserID);
                SqlDataAdapter da = new SqlDataAdapter(cmd_Get);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);
                dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    Org.Add(new EmployeeModel
                    {
                        EmpID = Convert.ToInt32(row["Employee_Id"]),
                        OfficeID = Convert.ToInt32(row["Office_Id"]),
                        OrganizationID = Convert.ToInt32(row["Organization_Id"]),
                        Name = Convert.ToString(row["Name"]),
                        Designation = Convert.ToString(row["Designation"]),
                        Joining_Date = Convert.ToString(row["Joining_Date"]),
                        Person_Contat_Email = Convert.ToString(row["Email_Id"]),
                        Contact_Number = Convert.ToString(row["Contact_Number"])
                    });

                }
                _Con.Close();
                _Con.Dispose();
                da.Dispose();
                return Org;
            }
        }
        public static List<GridGetAllRegisteredOrg> Get_AllRegisteredOrg()
        {

            using (SqlCommand cmd_Get = new SqlCommand())
            {
                List<GridGetAllRegisteredOrg> Org = new List<GridGetAllRegisteredOrg>();
                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_Get.Connection = _Con;
                _Con.Open();
                cmd_Get.CommandType = System.Data.CommandType.StoredProcedure;
                cmd_Get.CommandText = "SP_GetALLRegisteredNGOS";//Stored procedure name
                SqlDataAdapter da = new SqlDataAdapter(cmd_Get);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);
                dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    Org.Add(new GridGetAllRegisteredOrg
                    {
                        Organization_Id = Convert.ToString(row["Organization_Id"]),
                        Office_Id = Convert.ToString(row["Office_Id"]),
                        Organization_Name = Convert.ToString(row["Organization_Name"]),
                        Organization_Type_Id = Convert.ToString(row["Organization_Type_Id"]),
                        Address = Convert.ToString(row["Address"])
                    });

                }
                _Con.Close();
                _Con.Dispose();
                da.Dispose();
                return Org;
            }
        }
        //Get Org Profile By ID
        //Get Organization Profile detail
        public static List<OrganizationProfileModel> Get_Org_ProfileByID(int OrgID, int OfficeID)
        {

            using (SqlCommand cmd_Get = new SqlCommand())
            {
                List<OrganizationProfileModel> Profile = new List<OrganizationProfileModel>();
                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_Get.Connection = _Con;
                _Con.Open();
                cmd_Get.CommandType = System.Data.CommandType.StoredProcedure;
                cmd_Get.CommandText = "SP_GetOrgProfileByID";//Stored procedure name
                cmd_Get.Parameters.AddWithValue("@Organization_Id", OrgID);
                cmd_Get.Parameters.AddWithValue("@Office_Id", OfficeID);
                SqlDataAdapter da = new SqlDataAdapter(cmd_Get);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                DataTable dt1 = new DataTable();
                DataTable dt2 = new DataTable();
                da.Fill(ds);
                dt = ds.Tables[0];
                dt1 = ds.Tables[1];
                dt2 = ds.Tables[2];

                foreach (DataRow row in dt.Rows)
                {
                    foreach (DataRow row1 in dt1.Rows)
                    {
                        foreach (DataRow row2 in dt2.Rows)
                        {
                            Profile.Add(new OrganizationProfileModel
                            {
                                Organization_Name = Convert.ToString(row["Organization_Name"]),
                                Office_Name = Convert.ToString(row["Office_Name"]),
                                Registeration_Date = Convert.ToString(row["Registeration_Date"]),
                                Person_Contact_Name = Convert.ToString(row["Person_Contact_Name"]),
                                Organization_Type_Id = Convert.ToString(row["Organization_Type_Id"]),
                                Registeration_Authority = Convert.ToString(row["Registeration_Authority"]),
                                LicenseNo = Convert.ToString(row["LicenseNo"]),
                                CompanyCategory = Convert.ToString(row["CompanyCategory"]),
                                Province_Id = Convert.ToString(row["Province_Id"]),
                                Division_Id = Convert.ToString(row["Division_Id"]),
                                District_Id = Convert.ToString(row["District_Id"]),
                                Person_Contact_Title = Convert.ToString(row["Person_Contact_Title"]),
                                Person_Contact_Number = Convert.ToString(row["Person_Contact_Number"]),
                                Person_Contact_Email = Convert.ToString(row["Person_Contact_Email"]),
                                Type_of_Business = Convert.ToString(row["Type_of_Business"]),
                                Planed_Activity = Convert.ToString(row["Planed_Activity"]),
                                Additional_Comments = Convert.ToString(row["Additional_Comments"]),
                                Logo_Image = Convert.ToString(row["Logo_Image"]),
                                Province_Name = Convert.ToString(row["Province_Name"]),
                                Division_Name = Convert.ToString(row["Division_Name"]),
                                District_Name = Convert.ToString(row["District_Name"]),
                                Street = Convert.ToString(row["Street"]),
                                House = Convert.ToString(row["House"]),
                                PostalCode = Convert.ToString(row["PostalCode"]),
                                SDG_Id = Convert.ToString(row1["SDG_Id"]).Split(','),
                                Total_Offices = Convert.ToInt32(row2["Total_Offices"])
                            });
                        }
                    }


                }
                _Con.Close();
                _Con.Dispose();
                da.Dispose();
                return Profile;
            }
        }
        #region Post Method
        public static bool Add_Employee(EmployeeModel Emp, string UserID)
        {
            bool status;
            string EmpName = Emp.Name;

            string FatherHusbandName = Emp.FatherHusbandName;
            string Gender = Emp.Gender;
            string Nationality = Emp.Nationality;
            string DOB = Emp.DOB;
            string BirthPlac = Emp.BirthPlace;
            string CNIC = Emp.CNIC;
            string MaritialStatus = Emp.MaritialStatus;
            string Height = Emp.Height;
            string BloodGroup = Emp.BloodGroup;
            string IdentificationMark = Emp.IdentificationMark;
            string Religion = Emp.Religion;
            string Qualification = Emp.Qualification;
            string Joining_Date = Emp.Joining_Date;
            string Designation = Emp.Designation;
            string SectionId = Emp.SectionId;
            string Person_Contat_Email = Emp.Person_Contat_Email;
            string Contact_Number = Emp.Contact_Number;
            string TemporaryAddress = Emp.TemporaryAddress;
            string PerminantAddress = Emp.PerminantAddress;
            //string Position = Emp.BomItems.Position;
            //string OrganizationName = Emp.BomItems.OrganizationName;
            //string FromDate = Emp.BomItems.FromDate;
            //string ToDate = Emp.ToDate;
            string Is_terminated = Emp.Is_terminated;
            string TerminatingDate = Emp.TerminatingDate;
            string Reason = Emp.Reason;
            string Note = Emp.Note;
            DateTime CreaetdOn = DateTime.Now;
            string CreatedBy = UserID;

            DateTime DateOfBirth = new DateTime();
            DateTime.TryParse(DOB, new CultureInfo("en-GB", true), DateTimeStyles.None, out DateOfBirth);

            DateTime DateOfJoining = new DateTime();
            DateTime.TryParse(DOB, new CultureInfo("en-GB", true), DateTimeStyles.None, out DateOfJoining);
            // var st1 = dtydt5.ToString("dd/MM/yyyy hh:mm:ss tt");
            using (SqlCommand cmd_insertion = new SqlCommand())
            {
                conn c = new conn();
                SqlConnection _Con = c.conect();
                SqlParameter SQP = new SqlParameter("@returnVal", SqlDbType.Int);
                cmd_insertion.Connection = _Con;
                _Con.Open();
                cmd_insertion.CommandType = CommandType.StoredProcedure;
                cmd_insertion.CommandText = "AddEmployee";//Stored procedure name
                cmd_insertion.Parameters.AddWithValue("@Name", EmpName);//(name in sp,modal attribute)
                cmd_insertion.Parameters.AddWithValue("@FatherHusbandName", FatherHusbandName);
                cmd_insertion.Parameters.AddWithValue("@Gender", Gender);
                cmd_insertion.Parameters.AddWithValue("@DOB", DOB);
                cmd_insertion.Parameters.AddWithValue("@Nationality", Nationality);
                cmd_insertion.Parameters.AddWithValue("@BirthPlace", BirthPlac);
                cmd_insertion.Parameters.AddWithValue("@CNIC", CNIC);
                cmd_insertion.Parameters.AddWithValue("@MaritialStatus", MaritialStatus);
                cmd_insertion.Parameters.AddWithValue("@Height", Height);
                cmd_insertion.Parameters.AddWithValue("@BloodGroup", BloodGroup);
                cmd_insertion.Parameters.AddWithValue("@IdentificationMark", IdentificationMark);
                cmd_insertion.Parameters.AddWithValue("@Religion", Religion);
                cmd_insertion.Parameters.AddWithValue("@Qualification", Qualification);
                cmd_insertion.Parameters.AddWithValue("@Joining_Date", Joining_Date);
                cmd_insertion.Parameters.AddWithValue("@Designation", Designation);
                cmd_insertion.Parameters.AddWithValue("@SectionId", SectionId);
                cmd_insertion.Parameters.AddWithValue("@Person_Contat_Email", Person_Contat_Email);
                cmd_insertion.Parameters.AddWithValue("@Contact_Number", Contact_Number);
                cmd_insertion.Parameters.AddWithValue("@TemporaryAddress", TemporaryAddress);
                cmd_insertion.Parameters.AddWithValue("@PerminantAddress", PerminantAddress);
                cmd_insertion.Parameters.AddWithValue("@Is_terminated", Is_terminated);
                cmd_insertion.Parameters.AddWithValue("@TerminatingDate", TerminatingDate=="" ? (object)DBNull.Value : TerminatingDate);
                cmd_insertion.Parameters.AddWithValue("@Reason", Reason);
                cmd_insertion.Parameters.AddWithValue("@Note", Note);
                cmd_insertion.Parameters.AddWithValue("@CreaetdOn", CreaetdOn);
                cmd_insertion.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                cmd_insertion.Parameters.AddWithValue("@UserID", UserID);
                SQP.Direction = ParameterDirection.ReturnValue;
                cmd_insertion.Parameters.Add(SQP);
                cmd_insertion.ExecuteNonQuery();
                status = true;
                _Con.Close();
                cmd_insertion.Parameters.Clear();
                int EmployeeID = Convert.ToInt32(SQP.Value);
                foreach (var item in Emp.BomItems)
                {
                    if (item != null && item.Position != "" && item.OrganizationName != "" && item.FromDate != "" && item.ToDate != "")
                    {
                        _Con.Open();
                        cmd_insertion.CommandType = CommandType.StoredProcedure;
                        cmd_insertion.CommandText = "Sp_Add_Experience";//Stored procedure name
                        cmd_insertion.Parameters.AddWithValue("@Position", item.Position);//(name in sp,modal attribute)
                        cmd_insertion.Parameters.AddWithValue("@OrganizationName", item.OrganizationName);
                        cmd_insertion.Parameters.AddWithValue("@FromDate", item.FromDate);
                        cmd_insertion.Parameters.AddWithValue("@ToDate", item.ToDate);
                        cmd_insertion.Parameters.AddWithValue("@CreaetdOn", CreaetdOn);
                        cmd_insertion.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                        cmd_insertion.Parameters.AddWithValue("@UserID", UserID);
                        cmd_insertion.Parameters.AddWithValue("@EmployeeId", EmployeeID);

                        cmd_insertion.ExecuteNonQuery();
                        status = true;
                        _Con.Close();
                        cmd_insertion.Parameters.Clear();
                    }
                }
            }
            return status;
        }
        #endregion
    }
}
