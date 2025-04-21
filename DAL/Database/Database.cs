using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;

namespace CHTL.DAL {
    public class Database {
        // TODO: Move connection string to appsettings.local.json
        private string connectionString = "Data Source=DESKTOP-OD1QLPU\\SQLEXPRESS;Initial Catalog=CuaHangTienLoi;User ID=sa;Password=ndc132;Encrypt=True;Trust Server Certificate=True";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
  
 } 