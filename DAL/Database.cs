using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;

namespace CHTL.DAL {
    public static class Database {
        public static SqlConnection GetLocalConnection() {
            return new SqlConnection("Data Source=(local);Initial Catalog=QuanLyDaoTaoSinhVien;Integrated Security=true;TrustServerCertificate=true;");
        }

        public static DataTable QueryTable(string query) {
            using (SqlConnection connection = GetLocalConnection()) {
                connection.Open();

                DataTable table = new DataTable();

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection)) {
                    adapter.Fill(table);
                }

                return table;
            }
        }
        
        public static DataTable QueryTable(string query, IReadOnlyDictionary<string, object> parameters) {
            using (SqlConnection connection = GetLocalConnection()) {
                connection.Open();

                DataTable table = new DataTable();

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection)) {
                    foreach (var parameter in parameters) {
                        adapter.SelectCommand.Parameters.AddWithValue(parameter.Key, parameter.Value);
                    }
                    
                    adapter.Fill(table);
                }

                return table;
            }
        }

        public static int ExecuteNonQuery(string query) {
            using (SqlConnection connection = GetLocalConnection()) {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection)) {
                    return command.ExecuteNonQuery();
                }
            }
        }
        
        public static int ExecuteNonQuery(string query, IReadOnlyDictionary<string, object> parameters) {
            using (SqlConnection connection = GetLocalConnection()) {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection)) {
                    foreach (var parameter in parameters) {
                        command.Parameters.AddWithValue(parameter.Key, parameter.Value);
                    }                    
                    
                    return command.ExecuteNonQuery();
                }
            }
        }
    }
}