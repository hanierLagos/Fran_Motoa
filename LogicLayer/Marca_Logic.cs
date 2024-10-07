using DataLayer;
using EntityLayer;
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


        public static int CrearMarca_Logic(string codigo, string nombre)
        {
            //Crear la instancia de Entidad

            Marcas m = new Marcas();
            m.CODIGO_MARCAA=codigo;
            m.NOMBRE_MARCA=nombre;

            //Crear una instancia para la capa de datos
            Marca_Data data = new Marca_Data();

            if (data.ReadMarca(codigo) == null)
            {
                return data.CrearMarca(m);

            }
            else
            {
                //En caso de que exista un registro con le mismo cdigo solo se actualiza
                return data.ActualizarMarca(m);
            }
        }// FIn de metodo

        public static DataTable GetMarcaLogic(string filter)
        {
            // Llamar al método de búsqueda de la capa de datos
            Marca_Data data = new Marca_Data();
            return data.ReadMarca(filter);
        }// fin de metodo

        public static DataTable ReadTopMarcaLogic(int numRows)
        {
            //Crear una nueva instancia de la capa de datos
            Marca_Data data = new Marca_Data();
            return data.ReadLastMarca(numRows);
        }// Fin de metodo


        public DataTable BuscarMarcaPorNombre(string nombre)
        {
            Marca_Data data = new Marca_Data();
            return data.BuscarMarcaPorNombre(nombre);
        }

    }
}
