using PresentacionLayer.Catalogos;
using PresentacionLayer.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PresentacionLayer.Login;
using PresentacionLayer.Operaciones;
using PresentacionLayer.Reportes;
using System.Data.SqlClient;



namespace PresentacionLayer
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string connectionString = "Data Source=DESKTOP-7GLINRR\\MSSQLSERVER01;Initial Catalog=TALLER_FRANC;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Conexión exitosa.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error de conexión: " + ex.Message);
                }
            }
            Application.Run(new FrmLogin());
        }
    }
}
