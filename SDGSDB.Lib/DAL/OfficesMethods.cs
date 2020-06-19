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
    public class OfficesMethod
    {
        
        //Get All Offices By ORG
        public static List<GridGetAllRegisteredOfficesByOrg> Get_AllRegisteredOfficesByOrg(int OrgID)
        {

            using (SqlCommand cmd_Get = new SqlCommand())
            {
                List<GridGetAllRegisteredOfficesByOrg> Offices = new List<GridGetAllRegisteredOfficesByOrg>();
                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_Get.Connection = _Con;
                _Con.Open();
                cmd_Get.CommandType = System.Data.CommandType.StoredProcedure;
                cmd_Get.CommandText = "SP_GetALLRegisteredOfficesByNGO";//Stored procedure name
                cmd_Get.Parameters.AddWithValue("@Organization_Id", OrgID);
                SqlDataAdapter da = new SqlDataAdapter(cmd_Get);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);
                dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    Offices.Add(new GridGetAllRegisteredOfficesByOrg
                   {
                       Organization_Id = Convert.ToString(row["Organization_Id"]),
                       Office_Id = Convert.ToString(row["Office_Id"]),
                       Organization_Name = Convert.ToString(row["Organization_Name"]),
                       HeadOffice_Name = Convert.ToString(row["HeadOffice_Name"]),
                       Address = Convert.ToString(row["Address"])
                   });

                }
                _Con.Close();
                _Con.Dispose();
                da.Dispose();
                return Offices;
            }
        }
        
    }
}
