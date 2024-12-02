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
            CargarReporteMejoresClientes();

        }

        private void CargarReporteMejoresClientes()
        {
            // Cambiar la cadena de conexión del TableAdapter antes de llenar los datos
            this.us_ReportMejoresClientesTableAdapter.Connection.ConnectionString =
                "Data Source=DESKTOP-7GLINRR\\MSSQLSERVER01;Initial Catalog=TALLER_FRANC;User Id=Admin;Password=CzMa7p*0";

            // Llenar el DataSet con los datos actualizados
            this.us_ReportMejoresClientesTableAdapter.Fill(this.fRAN_MOTOSDataSet4.Us_ReportMejoresClientes);

            // Refrescar el ReportViewer para mostrar el reporte actualizado
            this.reportViewer1.RefreshReport();
        }
    }
}
