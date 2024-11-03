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
    public partial class FrmVierMenuReportesVenta : Form
    {
        public FrmVierMenuReportesVenta()
        {
            InitializeComponent();
        }

        private void FrmVierMenuReportesVenta_Load(object sender, EventArgs e)
        {

        }

        private void BtnVentaProuctos_Click(object sender, EventArgs e)
        {
            FrmReportVentaProductos frmReportVentaProductos = new FrmReportVentaProductos();
            frmReportVentaProductos.ShowDialog();
        }

        private void btnVentaObra_Click(object sender, EventArgs e)
        {
            FrmReporteVentaManoObra frmReporteVentaManoObra = new FrmReporteVentaManoObra();
            frmReporteVentaManoObra.ShowDialog();  
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FrmReportVentas frmReportVentas = new FrmReportVentas();
            frmReportVentas.ShowDialog();   
        }

        private void btnTendenciaVentas_Click(object sender, EventArgs e)
        {
            FrmProductosMasVendidos frm = new FrmProductosMasVendidos();
            frm.ShowDialog();   
        }

        private void btnMejoresClientes_Click(object sender, EventArgs e)
        {
            FrmViewMejoresClientes frm = new FrmViewMejoresClientes();
            frm.ShowDialog();   
        }

        private void btnProductosVendidos_Click(object sender, EventArgs e)
        {
            FrmReportTendenciasVentas frm = new FrmReportTendenciasVentas();
            frm.ShowDialog();
        }
    }
}
