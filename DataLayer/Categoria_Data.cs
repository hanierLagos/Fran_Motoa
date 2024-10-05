using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Categoria_Data
    {
        public DataTable ObtenerIdCategoria()
        {
            // Definir una instancia DataTable por donde se enviará el resultado
            DataTable result = null;

            // Obtener cadena de conexión
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FRAN_MOTOSConnectionString"].ConnectionString))
            {
                // Crear una nueva instancia del SqlCommand y Asegurar que se destruya el objeto al finalizar
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        cmd.Connection = conn;  // Establecer la conexión con la que opera

                        // Indicar el tipo de comando a ejecutar en este caso un procedimiento, y el nombre del procedimiento
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "Us_ObtenerIdCategoria";

                        // Abrir la conexión para que se procesen los resultados
                        conn.Open();

                        // Procesar la instrucción y recuperar los valores en ExecuteReader
                        SqlDataReader rst = cmd.ExecuteReader();
                        // Verificar que se haya obtenido registro de la consulta
                        if (rst.HasRows)
                        {
                            result = new DataTable(); // Inicializar la instancia para agregar el registro
                            result.Load(rst); // Cargar los datos en el DataTable
                        }// Fin del condicional If
                    }
                    catch (Exception e)
                    {
                        throw new Exception("Se ha producido una infracción interna en el procesamiento de los datos " + e.Message);
                    }
                    finally
                    {
                        // En todo caso hay que asegurar el cierre de la conexión
                        conn.Close();
                    }// Fin de la instrucción finally
                }// Fin del using SqlCommand
            }// Fin de la instrucción using SqlConnection

            return result; // Devolver el DataTable resultante
        }
    }
}
