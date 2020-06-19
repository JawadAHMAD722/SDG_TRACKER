using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDGSDB.Models;

namespace SDGSDB.Lib.DAL
{
    public class Search
    {
        public static List<SDGs> Get_Sdg_by_org(string org_name)
        {

            using (SqlCommand cmd_Get = new SqlCommand())
            {
                List<SDGs> sdg = new List<SDGs>();
                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_Get.Connection = _Con;
                _Con.Open();
                cmd_Get.CommandType = System.Data.CommandType.StoredProcedure;
                cmd_Get.CommandText = "SP_GetSdgByOrg";//Stored procedure name
                cmd_Get.Parameters.AddWithValue("@org_name", org_name);
                SqlDataAdapter da = new SqlDataAdapter(cmd_Get);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);
                dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    sdg.Add(new SDGs
                    {
                        SDGS = row["SDG_Img"].ToString()
                    });
                }
                _Con.Close();
                _Con.Dispose();
                da.Dispose();
                return sdg;
            }
        }

        public static List<ORG> Get_org()
        {

            using (SqlCommand cmd_Get = new SqlCommand())
            {
                List<ORG> org = new List<ORG>();
                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_Get.Connection = _Con;
                _Con.Open();
                cmd_Get.CommandType = System.Data.CommandType.StoredProcedure;
                cmd_Get.CommandText = "SP_Get_org";//Stored procedure name
              
                SqlDataAdapter da = new SqlDataAdapter(cmd_Get);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);
                dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    org.Add(new ORG
                    {
                        Org = row["Organization_Name"].ToString()
                    });
                }
                _Con.Close();
                _Con.Dispose();
                da.Dispose();
                return org;
            }
        }
        public static List<ORG> Get_org_By_SDG(int id)
        {

            using (SqlCommand cmd_Get = new SqlCommand())
            {
                List<ORG> org = new List<ORG>();
                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_Get.Connection = _Con;
                _Con.Open();
                cmd_Get.CommandType = System.Data.CommandType.StoredProcedure;
                cmd_Get.CommandText = "SP_Get_Org_By_SDG";//Stored procedure name
                cmd_Get.Parameters.AddWithValue("@sdg_id", id);
                SqlDataAdapter da = new SqlDataAdapter(cmd_Get);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);
                dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    org.Add(new ORG
                    {
                        Org = row["Organization_Name"].ToString()
                    });
                }
                _Con.Close();
                _Con.Dispose();
                da.Dispose();
                return org;
            }
        }
    }
}
