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
            Application.Run(new FrmProductosMasVendidos());
        }
    }
}
