using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class Detalle_VentaLogic
    {
        //Metodo para agregar un detalle del producto vendido 
        public static int AgregarDetalleVenta(int idVenta, int idProducto, int cantidad, Decimal precioUnitario, Decimal SubTotal, string descripcion)
        {
            Dettale_Venta detalle = new Dettale_Venta();

            detalle.ID_VENTA = idVenta;
            detalle.ID_PRDUCTO = idProducto;
            detalle.CANTIDAD = cantidad;
            detalle.PRECIO_UNITARIO = precioUnitario;
            detalle.SUBTOTAL = SubTotal;
            detalle.DESCRIPCION = descripcion;


            Detalle_VentaData data = new Detalle_VentaData();
            return data.CrearDetalleVenta(detalle);

        }
    }
}
