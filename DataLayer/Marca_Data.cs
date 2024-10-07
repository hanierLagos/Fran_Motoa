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
    public class Marca_Data
    {
    

        public DataTable ObtenerIdMarca()
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
                        cmd.CommandText = "Us_ObtenerIdMarca";

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

        //Metodo para crear una nueva marca
        public int CrearMarca(Marcas m)
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
                        cmd.CommandText = "Us_AgregarMarca"; // Indicar el nombre de procedimineto a indicar

                        //Aseguerar que nonexiste contenido en los parámetros a utiliar
                        cmd.Parameters.Clear();

                        //Inidcar los parametros qeu seran enviados al procedimiento
                        cmd.Parameters.AddWithValue("@Codigo", m.CODIGO_MARCAA);
                        cmd.Parameters.AddWithValue("@Nombre_Marca", m.NOMBRE_MARCA);
                   
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

        //Metodo para Leer las marcas en caso de actualizacion usando un filtro como parametro
        public DataTable ReadMarca(string filter)
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
                        cmd.CommandText = "Us_ReadMarca";

                        //fonzar a que los parametros se encuentren nullos
                        cmd.Parameters.Clear();

                        //Establecer el parametro quwe se envia 
                        //indicar lps parametros que sean enviados al procediiento
                        cmd.Parameters.AddWithValue("@Codigo", filter);

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

        //Metodo para actualizar una marca
        public int ActualizarMarca(Marcas m)
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
                        cmd.CommandText = "Us_ActualizarMarca";

                        //Forzar a que los parametros se encuentren limpiios
                        cmd.Parameters.Clear();

                        // Indicar los parametros que seran enviados al procedimiento de actualizacion
                        cmd.Parameters.AddWithValue("@Codigo", m.CODIGO_MARCAA);
                        cmd.Parameters.AddWithValue("@Nombre_Marca", m.NOMBRE_MARCA);

                        //Inicializar la conexion 
                        conn.Open();
                        //procesar el comando de ejecucion de la consiulta
                        return cmd.ExecuteNonQuery();

                    }
                    catch (Exception e)
                    {

                        throw new Exception("Se ha producido una infraccion interna en el\n" + "procesamiento de los datos" + e.Message);
                    }
                    finally { conn.Close(); }
                }// fin de segundo using
            }// fin de primer using

        }// Fin de metodo update


        //Metodo para leer las marcas por una determinada cantidad mostrando la cantidad que se elige
        public DataTable ReadLastMarca(int numRows)
        {
            DataTable result = new DataTable();
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FRAN_MOTOSConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Us_ReadTopMarcas", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@ValuesTop", numRows);

                    try
                    {
                        conn.Open();
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                result.Load(dr);
                            }
                        }
                    }
                    catch (SqlException sqlEx)
                    {
                        // Capturar excepciones de SQL
                        throw new Exception("Error al ejecutar el comando SQL: " + sqlEx.Message, sqlEx);
                    }
                    catch (Exception ex)
                    {
                        // Capturar cualquier otra excepción
                        throw new Exception("Se ha producido una infracción interna en el procesamiento de los datos: " + ex.Message, ex);
                    }
                }
                return result;
            }
        }// Fin de método


        //Metodo para buscar una marca por su nombre
        public DataTable BuscarMarcaPorNombre(string nombre)
        {
            DataTable result = new DataTable();
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FRAN_MOTOSConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Us_BuscaMarcaPorNombre", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NOMBRE", nombre);

                    try
                    {
                        conn.Open();
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                result.Load(dr);
                            }
                        }
                    }
                    catch (SqlException sqlEx)
                    {
                        throw new Exception("Error SQL: " + sqlEx.Message, sqlEx);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error al procesar los datos: " + ex.Message, ex);
                    }
                }
            }
            return result;
        }




    }//Fin de la clase
}
