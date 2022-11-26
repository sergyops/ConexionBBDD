using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionBBDD
{
    class Methods
    {
        public void ShowCliente(string query, SqlConnection conn)
        {
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.CommandType = CommandType.Text;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("=====================");
                        Console.WriteLine("ID " + reader["id"].ToString());
                        Console.WriteLine("Nombre " + reader["nombre"].ToString());
                        Console.WriteLine("Apellido " + reader["apellido"].ToString());
                        Console.WriteLine("N.Articulos " + reader["narticulos"].ToString());
                        Console.WriteLine("Dinero gastado " + reader["dingastado"].ToString());
                    }
                }
            }
        }

        public void ShowArticulo(string query, SqlConnection conn)
        {
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.CommandType = CommandType.Text;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("=====================");
                        Console.WriteLine("ID " + reader["id"].ToString());
                        Console.WriteLine("Nombre " + reader["nombre"].ToString());
                        Console.WriteLine("Precio " + reader["precio"].ToString());
                        Console.WriteLine("Seccion " + reader["seccion"].ToString());
                        Console.WriteLine("N.Articulos " + reader["narticulos"].ToString());
                    }
                }
            }
        }

        public void executeUpdate(string query, SqlConnection conn)
        {
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.ExecuteNonQuery();
            }
        }

        public void executeInsert(string query, SqlConnection conn)
        {
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.ExecuteNonQuery();
            }
        }
    }
}
