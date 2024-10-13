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
    public class Usuario_Data
    {
        //Metodo para que el usuario se pueda loguiar
        public bool Autenticacion(string user, string pass, string area)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FRAN_MOTOSConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Us_AutenticacionUsuario", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@username", user);
                    cmd.Parameters.AddWithValue("@password", pass);
                    cmd.Parameters.AddWithValue("@area", area);

                    conn.Open();
                    int result = (int)cmd.ExecuteScalar();


                    return result > 0;
                }
            }
        }

        public int CrearUsuaeio(Usuario u)
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
                        cmd.CommandText = "Us_AgregarUsurio"; // Indicar el nombre de procedimineto a indicar

                        //Aseguerar que nonexiste contenido en los parámetros a utiliar
                        cmd.Parameters.Clear();

                        //Inidcar los parametros qeu seran enviados al procedimiento
                        cmd.Parameters.AddWithValue("@Codigo", u.CODIGO_USUARIO);
                        cmd.Parameters.AddWithValue("@Rol", u.ROL);
                        cmd.Parameters.AddWithValue("@Nombres", u.NOMBRES);
                        cmd.Parameters.AddWithValue("@Apellidos", u.APELLIDOS);
                        cmd.Parameters.AddWithValue("@Usuario", u.USUARIO);
                        cmd.Parameters.AddWithValue("@Contrasena", u.CONTRASENA);

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

        public DataTable LeerUsuario(string filter)
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
                        cmd.CommandText = "Us_LeerUsuario";

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

        public int ActualizaruUsuario(Usuario u)
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
                        cmd.CommandText = "Us_ActualizarUsuario";

                        //Forzar a que los parametros se encuentren limpiios
                        cmd.Parameters.Clear();

                        // Indicar los parametros que seran enviados al procedimiento de actualizacion
                        cmd.Parameters.AddWithValue("@Codigo", u.CODIGO_USUARIO);
                        cmd.Parameters.AddWithValue("@Rol", u.ROL);
                        cmd.Parameters.AddWithValue("@Nombres", u.NOMBRES);
                        cmd.Parameters.AddWithValue("@Apellidos", u.APELLIDOS);
                        cmd.Parameters.AddWithValue("@Usuario", u.USUARIO);
                        cmd.Parameters.AddWithValue("@Contrasena", u.CONTRASENA);

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

    
        ///Metodo para eliminar Usuario en este caso pasa a un estado inactivo
        public int EliminarUsuario(string codigo)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FRAN_MOTOSConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Us_EliminarUsuario", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@Codigo", codigo);

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

        //Metodo para mostrar usuarios
        public DataTable MostrarUsuarios()
        {
            // Definir la instancia de DataTable donde se enviará el resultado
            DataTable result = new DataTable(); // Inicializamos el DataTable desde el principio para evitar problemas de retorno nulo

            // Usar el bloque using para asegurarse de que la conexión se cierre correctamente
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FRAN_MOTOSConnectionString"].ConnectionString))
            {
                // Crear una nueva instancia de SqlCommand
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        // Establecer la conexión en la que se opera
                        cmd.Connection = conn;

                        // Indicar el tipo de comando a ejecutar, en este caso un procedimiento almacenado
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "Us_MostrarUsuarios"; // Asegúrate de que el nombre del procedimiento almacenado es correcto

                        // Asegurar que los parámetros estén vacíos
                        cmd.Parameters.Clear();

                        // Abrir la conexión para procesar los resultados
                        conn.Open();

                        // Ejecutar el comando y cargar los resultados en un SqlDataReader
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            // Verificar si se ha obtenido algún registro
                            if (dr.HasRows)
                            {
                                result.Load(dr); // Cargar los datos en el DataTable
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        // Lanzar una excepción en caso de error
                        throw new Exception("Se ha producido un error interno en el procesamiento de los datos: " + e.Message);
                    }
                    finally
                    {
                        // Asegurarse de que la conexión se cierra
                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }
                    }
                } // Fin del segundo using
            } // Fin del primer using

            return result;
        }

    }
}
