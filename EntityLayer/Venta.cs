using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Venta
    {
        public int ID_VENTA {  get; set; }
        public int ID_CLIENTE { get; set; }
        public int NUMERO_VENTA { get; set; }
        public DateTime FECHA_VENTA { get; set; }
        public Decimal MONTO_TOTAL { get; set; }
        public string METODO_PAGO { get; set; }
        public string ESTADO {  get; set; }
    }
}
