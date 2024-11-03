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
    public partial class FrmViewMejoresClientes : Form
    {
        public FrmViewMejoresClientes()
        {
            InitializeComponent();
        }

        private void FrmViewMejoresClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'fRAN_MOTOSDataSet4.Us_ReportMejoresClientes' Puede moverla o quitarla según sea necesario.
            this.us_ReportMejoresClientesTableAdapter.Fill(this.fRAN_MOTOSDataSet4.Us_ReportMejoresClientes);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
