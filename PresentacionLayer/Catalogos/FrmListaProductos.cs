using BussinesLayer;
using LogicLayer;
using PresentacionLayer.Menus;
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

namespace PresentacionLayer.Catalogos
{
    public partial class FrmListaProductos : Form
    {
        private DataTable originalDataTable;

        public FrmListaProductos()
        {
            InitializeComponent();
            cmbFilter.SelectedIndex = 0;
        }
        private void CargarProductos(DataTable dt)
        {
            // Limpiar las filas del DataGridView
            DG_Productos.Rows.Clear();

            // Recorrer los elementos para agregarlos al DataGridView
            foreach (DataRow dr in dt.Rows)
            {
                DG_Productos.Rows.Add(
                    dr["CODIGO_PRODUCTO"].ToString(),
                    dr["NOMBRE_PRODUCT"].ToString(),
                    dr["PRECIO_PRODUCTO"].ToString(),
                    dr["NOMBRE_MARCA"].ToString(),
                    dr["NOMBRE_CATEGORIA"].ToString(),
                     dr["CANTIDAD"].ToString(),
                    imgCrud.Images[0],
                    imgCrud.Images[1]
                );
            }
        }
        private void DG_Productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Verificar si se ha optado por la selección de edición del cliente
                if (e.ColumnIndex == 6) // Columna para editar
                {
                    string codigo = DG_Productos.CurrentRow.Cells[0].Value.ToString();
                    string nombre = DG_Productos.CurrentRow.Cells[1].Value.ToString();

                    // Conversión de tipo con manejo de excepciones
                    decimal precio;
                    int cantidad;

                    // Intenta convertir el precio
                    if (!decimal.TryParse(DG_Productos.CurrentRow.Cells[2].Value.ToString(), out precio))
                    {
                        MessageBox.Show("Error al leer el precio del producto.", "Error de conversión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Salir del método si hay un error
                    }

                    // Intenta convertir la cantidad
                    if (!int.TryParse(DG_Productos.CurrentRow.Cells[5].Value.ToString(), out cantidad))
                    {
                        MessageBox.Show("Error al leer la cantidad del producto.", "Error de conversión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Salir del método si hay un error
                    }

                    string marca = DG_Productos.CurrentRow.Cells[3].Value.ToString();
                    string categoria = DG_Productos.CurrentRow.Cells[4].Value.ToString();

                    // Mandar abrir al formulario de producto con los valores de los campos
                    FrmProducto frmpro = new FrmProducto(codigo, nombre, precio, marca, categoria, cantidad);
                    frmpro.ShowDialog();
                    cmbFilter_SelectedIndexChanged(sender, e);
                }
                else if (e.ColumnIndex == 7) // Columna para eliminar
                {
                    
                    MessageBox.Show("Error al dar de baja al Producto:\n 'Los Productos no se pueden eliminar por razones Internas' " , "Eliminar Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                }
            } // END- IF

        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Obtener la cantidad de registros que se deben visualizar
                int row = Convert.ToInt32(cmbFilter.SelectedItem.ToString());

                DataTable dt = Producto_Logic.ReadTopProductoLogic(row);

                // Invocar el método que se encarga del llenado de los datos
                CargarProductos(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Cargar los Productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmListaProductos_Load(object sender, EventArgs e)
        {
            originalDataTable = Producto_Logic.ReadTopProductoLogic(5);
            CargarProductos(originalDataTable); // Mostrar datos en el DataGridView
            WindowState = FormWindowState.Maximized;

        }

        private void mskCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Si se produce el evento al presionar la tecla Enter, se manda a llamar el método encargado de buscar
            if (e.KeyChar == (char)13)
            {
                // Mandar la solicitud por el controlador
                DataTable productoData = Producto_Logic.GetProductoLogic(mskCodigo.Text);

                if (productoData == null || productoData.Rows.Count == 0)
                {
                    MessageBox.Show("No se encuentra el registro del producto especificado: " + mskCodigo.Text, "Buscar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    // Mandar a cargar los registros recuperados en el DataGridView
                    CargarProductos(productoData);
                }
            }
        }

        private void txtBuscra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Verificar si hay texto en el TextBox.
                if (string.IsNullOrWhiteSpace(txtBuscra.Text))
                {
                    // Si no hay texto, mostrar todos los datos originales.
                    foreach (DataGridViewRow row in DG_Productos.Rows)
                    {
                        row.Visible = true; // Hacer visible cada fila.
                    }
                    return;
                }

                // Filtrar filas que coincidan con el texto ingresado.
                foreach (DataGridViewRow row in DG_Productos.Rows)
                {
                    // Verificar si la fila contiene el texto en NOMBRES o APELLIDOS.
                    bool isVisible = row.Cells["NOMBRE_PRODUCT"].Value.ToString().IndexOf(txtBuscra.Text, StringComparison.OrdinalIgnoreCase) >= 0;
                    // Establecer la visibilidad de la fila según el resultado de la búsqueda.
                    row.Visible = isVisible;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            FrmProducto frmProducto = new FrmProducto();
            frmProducto.ShowDialog();   
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmInventario frmInventario = new FrmInventario();
            frmInventario.ShowDialog();
            this.Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmEntradas_Inventario frmEntradas_Inventario= new FrmEntradas_Inventario();
            frmEntradas_Inventario.ShowDialog();
        }
    }
}
