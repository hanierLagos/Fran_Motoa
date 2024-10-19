namespace PresentacionLayer.Menus
{
    partial class FrmAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdministrador));
            this.bdtnMenus = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.BtnCerrarSesion = new System.Windows.Forms.ToolStripButton();
            this.pnlView = new System.Windows.Forms.Panel();
            this.BtnVentas = new System.Windows.Forms.ToolStripButton();
            this.BtnInventario = new System.Windows.Forms.ToolStripButton();
            this.BtnClientes = new System.Windows.Forms.ToolStripButton();
            this.BtnUsuarios = new System.Windows.Forms.ToolStripButton();
            this.BtnReportes = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.bdtnMenus)).BeginInit();
            this.bdtnMenus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bdtnMenus
            // 
            this.bdtnMenus.AddNewItem = null;
            this.bdtnMenus.AutoSize = false;
            this.bdtnMenus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(61)))), ((int)(((byte)(62)))));
            this.bdtnMenus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bdtnMenus.CountItem = null;
            this.bdtnMenus.DeleteItem = null;
            this.bdtnMenus.Dock = System.Windows.Forms.DockStyle.Left;
            this.bdtnMenus.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdtnMenus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bdtnMenus.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.bdtnMenus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnVentas,
            this.BtnInventario,
            this.BtnClientes,
            this.BtnUsuarios,
            this.BtnReportes});
            this.bdtnMenus.Location = new System.Drawing.Point(0, 0);
            this.bdtnMenus.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.bdtnMenus.MoveFirstItem = null;
            this.bdtnMenus.MoveLastItem = null;
            this.bdtnMenus.MoveNextItem = null;
            this.bdtnMenus.MovePreviousItem = null;
            this.bdtnMenus.Name = "bdtnMenus";
            this.bdtnMenus.PositionItem = null;
            this.bdtnMenus.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.bdtnMenus.Size = new System.Drawing.Size(153, 405);
            this.bdtnMenus.TabIndex = 30;
            this.bdtnMenus.Text = "bindingNavigator1";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bindingNavigator1.AutoSize = false;
            this.bindingNavigator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(61)))), ((int)(((byte)(62)))));
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
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 359);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(150, 37);
            this.bindingNavigator1.TabIndex = 32;
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
            // pnlView
            // 
            this.pnlView.BackColor = System.Drawing.Color.White;
            this.pnlView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlView.Location = new System.Drawing.Point(153, 0);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(768, 405);
            this.pnlView.TabIndex = 31;
            this.pnlView.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlView_Paint);
            // 
            // BtnVentas
            // 
            this.BtnVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnVentas.Image = global::PresentacionLayer.Properties.Resources.proceso1;
            this.BtnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVentas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnVentas.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnVentas.Name = "BtnVentas";
            this.BtnVentas.Padding = new System.Windows.Forms.Padding(10);
            this.BtnVentas.Size = new System.Drawing.Size(141, 44);
            this.BtnVentas.Text = "Ventas";
            this.BtnVentas.Click += new System.EventHandler(this.BtnVentas_Click);
            // 
            // BtnInventario
            // 
            this.BtnInventario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnInventario.Image = global::PresentacionLayer.Properties.Resources.lista_de_verificacion;
            this.BtnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInventario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnInventario.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnInventario.Name = "BtnInventario";
            this.BtnInventario.Padding = new System.Windows.Forms.Padding(10);
            this.BtnInventario.Size = new System.Drawing.Size(141, 44);
            this.BtnInventario.Text = "Inventario";
            this.BtnInventario.Click += new System.EventHandler(this.BtnInventario_Click);
            // 
            // BtnClientes
            // 
            this.BtnClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnClientes.Image = global::PresentacionLayer.Properties.Resources.agregar_contacto;
            this.BtnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnClientes.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Padding = new System.Windows.Forms.Padding(10);
            this.BtnClientes.Size = new System.Drawing.Size(141, 44);
            this.BtnClientes.Text = "Clientes";
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // BtnUsuarios
            // 
            this.BtnUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnUsuarios.Image = global::PresentacionLayer.Properties.Resources.ver_usuario;
            this.BtnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnUsuarios.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnUsuarios.Name = "BtnUsuarios";
            this.BtnUsuarios.Padding = new System.Windows.Forms.Padding(10);
            this.BtnUsuarios.Size = new System.Drawing.Size(141, 44);
            this.BtnUsuarios.Text = "Usuarios";
            this.BtnUsuarios.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // BtnReportes
            // 
            this.BtnReportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnReportes.Image = global::PresentacionLayer.Properties.Resources.grafico_de_barras;
            this.BtnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReportes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnReportes.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnReportes.Name = "BtnReportes";
            this.BtnReportes.Padding = new System.Windows.Forms.Padding(10);
            this.BtnReportes.Size = new System.Drawing.Size(141, 44);
            this.BtnReportes.Text = "Reportes";
            // 
            // FrmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 405);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.pnlView);
            this.Controls.Add(this.bdtnMenus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdministrador";
            this.Text = "FRAN MOTOS (Administrador)";
            this.Load += new System.EventHandler(this.FrmAdministrador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdtnMenus)).EndInit();
            this.bdtnMenus.ResumeLayout(false);
            this.bdtnMenus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bdtnMenus;
        private System.Windows.Forms.ToolStripButton BtnReportes;
        private System.Windows.Forms.ToolStripButton BtnUsuarios;
        private System.Windows.Forms.ToolStripButton BtnVentas;
        private System.Windows.Forms.ToolStripButton BtnInventario;
        private System.Windows.Forms.ToolStripButton BtnClientes;
        private System.Windows.Forms.Panel pnlView;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton BtnCerrarSesion;
    }
}