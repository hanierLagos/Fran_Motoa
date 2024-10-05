using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Entrada_Inventario
    {
       public int ID_ENTRADA {  get; set; }   
       public int NUMERO_ENTRADA { get; set; }
        public DateTime FECHA_ENTRADA { get; set; }
        public string DESCRIPCION { get; set; }
    }
}
