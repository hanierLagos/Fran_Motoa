namespace PresentacionLayer.Reportes
{
    partial class FrmReportTendenciasVentas
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.fRAN_MOTOSDataSet2 = new PresentacionLayer.FRAN_MOTOSDataSet2();
            this.usReportTop10ProductosMasVendidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.us_ReportTop10ProductosMasVendidosTableAdapter = new PresentacionLayer.FRAN_MOTOSDataSet2TableAdapters.Us_ReportTop10ProductosMasVendidosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.fRAN_MOTOSDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usReportTop10ProductosMasVendidosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.usReportTop10ProductosMasVendidosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PresentacionLayer.Reportes.RptProductosVendidos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(685, 581);
            this.reportViewer1.TabIndex = 0;
            // 
            // fRAN_MOTOSDataSet2
            // 
            this.fRAN_MOTOSDataSet2.DataSetName = "FRAN_MOTOSDataSet2";
            this.fRAN_MOTOSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usReportTop10ProductosMasVendidosBindingSource
            // 
            this.usReportTop10ProductosMasVendidosBindingSource.DataMember = "Us_ReportTop10ProductosMasVendidos";
            this.usReportTop10ProductosMasVendidosBindingSource.DataSource = this.fRAN_MOTOSDataSet2;
            // 
            // us_ReportTop10ProductosMasVendidosTableAdapter
            // 
            this.us_ReportTop10ProductosMasVendidosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReportTendenciasVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 581);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReportTendenciasVentas";
            this.Text = "FrmReportTendenciasVentas";
            this.Load += new System.EventHandler(this.FrmReportTendenciasVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fRAN_MOTOSDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usReportTop10ProductosMasVendidosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private FRAN_MOTOSDataSet2 fRAN_MOTOSDataSet2;
        private System.Windows.Forms.BindingSource usReportTop10ProductosMasVendidosBindingSource;
        private FRAN_MOTOSDataSet2TableAdapters.Us_ReportTop10ProductosMasVendidosTableAdapter us_ReportTop10ProductosMasVendidosTableAdapter;
    }
}