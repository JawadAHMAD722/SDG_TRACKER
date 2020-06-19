using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace SDGSDB.Lib.DAL
{
    public class conn
    {
        public SqlConnection conect()
        {            
            string ConnectinString = ConfigurationManager.ConnectionStrings["SDGSEntities"].ConnectionString;
            SqlConnection _Con = new SqlConnection(ConnectinString);
            return _Con;
        }
    }
}
