using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using tms.Model;

namespace tms.Repository
{
    public class OrderRepository
    {
        private readonly string _connectionString = "Server=FURINA-SIMP\\SQLEXPRESS02;Database=tms;User Id=sa;Password=Chinsakda@3;Encrypt=False;";

        public List<Order> GetAllOrders()
        {
            var orders = new List<Order>();

            using var conn = new SqlConnection(_connectionString);
            conn.Open();

            using var cmd = new SqlCommand("GetAllOrders", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                orders.Add(new Order
                {
                    OrderID = reader["OrderID"].ToString(),
                    Sender = reader["Sender"].ToString(),
                    Reciever = reader["Reciever"].ToString(),
                    OrderType = reader["OrderType"].ToString(),
                    OrderDate = Convert.ToDateTime(reader["OrderDate"])
                });
            }

            return orders;
        }

        public void AddOrder(Order order)
        {
            using var conn = new SqlConnection(_connectionString);
            conn.Open();

            using var cmd = new SqlCommand("InsertOrder", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@OrderID", order.OrderID);
            cmd.Parameters.AddWithValue("@Sender", order.Sender);
            cmd.Parameters.AddWithValue("@Reciever", order.Reciever);
            cmd.Parameters.AddWithValue("@OrderType", order.OrderType);
            cmd.Parameters.AddWithValue("@OrderDate", order.OrderDate);

            cmd.ExecuteNonQuery();
        }

        public void UpdateOrder(Order order)
        {
            using var conn = new SqlConnection(_connectionString);
            conn.Open();

            using var cmd = new SqlCommand("UpdateOrder", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@OrderID", order.OrderID);
            cmd.Parameters.AddWithValue("@Sender", order.Sender);
            cmd.Parameters.AddWithValue("@Reciever", order.Reciever);
            cmd.Parameters.AddWithValue("@OrderType", order.OrderType);
            cmd.Parameters.AddWithValue("@OrderDate", order.OrderDate);

            cmd.ExecuteNonQuery();
        }

        public Order GetOrderById(string orderId)
        {
            using var conn = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand("GetOrderById", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@OrderID", orderId);

            conn.Open();
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new Order
                {
                    OrderID = reader["OrderID"].ToString(),
                    Sender = reader["Sender"].ToString(),
                    Reciever = reader["Reciever"].ToString(),
                    OrderType = reader["OrderType"].ToString(),
                    OrderDate = Convert.ToDateTime(reader["OrderDate"]),
                    DeliveryId = reader["DeliveryId"] == DBNull.Value ? null : Convert.ToInt32(reader["DeliveryId"]),
                    DeliveryStatus = reader["DeliveryStatus"].ToString(),
                    TotalAmount = reader["TotalAmount"] == DBNull.Value ? null : Convert.ToDecimal(reader["TotalAmount"])
                };
            }

            return null;
        }

        public void DeleteOrder(string orderId)
        {
            using var conn = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand("DeleteOrder", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@OrderID", orderId);

            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
