using PresentacionLayer.Catalogos;
using PresentacionLayer.Operaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionLayer.Menus
{
    public partial class FrmInventario : Form
    {
        private Form frmActive = null;

        public FrmInventario()
        {
            InitializeComponent();
        }

        //Metodo pra abriri los formularios en un panel 
        private void OpenForm(Form frmHijo)
        {
            if (frmActive != null)
            {
                frmActive.Close();
            }
            frmActive = frmHijo;
            frmActive.TopLevel = false;
            frmActive.Dock = DockStyle.Fill;
            frmActive.FormBorderStyle = FormBorderStyle.None;
            pnlView.Controls.Add(frmHijo);
            pnlView.Tag = frmHijo;
            frmActive.Show();
        }
        private void FrmInventario_Load(object sender, EventArgs e)
        {

        }


        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {

            OpenForm(new FrmListaProductos());

        }

        private void FrmInventario_Load_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void btnEntradas_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmEntradas_Inventario());

        }
    }
}
