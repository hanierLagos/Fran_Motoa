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
        public DataTable ReadProducto(string codigo)
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
                        cmd.CommandText = "Us_ReadProducto";  // Procedimiento almacenado para leer productos
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

        // Método para actualizar un producto en la base de datos
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
    }

    
}
