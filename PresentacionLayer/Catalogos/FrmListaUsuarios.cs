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
    public partial class FrmListaUsuarios : Form
    {
        private DataTable originalDataTable;

        public FrmListaUsuarios()
        {
            InitializeComponent();
        }
        private void CargarUsuarios(DataTable dt)
        {
            // Limpiar las filas del DataGridView
            DG_Usuarios.Rows.Clear();

            // Recorrer los elementos para agregarlos al DataGridView
            foreach (DataRow dr in dt.Rows)
            {
                DG_Usuarios.Rows.Add(
                    dr["CODIGO_USUARIO"].ToString(),
                    dr["NOMBRES"].ToString(),
                    dr["APELLIDOS"].ToString(),
                    dr["ROL"].ToString(),
                    dr["USUARIO"].ToString(),
                    dr["CONTRASENA"].ToString(),
                    imgCrud.Images[0],
                    imgCrud.Images[1]
                );
            }
        }
        private void FrmListaUsuarios_Load(object sender, EventArgs e)
        {
            originalDataTable = Usuario_Logic.MostrarUsuarios();
            CargarUsuarios(originalDataTable); // Mostrar datos en el DataGridView
            WindowState = FormWindowState.Maximized;
        }

        private void DG_Usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Verificar si se ha optado por la selección de edición del suario
                if (e.ColumnIndex == 6)
                {
                    string codigo = DG_Usuarios.CurrentRow.Cells[0].Value.ToString();
                    string nombres = DG_Usuarios.CurrentRow.Cells[1].Value.ToString();
                    string apellidos = DG_Usuarios.CurrentRow.Cells[2].Value.ToString();
                    string rol = DG_Usuarios.CurrentRow.Cells[3].Value.ToString();
                    string usuario = DG_Usuarios.CurrentRow.Cells[4].Value.ToString();
                    string contrasena = DG_Usuarios.CurrentRow.Cells[5].Value.ToString();


                    // Mandar abrir al formulario de usuario para con los valores de los campos
                    FrmUsuario frm = new FrmUsuario(codigo, nombres, apellidos,rol, usuario, contrasena);
                    frm.ShowDialog();

                }
                else if (e.ColumnIndex == 7)
                {
                    // Confirmar la eliminación
                    var confirmResult = MessageBox.Show("¿Está seguro que desea dar de baja a este Usuario?", "Confirmar Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirmResult == DialogResult.Yes)
                    {
                        try
                        {
                            string codigo = DG_Usuarios.Rows[e.RowIndex].Cells[0].Value.ToString(); // Obtener ID como string
                            int rst = Usuario_Logic.EliminarUsuarioLogic(codigo);
                            if (rst > 0)
                            {
                                MessageBox.Show("El registro del Usuario ha sido dado de baja", "Baja de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al dar de baja al Usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }// END- IF
        }

        private void txtBuscra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Verificar si hay texto en el TextBox.
                if (string.IsNullOrWhiteSpace(txtBuscra.Text))
                {
                    // Si no hay texto, mostrar todos los datos originales.
                    foreach (DataGridViewRow row in DG_Usuarios.Rows)
                    {
                        row.Visible = true; // Hacer visible cada fila.
                    }
                    return;
                }

                // Filtrar filas que coincidan con el texto ingresado.
                foreach (DataGridViewRow row in DG_Usuarios.Rows)
                {
                    // Verificar si la fila contiene el texto en NOMBRES o APELLIDOS.
                    bool isVisible = row.Cells["NOMBRES"].Value.ToString().IndexOf(txtBuscra.Text, StringComparison.OrdinalIgnoreCase) >= 0;
                    bool visibleUsuario = row.Cells["usuario"].Value.ToString().IndexOf(txtBuscra.Text, StringComparison.OrdinalIgnoreCase) >= 0;
                    // Establecer la visibilidad de la fila según el resultado de la búsqueda.
                    row.Visible = isVisible;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmUsuario frmUsuario = new FrmUsuario();
            frmUsuario.ShowDialog();    
        }
    }
}
