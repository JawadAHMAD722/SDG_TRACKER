using SDGSDB.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Configuration;

namespace SDGSDB
{
    public class WebRoleProvider : RoleProvider
    {
        public override string ApplicationName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public override string[] GetRolesForUser(string username)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                string ConnectinString = ConfigurationManager.ConnectionStrings["SDGSEntities"].ConnectionString;
                SqlConnection _Con = new SqlConnection(ConnectinString);
                SqlParameter SQP = new SqlParameter("@returnVal", SqlDbType.NVarChar);
                SqlParameter SQP2 = new SqlParameter("@UserRole", SqlDbType.NVarChar);
                cmd.Connection = _Con;
                _Con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_GetRoleForUser";//Stored procedure name
                cmd.Parameters.AddWithValue("@UserName", username);//(name in sp,modal attribute)
                SQP.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(SQP);
                cmd.ExecuteNonQuery();
                //status = true;
                _Con.Close();
                cmd.Parameters.Clear();
                string UserRoles = Convert.ToString(SQP.Value);
                string[] str = {UserRoles};
                return (str);
            }
            
            //string[] str = { "a", "b" };
            //return (str);
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool IsUserInRole(string username, string roleName)
        {
            throw new NotImplementedException();
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}