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
using PresentacionLayer.Login;
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

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de diálogo de confirmación
            DialogResult result = MessageBox.Show("¿Estás seguro de que quieres cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Si el usuario confirma, cierra el formulario actual y muestra el frmLogin
            if (result == DialogResult.Yes)
            {

                this.Hide();
                FrmLogin Anterior = new FrmLogin();
                Anterior.ShowDialog();
                this.Close();
            }
        }

        private void BtnCaja_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmIngresosCaja());

        }

        private void BtnCaja_Click_1(object sender, EventArgs e)
        {
            OpenForm(new FrmIngresosCaja());
        }
    }
}
