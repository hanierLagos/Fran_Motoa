using Microsoft.Reporting.WinForms;
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
    public partial class FrmReporteVentaManoObra : Form
    {
        public FrmReporteVentaManoObra()
        {
            InitializeComponent();
        }

        private void FrmReporteVentaManoObra_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            // Cambiar la cadena de conexión del TableAdapter antes de llenar los datos
            this.us_ReportVentasManoObraRealizadasConDetallesTableAdapter.Connection.ConnectionString =
                "Data Source=DESKTOP-7GLINRR\\MSSQLSERVER01;Initial Catalog=TALLER_FRANC;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            // Obtener las fechas de los DateTimePicker
            DateTime fechaInicio = datePickerFEchaInicio.Value;
            DateTime fechaFin = datePickerFechaFin.Value;

            // Llenar el DataSet usando el TableAdapter y los parámetros de fecha
            try
            {

                // Llenar el DataSet usando el TableAdapter con los parámetros de fecha
                this.us_ReportVentasManoObraRealizadasConDetallesTableAdapter.Fill(
                    this.fRAN_MOTOSDataSet7.Us_ReportVentasManoObraRealizadasConDetalles, fechaInicio, fechaFin);

                // Refrescar el ReportViewer para mostrar el reporte actualizado
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el reporte: " + ex.Message);
            }

        }
    }
}
