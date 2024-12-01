using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCaro2
{
    public class Db
    {
        private string connectionString = "Server=localhost\\sqlexpress;Database=GameCaro;Trusted_Connection=True;";
        public SqlConnection con;
        public Db() {
            con = new SqlConnection(connectionString);
        }
    }
}
