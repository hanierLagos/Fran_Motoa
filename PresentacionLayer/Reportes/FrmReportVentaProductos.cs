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
    public partial class FrmReportVentaProductos : Form
    {
        public FrmReportVentaProductos()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void FrmReportVentaProductos_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            // Obtener las fechas de los DateTimePicker
            DateTime fechaInicio = datePickerFEchaInicio.Value;
            DateTime fechaFin = datePickerFechaFin.Value;

            // Llenar el DataSet usando el TableAdapter y los parámetros de fecha
            try
            {
                // Cambiar la cadena de conexión del TableAdapter antes de llenar los datos
                this.us_ReportVentasProductosRealizadasConDetallesTableAdapter.Connection.ConnectionString =
                    "Data Source=DESKTOP-7GLINRR;Initial Catalog=TALLER_FRANC;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

                this.us_ReportVentasProductosRealizadasConDetallesTableAdapter.Fill(this.fRAN_MOTOSDataSet6.Us_ReportVentasProductosRealizadasConDetalles, fechaInicio, fechaFin);

                // Refrescar el ReportViewer
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el reporte: " + ex.Message);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
