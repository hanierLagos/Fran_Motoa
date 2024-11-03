namespace PresentacionLayer.Reportes
{
    partial class FrmReportVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportVentas));
            this.usReportVentasRealizadasConDetallesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fRAN_MOTOSDataSet8 = new PresentacionLayer.FRAN_MOTOSDataSet8();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.bindingNavigator3 = new System.Windows.Forms.BindingNavigator(this.components);
            this.BtnReporte = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.datePickerFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.datePickerFEchaInicio = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.us_ReportVentasRealizadasConDetallesTableAdapter = new PresentacionLayer.FRAN_MOTOSDataSet8TableAdapters.Us_ReportVentasRealizadasConDetallesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.usReportVentasRealizadasConDetallesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fRAN_MOTOSDataSet8)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).BeginInit();
            this.bindingNavigator3.SuspendLayout();
            this.SuspendLayout();
            // 
            // usReportVentasRealizadasConDetallesBindingSource
            // 
            this.usReportVentasRealizadasConDetallesBindingSource.DataMember = "Us_ReportVentasRealizadasConDetalles";
            this.usReportVentasRealizadasConDetallesBindingSource.DataSource = this.fRAN_MOTOSDataSet8;
            // 
            // fRAN_MOTOSDataSet8
            // 
            this.fRAN_MOTOSDataSet8.DataSetName = "FRAN_MOTOSDataSet8";
            this.fRAN_MOTOSDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panel3.Controls.Add(this.label8);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(783, 42);
            this.panel3.TabIndex = 76;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(305, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 22);
            this.label8.TabIndex = 43;
            this.label8.Text = "Reporte de Ventas";
            // 
            // bindingNavigator3
            // 
            this.bindingNavigator3.AddNewItem = null;
            this.bindingNavigator3.AutoSize = false;
            this.bindingNavigator3.BackColor = System.Drawing.Color.Transparent;
            this.bindingNavigator3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bindingNavigator3.CountItem = null;
            this.bindingNavigator3.DeleteItem = null;
            this.bindingNavigator3.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigator3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator3.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.bindingNavigator3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnReporte});
            this.bindingNavigator3.Location = new System.Drawing.Point(621, 50);
            this.bindingNavigator3.MoveFirstItem = null;
            this.bindingNavigator3.MoveLastItem = null;
            this.bindingNavigator3.MoveNextItem = null;
            this.bindingNavigator3.MovePreviousItem = null;
            this.bindingNavigator3.Name = "bindingNavigator3";
            this.bindingNavigator3.PositionItem = null;
            this.bindingNavigator3.Size = new System.Drawing.Size(154, 37);
            this.bindingNavigator3.TabIndex = 75;
            this.bindingNavigator3.Text = "bindingNavigator1";
            // 
            // BtnReporte
            // 
            this.BtnReporte.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(61)))), ((int)(((byte)(62)))));
            this.BtnReporte.Image = global::PresentacionLayer.Properties.Resources.ventas;
            this.BtnReporte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnReporte.Name = "BtnReporte";
            this.BtnReporte.Padding = new System.Windows.Forms.Padding(10);
            this.BtnReporte.RightToLeftAutoMirrorImage = true;
            this.BtnReporte.Size = new System.Drawing.Size(109, 34);
            this.BtnReporte.Text = "Reporte";
            this.BtnReporte.Click += new System.EventHandler(this.BtnReporte_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(88)))), ((int)(((byte)(111)))));
            this.label1.Location = new System.Drawing.Point(295, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 74;
            this.label1.Text = "Fecha Fin:";
            // 
            // datePickerFechaFin
            // 
            this.datePickerFechaFin.CalendarFont = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerFechaFin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.datePickerFechaFin.CustomFormat = "\"dd MM , yyyy \"";
            this.datePickerFechaFin.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerFechaFin.Location = new System.Drawing.Point(384, 59);
            this.datePickerFechaFin.Margin = new System.Windows.Forms.Padding(2);
            this.datePickerFechaFin.MaxDate = new System.DateTime(2025, 12, 25, 23, 59, 59, 999);
            this.datePickerFechaFin.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.datePickerFechaFin.Name = "datePickerFechaFin";
            this.datePickerFechaFin.Size = new System.Drawing.Size(155, 25);
            this.datePickerFechaFin.TabIndex = 73;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(88)))), ((int)(((byte)(111)))));
            this.label14.Location = new System.Drawing.Point(11, 62);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 19);
            this.label14.TabIndex = 72;
            this.label14.Text = "Fecha Inicio:";
            // 
            // datePickerFEchaInicio
            // 
            this.datePickerFEchaInicio.CalendarFont = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerFEchaInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.datePickerFEchaInicio.CustomFormat = "\"dd MM , yyyy \"";
            this.datePickerFEchaInicio.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerFEchaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerFEchaInicio.Location = new System.Drawing.Point(118, 59);
            this.datePickerFEchaInicio.Margin = new System.Windows.Forms.Padding(2);
            this.datePickerFEchaInicio.MaxDate = new System.DateTime(2025, 12, 25, 23, 59, 59, 999);
            this.datePickerFEchaInicio.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.datePickerFEchaInicio.Name = "datePickerFEchaInicio";
            this.datePickerFEchaInicio.Size = new System.Drawing.Size(155, 25);
            this.datePickerFEchaInicio.TabIndex = 71;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.usReportVentasRealizadasConDetallesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PresentacionLayer.Reportes.ReportVentas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(15, 105);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(760, 521);
            this.reportViewer1.TabIndex = 77;
            // 
            // us_ReportVentasRealizadasConDetallesTableAdapter
            // 
            this.us_ReportVentasRealizadasConDetallesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReportVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 638);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.bindingNavigator3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datePickerFechaFin);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.datePickerFEchaInicio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReportVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTE DE VENTAS";
            this.Load += new System.EventHandler(this.FrmReportVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usReportVentasRealizadasConDetallesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fRAN_MOTOSDataSet8)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).EndInit();
            this.bindingNavigator3.ResumeLayout(false);
            this.bindingNavigator3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingNavigator bindingNavigator3;
        public System.Windows.Forms.ToolStripButton BtnReporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datePickerFechaFin;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker datePickerFEchaInicio;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource usReportVentasRealizadasConDetallesBindingSource;
        private FRAN_MOTOSDataSet8 fRAN_MOTOSDataSet8;
        private FRAN_MOTOSDataSet8TableAdapters.Us_ReportVentasRealizadasConDetallesTableAdapter us_ReportVentasRealizadasConDetallesTableAdapter;
    }
}