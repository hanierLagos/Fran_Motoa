using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Productos
    {
        public int ID_PRODUCTO {  get; set; }
        public string CODIGO_PRODUCTO { get; set; }
        public string NOMBRE_PRODUCTO { get; set; }
        public Decimal PRECIO {  get; set; }
        public int ID_MARCA {  get; set; }
        public int ID_CATEGORIA { get; set; }

        public int CANTIDAD { get; set; }
        public string ESTADO { get; set; }



    }
}
