using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ConexionBD_PracticaPromerica
{
    public class ConexionBD
    {
          private string cadenaConexion;

    public ConexionBD(string cadenaConexion)
    {
        this.cadenaConexion = cadenaConexion;
    }

    //DEVUELVE DATASET AL REALIZAR UNA CONSULTA
    public DataSet EjecutarConsulta(string consulta)
    {
        using (SqlConnection conexion = new SqlConnection(cadenaConexion))
        {
            DataSet dataSet = new DataSet();
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(dataSet);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return dataSet;
        }
    }

    //DEVUELVE CANTIDAD DE FILAS AFECTADAS EN UPDATE, INSERT Y DELETE
    public int EjecutarQuery(string consulta)
    {
        using (SqlConnection conexion = new SqlConnection(cadenaConexion))
        {
            int filasAfectadas = 0;
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand(consulta, conexion);
                filasAfectadas = comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return filasAfectadas;
        }
    }

    public int ObtenerCantidadFilasSelect(string consulta)
    {
        int cantidadFilas = 0;
        using (SqlConnection conexion = new SqlConnection(cadenaConexion))
        {
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand(consulta, conexion);
                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        cantidadFilas++;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        return cantidadFilas;
    }
    }
}
