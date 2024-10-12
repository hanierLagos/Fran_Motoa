using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

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
    }
}
