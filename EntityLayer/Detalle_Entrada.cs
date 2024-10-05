using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Detalle_Entrada
    {
        public int ID_DETALLE_ENTRADA {  get; set; }
        public int ID_ENTRADA { get; set; }
        public int ID_PRODUCTO { get; set; }
        public int CANTIDAD {  get; set; }  
        public Decimal PRECIO_ENTRADA { get; set; }
        public Decimal PRECIO_VENTA { get; set; }
    }
}
