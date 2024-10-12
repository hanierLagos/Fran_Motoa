using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PresentacionLayer.Catalogos;
using PresentacionLayer.Operaciones;

namespace PresentacionLayer.Menus
{
    public partial class FrmMenuVentas : Form
    {
        private Form frmActive = null;

        public FrmMenuVentas()
        {
            InitializeComponent();
        }

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

        private void pnlView_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmMenuVentas_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmVentas());
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmListaProductos());
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            OpenForm(new frmListClientes());
        }
    }
}
