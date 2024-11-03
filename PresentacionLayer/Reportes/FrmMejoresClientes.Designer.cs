namespace PresentacionLayer.Reportes
{
    partial class FrmMejoresClientes
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
            this.fRAN_MOTOSDataSet4 = new PresentacionLayer.FRAN_MOTOSDataSet4();
            this.fRANMOTOSDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usReportMejoresClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.us_ReportMejoresClientesTableAdapter = new PresentacionLayer.FRAN_MOTOSDataSet4TableAdapters.Us_ReportMejoresClientesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.fRAN_MOTOSDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fRANMOTOSDataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usReportMejoresClientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.usReportMejoresClientesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PresentacionLayer.Reportes.ReporteMejoresClientes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(629, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // fRAN_MOTOSDataSet4
            // 
            this.fRAN_MOTOSDataSet4.DataSetName = "FRAN_MOTOSDataSet4";
            this.fRAN_MOTOSDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fRANMOTOSDataSet4BindingSource
            // 
            this.fRANMOTOSDataSet4BindingSource.DataSource = this.fRAN_MOTOSDataSet4;
            this.fRANMOTOSDataSet4BindingSource.Position = 0;
            // 
            // usReportMejoresClientesBindingSource
            // 
            this.usReportMejoresClientesBindingSource.DataMember = "Us_ReportMejoresClientes";
            this.usReportMejoresClientesBindingSource.DataSource = this.fRAN_MOTOSDataSet4;
            // 
            // us_ReportMejoresClientesTableAdapter
            // 
            this.us_ReportMejoresClientesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmMejoresClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmMejoresClientes";
            this.Text = "FrmMejoresClientes";
            this.Load += new System.EventHandler(this.FrmMejoresClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fRAN_MOTOSDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fRANMOTOSDataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usReportMejoresClientesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private FRAN_MOTOSDataSet4 fRAN_MOTOSDataSet4;
        private System.Windows.Forms.BindingSource fRANMOTOSDataSet4BindingSource;
        private System.Windows.Forms.BindingSource usReportMejoresClientesBindingSource;
        private FRAN_MOTOSDataSet4TableAdapters.Us_ReportMejoresClientesTableAdapter us_ReportMejoresClientesTableAdapter;
    }
}