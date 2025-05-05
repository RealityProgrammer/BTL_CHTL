using Microsoft.Data.SqlClient;

namespace CHTL.DAL {
    public class Database {
        public SqlConnection GetConnection() => new SqlConnection(Configurations.GetValue("Database:ConnectionString"));
    }
}