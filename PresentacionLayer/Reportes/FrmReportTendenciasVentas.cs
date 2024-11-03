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
    public partial class FrmReportTendenciasVentas : Form
    {
        public FrmReportTendenciasVentas()
        {
            InitializeComponent();

        }

        private void FrmReportTendenciasVentas_Load(object sender, EventArgs e)
        {
            CargarReporteTop10Productos();

        }
        private void CargarReporteTop10Productos()
        {
            // Cambiar la cadena de conexión del TableAdapter antes de llenar los datos
            this.us_ReportTop10ProductosMasVendidosTableAdapter.Connection.ConnectionString =
                "Data Source=DESKTOP-7GLINRR\\MSSQLSERVER01;Initial Catalog=TALLER_FRANC;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            // Llenar el DataSet con los datos actualizados
            this.us_ReportTop10ProductosMasVendidosTableAdapter.Fill(this.fRAN_MOTOSDataSet2.Us_ReportTop10ProductosMasVendidos);

            // Refrescar el ReportViewer para mostrar el reporte actualizado
            this.reportViewer1.RefreshReport();
        }
    }
}
