using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Usuario_Data
    {
        //Metodo para que el usuario se pueda loguiar
        public bool Autenticacion(string user, string pass, string area)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["FRAN_MOTOSConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Us_AutenticacionUsuario", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@username", user);
                    cmd.Parameters.AddWithValue("@password", pass);
                    cmd.Parameters.AddWithValue("@area", area);

                    conn.Open();
                    int result = (int)cmd.ExecuteScalar();


                    return result > 0;
                }
            }
        }

    }
}
