
using EntityLayer;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public class Cliente_Data
    {
        public int CrearCliente(Cliente c)
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
                        cmd.CommandText = "Us_AgregarCliente"; // Indicar el nombre de procedimineto a indicar

                        //Aseguerar que nonexiste contenido en los parámetros a utiliar
                        cmd.Parameters.Clear();

                        //Inidcar los parametros qeu seran enviados al procedimiento
                        cmd.Parameters.AddWithValue("@codigo", c.CODIGO_CLIENTE);
                        cmd.Parameters.AddWithValue("@nombres", c.NOMBRES);
                        cmd.Parameters.AddWithValue("@apellidos", c.APELLIDOS);
                        cmd.Parameters.AddWithValue("@telefono", c.TELEFONO);
                        cmd.Parameters.AddWithValue("@direccion", c.DIRECCION);
                        


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

        public DataTable ReadCliente(string filter)
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
                        cmd.CommandText = "Us_ReadCliente";

                        //fonzar a que los parametros se encuentren nullos
                        cmd.Parameters.Clear();

                        //Establecer el parametro quwe se envia 
                        //indicar lps parametros que sean enviados al procediiento
                        cmd.Parameters.AddWithValue("@codigo", filter);

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

        public int ActualizarCliente(Cliente c)
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
                        cmd.CommandText = "Us_ActualizarCliente";

                        //Forzar a que los parametros se encuentren limpiios
                        cmd.Parameters.Clear();

                        // Indicar los parametros que seran enviados al procedimiento de actualizacion
                        //Inidcar los parametros qeu seran enviados al procedimiento
                        cmd.Parameters.AddWithValue("@codigo", c.CODIGO_CLIENTE);
                        cmd.Parameters.AddWithValue("@nombres", c.NOMBRES);
                        cmd.Parameters.AddWithValue("@apellidos", c.APELLIDOS);
                        cmd.Parameters.AddWithValue("@telefono", c.TELEFONO);
                        cmd.Parameters.AddWithValue("@direccion", c.DIRECCION);
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

        public DataTable ReadLastClient(int numRows)
        {
            DataTable result = new DataTable();
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FRAN_MOTOSConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Us_ReadTopCliente", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@valuesTop", numRows);

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

        public DataTable BuscarClientePorNombre(string nombre)
        {
            DataTable result = new DataTable();
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FRAN_MOTOSConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Us_BuscarClientePorNombre", conn))
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

        ///Metodo para eliminar clientes en este caso pasa a un estado inactivo
        public int EliminarCliente(string codigo)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FRAN_MOTOSConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Us_EliminarCliente", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@codigo", codigo);

                    try
                    {
                        conn.Open();
                        return cmd.ExecuteNonQuery();
                    }
                    catch (SqlException sqlEx)
                    {
                        throw new Exception("Error al ejecutar el comando SQL: " + sqlEx.Message, sqlEx);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error interno de la aplicación: " + ex.Message, ex);
                    }
                }
            }
        }


    }
}
