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
    public partial class FrmMarca : Form
    {
      
        public FrmMarca(string codigo, string nombre)
        {
            InitializeComponent();
            txtCodigo.Text = codigo;
            txtNombre.Text = nombre;
        }
        public FrmMarca()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if 
                (string.IsNullOrEmpty(txtCodigo.Text) || string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           //Crear un ainstancia para guardar segun la logica
           int val = Marca_Logic.CrearMarca_Logic(txtCodigo.Text, txtNombre.Text);
            if (val > 0)
            {
                MessageBox.Show("El registro de la Marca ha sido registrado correctamente.", "Registrar Marca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodigo.Clear();
                txtNombre.Clear();
            }

        }

        private void FrmMarca_Load(object sender, EventArgs e)
        {

        }
    }
}
