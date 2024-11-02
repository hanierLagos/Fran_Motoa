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
            CargarMarcaComboBox();
            CargarCategoriaComboBox();
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
            CargarMarcaComboBox();
            CargarCategoriaComboBox();
        }

        //Metodo para cargar las marcas existentes en un ComboBox
        private void CargarMarcaComboBox()
        {
            //Cargar el listado de las marcas       
            foreach (DataRow r in Marca_Logic.ObtenerIdMarca().Rows)
            {
                //Cargar los nombres de las marcas
                cmbMarca.Items.Add(r["NOMBRE_MARCA"].ToString());
                idM.Add(int.Parse(r["ID_MARCA"].ToString()));
            }//Fin de la instrucción foreach
        }

        //Metodo para cargar las categorias existentes en un ComboBox
        private void CargarCategoriaComboBox()
        {

            //Cargar el listado de las categorias       
            foreach (DataRow r in Categoria_Logic.ObtenerIdCategoria().Rows)
            {
                //Cargar los nombres de las categorias
                cmbCategoria.Items.Add(r["NOMBRE_CATEGORIA"].ToString());
                idC.Add(int.Parse(r["ID_CATEGORIA"].ToString()));
            }//Fin de la instrucción foreach     
        }
        private void FrmProducto_Load(object sender, EventArgs e)
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

                int selectedMarca = idM[this.cmbMarca.SelectedIndex];
                int selectedCategoria = idC[this.cmbCategoria.SelectedIndex];

                int val = Producto_Logic.CrearProductoEntrada_Logic(this.mskCodigo.Text,
                    this.txtNombre.Text,
                    decimal.Parse(this.txtPrecioProducto.Text),
                    selectedMarca,
                    selectedCategoria,
                    int.Parse(this.txtCantidad.Text)

                );

                if (val >0)
                {
                    MessageBox.Show("El registro del producto ha sido registrado correctamente.", "Registrar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mskCodigo.Clear();
                    txtNombre.Clear();
                    txtPrecioProducto.Clear();
                    cmbCategoria.SelectedIndex = 0;
                    cmbMarca.SelectedIndex = 0;
                    txtCantidad.Clear();    
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Registrar Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        //Metodo para limpiar todos los Campos



    }
}
