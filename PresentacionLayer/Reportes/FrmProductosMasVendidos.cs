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
    public partial class FrmProductosMasVendidos : Form
    {
        public FrmProductosMasVendidos()
        {
            InitializeComponent();
        }

        private void FrmProductosMasVendidos_Load(object sender, EventArgs e)
        {
            CargarReporteTendenciasVentas();
        }
        private void CargarReporteTendenciasVentas()
        {
            // Cambiar la cadena de conexión del TableAdapter antes de llenar los datos
            this.us_ReportTendenciasVentasTableAdapter.Connection.ConnectionString =
                "Data Source=ALEJANDRO;Initial Catalog=TALLER_FRANC;User Id=FRAN;Password=CzMa7p*0";

            // Llenar el DataSet con los datos actualizados
            this.us_ReportTendenciasVentasTableAdapter.Fill(this.fRAN_MOTOSDataSet5.Us_ReportTendenciasVentas);

            // Refrescar el ReportViewer para mostrar el reporte actualizado
            this.reportViewer1.RefreshReport();
        }

    }
}
