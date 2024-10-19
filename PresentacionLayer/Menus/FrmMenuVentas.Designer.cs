namespace PresentacionLayer.Menus
{
    partial class FrmMenuVentas
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
            this.bindingBotons = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnVentas = new System.Windows.Forms.ToolStripButton();
            this.BtnProductos = new System.Windows.Forms.ToolStripButton();
            this.BtnClientes = new System.Windows.Forms.ToolStripButton();
            this.BtnReportes = new System.Windows.Forms.ToolStripButton();
            this.pnlView = new System.Windows.Forms.Panel();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.BtnCerrarSesion = new System.Windows.Forms.ToolStripButton();
            this.BtnCaja = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.bindingBotons)).BeginInit();
            this.bindingBotons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingBotons
            // 
            this.bindingBotons.AddNewItem = null;
            this.bindingBotons.AutoSize = false;
            this.bindingBotons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(88)))), ((int)(((byte)(111)))));
            this.bindingBotons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bindingBotons.CountItem = null;
            this.bindingBotons.DeleteItem = null;
            this.bindingBotons.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingBotons.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingBotons.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingBotons.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.bindingBotons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnVentas,
            this.BtnProductos,
            this.BtnClientes,
            this.BtnCaja,
            this.BtnReportes});
            this.bindingBotons.Location = new System.Drawing.Point(0, 0);
            this.bindingBotons.MoveFirstItem = null;
            this.bindingBotons.MoveLastItem = null;
            this.bindingBotons.MoveNextItem = null;
            this.bindingBotons.MovePreviousItem = null;
            this.bindingBotons.Name = "bindingBotons";
            this.bindingBotons.PositionItem = null;
            this.bindingBotons.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.bindingBotons.Size = new System.Drawing.Size(967, 41);
            this.bindingBotons.TabIndex = 30;
            this.bindingBotons.Text = "bindingNavigator1";
            // 
            // btnVentas
            // 
            this.btnVentas.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnVentas.Image = global::PresentacionLayer.Properties.Resources.mano;
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Padding = new System.Windows.Forms.Padding(10);
            this.btnVentas.Size = new System.Drawing.Size(108, 38);
            this.btnVentas.Text = "Ventas";
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // BtnProductos
            // 
            this.BtnProductos.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnProductos.Image = global::PresentacionLayer.Properties.Resources.lista_de_verificacion;
            this.BtnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProductos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnProductos.Name = "BtnProductos";
            this.BtnProductos.Size = new System.Drawing.Size(118, 38);
            this.BtnProductos.Text = "Productos";
            this.BtnProductos.Click += new System.EventHandler(this.BtnProductos_Click);
            // 
            // BtnClientes
            // 
            this.BtnClientes.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnClientes.Image = global::PresentacionLayer.Properties.Resources.agregar_contacto;
            this.BtnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Size = new System.Drawing.Size(98, 38);
            this.BtnClientes.Text = "Clientes";
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // BtnReportes
            // 
            this.BtnReportes.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnReportes.Image = global::PresentacionLayer.Properties.Resources.grafico_de_barras;
            this.BtnReportes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnReportes.Name = "BtnReportes";
            this.BtnReportes.Size = new System.Drawing.Size(107, 38);
            this.BtnReportes.Text = "Reportes";
            // 
            // pnlView
            // 
            this.pnlView.BackColor = System.Drawing.Color.White;
            this.pnlView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlView.Location = new System.Drawing.Point(0, 41);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(967, 409);
            this.pnlView.TabIndex = 31;
            this.pnlView.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlView_Paint);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bindingNavigator1.AutoSize = false;
            this.bindingNavigator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(88)))), ((int)(((byte)(111)))));
            this.bindingNavigator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnCerrarSesion});
            this.bindingNavigator1.Location = new System.Drawing.Point(814, 3);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(153, 37);
            this.bindingNavigator1.TabIndex = 34;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // BtnCerrarSesion
            // 
            this.BtnCerrarSesion.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnCerrarSesion.Image = global::PresentacionLayer.Properties.Resources.cerrar_sesion__1_;
            this.BtnCerrarSesion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCerrarSesion.Name = "BtnCerrarSesion";
            this.BtnCerrarSesion.Size = new System.Drawing.Size(132, 34);
            this.BtnCerrarSesion.Text = "Cerrar Sesión";
            this.BtnCerrarSesion.Click += new System.EventHandler(this.BtnCerrarSesion_Click);
            // 
            // BtnCaja
            // 
            this.BtnCaja.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCaja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnCaja.Image = global::PresentacionLayer.Properties.Resources.caja_registradora;
            this.BtnCaja.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCaja.Name = "BtnCaja";
            this.BtnCaja.Size = new System.Drawing.Size(68, 38);
            this.BtnCaja.Text = "Caja";
            this.BtnCaja.Click += new System.EventHandler(this.BtnCaja_Click_1);
            // 
            // FrmMenuVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 450);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.pnlView);
            this.Controls.Add(this.bindingBotons);
            this.Name = "FrmMenuVentas";
            this.Text = "FRAN MOTOS (Ventas)";
            this.Load += new System.EventHandler(this.FrmMenuVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingBotons)).EndInit();
            this.bindingBotons.ResumeLayout(false);
            this.bindingBotons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingBotons;
        private System.Windows.Forms.ToolStripButton btnVentas;
        private System.Windows.Forms.ToolStripButton BtnProductos;
        private System.Windows.Forms.ToolStripButton BtnClientes;
        private System.Windows.Forms.ToolStripButton BtnReportes;
        private System.Windows.Forms.Panel pnlView;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton BtnCerrarSesion;
        private System.Windows.Forms.ToolStripButton BtnCaja;
    }
}