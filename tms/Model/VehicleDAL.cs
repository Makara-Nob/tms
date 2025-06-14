using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using tms.Data;

namespace tms.Model
{
    public class VehicleDAL
    {
        public List<Vehicle> GetAllVehicles()
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            const string query = "SELECT VehicleID, Type, Capacity, LicensePlate, RouteID, Status, MaintenanceDate, CreatedDate, ModifiedDate FROM Vehicles ORDER BY VehicleID";

            using (DataTable dt = DatabaseHelper.ExecuteQuery(query))
            {
                foreach (DataRow row in dt.Rows)
                {
                    vehicles.Add(MapRowToVehicle(row));
                }
            }

            return vehicles;
        }

        public Vehicle GetVehicleById(string vehicleId)
        {
            const string query = "SELECT VehicleID, Type, Capacity, LicensePlate, RouteID, Status, MaintenanceDate, CreatedDate, ModifiedDate FROM Vehicles WHERE VehicleID = @VehicleID";
            SqlParameter[] parameters = {
                new SqlParameter("@VehicleID", vehicleId)
            };

            using (DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters))
            {
                if (dt.Rows.Count > 0)
                {
                    return MapRowToVehicle(dt.Rows[0]);
                }
            }

            return null;
        }

        public List<Vehicle> SearchVehicles(string searchTerm)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            const string query = @"SELECT VehicleID, Type, Capacity, LicensePlate, RouteID, Status, MaintenanceDate, CreatedDate, ModifiedDate 
                                 FROM Vehicles 
                                 WHERE VehicleID LIKE @SearchTerm 
                                 OR Type LIKE @SearchTerm 
                                 OR LicensePlate LIKE @SearchTerm 
                                 OR RouteID LIKE @SearchTerm
                                 OR Status LIKE @SearchTerm
                                 ORDER BY VehicleID";

            SqlParameter[] parameters = {
                new SqlParameter("@SearchTerm", SqlDbType.NVarChar, 100) { Value = $"%{searchTerm}%" }
            };

            using (DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters))
            {
                foreach (DataRow row in dt.Rows)
                {
                    vehicles.Add(MapRowToVehicle(row));
                }
            }

            return vehicles;
        }

        public bool InsertVehicle(Vehicle vehicle)
        {
            const string query = @"INSERT INTO Vehicles 
                                 (VehicleID, Type, Capacity, LicensePlate, RouteID, Status, MaintenanceDate, CreatedDate, ModifiedDate)
                                 VALUES 
                                 (@VehicleID, @Type, @Capacity, @LicensePlate, @RouteID, @Status, @MaintenanceDate, @CreatedDate, @ModifiedDate)";

            SqlParameter[] parameters = GetVehicleParameters(vehicle);
            int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }

        public bool UpdateVehicle(Vehicle vehicle)
        {
            const string query = @"UPDATE Vehicles SET 
                                 Type = @Type, 
                                 Capacity = @Capacity, 
                                 LicensePlate = @LicensePlate, 
                                 RouteID = @RouteID, 
                                 Status = @Status,
                                 MaintenanceDate = @MaintenanceDate, 
                                 ModifiedDate = @ModifiedDate
                                 WHERE VehicleID = @VehicleID";

            SqlParameter[] parameters = GetVehicleParameters(vehicle);
            int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }

        public bool DeleteVehicle(string vehicleId)
        {
            const string query = "DELETE FROM Vehicles WHERE VehicleID = @VehicleID";
            SqlParameter[] parameters = {
                new SqlParameter("@VehicleID", vehicleId)
            };

            int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }

        public List<string> GetVehicleTypes() => new List<string> { "Bus", "Van", "Truck", "Car", "Motorcycle" };

        public List<string> GetVehicleStatuses() => new List<string> { "Active", "Inactive", "Maintenance", "Retired" };

        private Vehicle MapRowToVehicle(DataRow row)
        {
            return new Vehicle
            {
                VehicleID = row.Field<string>("VehicleID"),
                Type = row.Field<string>("Type"),
                Capacity = row.IsNull("Capacity") ? null : row.Field<int>("Capacity"),
                LicensePlate = row.Field<string>("LicensePlate"),
                RouteID = row.Field<string>("RouteID"),
                Status = row.Field<string>("Status"),
                MaintenanceDate = row.IsNull("MaintenanceDate") ? null : row.Field<DateTime>("MaintenanceDate"),
                CreatedDate = row.Field<DateTime>("CreatedDate"),
                ModifiedDate = row.Field<DateTime>("ModifiedDate")
            };
        }

        private SqlParameter[] GetVehicleParameters(Vehicle vehicle)
        {
            return new SqlParameter[]
            {
                new SqlParameter("@VehicleID", SqlDbType.NVarChar, 50) { Value = vehicle.VehicleID },
                new SqlParameter("@Type", SqlDbType.NVarChar, 50) { Value = vehicle.Type ?? (object)DBNull.Value },
                new SqlParameter("@Capacity", SqlDbType.Int) { Value = vehicle.Capacity ?? (object)DBNull.Value },
                new SqlParameter("@LicensePlate", SqlDbType.NVarChar, 20) { Value = vehicle.LicensePlate ?? (object)DBNull.Value },
                new SqlParameter("@RouteID", SqlDbType.NVarChar, 50) { Value = vehicle.RouteID ?? (object)DBNull.Value },
                new SqlParameter("@Status", SqlDbType.NVarChar, 20) { Value = vehicle.Status ?? (object)DBNull.Value },
                new SqlParameter("@MaintenanceDate", SqlDbType.DateTime) { Value = vehicle.MaintenanceDate ?? (object)DBNull.Value },
                new SqlParameter("@CreatedDate", SqlDbType.DateTime) { Value = vehicle.CreatedDate },
                new SqlParameter("@ModifiedDate", SqlDbType.DateTime) { Value = DateTime.UtcNow } 
            };
        }
    }
}