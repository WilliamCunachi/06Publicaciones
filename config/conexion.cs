﻿using System;
using System.Data.SqlClient;

namespace _06Publicaciones.config
{
    public static class Conexion
    {
        private static readonly string connectionString;

        static Conexion()
        {
            // Aquí puedes establecer tu cadena de conexión. Se recomienda obtenerla de un archivo de configuración o variables de entorno.
            connectionString = "Server=ALEXIA\\SQLEXPRESS;database=pubs;uid=sa;pwd=2023022;";
        }

        public static SqlConnection GetConnection()
        {
            try
            {
                var connection = new SqlConnection(connectionString);
                connection.Open();
                return connection;
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error al conectar con la base de datos: {ex.Message}");
                throw;
            }
        }
    }
}
