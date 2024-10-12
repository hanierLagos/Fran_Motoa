using PresentacionLayer.Catalogos;
using PresentacionLayer.Login;
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
    public partial class FrmAdministrador : Form
    {
        private Form frmActive = null;

        public FrmAdministrador()
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
        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void FrmAdministrador_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmVentas());
        }

        private void BtnInventario_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmListaProductos());
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            OpenForm(new frmListClientes());
        }

        private void pnlView_Paint(object sender, PaintEventArgs e)
        {

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
    }
}
