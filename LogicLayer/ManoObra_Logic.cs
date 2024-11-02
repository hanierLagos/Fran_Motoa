using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class ManoObra_Logic
    {
        //Metodo pra obtener id del cliente
        public static DataTable CargarTipoManoObra()
        {
            ManoObra_Data data = new ManoObra_Data();
            return data.CargarTipoManoObra();

        }

        //Metodo para agregar un detalle de mano deobra vendido 
        public static int AgregarDetalleObra(int idVenta, int idTipo, string descripcion, Decimal precio)
        {
            ManoObra detalle = new ManoObra();

            detalle.ID_VENTA = idVenta;
            detalle.ID_TIPO = idTipo;
            detalle.DESCRIPCION = descripcion;
            detalle.PRECIO_OBRA = precio;

            ManoObra_Data data = new ManoObra_Data();
            return data.CrearDetalleObra(detalle);

        }
    }
}
