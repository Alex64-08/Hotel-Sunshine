using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Modelos.Conexion
{
    public class ConexionDB
    {
        private static string servidor = "DESKTOP-J40DV93\\SQLEXPRESS";
        private static string dbData = "Hotel"; // Nombre de la base de datos

        public static SqlConnection Conectar()
        {
            string cadena = $"Data Source={servidor};Initial Catalog={dbData};Integrated Security=True";
            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();
            return conexion;
        }
    }
}
