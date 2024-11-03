namespace PresentacionLayer.Reportes
{
    partial class FrmVerEntradas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVerEntradas));
            this.usReportEntradasRealizadasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fRAN_MOTOSDataSet9 = new PresentacionLayer.FRAN_MOTOSDataSet9();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCantidad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.us_ReportEntradasRealizadasTableAdapter = new PresentacionLayer.FRAN_MOTOSDataSet9TableAdapters.Us_ReportEntradasRealizadasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.usReportEntradasRealizadasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fRAN_MOTOSDataSet9)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // usReportEntradasRealizadasBindingSource
            // 
            this.usReportEntradasRealizadasBindingSource.DataMember = "Us_ReportEntradasRealizadas";
            this.usReportEntradasRealizadasBindingSource.DataSource = this.fRAN_MOTOSDataSet9;
            // 
            // fRAN_MOTOSDataSet9
            // 
            this.fRAN_MOTOSDataSet9.DataSetName = "FRAN_MOTOSDataSet9";
            this.fRAN_MOTOSDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panel3.Controls.Add(this.label8);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 42);
            this.panel3.TabIndex = 77;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(314, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 22);
            this.label8.TabIndex = 43;
            this.label8.Text = "Entradas Realizadas";
            // 
            // cmbCantidad
            // 
            this.cmbCantidad.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCantidad.FormattingEnabled = true;
            this.cmbCantidad.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "100",
            "200"});
            this.cmbCantidad.Location = new System.Drawing.Point(121, 54);
            this.cmbCantidad.Name = "cmbCantidad";
            this.cmbCantidad.Size = new System.Drawing.Size(121, 27);
            this.cmbCantidad.TabIndex = 78;
            this.cmbCantidad.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(88)))), ((int)(((byte)(111)))));
            this.label1.Location = new System.Drawing.Point(11, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 79;
            this.label1.Text = "Cant. a Ver:";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.usReportEntradasRealizadasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PresentacionLayer.Reportes.ReporteEntradasInventario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(15, 87);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(773, 585);
            this.reportViewer1.TabIndex = 80;
            // 
            // us_ReportEntradasRealizadasTableAdapter
            // 
            this.us_ReportEntradasRealizadasTableAdapter.ClearBeforeFill = true;
            // 
            // FrmVerEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 684);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCantidad);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVerEntradas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTE DE ENTRADAS";
            this.Load += new System.EventHandler(this.FrmVerEntradas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usReportEntradasRealizadasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fRAN_MOTOSDataSet9)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbCantidad;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource usReportEntradasRealizadasBindingSource;
        private FRAN_MOTOSDataSet9 fRAN_MOTOSDataSet9;
        private FRAN_MOTOSDataSet9TableAdapters.Us_ReportEntradasRealizadasTableAdapter us_ReportEntradasRealizadasTableAdapter;
    }
}