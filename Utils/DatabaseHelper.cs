﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;

namespace TravelTour.Utils
{
    public class DatabaseHelper : IDisposable
    {
        private SqlConnection _connection;

        public DatabaseHelper(string connectionString)
        {
            _connection = new SqlConnection("Data Source=LAP-CUA-BOTHOMT\\BOSEVER;Initial Catalog=dulich;Integrated Security=True");

        }

        // Mở kết nối
        public void OpenConnection()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        // Thực hiện truy vấn không trả về dữ liệu (INSERT, UPDATE, DELETE)
        public int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                OpenConnection();
                int result = command.ExecuteNonQuery();
                //CloseConnection();
                return result;
            }
        }

        // Thực hiện truy vấn trả về dữ liệu (SELECT)
        public DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                DataTable dataTable = new DataTable();
                OpenConnection();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }

                //CloseConnection();
                return dataTable;
            }
        }

        public object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            using (SqlCommand command = new SqlCommand(query, _connection))
            {
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                OpenConnection();
                object result = command.ExecuteScalar();
                //CloseConnection();
                return result;
            }
        }


        // Implement IDisposable interface
        public void Dispose()
        {
            //CloseConnection();
            _connection.Dispose();
        }
    }
}