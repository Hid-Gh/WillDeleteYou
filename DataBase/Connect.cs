using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dream_Hotel.DataBase
{
    class Connect
    {
        private static SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Test"].ConnectionString);

        static public SqlConnection Connection { get {return con; } }
    }
}
