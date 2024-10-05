using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataLayer;

namespace LogicLayer
{
    public class Detalle_EntradaLogic
    {
        public static int AgregarDetalleEntrada(int idEntrada, int idProducto, int cantidad, Decimal precioEntrada, Decimal precioVenta)
        {
            Detalle_Entrada detalle = new Detalle_Entrada();

            detalle.ID_ENTRADA = idEntrada;
            detalle.ID_PRODUCTO = idProducto;
            detalle.CANTIDAD = cantidad;
            detalle.PRECIO_ENTRADA = precioEntrada;
            detalle.PRECIO_VENTA = precioVenta;


            Detalle_EntradaData data = new Detalle_EntradaData();
            return data.CrearDetalleEntrada(detalle);

        }


    }
}
