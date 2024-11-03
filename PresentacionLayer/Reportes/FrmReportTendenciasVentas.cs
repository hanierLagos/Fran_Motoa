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
            // TODO: esta línea de código carga datos en la tabla 'fRAN_MOTOSDataSet2.Us_ReportTop10ProductosMasVendidos' Puede moverla o quitarla según sea necesario.
            this.us_ReportTop10ProductosMasVendidosTableAdapter.Fill(this.fRAN_MOTOSDataSet2.Us_ReportTop10ProductosMasVendidos);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
