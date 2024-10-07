using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionLayer.Catalogos
{
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
        }

        public FrmCategoria(string codigo, string nombre)
        {
            InitializeComponent();
            txtCodigo.Text = codigo;
            txtNombre.Text = nombre;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text) || string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Crear un ainstancia para guardar segun la logica
            int val = Categoria_Logic.CrearCategoria_Logic(txtCodigo.Text, txtNombre.Text);
            if (val > 0)
            {
                MessageBox.Show("El registro de la Categoría ha sido registrado correctamente.", "Registrar Categoría", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodigo.Clear();
                txtNombre.Clear();
            }
        }
    }
}
