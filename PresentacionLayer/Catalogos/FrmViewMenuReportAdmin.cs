using PresentacionLayer.Reportes;
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
    public partial class FrmViewMenuReportAdmin : Form
    {
        public FrmViewMenuReportAdmin()
        {
            InitializeComponent();
        }

        private void BtnVentaProuctos_Click(object sender, EventArgs e)
        {
            FrmReportVentaProductos frm = new FrmReportVentaProductos();    
            frm.ShowDialog();
        }

        private void btnVentaObra_Click(object sender, EventArgs e)
        {
            FrmReporteVentaManoObra frm = new FrmReporteVentaManoObra();
            frm.ShowDialog();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FrmReportVentas frm = new FrmReportVentas();
            frm.ShowDialog();   
        }

        private void btnTendenciaVentas_Click(object sender, EventArgs e)
        {
            FrmProductosMasVendidos frm= new FrmProductosMasVendidos();
            frm.ShowDialog();
        }

        private void btnMejoresClientes_Click(object sender, EventArgs e)
        {
            FrmViewMejoresClientes frm= new FrmViewMejoresClientes();
            frm.ShowDialog();
        }

        private void btnProductosVendidos_Click(object sender, EventArgs e)
        {
            FrmReportTendenciasVentas frm = new FrmReportTendenciasVentas();
            frm.ShowDialog();
        }

        private void btnVerEntradas_Click(object sender, EventArgs e)
        {
            FrmVerEntradas frm = new FrmVerEntradas();
            frm.ShowDialog();
        }
    }
}
