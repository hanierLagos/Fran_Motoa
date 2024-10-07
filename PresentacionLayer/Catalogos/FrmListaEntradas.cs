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
    public partial class FrmListaEntradas : Form
    {
        public FrmListaEntradas()
        {
            InitializeComponent();
        }

        private void FrmListaEntradas_Load(object sender, EventArgs e)
        {
            // Llamamos al método que carga las entradas cuando el formulario se carga
            CargarEntradas();

        }
        // Método para cargar las entradas en el DataGridView
        private void CargarEntradas()
        {
            try
            {
                DataTable dt = Entrada_InventarioLogic.VerEntradas();

                // Limpiar el DataGridView antes de agregar nuevas filas
                DG_ListaEntradas.Rows.Clear();

                // Agregar cada entrada al DataGridView
                foreach (DataRow row in dt.Rows)
                {
                    DG_ListaEntradas.Rows.Add(
                        row["NUMERO_ENTRADA"].ToString(),
                        Convert.ToDateTime(row["FECHA_ENTRADA"]).ToString("dd/MM/yyyy"),
                        row["PRODUCTOS"].ToString(),
                        row["DESCRIPCION"].ToString()
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las entradas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
