using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace LogicLayer
{
    public class Categoria_Logic
    {
        public static DataTable ObtenerIdCategoria()
        {
            Categoria_Data categoria_Data = new Categoria_Data();
            return categoria_Data.ObtenerIdCategoria();
        }
    }
}
