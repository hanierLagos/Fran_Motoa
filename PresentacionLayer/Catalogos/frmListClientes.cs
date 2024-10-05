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

namespace PresentacionLayer.Catalogos
{
    public partial class frmListClientes : Form
    {
        private DataTable originalDataTable;

        public frmListClientes()
        {
            InitializeComponent();
            cmbFilter.SelectedIndex = 0;

           
        }
        private void CargarCliente(DataTable dt)
        {
            // Limpiar las filas del DataGridView
            DG_Clientes.Rows.Clear();

            // Recorrer los elementos para agregarlos al DataGridView
            foreach (DataRow dr in dt.Rows)
            {
                DG_Clientes.Rows.Add(
                    dr["CODIGO_CLIENTE"].ToString(),
                    dr["NOMBRES"].ToString(),
                    dr["APELLIDOS"].ToString(),
                    dr["TELEFONO"].ToString(),
                    dr["DIRECCION"].ToString(),
                    imgCrud.Images[0],
                    imgCrud.Images[1]
                );
            }
        }

        private void DG_Clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Verificar si se ha optado por la selección de edición del cliente
                if (e.ColumnIndex == 5)
                {
                    string codigo = DG_Clientes.CurrentRow.Cells[0].Value.ToString();
                    string nombres = DG_Clientes.CurrentRow.Cells[1].Value.ToString();
                    string apellidos = DG_Clientes.CurrentRow.Cells[2].Value.ToString();
                    string telefono = DG_Clientes.CurrentRow.Cells[3].Value.ToString();
                    string direccion = DG_Clientes.CurrentRow.Cells[4].Value.ToString();
                   

                    // Mandar abrir al formulario de cliente para con los valores de los campos
                    FrmCliente frmclient = new FrmCliente(codigo, nombres, apellidos, telefono, direccion);
                    frmclient.ShowDialog();
                    
                }
                else if (e.ColumnIndex == 6)
                {
                    // Confirmar la eliminación
                    var confirmResult = MessageBox.Show("¿Está seguro que desea dar de baja a este cliente?", "Confirmar Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirmResult == DialogResult.Yes)
                    {
                        try
                        {
                            string codigo = DG_Clientes.Rows[e.RowIndex].Cells[0].Value.ToString(); // Obtener ID como string
                            int rst = Cliente_Logic.EliminarClienteLogic(codigo);
                            if (rst > 0)
                            {
                                MessageBox.Show("El registro del cliente ha sido dado de baja", "Baja de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // Recargar la lista de clientes después de eliminar
                                cmbFilter_SelectedIndexChanged(null, null);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al dar de baja al cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }// END- IF
        }

        private void frmListClientes_Load(object sender, EventArgs e)
        {
            // Cargar todos los clientes en originalDataTable al cargar el formulario
            originalDataTable = Cliente_Logic.ReadTopClienteLogic(100);
            CargarCliente(originalDataTable); // Mostrar datos en el DataGridView
           
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Obtener la cantidad de registros que se deben visualizar
                int row = Convert.ToInt32(cmbFilter.SelectedItem.ToString());

                DataTable dt = Cliente_Logic.ReadTopClienteLogic(row);

                // Invocar el método que se encarga del llenado de los datos
                CargarCliente(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void BtnGuestPlus_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente();
            frmCliente.ShowDialog();
        }

        private void txtBuscra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Verificar si hay texto en el TextBox.
                if (string.IsNullOrWhiteSpace(txtBuscra.Text))
                {
                    // Si no hay texto, mostrar todos los datos originales.
                    foreach (DataGridViewRow row in DG_Clientes.Rows)
                    {
                        row.Visible = true; // Hacer visible cada fila.
                    }
                    return;
                }

                // Filtrar filas que coincidan con el texto ingresado.
                foreach (DataGridViewRow row in DG_Clientes.Rows)
                {
                    // Verificar si la fila contiene el texto en NOMBRES o APELLIDOS.
                    bool isVisible = row.Cells["NOMBRES"].Value.ToString().IndexOf(txtBuscra.Text, StringComparison.OrdinalIgnoreCase) >= 0 ||
                                     row.Cells["APELLIDOS"].Value.ToString().IndexOf(txtBuscra.Text, StringComparison.OrdinalIgnoreCase) >= 0;

                    // Establecer la visibilidad de la fila según el resultado de la búsqueda.
                    row.Visible = isVisible;
                }

                // Comprobar si hay resultados.
                if (DG_Clientes.Rows.Cast<DataGridViewRow>().All(r => !r.Visible))
                {
                    MessageBox.Show("No se encontraron resultados para la búsqueda.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        private void txtBuscra_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscra.Text))
            {
                MessageBox.Show("Debe especificar la búsqueda.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtCodigo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // Si se produce el evento al presionar la tecla Enter, se manda a llamar el método encargado de buscar
            if (e.KeyChar == (char)13)
            {
                // Mandar la solicitud por el controlador
                DataTable clientData = Cliente_Logic.GetClientLogic(txtCodigo.Text);

                if (clientData == null || clientData.Rows.Count == 0)
                {
                    MessageBox.Show("No se encuentra el registro del cliente especificado: " + txtCodigo.Text, "Buscar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    // Mandar a cargar los registros recuperados en el DataGridView
                    CargarCliente(clientData);
                }
            }
        }
    }
}
