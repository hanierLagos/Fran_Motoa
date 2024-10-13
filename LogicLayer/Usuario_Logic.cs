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
    public class Usuario_Logic
    {
        // Método para autenticar al usuario
        public bool AuthenticateUser(string user, string pass, string area)
        {
            Usuario_Data userData = new Usuario_Data();
            return userData.Autenticacion(user, pass, area);
        }


        public static int CrearUsuario_Logic(string codigo,string rol, string nombres, string apellidos, string usuario, string contrasena)
        {
            //Crear la instancia de Entidad

            Usuario u= new Usuario(codigo,rol, nombres, apellidos, usuario, contrasena);

            //Crear una instancia para la capa de datos

            Usuario_Data data = new Usuario_Data();

            if (data.LeerUsuario(codigo) == null)
            {
                return data.CrearUsuaeio(u);

            }
            else
            {
                //En caso de que exista un registro con le mismo cdigo solo se actualiza
                return data.ActualizaruUsuario(u);
            }
        }// FIn de metodo

        public static DataTable LeerUsuarioLogic(string filter)
        {
            // Llamar al método de búsqueda de la capa de datos
            Usuario_Data data = new Usuario_Data();
            return data.LeerUsuario(filter);
        }// fin de metodo

        public static int EliminarUsuarioLogic(string codigo)
        {
            Usuario_Data data = new Usuario_Data();
            return data.EliminarUsuario(codigo);
        }

        public static DataTable MostrarUsuarios()
        {
            Usuario_Data data = new Usuario_Data();
            return data.MostrarUsuarios();

        }
    }
}
