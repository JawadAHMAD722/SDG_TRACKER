using System;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using SDGSDB;
using System.Web;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDGSDB.Models;
using SDGSDB.Controllers;

namespace SDGSDB.Lib.DAL
{
    public class Dashboard
    {
        #region Get Methods
        //Get Total Register NGO
        public static int Get_TotalRegNGO()
        {
            int Result = 0;
            using (SqlCommand cmd_Get = new SqlCommand())
            {
                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_Get.Connection = _Con;
                _Con.Open();
                cmd_Get.CommandType = System.Data.CommandType.StoredProcedure;
                cmd_Get.CommandText = "SP_GetTotalRegisterOrg";//Stored procedure name
                Result = (int) cmd_Get.ExecuteScalar();
                _Con.Close();
                return Result;
            }
        }
        //Get Total Registration Request
        public static int Get_TotalRegRequest()
        {
            int Result = 0;
            using (SqlCommand cmd_Get = new SqlCommand())
            {
                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_Get.Connection = _Con;
                _Con.Open();
                cmd_Get.CommandType = System.Data.CommandType.StoredProcedure;
                cmd_Get.CommandText = "SP_GetTotalRegisterRequest";//Stored procedure name
                Result = (int)cmd_Get.ExecuteScalar();
                _Con.Close();
                return Result;
            }
        }
        //Get Login Organization and Office Information
        public static List<LoginOrgAndOfficeInfoModel> Get_LoginOrgOfficeInfo(string UserID)
        {

            using (SqlCommand cmd_Get = new SqlCommand())
            {
                List<LoginOrgAndOfficeInfoModel> Login = new List<LoginOrgAndOfficeInfoModel>();
                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_Get.Connection = _Con;
                _Con.Open();
                cmd_Get.CommandType = System.Data.CommandType.StoredProcedure;
                cmd_Get.CommandText = "SP_GetOrgOfficeBYLoginID";//Stored procedure name
                cmd_Get.Parameters.AddWithValue("@UserID", UserID);
                SqlDataAdapter da = new SqlDataAdapter(cmd_Get);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);
                dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    Login.Add(new LoginOrgAndOfficeInfoModel
                    {
                        Organization_Name = Convert.ToString(row["Organization_Name"]),
                        Office_Name = Convert.ToString(row["Office_Name"]),
                        Logo_Image = Convert.ToString(row["Logo_Image"]),
                        Organization_Type_Id = Convert.ToString(row["Organization_Type_Id"]),
                        Type_of_Business = Convert.ToString(row["Type_of_Business"]),
                        Planed_Activity = Convert.ToString(row["Planed_Activity"]),
                        Additional_Comments = Convert.ToString(row["Additional_Comments"]),
                        Person_Contat_Email = Convert.ToString(row["Person_Contat_Email"])
                    });
                }
                _Con.Close();
                _Con.Dispose();
                da.Dispose();
                return Login;
            }
        }
        #endregion

    }
}
