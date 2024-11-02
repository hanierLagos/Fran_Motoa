using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer
{
    public class Cliente_Logic
    {
        public static int CrearCiente_Logic(string codigo, string nombres, string apellidos, string telefono, string direccion)
        {
            //Crear la instancia de Entidad

            Cliente c = new Cliente(codigo, nombres, apellidos, telefono, direccion);

            //Crear una instancia para la capa de datos

            Cliente_Data cd = new Cliente_Data();

            if (cd.ReadCliente(codigo) == null)
            {
                return cd.CrearCliente(c);

            }
            else
            {
                //En caso de que exista un registro con le mismo cdigo solo se actualiza
                return cd.ActualizarCliente(c);
            }
        }// FIn de metodo

        public static DataTable GetClientLogic(string filter)
        {
            // Llamar al método de búsqueda de la capa de datos
            Cliente_Data cd = new Cliente_Data();
            return cd.ReadCliente(filter);
        }// fin de metodo
        public static DataTable ReadTopClienteLogic(int val)
        {
            //Crear una nueva instancia de la capa de datos
            Cliente_Data cd = new Cliente_Data();

            //Invocar al método para la lectura de datos
            return cd.ReadLastClient(val);
        }// Fin de metodo



        public DataTable BuscarClientePorNombre(string nombre)
        {
            Cliente_Data clienteData = new Cliente_Data();
            return clienteData.BuscarClientePorNombre(nombre);
        }

        public static int EliminarClienteLogic(string codigo)
        {
            Cliente_Data cd = new Cliente_Data();
            return cd.EliminarCliente(codigo);
        }

        //Metodo pra obtener id del cliente
        public static DataTable CargarClientesVenta()
        {
            Cliente_Data data = new Cliente_Data();
            return data.CargarClientesVenta();

        }

    }
}
