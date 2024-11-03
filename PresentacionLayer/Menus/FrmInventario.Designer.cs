namespace PresentacionLayer.Menus
{
    partial class FrmInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInventario));
            this.bindingBotons = new System.Windows.Forms.BindingNavigator(this.components);
            this.BtnProductos = new System.Windows.Forms.ToolStripButton();
            this.BtnMarcasCategorias = new System.Windows.Forms.ToolStripButton();
            this.BtnReportes = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.pnlView = new System.Windows.Forms.Panel();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.BtnCerrarSesion = new System.Windows.Forms.ToolStripButton();
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
            this.BtnProductos,
            this.BtnMarcasCategorias,
            this.BtnReportes,
            this.toolStripButton1});
            this.bindingBotons.Location = new System.Drawing.Point(0, 0);
            this.bindingBotons.MoveFirstItem = null;
            this.bindingBotons.MoveLastItem = null;
            this.bindingBotons.MoveNextItem = null;
            this.bindingBotons.MovePreviousItem = null;
            this.bindingBotons.Name = "bindingBotons";
            this.bindingBotons.PositionItem = null;
            this.bindingBotons.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.bindingBotons.Size = new System.Drawing.Size(980, 41);
            this.bindingBotons.TabIndex = 29;
            this.bindingBotons.Text = "bindingNavigator1";
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
            this.BtnProductos.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // BtnMarcasCategorias
            // 
            this.BtnMarcasCategorias.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMarcasCategorias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnMarcasCategorias.Image = global::PresentacionLayer.Properties.Resources.etiqueta;
            this.BtnMarcasCategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMarcasCategorias.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnMarcasCategorias.Name = "BtnMarcasCategorias";
            this.BtnMarcasCategorias.Size = new System.Drawing.Size(197, 38);
            this.BtnMarcasCategorias.Text = "Marcas y Categorias";
            this.BtnMarcasCategorias.Click += new System.EventHandler(this.BtnMarcasCategorias_Click);
            // 
            // BtnReportes
            // 
            this.BtnReportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnReportes.Image = global::PresentacionLayer.Properties.Resources.grafico_de_barras;
            this.BtnReportes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnReportes.Name = "BtnReportes";
            this.BtnReportes.Size = new System.Drawing.Size(100, 38);
            this.BtnReportes.Text = "Reportes";
            this.BtnReportes.Click += new System.EventHandler(this.BtnReportes_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(192, 38);
            this.toolStripButton1.Text = "Ver Entradas Realizadas";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // pnlView
            // 
            this.pnlView.BackColor = System.Drawing.Color.White;
            this.pnlView.BackgroundImage = global::PresentacionLayer.Properties.Resources.logo_tallerfranc1;
            this.pnlView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlView.Location = new System.Drawing.Point(0, 41);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(980, 409);
            this.pnlView.TabIndex = 30;
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
            this.bindingNavigator1.Location = new System.Drawing.Point(827, 4);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(153, 37);
            this.bindingNavigator1.TabIndex = 33;
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
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 450);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.pnlView);
            this.Controls.Add(this.bindingBotons);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInventario";
            this.Text = "FRAN MOTOS";
            this.Load += new System.EventHandler(this.FrmInventario_Load_1);
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
        private System.Windows.Forms.ToolStripButton BtnProductos;
        private System.Windows.Forms.ToolStripButton BtnMarcasCategorias;
        private System.Windows.Forms.ToolStripButton BtnReportes;
        private System.Windows.Forms.Panel pnlView;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton BtnCerrarSesion;
    }
}