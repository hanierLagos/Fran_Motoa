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
            // TODO: esta línea de código carga datos en la tabla 'fRAN_MOTOSDataSet5.Us_ReportTendenciasVentas' Puede moverla o quitarla según sea necesario.
            this.us_ReportTendenciasVentasTableAdapter.Fill(this.fRAN_MOTOSDataSet5.Us_ReportTendenciasVentas);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
