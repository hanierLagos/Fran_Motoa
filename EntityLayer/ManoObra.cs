using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class ManoObra
    {
        public int ID_MANO_OBRA { get; set; }
        public int ID_VENTA { get; set; }
        public int ID_TIPO { get; set; }
        public string DESCRIPCION { get; set; } 
        public Decimal PRECIO_OBRA { get; set; }
    }
}
