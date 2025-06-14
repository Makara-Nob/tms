using System;
using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;

namespace tms.Data
{
    public class DatabaseHelper : IDisposable
    {
        private static string _connectionString;
        private SqlConnection _connection;

        static DatabaseHelper()
        {
            // Try to get connection string from configuration first
            _connectionString = ConfigurationManager.ConnectionStrings["RouteManagementSystem"]?.ConnectionString;

            // Fallback to hardcoded connection string if not found in config
            if (string.IsNullOrEmpty(_connectionString))
            {
                _connectionString = @"Server=FURINA-SIMP\SQLEXPRESS02;Database=RouteManagementSystem;User Id=sa;Password=Chinsakda@3;Encrypt=true;TrustServerCertificate=True;";
            }
        }

        public static string ConnectionString
        {
            get => _connectionString;
            set => _connectionString = value;
        }

        public SqlConnection GetConnection()
        {
            if (_connection == null)
            {
                _connection = new SqlConnection(_connectionString);
            }
            return _connection;
        }

        public static DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.Text;

                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    using (var adapter = new SqlDataAdapter(command))
                    {
                        var dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        public static DataTable ExecuteStoredProcedure(string procedureName, SqlParameter[] parameters = null)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(procedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    using (var adapter = new SqlDataAdapter(command))
                    {
                        var dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        public static int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.Text;

                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    return command.ExecuteNonQuery();
                }
            }
        }

        public static int ExecuteStoredProcedureNonQuery(string procedureName, SqlParameter[] parameters = null)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(procedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    return command.ExecuteNonQuery();
                }
            }
        }

        public object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.Text;

                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    return command.ExecuteScalar();
                }
            }
        }

        public void Dispose()
        {
            if (_connection != null)
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();

                _connection.Dispose();
                _connection = null;
            }
        }

        // Vehicle-specific methods using stored procedures
        public string AddVehicle(string vehicleID, string type, int capacity, string licensePlate,
                                string routeID = null, string status = "Active", DateTime? maintenanceDate = null)
        {
            var parameters = new[]
            {
                new SqlParameter("@VehicleID", SqlDbType.NVarChar, 50) { Value = vehicleID },
                new SqlParameter("@Type", SqlDbType.NVarChar, 100) { Value = type },
                new SqlParameter("@Capacity", SqlDbType.Int) { Value = capacity },
                new SqlParameter("@LicensePlate", SqlDbType.NVarChar, 20) { Value = licensePlate },
                new SqlParameter("@RouteID", SqlDbType.NVarChar, 50) { Value = (object)routeID ?? DBNull.Value },
                new SqlParameter("@Status", SqlDbType.NVarChar, 50) { Value = status },
                new SqlParameter("@MaintenanceDate", SqlDbType.Date) { Value = (object)maintenanceDate ?? DBNull.Value }
            };

            var result = ExecuteStoredProcedure("spAddVehicle", parameters);
            return result.Rows.Count > 0 ? result.Rows[0]["NewVehicleId"].ToString() : vehicleID;
        }

        public DataTable GetAllVehicles()
        {
            return ExecuteStoredProcedure("spGetAllVehicles");
        }

        public int UpdateVehicle(string vehicleID, string type, int capacity, string licensePlate,
                                string routeID = null, string status = "Active", DateTime? maintenanceDate = null)
        {
            var parameters = new[]
            {
                new SqlParameter("@VehicleID", SqlDbType.NVarChar, 50) { Value = vehicleID },
                new SqlParameter("@Type", SqlDbType.NVarChar, 100) { Value = type },
                new SqlParameter("@Capacity", SqlDbType.Int) { Value = capacity },
                new SqlParameter("@LicensePlate", SqlDbType.NVarChar, 20) { Value = licensePlate },
                new SqlParameter("@RouteID", SqlDbType.NVarChar, 50) { Value = (object)routeID ?? DBNull.Value },
                new SqlParameter("@Status", SqlDbType.NVarChar, 50) { Value = status },
                new SqlParameter("@MaintenanceDate", SqlDbType.Date) { Value = (object)maintenanceDate ?? DBNull.Value }
            };

            var result = ExecuteStoredProcedure("spUpdateVehicle", parameters);
            return result.Rows.Count > 0 ? Convert.ToInt32(result.Rows[0]["RowsAffected"]) : 0;
        }

        public int DeleteVehicle(string vehicleID)
        {
            var parameter = new SqlParameter("@VehicleID", SqlDbType.NVarChar, 50) { Value = vehicleID };
            var result = ExecuteStoredProcedure("spDeleteVehicle", new[] { parameter });
            return result.Rows.Count > 0 ? Convert.ToInt32(result.Rows[0]["RowsAffected"]) : 0;
        }

        // Route-specific methods (if needed)
        public DataTable GetAllRoutes()
        {
            const string query = "SELECT * FROM Routes ORDER BY RouteID";
            return ExecuteQuery(query);
        }

        public DataTable GetRouteById(string routeID)
        {
            const string query = "SELECT * FROM Routes WHERE RouteID = @RouteID";
            var parameter = new SqlParameter("@RouteID", SqlDbType.NVarChar, 50) { Value = routeID };
            return ExecuteQuery(query, new[] { parameter });
        }

        public DataTable GetVehiclesByRoute(string routeID)
        {
            const string query = "SELECT * FROM Vehicles WHERE RouteID = @RouteID";
            var parameter = new SqlParameter("@RouteID", SqlDbType.NVarChar, 50) { Value = routeID };
            return ExecuteQuery(query, new[] { parameter });
        }

        public DataTable GetVehiclesByStatus(string status)
        {
            const string query = "SELECT * FROM Vehicles WHERE Status = @Status";
            var parameter = new SqlParameter("@Status", SqlDbType.NVarChar, 50) { Value = status };
            return ExecuteQuery(query, new[] { parameter });
        }
    }
}