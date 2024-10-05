using BussinesLayer;
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
    public partial class FrmProducto : Form
    {
        private List<int> idM = new List<int>();
        private List<int> idC = new List<int>();
        public FrmProducto(string codigo, string nombre, Decimal precio, string marca, string categoria, int cantidad)
        { 
            InitializeComponent();
            mskCodigo.Text = codigo;
            txtNombre.Text = nombre;
            txtPrecioProducto.Text = precio.ToString();
            cmbMarca.Text = marca;
            cmbCategoria.Text = categoria;
            txtCantidad.Text = cantidad.ToString();
        }

        public FrmProducto()
        {
            InitializeComponent();
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            //Cargar el listado de las marcas       
            foreach (DataRow r in Marca_Logic.ObtenerIdMarca().Rows)
            {
                //Cargar los nombres de las marcas
                cmbMarca.Items.Add(r["NOMBRE_MARCA"].ToString());
                idM.Add(int.Parse(r["ID_MARCA"].ToString()));
            }//Fin de la instrucción foreach

            //Mandar a mostrar el primer indice
            cmbMarca.SelectedIndex = -1;

            //Cargar el listado de las categorias       
            foreach (DataRow r in Categoria_Logic.ObtenerIdCategoria().Rows)
            {
                //Cargar los nombres de las categorias
                cmbCategoria.Items.Add(r["NOMBRE_CATEGORIA"].ToString());
                idC.Add(int.Parse(r["ID_CATEGORIA"].ToString()));
            }//Fin de la instrucción foreach

            //Mandar a mostrar el primer indice
            cmbCategoria.SelectedIndex = -1;

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(mskCodigo.Text) || string.IsNullOrEmpty(txtNombre.Text) ||
                    string.IsNullOrEmpty(txtPrecioProducto.Text) || string.IsNullOrEmpty(txtCantidad.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int selectedMarca = idM[cmbMarca.SelectedIndex];
                int selectedCategoria = idC[cmbCategoria.SelectedIndex];

                int val = Producto_Logic.CrearProducto_Logic(
                    mskCodigo.Text,
                    txtNombre.Text,
                    decimal.Parse(txtPrecioProducto.Text),
                    selectedMarca,
                    selectedCategoria,
                    int.Parse(txtCantidad.Text)
                );

                if (!(val > 0))
                {
                    MessageBox.Show("El registro del producto ha sido registrado correctamente.", "Registrar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el producto. Intente nuevamente.", "Registrar Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Registrar Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
    }
}
