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
    public partial class FrmListaCategoriaMarcas : Form
    {
        private DataTable originalDataTableMarca;
        private DataTable originalDataTableCategoria;


        public FrmListaCategoriaMarcas()
        {
            InitializeComponent();
            cmbFilterMarca.SelectedIndex =0;
            cmbFilterCategoria.SelectedIndex = 0;

        }

        private void FrmListaCategoriaMarcas_Load(object sender, EventArgs e)
        {
            // Cargar todos los clientes en originalDataTable al cargar el formulario
            originalDataTableMarca = Marca_Logic.ReadTopMarcaLogic(5);
            CargarMarca(originalDataTableMarca); // Mostrar datos en el DataGridView

            // Cargar todos los clientes en originalDataTable al cargar el formulario
            originalDataTableCategoria = Categoria_Logic.ReadTopCategoriaLogic(5);
            CargarCategoria(originalDataTableCategoria); // Mostrar datos en el DataGridView
        }

        //Metodo para cargar las marcas en la tabla
        private void CargarMarca(DataTable dt)
        {
            // Limpiar las filas del DataGridView
            DG_Marcas.Rows.Clear();

            // Recorrer los elementos para agregarlos al DataGridView
            foreach (DataRow dr in dt.Rows)
            {
                DG_Marcas.Rows.Add(
                    dr["CODIGO_MARCA"].ToString(),
                    dr["NOMBRE_MARCA"].ToString(),
                    imgCrud.Images[0],
                    imgCrud.Images[1]
                );
            }
        }

        //Metodo para cargar las categorías en la tabla
        private void CargarCategoria(DataTable dt)
        {
            // Limpiar las filas del DataGridView
            DG_Categorias.Rows.Clear();

            // Recorrer los elementos para agregarlos al DataGridView
            foreach (DataRow dr in dt.Rows)
            {
                DG_Categorias.Rows.Add(
                    dr["CODIGO_CATEGORIA"].ToString(),
                    dr["NOMBRE_CATEGORIA"].ToString(),
                    imgCrud1.Images[0],
                    imgCrud1.Images[1]
                );
            }
        }

        private void DG_Marcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Verificar si se ha optado por la selección de edición del cliente
                if (e.ColumnIndex == 2)
                {
                    string codigo = DG_Marcas.CurrentRow.Cells[0].Value.ToString();
                    string nombres = DG_Marcas.CurrentRow.Cells[1].Value.ToString();


                    // Mandar abrir al formulario de cliente para con los valores de los campos
                    FrmMarca frmMarca = new FrmMarca(codigo, nombres);
                    frmMarca.ShowDialog();
                    cmbFilterMarca_SelectedIndexChanged(sender, e);

                }
                else if (e.ColumnIndex == 3)
                {
                    MessageBox.Show("Error al dar de baja a la Marca: \n 'La Marca debe mantenerse Registrada para Cualquier Entrada al Inventario ",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }// END- IF
        }

        private void cmbFilterMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Obtener la cantidad de registros que se deben visualizar
                int row = Convert.ToInt32(cmbFilterMarca.SelectedItem.ToString());

                DataTable dt = Marca_Logic.ReadTopMarcaLogic(row);

                // Invocar el método que se encarga del llenado de los datos
                CargarMarca(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las Marcas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscarMarca_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Verificar si hay texto en el TextBox.
                if (string.IsNullOrWhiteSpace(txtBuscarMarca.Text))
                {
                    // Si no hay texto, mostrar todos los datos originales.
                    foreach (DataGridViewRow row in DG_Marcas.Rows)
                    {
                        row.Visible = true; // Hacer visible cada fila.
                    }
                    return;
                }

                // Filtrar filas que coincidan con el texto ingresado.
                foreach (DataGridViewRow row in DG_Marcas.Rows)
                {
                    // Verificar si la fila contiene el texto en NOMBRES o APELLIDOS.
                    bool isVisible =row.Cells["NOMBRE_MARCA"].Value.ToString().IndexOf(txtBuscarMarca.Text, StringComparison.OrdinalIgnoreCase) >= 0;

                    // Establecer la visibilidad de la fila según el resultado de la búsqueda.
                    row.Visible = isVisible;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        private void txtCodigoMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                // Intentar recuperar datos de la marca
                DataTable marcaData = Marca_Logic.GetMarcaLogic(txtCodigoMarca.Text);

                if (marcaData == null || marcaData.Rows.Count == 0)
                {
                    MessageBox.Show("No se encuentra el registro de la Marca especificado: " + txtCodigoMarca.Text, "Buscar Marca", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    // Verificar si el DataTable tiene una columna llamada "CODIGO_MARCA"
                    if (!marcaData.Columns.Contains("CODIGO_MARCA"))
                    {
                        MessageBox.Show("Error: La columna 'CODIGO_MARCA' no se encuentra en los datos.", "Error de columna", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Cargar los datos en el DataGridView si todo está bien
                    CargarMarca(marcaData);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscarMarca.Text))
            {
                MessageBox.Show("Debe especificar la búsqueda.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DG_Categorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Verificar si se ha optado por la selección de edición del cliente
                if (e.ColumnIndex == 2)
                {
                    string codigo = DG_Categorias.CurrentRow.Cells[0].Value.ToString();
                    string nombres = DG_Categorias.CurrentRow.Cells[1].Value.ToString();


                    // Mandar abrir al formulario de cliente para con los valores de los campos
                    FrmCategoria frmCategoria = new FrmCategoria(codigo, nombres);
                    frmCategoria.ShowDialog();
                    cmbFilterCategoria_SelectedIndexChanged(sender, e);


                }
                else if (e.ColumnIndex == 3)
                {
                    MessageBox.Show("Error al dar de baja a la Categoría: \n 'La Categoría debe mantenerse Registrada para Cualquier Entrada al Inventario ",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }// END- IF

        }

        private void txtCodigoCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                // Intentar recuperar datos de la marca
                DataTable marcaData = Categoria_Logic.GetCategoriaLogic(txtCodigoCategoria.Text);

                if (marcaData == null || marcaData.Rows.Count == 0)
                {
                    MessageBox.Show("No se encuentra el registro de la Categoría especificado: " + txtCodigoCategoria.Text, "Buscar Categoría", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    // Verificar si el DataTable tiene una columna llamada "CODIGO_MARCA"
                    if (!marcaData.Columns.Contains("CODIGO_CATEGORIA"))
                    {
                        MessageBox.Show("Error: La columna 'CODIGO_CATEGORIA' no se encuentra en los datos.", "Error de columna", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Cargar los datos en el DataGridView si todo está bien
                    CargarCategoria(marcaData);
                }
            }
        }

        private void txtBuscarCategoria_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Verificar si hay texto en el TextBox.
                if (string.IsNullOrWhiteSpace(txtBuscarCategoria.Text))
                {
                    // Si no hay texto, mostrar todos los datos originales.
                    foreach (DataGridViewRow row in DG_Categorias.Rows)
                    {
                        row.Visible = true; // Hacer visible cada fila.
                    }
                    return;
                }

                // Filtrar filas que coincidan con el texto ingresado.
                foreach (DataGridViewRow row in DG_Categorias.Rows)
                {
                    // Verificar si la fila contiene el texto en NOMBRES o APELLIDOS.
                    bool isVisible = row.Cells["NOMBRE_CATEGORIA"].Value.ToString().IndexOf(txtBuscarCategoria.Text, StringComparison.OrdinalIgnoreCase) >= 0;

                    // Establecer la visibilidad de la fila según el resultado de la búsqueda.
                    row.Visible = isVisible;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        private void cmbFilterCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Obtener la cantidad de registros que se deben visualizar
                int row = Convert.ToInt32(cmbFilterCategoria.SelectedItem.ToString());

                DataTable dt = Categoria_Logic.ReadTopCategoriaLogic(row);

                // Invocar el método que se encarga del llenado de los datos
                CargarCategoria(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las Categorías: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
