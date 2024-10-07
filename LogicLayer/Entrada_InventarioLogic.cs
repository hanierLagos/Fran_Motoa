using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using EntityLayer;

namespace BussinesLayer
{
    public class Entrada_InventarioLogic
    {
        public static int CrearEntrada_Logic(int numero, DateTime fecha, string descripcion)
        {
            //Crear la instancia de Entidad

            Entrada_Inventario e = new Entrada_Inventario
            {
                NUMERO_ENTRADA = numero,
                FECHA_ENTRADA = fecha,
                DESCRIPCION = descripcion,
                
            };

            //Crear una instancia para la capa de datos

            Entrada_InventarioData ed = new Entrada_InventarioData();

            if (ed.ReadEntrad(numero) == null)
            {
                return ed.CrearEntrada(e);

            }
            else
            {
                //En caso de que exista un registro con le mismo cdigo solo se actualiza
                return ed.ActualizarEntrada(e);
            }
        }// FIn de metodo

        public static int ObtenerNumeroEntrada()
        {
            try
            {
                Entrada_InventarioData data = new Entrada_InventarioData();
                return data.ObtenerNumeroEntrada();
            }
            catch (Exception ex)
            {
                throw new Exception("Error en GetNextBuyNumber: " + ex.Message, ex);
            }
        }


        //Metodo pra obtener id de la entrada
        public static DataTable ObtenerIdEntrada()
        {
            Entrada_InventarioData ed = new Entrada_InventarioData();
            return ed.ObtenerIdEntrdada();

        }

        
        public static DataTable VerEntradas()
        {
            Entrada_InventarioData data = new Entrada_InventarioData();
            return data.VerEntradas();
        
        }
    }
}
