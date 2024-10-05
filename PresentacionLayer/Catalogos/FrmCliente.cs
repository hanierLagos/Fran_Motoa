using BussinesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PresentacionLayer.Catalogos
{
    public partial class FrmCliente : Form
    {
       

        public FrmCliente(string codigo, string nombres, string apellidos, string telefono, string direccion)
        {
            InitializeComponent();
            txtCodigo.Text = codigo;
            txtNombres.Text = nombres;
            txtApellidos.Text = apellidos;
            txtTelefono.Text = telefono;
            txtDireccion.Text = direccion;
            txtCodigo.Focus();

        }

        public FrmCliente()
        {
            InitializeComponent();
            txtCodigo.Focus();

        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Validar la entrada del usuario
                if (
                string.IsNullOrEmpty(txtCodigo.Text) ||
                    string.IsNullOrEmpty(txtNombres.Text) ||
                    string.IsNullOrEmpty(txtApellidos.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                int val = Cliente_Logic.CrearCiente_Logic(this.txtCodigo.Text, this.txtNombres.Text,
                    this.txtApellidos.Text, this.txtTelefono.Text, this.txtDireccion.Text);

                // Llamar a la lógica de negocios para agregar insumos
                if (val > 0)
                {
                    MessageBox.Show(" El regustro del cliente " + "\nCodigo: " + this.txtCodigo.Text
                             + "\n ha sido registrado correctamente.", "Registrar Cliente", MessageBoxButtons.OK,
                              MessageBoxIcon.Information);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Registrar Cliente", MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
            }
        }
    }
}
