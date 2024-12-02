using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionLayer.Reportes
{
    public partial class FrmVerEntradas : Form
    {
        public FrmVerEntradas()
        {
            InitializeComponent();

            cmbCantidad.SelectedIndex = 0;
        }

        private void FrmVerEntradas_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cantAver = Convert.ToInt32(cmbCantidad.SelectedItem.ToString());

            // Llenar el DataSet usando el TableAdapter y los parámetros del coombobox
            try
            {
                // Cambiar la cadena de conexión del TableAdapter antes de llenar los datos
                this.us_ReportEntradasRealizadasTableAdapter.Connection.ConnectionString =
                    "Data Source=DESKTOP-7GLINRR\\MSSQLSERVER01;Initial Catalog=TALLER_FRANC;User Id=Admin;Password=CzMa7p*0";
                this.us_ReportEntradasRealizadasTableAdapter.Fill(this.fRAN_MOTOSDataSet9.Us_ReportEntradasRealizadas, cantAver);

                // Refrescar el ReportViewer
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el reporte: " + ex.Message);
            }
        }
    }
}
