using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Dettale_Venta
    {
        public int ID_DETALLE {  get; set; }
        public int ID_VENTA { get; set; }
        public int ID_PRDUCTO { get; set; }
        public int CANTIDAD { get; set; }
        public Decimal PRECIO_UNITARIO { get; set; }
        public decimal SUBTOTAL { get;set; }
        public string DESCRIPCION { get; set; } 
    }
}
