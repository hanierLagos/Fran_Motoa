using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace LogicLayer
{
    public class VentaLogic
    {
        public static DataTable ObtenerIdVenta()
        {
            VentaData data = new VentaData();
            return data.ObtenerIdVenta();
        }


        public static int CrearVenta_Logic(int idCliente, int numero,DateTime fecha, Decimal montoTotal, string metodoPago)
        {
            //Crear la instancia de Entidad

            Venta v = new Venta();
            v.ID_CLIENTE = idCliente;
            v.NUMERO_VENTA = numero;
            v.FECHA_VENTA = fecha;
            v.MONTO_TOTAL = montoTotal;
            v.METODO_PAGO = metodoPago;

            //Crear una instancia para la capa de datos
            VentaData data = new VentaData();

            if (data.ReadVenta(numero) == null)
            {
                return data.CrearVenta(v);

            }
            else
            {
                //En caso de que exista un registro con le mismo cdigo solo se actualiza
                return data.ActualizarVenta(v);
            }
        }// FIn de metodo


        //metodo para anular venta
        public static int AnularVenta(int nVennta)
        {
            VentaData data = new VentaData();
            return data.AnularVenta(nVennta);
        }

        //metodo para obtener el siguiente numero de venta
        public static int ObtenerNumeroVenta()
        {
            VentaData ventaData = new VentaData();
            return ventaData.ObtenerNumeroVenta();

        }

    }
}
