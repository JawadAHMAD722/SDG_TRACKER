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
    public class TourismMethods
    {
        #region Post Method

        //Post UC Tourism Spot Insertion
        public static bool UCTourismSpot_Insertion(UCTourismSpotModel UCT, string UserID)
        {
            bool status;
            string TouristSpotName = UCT.TouristSpotName;
            int TouristSpotCategory = UCT.TouristSpotCategory;
            string Popularity = UCT.Popularity;
            string Address = UCT.Address;
            bool IsHotel = UCT.IsHotel;
            bool IsRestaurant = UCT.IsRestaurant;
            bool IsAccommodation = UCT.IsAccommodation;
            bool IsShop = UCT.IsShop;
            string TimeOpen = UCT.TimeOpen;
            string TimeClose = UCT.TimeClose;
            string Description = UCT.Description;
            DateTime CreaetdOn = DateTime.Now;
            string CreatedBy = UserID;
            bool ISActive = true;

            using (SqlCommand cmd_insertion = new SqlCommand())
            {
                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_insertion.Connection = _Con;
                _Con.Open();
                cmd_insertion.CommandType = CommandType.StoredProcedure;
                cmd_insertion.CommandText = "AddUCTourismSpot";//Stored procedure name
                cmd_insertion.Parameters.AddWithValue("@TouristSpotName", TouristSpotName);//(name in sp,modal attribute)
                cmd_insertion.Parameters.AddWithValue("@TouristSpotCategory", TouristSpotCategory);
                cmd_insertion.Parameters.AddWithValue("@Popularity", Popularity);
                cmd_insertion.Parameters.AddWithValue("@Address", Address);
                cmd_insertion.Parameters.AddWithValue("@IsHotel", IsHotel);
                cmd_insertion.Parameters.AddWithValue("@IsRestaurant", IsRestaurant);
                cmd_insertion.Parameters.AddWithValue("@IsAccommodation", IsAccommodation);
                cmd_insertion.Parameters.AddWithValue("@IsShop ", IsShop);
                cmd_insertion.Parameters.AddWithValue("@TimeOpen", TimeOpen);
                cmd_insertion.Parameters.AddWithValue("@TimeClose", TimeClose);
                cmd_insertion.Parameters.AddWithValue("@Description", Description);
                cmd_insertion.Parameters.AddWithValue("@UserID", UserID);
                cmd_insertion.Parameters.AddWithValue("@CreatedOn", CreaetdOn);
                cmd_insertion.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                cmd_insertion.Parameters.AddWithValue("@IsActive", ISActive);
                cmd_insertion.ExecuteNonQuery();
                status = true;
                _Con.Close();
                status = true;
            }
            return status;
        }
        //Post UC Tourism Spot Updation
        public static bool UCTourismSpot_Updation(UCTourismSpotModel UCT, string UserID,int TouristSpotId)
        {
            bool status;
            string TouristSpotName = UCT.TouristSpotName;
            int TouristSpotCategory = UCT.TouristSpotCategory;
            string Popularity = UCT.Popularity;
            string Address = UCT.Address;
            bool IsHotel = UCT.IsHotel;
            bool IsRestaurant = UCT.IsRestaurant;
            bool IsAccommodation = UCT.IsAccommodation;
            bool IsShop = UCT.IsShop;
            string TimeOpen = UCT.TimeOpen;
            string TimeClose = UCT.TimeClose;
            string Description = UCT.Description;
            DateTime UpdatedOn = DateTime.Now;
            string UpdatedBy = UserID;
            bool ISActive = true;
            bool Is_Deleted = false;

            using (SqlCommand cmd_insertion = new SqlCommand())
            {
                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_insertion.Connection = _Con;
                _Con.Open();
                cmd_insertion.CommandType = CommandType.StoredProcedure;
                cmd_insertion.CommandText = "Sp_Update_UCTourismSpot";//Stored procedure name
                cmd_insertion.Parameters.AddWithValue("@TouristSpotId ", TouristSpotId);//(name in sp,modal attribute)
                cmd_insertion.Parameters.AddWithValue("@TouristSpotName", TouristSpotName);
                cmd_insertion.Parameters.AddWithValue("@TouristSpotCategory", TouristSpotCategory);
                cmd_insertion.Parameters.AddWithValue("@Popularity", Popularity);
                cmd_insertion.Parameters.AddWithValue("@Address", Address);
                cmd_insertion.Parameters.AddWithValue("@IsHotel", IsHotel);
                cmd_insertion.Parameters.AddWithValue("@IsRestaurant", IsRestaurant);
                cmd_insertion.Parameters.AddWithValue("@IsAccommodation", IsAccommodation);
                cmd_insertion.Parameters.AddWithValue("@IsShop ", IsShop);
                cmd_insertion.Parameters.AddWithValue("@TimeOpen", TimeOpen);
                cmd_insertion.Parameters.AddWithValue("@TimeClose", TimeClose);
                cmd_insertion.Parameters.AddWithValue("@Description", Description);
                cmd_insertion.Parameters.AddWithValue("@UserID", UserID);
                cmd_insertion.Parameters.AddWithValue("@UpdatedOn", UpdatedOn);
                cmd_insertion.Parameters.AddWithValue("@UpdatedBy", UpdatedBy);
                cmd_insertion.Parameters.AddWithValue("@IsActive", ISActive);
                cmd_insertion.Parameters.AddWithValue("@Is_Deleted", Is_Deleted);
                cmd_insertion.ExecuteNonQuery();
                status = true;
                _Con.Close();
                status = true;
            }
            return status;
        }

        //Post UC Tourism Spot Updation
        public static bool UCTourismSpot_Deletion(string UserID, int TouristSpotId)
        {
            bool status;
            DateTime UpdatedOn = DateTime.Now;
            string UpdatedBy = UserID;
            bool ISActive = false;
            bool Is_Deleted = true;

            using (SqlCommand cmd_insertion = new SqlCommand())
            {
                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_insertion.Connection = _Con;
                _Con.Open();
                cmd_insertion.CommandType = CommandType.StoredProcedure;
                cmd_insertion.CommandText = "Sp_Delete_UCTourismSpot";//Stored procedure name
                cmd_insertion.Parameters.AddWithValue("@TouristSpotId ", TouristSpotId);//(name in sp,modal attribute)
                cmd_insertion.Parameters.AddWithValue("@UserID", UserID);
                cmd_insertion.Parameters.AddWithValue("@UpdatedOn", UpdatedOn);
                cmd_insertion.Parameters.AddWithValue("@UpdatedBy", UpdatedBy);
                cmd_insertion.Parameters.AddWithValue("@IsActive", ISActive);
                cmd_insertion.Parameters.AddWithValue("@Is_Deleted", Is_Deleted);
                cmd_insertion.ExecuteNonQuery();
                status = true;
                _Con.Close();
                status = true;
            }
            return status;
        }
        //Post UC Tourism Spot's Gallary Insertion
        public static bool UCTourismSpotGallary_Insertion(UCTourismSpotGallaryModel UCTSG, string UserID)
        {
            bool status;
            string SpotImage = (UCTSG.SpotImage).Remove(0, 12);
            int ToursimSpotId = UCTSG.ToursimSpotId;
            DateTime CreaetdOn = DateTime.Now;
            string CreatedBy = UserID;
            bool ISActive = true;
            bool IsDeleted = false;

            using (SqlCommand cmd_insertion = new SqlCommand())
            {
                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_insertion.Connection = _Con;
                _Con.Open();
                cmd_insertion.CommandType = CommandType.StoredProcedure;
                cmd_insertion.CommandText = "Sp_AddTourismSpotGallary";//Stored procedure name
                cmd_insertion.Parameters.AddWithValue("@SpotImage", SpotImage);//(name in sp,modal attribute)
                cmd_insertion.Parameters.AddWithValue("@ToursimSpotId", ToursimSpotId);
                cmd_insertion.Parameters.AddWithValue("@CreaetdOn", CreaetdOn);
                cmd_insertion.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                cmd_insertion.Parameters.AddWithValue("@ISActive", ISActive);
                cmd_insertion.Parameters.AddWithValue("@IsDeleted", IsDeleted);
                cmd_insertion.Parameters.AddWithValue("@UserID", UserID);
                cmd_insertion.ExecuteNonQuery();
                status = true;
                _Con.Close();
                status = true;
            }
            return status;
        }
        
        #endregion
        #region Get Methods
        //Get All UCTourismSpots
        public static List<UCTourismSpotModel> Get_AllTourismSpotByUC(string UserID)
        {

            using (SqlCommand cmd_Get = new SqlCommand())
            {
                List<UCTourismSpotModel> UCTS = new List<UCTourismSpotModel>();
                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_Get.Connection = _Con;
                _Con.Open();
                cmd_Get.CommandType = System.Data.CommandType.StoredProcedure;
                cmd_Get.CommandText = "SP_GetALLTourismSpotsByUcId";//Stored procedure name
                cmd_Get.Parameters.AddWithValue("@UserID", UserID);
                SqlDataAdapter da = new SqlDataAdapter(cmd_Get);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);
                dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    UCTS.Add(new UCTourismSpotModel
                    {
                        TouristSpotId = Convert.ToInt32(row["TouristSpotId"]),
                        TouristSpotName = Convert.ToString(row["TouristSpotName"]),
                        TouristSpotCategory = Convert.ToInt32(row["TouristSpotCategory"]),
                        Popularity = Convert.ToString(row["Popularity"]),
                        TimeOpen = (row["TimeOpen"].ToString()),
                        TimeClose = (row["TimeClose"].ToString()),
                        Address = Convert.ToString(row["Address"])
                    });
                }
                _Con.Close();
                _Con.Dispose();
                da.Dispose();
                return UCTS;
            }
        }

        //Get All UCTourismSpots
        public static List<UCTourismSpotModel> Get_TourismSpotByTourismSpot(string UserID , int TouristSpotId)
        {

            using (SqlCommand cmd_Get = new SqlCommand())
            {
                List<UCTourismSpotModel> UCTS = new List<UCTourismSpotModel>();
                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_Get.Connection = _Con;
                _Con.Open();
                cmd_Get.CommandType = System.Data.CommandType.StoredProcedure;
                cmd_Get.CommandText = "SP_GetALLTourismSpotsByTourismSpotID";//Stored procedure name
                cmd_Get.Parameters.AddWithValue("@UserID", UserID);
                cmd_Get.Parameters.AddWithValue("@TouristSpotId", TouristSpotId);
                SqlDataAdapter da = new SqlDataAdapter(cmd_Get);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);
                dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    UCTS.Add(new UCTourismSpotModel
                    {
                        TouristSpotId = Convert.ToInt32(row["TouristSpotId"]),
                        TouristSpotName = Convert.ToString(row["TouristSpotName"]),
                        TouristSpotCategory = Convert.ToInt32(row["TouristSpotCategory"]),
                        Popularity = Convert.ToString(row["Popularity"]),
                        Address = Convert.ToString(row["Address"]),
                        IsHotel = Convert.ToBoolean(row["IsHotel"]),
                        IsRestaurant = Convert.ToBoolean(row["IsRestaurant"]),
                        IsAccommodation = Convert.ToBoolean(row["IsAccommodation"]),
                        IsShop = Convert.ToBoolean(row["IsShop"]),
                        TimeOpen = (row["TimeOpen"].ToString()),
                        TimeClose = (row["TimeClose"].ToString()),
                        Description = Convert.ToString(row["Description"])
                    });
                }
                _Con.Close();
                _Con.Dispose();
                da.Dispose();
                return UCTS;
            }
        }

        //Get All Tourism Spots Gallary Image By UC
        public static List<UCTourismSpotGallaryModel> Get_AllTourismSpotGalleryByUC(string UserID)
        {

            using (SqlCommand cmd_Get = new SqlCommand())
            {
                List<UCTourismSpotGallaryModel> UCTSG = new List<UCTourismSpotGallaryModel>();
                conn c = new conn();
                SqlConnection _Con = c.conect();
                cmd_Get.Connection = _Con;
                _Con.Open();
                cmd_Get.CommandType = System.Data.CommandType.StoredProcedure;
                cmd_Get.CommandText = "SP_GetALLTourismSpotsGallaryByUcId";//Stored procedure name
                cmd_Get.Parameters.AddWithValue("@UserID", UserID);
                SqlDataAdapter da = new SqlDataAdapter(cmd_Get);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);
                dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    UCTSG.Add(new UCTourismSpotGallaryModel
                    {
                        TourismSpotGallaryId = Convert.ToInt32(row["TourismSpotGallaryId"]),
                        ToursimSpotId = Convert.ToInt32(row["ToursimSpotId"]),
                        SpotImage = Convert.ToString(row["SpotImage"])
                    });

                }
                _Con.Close();
                _Con.Dispose();
                da.Dispose();
                return UCTSG;
            }
        }
        //Get Organizatio by UC ORGID
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
        #endregion
    }

}
