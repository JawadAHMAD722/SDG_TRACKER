using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDGSDB.Lib.DAL;
using SDGSDB.Models;


namespace SDGSDB.Lib.Common
{
    public class DDL
    {
        public static List<ProvinceModel> Get_Province()
        {
            
            using (SqlCommand cmd_Get = new SqlCommand())
            {
                List<ProvinceModel> Province = new List<ProvinceModel>();
                conn c = new conn();
                SqlConnection _Con = c.conect();
           
              
                cmd_Get.Connection = _Con;
                _Con.Open();
                cmd_Get.CommandType = System.Data.CommandType.StoredProcedure;
                cmd_Get.CommandText = "SP_DDL_GetProvince";//Stored procedure name
                SqlDataAdapter da = new SqlDataAdapter(cmd_Get);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);
                dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    Province.Add(new ProvinceModel
                    {
                        Province_Id = Convert.ToString(row["Province_Id"]),
                        Province_Name = Convert.ToString(row["Province_Name"])
                    });
                }
                _Con.Close();
                _Con.Dispose();
                da.Dispose();
                return Province;
            }
        }
        //Tourism Spot
        public static List<DDLTourismSpotModel> Get_TourismSpot()
        {

            using (SqlCommand cmd_Get = new SqlCommand())
            {
                List<DDLTourismSpotModel> TouristSpot = new List<DDLTourismSpotModel>();
                conn c = new conn();
                SqlConnection _Con = c.conect();


                cmd_Get.Connection = _Con;
                _Con.Open();
                cmd_Get.CommandType = System.Data.CommandType.StoredProcedure;
                cmd_Get.CommandText = "SP_DDL_TourismSpots";//Stored procedure name
                SqlDataAdapter da = new SqlDataAdapter(cmd_Get);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);
                dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    TouristSpot.Add(new DDLTourismSpotModel
                    {
                        TouristSpotId = Convert.ToString(row["TouristSpotId"]),
                        TouristSpotName = Convert.ToString(row["TouristSpotName"])
                    });
                }
                _Con.Close();
                _Con.Dispose();
                da.Dispose();
                return TouristSpot;
            }
        }

        //Tourism Spot Categories
        public static List<DDLTourismSpotCatModel> Get_TourismSpotCategories()
        {

            using (SqlCommand cmd_Get = new SqlCommand())
            {
                List<DDLTourismSpotCatModel> TouristSpotCat = new List<DDLTourismSpotCatModel>();
                conn c = new conn();
                SqlConnection _Con = c.conect();


                cmd_Get.Connection = _Con;
                _Con.Open();
                cmd_Get.CommandType = System.Data.CommandType.StoredProcedure;
                cmd_Get.CommandText = "SP_DDL_TourismSpotsCatedories";//Stored procedure name
                SqlDataAdapter da = new SqlDataAdapter(cmd_Get);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);
                dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    TouristSpotCat.Add(new DDLTourismSpotCatModel
                    {
                        TourismSpotCatgId = Convert.ToInt32(row["TourismSpotCatgId"]),
                        TourismSportCategory = Convert.ToString(row["TourismSportCategory"])
                    });
                }
                _Con.Close();
                _Con.Dispose();
                da.Dispose();
                return TouristSpotCat;
            }
        }
        //Divisions DrpDown Binding
        public static List<DDLDivisionsModel> Get_Divisions(int Province_Id)
        {
            
            using (SqlCommand cmd_Get = new SqlCommand())
            {
                List<DDLDivisionsModel> Divisions = new List<DDLDivisionsModel>();
                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_Get.Connection = _Con;
                _Con.Open();
                cmd_Get.CommandType = System.Data.CommandType.StoredProcedure;
                cmd_Get.CommandText = "SP_DDL_GetDivisionsByID";//Stored procedure name
                cmd_Get.Parameters.AddWithValue("@Province_Id", Province_Id);
                SqlDataAdapter da = new SqlDataAdapter(cmd_Get);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);
                dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    Divisions.Add(new DDLDivisionsModel
                    {
                        Divison_Id = Convert.ToString(row["Divison_Id"]),
                        Division_Name = Convert.ToString(row["Division_Name"])
                    });
                }
                _Con.Close();
                _Con.Dispose();
                da.Dispose();
                return Divisions;
            }
        }

        //Districts DrpDown Binding
        public static List<DDLDistrictModel> Get_Districts(int Division_Id)
        {
            
            using (SqlCommand cmd_Get = new SqlCommand())
            {
                List<DDLDistrictModel> Districts = new List<DDLDistrictModel>();
                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_Get.Connection = _Con;
                _Con.Open();
                cmd_Get.CommandType = System.Data.CommandType.StoredProcedure;
                cmd_Get.CommandText = "SP_DDL_GetDistrictsByDivisionID";//Stored procedure name
                cmd_Get.Parameters.AddWithValue("@Division_Id", Division_Id);
                SqlDataAdapter da = new SqlDataAdapter(cmd_Get);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);
                dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    Districts.Add(new DDLDistrictModel
                    {
                        District_Id = Convert.ToString(row["District_Id"]),
                        District_Name = Convert.ToString(row["District_Name"])
                    });
                }
                _Con.Close();
                _Con.Dispose();
                da.Dispose();
                return Districts;
            }
        }

        //Tehsils DrpDown Binding
        public static List<DDLTehsilsModel> Get_Tehsils(int DistrictID)
        {

            using (SqlCommand cmd_Get = new SqlCommand())
            {
                List<DDLTehsilsModel> Tehsils = new List<DDLTehsilsModel>();
                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_Get.Connection = _Con;
                _Con.Open();
                cmd_Get.CommandType = System.Data.CommandType.StoredProcedure;
                cmd_Get.CommandText = "SP_DDL_GetTehsilsByDistrictID";//Stored procedure name
                cmd_Get.Parameters.AddWithValue("@District_Id", DistrictID);
                SqlDataAdapter da = new SqlDataAdapter(cmd_Get);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);
                dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    Tehsils.Add(new DDLTehsilsModel
                    {
                        Tehsil_Id = Convert.ToString(row["Tehsil_Id"]),
                        Tehsil_Name = Convert.ToString(row["Tehsil_Name"])
                    });
                }
                _Con.Close();
                _Con.Dispose();
                da.Dispose();
                return Tehsils;
            }
        }

        //Union Councils DrpDown Binding
        public static List<DDLUnionCouncilModel> Get_Union_Councils(int DistrictID)
        {

            using (SqlCommand cmd_Get = new SqlCommand())
            {
                List<DDLUnionCouncilModel> UnionCouncil = new List<DDLUnionCouncilModel>();
                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_Get.Connection = _Con;
                _Con.Open();
                cmd_Get.CommandType = System.Data.CommandType.StoredProcedure;
                cmd_Get.CommandText = "SP_DDL_GetUnion_CouncilsByDistrictID";//Stored procedure name
                cmd_Get.Parameters.AddWithValue("@District_Id", DistrictID);
                SqlDataAdapter da = new SqlDataAdapter(cmd_Get);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);
                dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    UnionCouncil.Add(new DDLUnionCouncilModel
                    {
                        UC_Id = Convert.ToString(row["UC_Id"]),
                        UC_Name = Convert.ToString(row["UC_Name"])
                    });
                }
                _Con.Close();
                _Con.Dispose();
                da.Dispose();
                return UnionCouncil;
            }
        }

        //Organization_Type DropDown Binding
        public static List<DDLOrganizationTypeModel> GetOrganization_Types()
        {
            using (SqlCommand cmd_Get = new SqlCommand())
            {
              
                List<DDLOrganizationTypeModel> OrganizationType = new List<DDLOrganizationTypeModel>();
                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_Get.Connection = _Con;
                _Con.Open();
                cmd_Get.CommandType = System.Data.CommandType.StoredProcedure;
                cmd_Get.CommandText = "SP_DDL_GetOrganization_Types";//Stored procedure name
                SqlDataAdapter da = new SqlDataAdapter(cmd_Get);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);
                dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    OrganizationType.Add(new DDLOrganizationTypeModel
                    {
                        Organization_Type_Id = Convert.ToInt32(row["Organization_Type_Id"]),
                        Organization_Type = Convert.ToString(row["Organization_Type"])
                    });
                }
                _Con.Close();
                _Con.Dispose();
                da.Dispose();
                return OrganizationType;
            }
        }

        //SDGS DropdownList Binding
        public static List<DDLSDGModel> Get_SDGS()
        {
            
            using (SqlCommand cmd_Get = new SqlCommand())
            {
                List<DDLSDGModel> SDG = new List<DDLSDGModel>();
                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_Get.Connection = _Con;
                _Con.Open();
                cmd_Get.CommandType = System.Data.CommandType.StoredProcedure;
                cmd_Get.CommandText = "SP_DDL_GetSDGS";//Stored procedure name
                SqlDataAdapter da = new SqlDataAdapter(cmd_Get);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);
                dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    SDG.Add(new DDLSDGModel
                    {
                        SDG_Id = Convert.ToString(row["SDG_Id"]),
                        SDG_Name = Convert.ToString(row["SDG_Name"])
                    });
                }
                _Con.Close();
                _Con.Dispose();
                da.Dispose();
                return SDG;
            }
        }

        //Targets DropdownList Binding
        public static List<DDLTargetModel> Get_Targets(int SDG_Id)
        {
            
            using (SqlCommand cmd_Get = new SqlCommand())
            {
                List<DDLTargetModel> Targets = new List<DDLTargetModel>();
                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_Get.Connection = _Con;
                _Con.Open();
                cmd_Get.CommandType = System.Data.CommandType.StoredProcedure;
                cmd_Get.CommandText = "SP_DDL_GetTargetBySDGID";//Stored procedure name
                cmd_Get.Parameters.AddWithValue("@SDG_Id", SDG_Id);
                SqlDataAdapter da = new SqlDataAdapter(cmd_Get);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);
                dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    Targets.Add(new DDLTargetModel
                    {
                        Target_Id = Convert.ToString(row["Target_Id"]),
                        Target_Name = Convert.ToString(row["Target_Name"])
                    });
                }
                _Con.Close();
                _Con.Dispose();
                da.Dispose();
                return Targets;
            }
        }

        //Indicators DropdownList Binding
        public static List<DDLIndicatorsModel> Get_Indicators(int Target_Id)
        {
            
            using (SqlCommand cmd_Get = new SqlCommand())
            {
                List<DDLIndicatorsModel> Indicators = new List<DDLIndicatorsModel>();
                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_Get.Connection = _Con;
                _Con.Open();
                cmd_Get.CommandType = System.Data.CommandType.StoredProcedure;
                cmd_Get.CommandText = "SP_DDL_GetIndicatorByTargetID";//Stored procedure name
                cmd_Get.Parameters.AddWithValue("@Target_Id", Target_Id);
                SqlDataAdapter da = new SqlDataAdapter(cmd_Get);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);
                dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    Indicators.Add(new DDLIndicatorsModel
                    {
                        Indicator_Id = Convert.ToString(row["Indicator_Id"]),
                        Indicator_Name = Convert.ToString(row["Indicator_Name"])
                    });
                }
                _Con.Close();
                _Con.Dispose();
                da.Dispose();
                return Indicators;
            }
        }
        //DDL Sectors
        public static List<DDLSectorsModel> Get_Sectors()
        {

            using (SqlCommand cmd_Get = new SqlCommand())
            {
                List<DDLSectorsModel> Sectors = new List<DDLSectorsModel>();
                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_Get.Connection = _Con;
                _Con.Open();
                cmd_Get.CommandType = System.Data.CommandType.StoredProcedure;
                cmd_Get.CommandText = "SP_DDL_GetSectors";//Stored procedure name
                SqlDataAdapter da = new SqlDataAdapter(cmd_Get);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);
                dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    Sectors.Add(new DDLSectorsModel
                    {
                        Sector_ID = Convert.ToString(row["Sector_ID"]),
                        SectorName = Convert.ToString(row["SectorName"])
                    });
                }
                _Con.Close();
                _Con.Dispose();
                da.Dispose();
                return Sectors;
            }
        }
        //Sectors Category DrpDown Binding
        public static List<DDLSectorsCategoryModel> Get_SectorsCategoryBySectors(int Sector_ID)
        {

            using (SqlCommand cmd_Get = new SqlCommand())
            {
                List<DDLSectorsCategoryModel> Divisions = new List<DDLSectorsCategoryModel>();
                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_Get.Connection = _Con;
                _Con.Open();
                cmd_Get.CommandType = System.Data.CommandType.StoredProcedure;
                cmd_Get.CommandText = "SP_DDL_GetSectorCategoryBySectorID";//Stored procedure name
                cmd_Get.Parameters.AddWithValue("@Sector_ID", Sector_ID);
                SqlDataAdapter da = new SqlDataAdapter(cmd_Get);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);
                dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    Divisions.Add(new DDLSectorsCategoryModel
                    {
                        Sector_Category_Id = Convert.ToString(row["Sector_Category_Id"]),
                        Category_Name = Convert.ToString(row["Category_Name"])
                    });
                }
                _Con.Close();
                _Con.Dispose();
                da.Dispose();
                return Divisions;
            }
        }
    }
}
