namespace PresentacionLayer.Reportes
{
    partial class FrmProductosMasVendidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductosMasVendidos));
            this.usReportTendenciasVentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fRAN_MOTOSDataSet5 = new PresentacionLayer.FRAN_MOTOSDataSet5();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.fRANMOTOSDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.us_ReportTendenciasVentasTableAdapter = new PresentacionLayer.FRAN_MOTOSDataSet5TableAdapters.Us_ReportTendenciasVentasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.usReportTendenciasVentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fRAN_MOTOSDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fRANMOTOSDataSet5BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // usReportTendenciasVentasBindingSource
            // 
            this.usReportTendenciasVentasBindingSource.DataMember = "Us_ReportTendenciasVentas";
            this.usReportTendenciasVentasBindingSource.DataSource = this.fRAN_MOTOSDataSet5;
            // 
            // fRAN_MOTOSDataSet5
            // 
            this.fRAN_MOTOSDataSet5.DataSetName = "FRAN_MOTOSDataSet5";
            this.fRAN_MOTOSDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.usReportTendenciasVentasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PresentacionLayer.Reportes.ReporteTendenciaDeVentas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(611, 589);
            this.reportViewer1.TabIndex = 0;
            // 
            // fRANMOTOSDataSet5BindingSource
            // 
            this.fRANMOTOSDataSet5BindingSource.DataSource = this.fRAN_MOTOSDataSet5;
            this.fRANMOTOSDataSet5BindingSource.Position = 0;
            // 
            // us_ReportTendenciasVentasTableAdapter
            // 
            this.us_ReportTendenciasVentasTableAdapter.ClearBeforeFill = true;
            // 
            // FrmProductosMasVendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 589);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProductosMasVendidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTE TENDENCIA DE VENTAS";
            this.Load += new System.EventHandler(this.FrmProductosMasVendidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usReportTendenciasVentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fRAN_MOTOSDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fRANMOTOSDataSet5BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private FRAN_MOTOSDataSet5 fRAN_MOTOSDataSet5;
        private System.Windows.Forms.BindingSource fRANMOTOSDataSet5BindingSource;
        private System.Windows.Forms.BindingSource usReportTendenciasVentasBindingSource;
        private FRAN_MOTOSDataSet5TableAdapters.Us_ReportTendenciasVentasTableAdapter us_ReportTendenciasVentasTableAdapter;
    }
}