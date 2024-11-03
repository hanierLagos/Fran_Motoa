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
            // Obtener las fechas de los DateTimePicker
            DateTime fechaInicio = datePickerFEchaInicio.Value;
            DateTime fechaFin = datePickerFechaFin.Value;

            // Llenar el DataSet usando el TableAdapter y los parámetros de fecha
            try
            {
                // Usa el TableAdapter para llenar el DataSet con los datos filtrados
                this.us_ReportVentasManoObraRealizadasConDetallesTableAdapter.Fill(this.fRAN_MOTOSDataSet7.Us_ReportVentasManoObraRealizadasConDetalles, fechaInicio, fechaFin);

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
