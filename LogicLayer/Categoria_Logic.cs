using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using EntityLayer;

namespace LogicLayer
{
    public class Categoria_Logic
    {
        public static DataTable ObtenerIdCategoria()
        {
            Categoria_Data categoria_Data = new Categoria_Data();
            return categoria_Data.ObtenerIdCategoria();
        }


        public static int CrearCategoria_Logic(string codigo, string nombre)
        {
            //Crear la instancia de Entidad

            Categorias c = new Categorias();
            c.CODIGO_CATEGORIA = codigo;
            c.NOMBRE_CATEGORIA = nombre;

            //Crear una instancia para la capa de datos
            Categoria_Data data = new Categoria_Data();

            if (data.ReadCategoria(codigo) == null)
            {
                return data.CrearCategoria(c);

            }
            else
            {
                //En caso de que exista un registro con le mismo cdigo solo se actualiza
                return data.ActualizarCategoria(c);
            }
        }// FIn de metodo

        public static DataTable GetCategoriaLogic(string filter)
        {
            // Llamar al método de búsqueda de la capa de datos
            Categoria_Data data = new Categoria_Data();
            return data.ReadCategoria(filter);
        }// fin de metodo

        public static DataTable ReadTopCategoriaLogic(int numRows)
        {
            //Crear una nueva instancia de la capa de datos
            Categoria_Data data = new Categoria_Data();
            return data.ReadLastCategoria(numRows);
        }// Fin de metodo


        public DataTable BuscarCategoriaPorNombre(string nombre)
        {
            Categoria_Data data = new Categoria_Data();
            return data.BuscarCategoriaPorNombre(nombre);
        }
    }
}
