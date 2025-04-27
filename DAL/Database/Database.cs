using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace CHTL.DAL {
    public class Database {
        public SqlConnection GetConnection()
        {
            return new SqlConnection(Configurations.GetValue("Database:ConnectionString"));
        }
    }
  
 } 