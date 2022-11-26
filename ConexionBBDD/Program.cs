using System;
using System.Data;
using System.Text;
using ConexionBBDD;
using Microsoft.Data.SqlClient;

namespace Connection
{


    class Program
    {
        static void Main(string[] args)
        {
            string datasource = "DESKTOP-GM5SGO2";
            string database = "Comercio";//initial catalog
            string username = "sa";
            string password = "adm1n";

            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                        + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password + ";TrustServerCertificate=true";

            SqlConnection conn = new SqlConnection(connString);//nueva conexión
            Methods metodo = new Methods();

            try
            {
                conn.Open();

                //INSERT
                metodo.executeInsert("INSERT INTO cliente (id, nombre, apellido, narticulos, dingastado) VALUES (11, 'pepe', 'garcia', 30, 400)",conn);
                
                Console.WriteLine("imprimimos los datos que hemos introducido");
                metodo.ShowCliente("SELECT * FROM cliente WHERE id = '11'", conn);


                //UPDATE
                metodo.executeUpdate("UPDATE cliente SET apellido = 'soria' WHERE id = '11'", conn);

                Console.WriteLine("imprimimos para comprobar que han cambiado los datos");
                metodo.ShowCliente("SELECT * FROM cliente WHERE id = '11'", conn);


                //SELECT
                Console.WriteLine("imprimimos los datos de la tabla articulo");
                metodo.ShowArticulo("SELECT * FROM articulo", conn);

                conn.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}