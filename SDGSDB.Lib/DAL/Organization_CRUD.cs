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
    public class Organization_CRUD
    {
        //static SqlConnection _Con = null;
        SqlCommand _cmd = null;
        SqlDataReader rd = null;
        SqlTransaction _Transation;
        Organization_CRUD()
        {
            //  _Con = new SqlConnection(@"Data Source=.\\IBMS_DEVELOPER;SDGs=True;Initial Catalog=SmallBizDb_DevNew;Integrated Security=true");
        }
        public static int Organization_Insertion(Organization org)
        {

            int OrgID;
            bool status;
            int[] Result = new int[2];
            using (SqlCommand cmd_insertion = new SqlCommand())
            {
                //_Con = new SqlConnection(
                //    @"Data Source=(localdb)\IBMS_DEVLOPER;Initial Catalog=SDGS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_insertion.Connection = _Con;
                _Con.Open();
                cmd_insertion.CommandType = System.Data.CommandType.StoredProcedure;
                cmd_insertion.CommandText = "AddInitialOrganizationSP";
                cmd_insertion.Parameters.AddWithValue("@Organization_Name", org.Organization_Name);
                cmd_insertion.Parameters.AddWithValue("@Name", org.Name);
                cmd_insertion.Parameters.AddWithValue("@Contact_Number", org.Contact_Number);
                cmd_insertion.Parameters.AddWithValue("@Email_Id", org.Email_Id);
                cmd_insertion.Parameters.AddWithValue("@Organization_Type_Id", org.Organization_Type_Id);
                cmd_insertion.Parameters.AddWithValue("@Type_of_business", org.Type_of_business);
                cmd_insertion.Parameters.AddWithValue("@Planed_Activity", org.Planed_Activity);
                cmd_insertion.Parameters.AddWithValue("@Additional_Comments", org.Additional_Comments);
                cmd_insertion.Parameters.Add("@OrgOfficeID", SqlDbType.Int).Direction = ParameterDirection.Output;
                SqlParameter retreval = cmd_insertion.Parameters.Add("@org_id", SqlDbType.VarChar);
                retreval.Direction = ParameterDirection.ReturnValue;
                cmd_insertion.ExecuteNonQuery();
                OrgID = (int) cmd_insertion.Parameters["@org_id"].Value;
                int OfficeId = Convert.ToInt32(cmd_insertion.Parameters["@OrgOfficeID"].Value);
                _Con.Close();
                cmd_insertion.Parameters.Clear();
                Result[0] = OrgID;
                Result[1] = OfficeId;
                status = true;
            }
            return OrgID;
        }
        public static List<FetchOrg> Get_Pending_Organization_Data()
        {
           
            using (SqlCommand cmd_Get = new SqlCommand())
            {
                List<FetchOrg> Organization = new List<FetchOrg>();
                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_Get.Connection = _Con;
                _Con.Open();
                cmd_Get.CommandType = System.Data.CommandType.StoredProcedure;
                cmd_Get.CommandText = "FetchUnregisteredOrgData";//Stored procedure name

                SqlDataAdapter da = new SqlDataAdapter(cmd_Get);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);
                dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    Organization.Add(new FetchOrg
                    {
                        Organization_Id = Int32.Parse(row["Organization_id"].ToString()),
                        Office_Id = Int32.Parse(row["Office_Id"].ToString()),
                        Organization_Name = Convert.ToString(row["Organization_Name"]),
                        Email_Id = Convert.ToString(row["Email_Id"]),
                        Contact_Number = Convert.ToString(row["Contact_Number"])
                    });
                }
                _Con.Close();
                _Con.Dispose();
                da.Dispose();
                return Organization;
            }
        }
        public static List<FetchOrg> Get_Accepted_Organization_Data()
        {
            
            using (SqlCommand cmd_Get = new SqlCommand())
            {
                List<FetchOrg> Organization = new List<FetchOrg>();
                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_Get.Connection = _Con;
                _Con.Open();
                cmd_Get.CommandType = System.Data.CommandType.StoredProcedure;
                cmd_Get.CommandText = "FetchAcceptedOrgData";//Stored procedure name

                SqlDataAdapter da = new SqlDataAdapter(cmd_Get);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);
                dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    Organization.Add(new FetchOrg
                    {
                        Organization_Id = Int32.Parse(row["Organization_id"].ToString()),
                        Organization_Name = Convert.ToString(row["Organization_Name"]),
                        Email_Id = Convert.ToString(row["Email_Id"]),
                        Contact_Number = Convert.ToString(row["Contact_Number"])
                    });
                }
                _Con.Close();
                _Con.Dispose();
                da.Dispose();
                return Organization;
            }
        }
        public static List<FetchOrg> Get_Rejected_Organization_Data()
        {
            
            using (SqlCommand cmd_Get = new SqlCommand())
            {
                List<FetchOrg> Organization = new List<FetchOrg>();
                conn c = new conn();
                SqlConnection _Con = c.conect(); cmd_Get.Connection = _Con;
                _Con.Open();
                cmd_Get.CommandType = System.Data.CommandType.StoredProcedure;
                cmd_Get.CommandText = "FetchRejectedOrgData";//Stored procedure name

                SqlDataAdapter da = new SqlDataAdapter(cmd_Get);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);
                dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    Organization.Add(new FetchOrg
                    {
                        Organization_Id = Int32.Parse(row["Organization_id"].ToString()),
                        Organization_Name = Convert.ToString(row["Organization_Name"]),
                        Email_Id = Convert.ToString(row["Email_Id"]),
                        Contact_Number = Convert.ToString(row["Contact_Number"])
                    });
                }
                _Con.Close();
                _Con.Dispose();
                da.Dispose();
                return Organization;
            }
        }

        public static string FetchEmailForReg(int id)
        {
         
            using (SqlCommand cmd_Get_Email = new SqlCommand())
            {
                FetchPrimaryEmail Email = new FetchPrimaryEmail();
                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_Get_Email.Connection = _Con;
                _Con.Open();
                cmd_Get_Email.CommandType = System.Data.CommandType.StoredProcedure;
                
                cmd_Get_Email.CommandText = "FetchPrimaryEmail";//Stored procedure name
                cmd_Get_Email.Parameters.AddWithValue("@orgId", id); 
                SqlDataAdapter da = new SqlDataAdapter(cmd_Get_Email);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);
                dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    Email.Email_Id = row["Person_Contact_Email"].ToString();
                }
                _Con.Close();
                _Con.Dispose();
                da.Dispose();
                return Email.Email_Id;
            }
        }

        //Get Registered NGO's Emails
        public static List<GetRegisteredOrgEmailModel> Get_RegisterOrgEmails(int Organization_Id,int Office_Id)
        {
            
            using (SqlCommand cmd_Get = new SqlCommand())
            {
                List<GetRegisteredOrgEmailModel> Emails = new List<GetRegisteredOrgEmailModel>();
                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_Get.Connection = _Con;
                _Con.Open();
                cmd_Get.CommandType = System.Data.CommandType.StoredProcedure;
                cmd_Get.CommandText = "SP_GetRegisteredOrgEmails";//Stored procedure name
                cmd_Get.Parameters.AddWithValue("@Organization_Id", Organization_Id);
                cmd_Get.Parameters.AddWithValue("@Office_Id", Office_Id);
                SqlDataAdapter da = new SqlDataAdapter(cmd_Get);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);
                dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    Emails.Add(new GetRegisteredOrgEmailModel
                    {
                        Person_Contat_Email = Convert.ToString(row["Person_Contat_Email"])
                    });
                }
                _Con.Close();
                _Con.Dispose();
                da.Dispose();
                return Emails;
            }
        }


        public static bool Confirm_Email(string i)
        {
            byte[] bytes = Convert.FromBase64String(i);
            string str = Encoding.Default.GetString(bytes);
            int id = Int32.Parse(str);
            bool status = false;

            using (SqlCommand cmd_update= new SqlCommand())
            {
                conn c = new conn();
                SqlConnection _Con = c.conect();
                _Con.Open();
                cmd_update.Connection = _Con;
                cmd_update.CommandType= System.Data.CommandType.StoredProcedure;
                cmd_update.CommandText = "ConfirmEmail";
                cmd_update.Parameters.AddWithValue("@Organization_Id", id);
                cmd_update.ExecuteNonQuery();
                status = true;
                _Con.Close();
            }

            return status;
        }

        public static void ConfirmReg(Registration r)
        {
            using (SqlCommand update_status = new SqlCommand())
            {
                conn c = new conn();
                SqlConnection _Con = c.conect();
                _Con.Open();
                update_status.Connection = _Con;
                update_status.CommandType = System.Data.CommandType.StoredProcedure;
                update_status.CommandText = "RegistrationAccaptance";
                update_status.Parameters.AddWithValue("orgid", r.id);
                update_status.Parameters.AddWithValue("@status", r.status);
                update_status.ExecuteNonQuery();
                _Con.Close();
            }


        }
        

    }
   
}
