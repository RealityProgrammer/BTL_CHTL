using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;

namespace CHTL.DAL {
    public class Database {
        private string connectionString = "Data Source=(local);Initial Catalog=CuaHangTienLoi;Integrated Security=true;Trust Server Certificate=true";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
  
 } 