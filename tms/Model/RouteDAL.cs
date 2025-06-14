using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using tms.Data;

namespace tms.Model
{
    public class RouteDAL
    {
        public List<Route> GetAllRoutes()
        {
            List<Route> routes = new List<Route>();
            const string query = "SELECT RouteID, StartPoint, EndPoint, DistanceKm, EstimatedTimeMinutes, VehicleAssigned, Priority, AvoidTolls, EnableWeatherAlerts, CreatedDate, ModifiedDate FROM Routes ORDER BY RouteID";

            using (DataTable dt = DatabaseHelper.ExecuteQuery(query))
            {
                foreach (DataRow row in dt.Rows)
                {
                    routes.Add(MapRowToRoute(row));
                }
            }

            return routes;
        }

        public Route GetRouteById(string routeId)
        {
            const string query = "SELECT RouteID, StartPoint, EndPoint, DistanceKm, EstimatedTimeMinutes, VehicleAssigned, Priority, AvoidTolls, EnableWeatherAlerts, CreatedDate, ModifiedDate FROM Routes WHERE RouteID = @RouteID";
            SqlParameter[] parameters = {
                new SqlParameter("@RouteID", routeId)
            };

            using (DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters))
            {
                if (dt.Rows.Count > 0)
                {
                    return MapRowToRoute(dt.Rows[0]);
                }
            }

            return null;
        }

        public List<Route> SearchRoutes(string searchTerm)
        {
            List<Route> routes = new List<Route>();
            const string query = @"SELECT RouteID, StartPoint, EndPoint, DistanceKm, EstimatedTimeMinutes, VehicleAssigned, Priority, AvoidTolls, EnableWeatherAlerts, CreatedDate, ModifiedDate 
                                 FROM Routes 
                                 WHERE RouteID LIKE @SearchTerm 
                                 OR StartPoint LIKE @SearchTerm 
                                 OR EndPoint LIKE @SearchTerm 
                                 OR VehicleAssigned LIKE @SearchTerm
                                 ORDER BY RouteID";

            SqlParameter[] parameters = {
                new SqlParameter("@SearchTerm", SqlDbType.NVarChar, 100) { Value = $"%{searchTerm}%" }
            };

            using (DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters))
            {
                foreach (DataRow row in dt.Rows)
                {
                    routes.Add(MapRowToRoute(row));
                }
            }

            return routes;
        }

        public bool InsertRoute(Route route)
        {
            const string query = @"INSERT INTO Routes 
                                 (RouteID, StartPoint, EndPoint, DistanceKm, EstimatedTimeMinutes, VehicleAssigned, Priority, AvoidTolls, EnableWeatherAlerts, CreatedDate, ModifiedDate)
                                 VALUES 
                                 (@RouteID, @StartPoint, @EndPoint, @DistanceKm, @EstimatedTimeMinutes, @VehicleAssigned, @Priority, @AvoidTolls, @EnableWeatherAlerts, @CreatedDate, @ModifiedDate)";

            SqlParameter[] parameters = GetRouteParameters(route);
            int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }

        public bool UpdateRoute(Route route)
        {
            const string query = @"UPDATE Routes SET 
                                 StartPoint = @StartPoint, 
                                 EndPoint = @EndPoint, 
                                 DistanceKm = @DistanceKm, 
                                 EstimatedTimeMinutes = @EstimatedTimeMinutes,
                                 VehicleAssigned = @VehicleAssigned, 
                                 Priority = @Priority, 
                                 AvoidTolls = @AvoidTolls, 
                                 EnableWeatherAlerts = @EnableWeatherAlerts,
                                 ModifiedDate = @ModifiedDate
                                 WHERE RouteID = @RouteID";

            SqlParameter[] parameters = GetRouteParameters(route);
            int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }

        public bool DeleteRoute(string routeId)
        {
            const string query = "DELETE FROM Routes WHERE RouteID = @RouteID";
            SqlParameter[] parameters = {
                new SqlParameter("@RouteID", routeId)
            };

            int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }

        private Route MapRowToRoute(DataRow row)
        {
            return new Route
            {
                RouteID = row.Field<string>("RouteID"),
                StartPoint = row.Field<string>("StartPoint"),
                EndPoint = row.Field<string>("EndPoint"),
                DistanceKm = row.IsNull("DistanceKm") ? null : row.Field<decimal>("DistanceKm"),
                EstimatedTimeMinutes = row.IsNull("EstimatedTimeMinutes") ? null : row.Field<int>("EstimatedTimeMinutes"),
                VehicleAssigned = row.Field<string>("VehicleAssigned"),
                Priority = row.Field<string>("Priority"),
                AvoidTolls = row.Field<bool>("AvoidTolls"),
                EnableWeatherAlerts = row.Field<bool>("EnableWeatherAlerts"),
                CreatedDate = row.Field<DateTime>("CreatedDate"),
                ModifiedDate = row.Field<DateTime>("ModifiedDate")
            };
        }

        private SqlParameter[] GetRouteParameters(Route route)
        {
            return new SqlParameter[]
            {
                new SqlParameter("@RouteID", SqlDbType.NVarChar, 50) { Value = route.RouteID },
                new SqlParameter("@StartPoint", SqlDbType.NVarChar, 100) { Value = route.StartPoint },
                new SqlParameter("@EndPoint", SqlDbType.NVarChar, 100) { Value = route.EndPoint },
                new SqlParameter("@DistanceKm", SqlDbType.Decimal)
                {
                    Value = route.DistanceKm ?? (object)DBNull.Value,
                    Precision = 10,
                    Scale = 2
                },
                new SqlParameter("@EstimatedTimeMinutes", SqlDbType.Int)
                {
                    Value = route.EstimatedTimeMinutes ?? (object)DBNull.Value
                },
                new SqlParameter("@VehicleAssigned", SqlDbType.NVarChar, 50) { Value = route.VehicleAssigned ?? (object)DBNull.Value },
                new SqlParameter("@Priority", SqlDbType.NVarChar, 20) { Value = route.Priority ?? (object)DBNull.Value },
                new SqlParameter("@AvoidTolls", SqlDbType.Bit) { Value = route.AvoidTolls },
                new SqlParameter("@EnableWeatherAlerts", SqlDbType.Bit) { Value = route.EnableWeatherAlerts },
                new SqlParameter("@CreatedDate", SqlDbType.DateTime) { Value = route.CreatedDate },
                new SqlParameter("@ModifiedDate", SqlDbType.DateTime) { Value = route.ModifiedDate }
            };
        }
    }
}