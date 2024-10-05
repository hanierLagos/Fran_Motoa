using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class Marca_Logic
    {
        public static DataTable ObtenerIdMarca()
        {
            Marca_Data md= new Marca_Data();
            return md.ObtenerIdMarca();
        }
    }
}
