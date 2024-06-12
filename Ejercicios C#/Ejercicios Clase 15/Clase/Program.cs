using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Clase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionStr = " Data Source = DESKTOP-1SR8ITP\\LEONSQLEXPRESS; Initial Catalog = Base de Prueba; Integrated Security = True";


            // Sentencias SQL
            string insertQuery = "INSERT INTO Empleados (emp_nro, apellido, oficio, dir, fecha_alt, salario, comision, dept_no)  VALUES(7921,'Perez','Empleador',7749,GETDATE(), 10000000,0,30)";
            string selectQueryAll = "SELECT * FROM Empleados";
            string selectQueryFiltered = "SELECT emp_nro, apellido, oficio FROM Empleados WHERE oficio = 'Empleado'";
            string updateQuery = "UPDATE Empleados SET oficio = 'Empleado' WHERE emp_nro = 7951";
            string deleteQuery = "DELETE FROM Empleados WHERE emp_nro = 7951";

            // Establecer la conexión
            SqlConnection conexion = new SqlConnection(connectionStr);
            try
            {
                conexion.Open();

                // Ejecutar INSERT
                ExecuteQuery(conexion, insertQuery);

                // Ejecutar SELECT
                Console.WriteLine("Consulta SELECT de todos los empleados:");
                ExecuteQuery(conexion, selectQueryAll);

                //Console.WriteLine("\nConsulta SELECT de empleados con oficio 'Empleado':");
                //ExecuteQuery(conexion, selectQueryFiltered);

                //// Ejecutar UPDATE
                //ExecuteQuery(conexion, updateQuery);

                //// Ejecutar DELETE
                //ExecuteQuery(conexion, deleteQuery);

                //// Mostrar empleados después del DELETE
                //Console.WriteLine("\nEmpleados después de eliminar el empleado con emp_nro 7951:");
                //ExecuteQuery(conexion, selectQueryAll);



            }
            catch (Exception ex)
            {

            }
            finally
            {
                // Cerramos conexion
                conexion.Close();
                Console.ReadKey();
            }



        }

        static void ExecuteQuery(SqlConnection conexion, string query)
        {
            using (SqlCommand command = new SqlCommand(query, conexion))
            {
                command.CommandType = CommandType.Text;

                SqlDataReader reader = command.ExecuteReader();

                // Lo que hace es mostrar cada fila de que se lee por consola
                while (reader.Read())
                {
                    // Muestra cada elemento de esa fila 
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write(reader[i] + "\t");
                    }
                    Console.WriteLine();
                }

                reader.Close();
            }
        }
    }
}
