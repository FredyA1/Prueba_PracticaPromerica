using System;
using System.Data;

namespace ConexionBD_PracticaPromerica
{
    class Program
    {
        static void Main(string[] args)
        {
            
     // EJEMPLO CADENA DE CONEXION
            string cadenaConexion= "Server=SQLOLEDB; Database=alquilerautos; User Id =sa; Password=1234";


            ConexionBD dbManager = new ConexionBD(cadenaConexion);

            // Ejemplo de consulta SELECT
            string consultaSelect = "select  * from vehiculo";
            DataSet resultadoSelect = dbManager.EjecutarConsulta(consultaSelect);
            Console.WriteLine("Resultado de la consulta SELECT:");

            // Imprimir el contenido del DataSet
            foreach (DataTable tabla in resultadoSelect.Tables)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    foreach (DataColumn columna in tabla.Columns)
                    {
                        Console.WriteLine($"{columna.ColumnName}: {fila[columna]}");
                    }
                    Console.WriteLine();
                }
            }

            // Ejemplo de consulta INSERT
            string consultaInsert = "INSERT INTO MiTabla (Columna1, Columna2) VALUES ('Valor1', 'Valor2')";
            int filasInsertadas = dbManager.EjecutarQuery(consultaInsert);
            Console.WriteLine($"Se han insertado {filasInsertadas} filas.");

            // Ejemplo de consulta UPDATE
            string consultaUpdate = "UPDATE MiTabla SET Columna1 = 'NuevoValor' WHERE Columna2 = 'Valor2'";
            int filasActualizadas = dbManager.EjecutarQuery(consultaUpdate);
            Console.WriteLine($"Se han actualizado {filasActualizadas} filas.");

            // Ejemplo de consulta DELETE
            string consultaDelete = "DELETE FROM MiTabla WHERE Columna1 = 'Valor1'";
            int filasEliminadas = dbManager.EjecutarQuery(consultaDelete);
            Console.WriteLine($"Se han eliminado {filasEliminadas} filas.");

            // Ejemplo de obtener la cantidad de filas que devolvería un SELECT
            string consultaCount = "SELECT COUNT(*) FROM MiTabla";
            int rowCount = dbManager.ObtenerCantidadFilasSelect(consultaCount);
            Console.WriteLine($"Número de filas que devolvería la consulta SELECT: {rowCount}");

            Console.ReadLine();
        }
    }
}
