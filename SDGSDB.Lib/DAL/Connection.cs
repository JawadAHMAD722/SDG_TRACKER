using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDGSDB.Lib.DAL
{
   public class Connection
    {
        public SqlConnection conn()
        {
            SqlConnection _Con = new SqlConnection(@"Data Source=JAWAD-PC;Initial Catalog=SDGS;Integrated Security=true;");
            return _Con;
        }
     
      
    }
}
