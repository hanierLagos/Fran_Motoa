using EntityLayer;
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
    public class Detalle_VentaData
    {
        // Método para crear un detalle en la base de datos
        public int CrearDetalleVenta(Dettale_Venta p)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FRAN_MOTOSConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "Us_AgregarDetalleVenta";

                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@IdVenta", p.ID_VENTA);
                        cmd.Parameters.AddWithValue("@IdProducto", p.ID_PRDUCTO);
                        cmd.Parameters.AddWithValue("@Cantidad", p.CANTIDAD);
                        cmd.Parameters.AddWithValue("@PrecioUnitario", p.PRECIO_UNITARIO);
                        cmd.Parameters.AddWithValue("@SubTotal", p.SUBTOTAL);
                        cmd.Parameters.AddWithValue("@Descripcion", p.DESCRIPCION);

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
    }
}
