using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace DataLayer
{
    public class Entrada_InventarioData
    {

        //Metodo para obtener el nuevo numero de compra
        public int ObtenerNumeroEntrada()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FRAN_MOTOSConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Us_ObtenerNumeroEntrada", conn))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        conn.Open();

                        // Ejecutar el procedimiento almacenado y obtener el resultado
                        object result = cmd.ExecuteScalar();

                        // Validar el resultado y devolver el número de factura
                        if (result != null && int.TryParse(result.ToString(), out int nextNumber))
                        {
                            return nextNumber;
                        }
                        else
                        {
                            // Lanzar una excepción si no se puede obtener el número de factura
                            throw new Exception("No se pudo obtener el próximo número de Entrada.");
                        }
                    }
                    catch (SqlException ex)
                    {
                        // Manejar las excepciones SQL y lanzar una nueva excepción con información detallada
                        throw new Exception("Error al ejecutar el procedimiento almacenado Us_ObtenerNumeroEntrada: " + ex.Message, ex);
                    }
                    catch (Exception ex)
                    {
                        // Manejar otras excepciones y lanzar una nueva excepción con información detallada
                        throw new Exception("Error interno al obtener el próximo número de factura de compra: " + ex.Message, ex);
                    }
                }
            }
        }

        public int CrearEntrada(Entrada_Inventario e)
        {
            // Establecer la cadena de coneccióm , asegurando que se liberen los recursos
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FRAN_MOTOSConnectionString"].ConnectionString))
            {
                //Crear la instancia de sql comand, asegurando que se destruya
                using (SqlCommand cmd = new SqlCommand())
                {
                    // Establecer los pasos neceasrios la inserción de registros
                    try
                    {
                        //Asignar la conección vigente
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "Us_AgregarEntrada"; // Indicar el nombre de procedimineto a indicar

                        //Aseguerar que nonexiste contenido en los parámetros a utiliar
                        cmd.Parameters.Clear();

                        //Inidcar los parametros qeu seran enviados al procedimiento
                        cmd.Parameters.AddWithValue("@Numero", e.NUMERO_ENTRADA);
                        cmd.Parameters.AddWithValue("@Fecha", e.FECHA_ENTRADA);
                        cmd.Parameters.AddWithValue("@Description", e.DESCRIPCION);
                       



                        //Abrir la coneccion con SGBD
                        conn.Open();
                        //Procesar la consulta
                        return cmd.ExecuteNonQuery();

                    }// fin de try
                    catch (Exception ex)
                    {
                        throw new Exception("Error interno de la aplicación" + ex.Message);
                    }// fin de catch
                    finally
                    {
                        conn.Close();//Aasegurar que la conección se cierre
                    }//fin de finally

                }// fin de using

            }// Fin de using


        }// Fin de metodo

        public DataTable ReadEntrad(int numero)
        {
            //definir la instancia datatable por donde se enviará ekl resultado
            DataTable result = null;

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FRAN_MOTOSConnectionString"].ConnectionString))
            {
                //crear una nueva instancia de sqlComand y asegurar que se destruya el objeto al finaklizar
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        //establecer lam coneccion en la que se opera
                        cmd.Connection = conn;

                        //Indicar el tipo de comasndo a ejecutar en este caso un procedimiento 
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "Us_ReadEntrada";

                        //fonzar a que los parametros se encuentren nullos
                        cmd.Parameters.Clear();

                        //Establecer el parametro quwe se envia 
                        //indicar lps parametros que sean enviados al procediiento
                        cmd.Parameters.AddWithValue("@Numero", numero);

                        //abrir la coneccion para quese proceda los resultados
                        conn.Open();

                        SqlDataReader dr = cmd.ExecuteReader();
                        //Verificar que se haya obtenido registro de la consulta
                        if (dr.HasRows)
                        {
                            result = new DataTable(); // inicializar la instancia para agregar el registro
                            result.Load(dr); // cagar los datos de DataTable
                        }//Fin del condicional If


                    }
                    catch (Exception e)
                    {

                        throw new Exception("Se ha producido una infraccion interna en el\n" + "procesamiento de los datos" + e.Message);
                    }
                    finally
                    {
                        conn.Close();

                    }
                }//fin de segundo using

            }// fin de primer using
            return result;
        }//fin de metodo GetGuest 

        public int ActualizarEntrada(Entrada_Inventario e)
        {

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FRAN_MOTOSConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        cmd.Connection = conn; // Establecer la conexion con la que opera

                        //indicar el tipo de comando a ejecutar en este caso un prpcedimiento y el nombre del procedimiento
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "Us_ActualizarEntrada";

                        //Forzar a que los parametros se encuentren limpiios
                        cmd.Parameters.Clear();

                        // Indicar los parametros que seran enviados al procedimiento de actualizacion
                        //Inidcar los parametros qeu seran enviados al procedimiento
                        cmd.Parameters.AddWithValue("@Numero", e.NUMERO_ENTRADA);
                        cmd.Parameters.AddWithValue("@Fecha", e.FECHA_ENTRADA);
                        cmd.Parameters.AddWithValue("@Description", e.DESCRIPCION);
                        //Inicializar la conexion 
                        conn.Open();
                        //procesar el comando de ejecucion de la consiulta
                        return cmd.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {

                        throw new Exception("Se ha producido una infraccion interna en el\n" + "procesamiento de los datos" + ex.Message);
                    }
                    finally { conn.Close(); }
                }// fin de segundo using
            }// fin de primer using

        }// Fin de metodo update

        //Metodo para obtener id de la entrada
        public DataTable ObtenerIdEntrdada()
        {
            // Definir una instancia DataTable para almacenar el resultado
            DataTable result = null;

            // Obtener la cadena de conexión desde el archivo de configuración
            string connectionString = ConfigurationManager.ConnectionStrings["FRAN_MOTOSConnectionString"].ConnectionString;

            // Crear una nueva conexión SQL usando la cadena de conexión
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Crear un nuevo comando SQL para ejecutar el procedimiento almacenado
                using (SqlCommand cmd = new SqlCommand("Us_ObtenerIdEntrada", conn))
                {
                    try
                    {
                        // Establecer el tipo de comando como procedimiento almacenado
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Abrir la conexión
                        conn.Open();

                        // Ejecutar el comando y obtener los resultados en un SqlDataReader
                        SqlDataReader reader = cmd.ExecuteReader();

                        // Verificar si hay filas en el resultado
                        if (reader.HasRows)
                        {
                            // Inicializar el DataTable
                            result = new DataTable();

                            // Cargar los datos del SqlDataReader en el DataTable
                            result.Load(reader);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Se ha producido un error al procesar los datos: " + ex.Message);
                    }
                    finally
                    {
                        // Cerrar la conexión
                        conn.Close();
                    }
                }
            }

            // Devolver el DataTable resultante
            return result;
        }


    }// Fin de la clase

}

