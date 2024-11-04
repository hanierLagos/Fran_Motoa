using EntityLayer;
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
    public class Producto_Data
    {
        // Método para crear un producto en la base de datos
        public int CrearProducto(Productos p)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FRAN_MOTOSConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "Us_AgregarProducto";

                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@codigo", p.CODIGO_PRODUCTO);
                        cmd.Parameters.AddWithValue("@nombre", p.NOMBRE_PRODUCTO);
                        cmd.Parameters.AddWithValue("@precio", p.PRECIO);
                        cmd.Parameters.AddWithValue("@marcaid", p.ID_MARCA);
                        cmd.Parameters.AddWithValue("@categoriaid", p.ID_CATEGORIA);
                        cmd.Parameters.AddWithValue("@cantidad", p.CANTIDAD);

                        conn.Open();
                        return cmd.ExecuteNonQuery();
                    }
                    catch (SqlException sqlEx)
                    {
                        // Captura errores de SQL específicos
                        throw new Exception("Error en la base de datos: " + sqlEx.Message);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error interno de la aplicación: " + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }


        // Método para leer un producto por su código
        public DataTable ReadProducto(string filter)
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
                        cmd.CommandText = "Us_ReadProducto";

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
        }//fin de metodo  



        // Método para leer un producto por su código
        public DataTable LeerProducto(string codigo)
        {
            DataTable result = new DataTable();  // Estructura para almacenar el resultado
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FRAN_MOTOSConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        // Asigna la conexión y tipo de comando
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "Us_LeerProducto";  // Procedimiento almacenado para leer productos
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@codigo", codigo);  // Parámetro de búsqueda

                        // Abre la conexión y ejecuta la lectura de datos
                        conn.Open();
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                result.Load(dr);  // Carga los datos en el DataTable si existen filas
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejo de errores
                        throw new Exception("Error al procesar los datos: " + ex.Message);
                    }
                    finally
                    {
                        // Cierra la conexión
                        conn.Close();
                    }
                }
            }
            return result;  // Retorna los datos del producto
        }

        // Método para actualizar un producto en la base de datos desde la ventana de editar
        public int ActualizarProducto(Productos p)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FRAN_MOTOSConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        // Asigna la conexión y el tipo de comando
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "Us_ActualizarProducto";  // Procedimiento almacenado para actualizar productos

                        // Limpia los parámetros y añade los nuevos con los valores actualizados
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@codigo", p.CODIGO_PRODUCTO);
                        cmd.Parameters.AddWithValue("@nombre", p.NOMBRE_PRODUCTO);
                        cmd.Parameters.AddWithValue("@precio", p.PRECIO);
                        cmd.Parameters.AddWithValue("@marcaid", p.ID_MARCA);
                        cmd.Parameters.AddWithValue("@categoriaid", p.ID_CATEGORIA);
                        cmd.Parameters.AddWithValue("@cantidad", p.CANTIDAD);


                        // Abre la conexión y ejecuta la actualización
                        conn.Open();
                        return cmd.ExecuteNonQuery();  // Retorna el número de filas afectadas
                    }
                    catch (Exception ex)
                    {
                        // Manejo de errores
                        throw new Exception("Error al actualizar el producto: " + ex.Message);
                    }
                    finally
                    {
                        // Cierra la conexión
                        conn.Close();
                    }
                }
            }
        }

        // Método para actualizar un producto que entran en la base de datos
        public int ActualizarProductoEntrada(Productos p)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FRAN_MOTOSConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        // Asigna la conexión y el tipo de comando
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "Us_ActualizarProductoEntrada";  // Procedimiento almacenado para actualizar productos

                        // Limpia los parámetros y añade los nuevos con los valores actualizados
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@codigo", p.CODIGO_PRODUCTO);
                        cmd.Parameters.AddWithValue("@nombre", p.NOMBRE_PRODUCTO);
                        cmd.Parameters.AddWithValue("@precio", p.PRECIO);
                        cmd.Parameters.AddWithValue("@marcaid", p.ID_MARCA);
                        cmd.Parameters.AddWithValue("@categoriaid", p.ID_CATEGORIA);
                        cmd.Parameters.AddWithValue("@cantidad", p.CANTIDAD);


                        // Abre la conexión y ejecuta la actualización
                        conn.Open();
                        return cmd.ExecuteNonQuery();  // Retorna el número de filas afectadas
                    }
                    catch (Exception ex)
                    {
                        // Manejo de errores
                        throw new Exception("Error al actualizar el producto: " + ex.Message);
                    }
                    finally
                    {
                        // Cierra la conexión
                        conn.Close();
                    }
                }
            }
        }

        // Método para leer los últimos productos agregados, limitados por 'numRows'
        public DataTable ReadLastProducto(int numRows)
        {
            DataTable result = new DataTable();
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FRAN_MOTOSConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Us_ReadTopProducto", conn))  // Procedimiento almacenado para obtener los últimos productos
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@valuesTop", numRows);  // Número de filas a obtener

                    try
                    {
                        // Abre la conexión y ejecuta la lectura de datos
                        conn.Open();
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                result.Load(dr);  // Carga los datos en el DataTable si hay resultados
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejo de errores
                        throw new Exception("Error al procesar los datos: " + ex.Message);
                    }
                }
            }
            return result;  // Retorna los productos obtenidos
        }

        // Método para buscar productos por nombre
        public DataTable BuscarProductoPorNombre(string nombre)
        {
            DataTable result = new DataTable();
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FRAN_MOTOSConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Us_BuscarProductoPorNombre", conn))  // Procedimiento almacenado para buscar productos
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NOMBRE", nombre);  // Parámetro de búsqueda

                    try
                    {
                        // Abre la conexión y ejecuta la búsqueda
                        conn.Open();
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                result.Load(dr);  // Carga los resultados en el DataTable
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejo de errores
                        throw new Exception("Error al buscar el producto: " + ex.Message);
                    }
                }
            }
            return result;  // Retorna los productos encontrados
        }

        // Método para eliminar un producto por su código
        public int EliminarProducto(string codigo)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FRAN_MOTOSConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Us_EliminarProducto", conn))  // Procedimiento almacenado para eliminar productos
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@codigo", codigo);  // Parámetro del código del producto a eliminar

                    try
                    {
                        // Abre la conexión y ejecuta la eliminación
                        conn.Open();
                        return cmd.ExecuteNonQuery();  // Retorna el número de filas afectadas
                    }
                    catch (Exception ex)
                    {
                        // Manejo de errores
                        throw new Exception("Error al eliminar el producto: " + ex.Message);
                    }
                }
            }
        }

        //Metodo para obtener id del producto
        public DataTable ObtenerIdProducto()
        {
            // Definir una instancia DataTable para almacenar el resultado
            DataTable result = null;

            // Obtener la cadena de conexión desde el archivo de configuración
            string connectionString = ConfigurationManager.ConnectionStrings["FRAN_MOTOSConnectionString"].ConnectionString;

            // Crear una nueva conexión SQL usando la cadena de conexión
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Crear un nuevo comando SQL para ejecutar el procedimiento almacenado
                using (SqlCommand cmd = new SqlCommand("Us_ObtenerIdProducto", conn))
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

        /// <summary>
        /// 
        ///METODO PARA MOSTRAR PRODUSTOS PARA REALIZAR UNA VENTA
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public DataTable MostrarProductos()
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
                        cmd.CommandText = "Us_MostrarProductos"; // Asegúrate de que el nombre del procedimiento almacenado es correcto

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

        // Método para ver todos los productos disponibles para vender
        public DataTable VerProductos()
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
                        cmd.CommandText = "Us_MostrarProductos"; // Asegúrate de que el nombre del procedimiento almacenado es correcto

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

        //Metodo para verificar la acntidad disponible en el inventario antes de hacer la compra
        public static int ObtenerCantidadDisponibleProducto(string codigo)
        {
            int cantidadDisponible = 0;

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FRAN_MOTOSConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Us_ObtenerCantidadProducto", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Codigo", codigo);

                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        cantidadDisponible = Convert.ToInt32(result);
                    }
                }
            }

            return cantidadDisponible;
        }



    }// Fin de la clase

}
