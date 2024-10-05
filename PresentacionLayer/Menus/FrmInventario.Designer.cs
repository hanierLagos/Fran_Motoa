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
            this.bindingBotons = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnEntradas = new System.Windows.Forms.ToolStripButton();
            this.BtnProductos = new System.Windows.Forms.ToolStripButton();
            this.BtnMarcasCategorias = new System.Windows.Forms.ToolStripButton();
            this.BtnReportes = new System.Windows.Forms.ToolStripButton();
            this.pnlView = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.bindingBotons)).BeginInit();
            this.bindingBotons.SuspendLayout();
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
            this.bindingBotons.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingBotons.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.bindingBotons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEntradas,
            this.BtnProductos,
            this.BtnMarcasCategorias,
            this.BtnReportes});
            this.bindingBotons.Location = new System.Drawing.Point(0, 0);
            this.bindingBotons.MoveFirstItem = null;
            this.bindingBotons.MoveLastItem = null;
            this.bindingBotons.MoveNextItem = null;
            this.bindingBotons.MovePreviousItem = null;
            this.bindingBotons.Name = "bindingBotons";
            this.bindingBotons.PositionItem = null;
            this.bindingBotons.Size = new System.Drawing.Size(900, 41);
            this.bindingBotons.TabIndex = 29;
            this.bindingBotons.Text = "bindingNavigator1";
            // 
            // btnEntradas
            // 
            this.btnEntradas.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntradas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEntradas.Image = global::PresentacionLayer.Properties.Resources.agregar1;
            this.btnEntradas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntradas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEntradas.Name = "btnEntradas";
            this.btnEntradas.Padding = new System.Windows.Forms.Padding(10);
            this.btnEntradas.Size = new System.Drawing.Size(124, 38);
            this.btnEntradas.Text = "Entradas";
            this.btnEntradas.Click += new System.EventHandler(this.btnEntradas_Click);
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
            // 
            // BtnReportes
            // 
            this.BtnReportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnReportes.Image = global::PresentacionLayer.Properties.Resources.grafico_de_barras;
            this.BtnReportes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnReportes.Name = "BtnReportes";
            this.BtnReportes.Size = new System.Drawing.Size(100, 38);
            this.BtnReportes.Text = "Reportes";
            // 
            // pnlView
            // 
            this.pnlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlView.Location = new System.Drawing.Point(0, 41);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(900, 409);
            this.pnlView.TabIndex = 30;
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.pnlView);
            this.Controls.Add(this.bindingBotons);
            this.Name = "FrmInventario";
            this.Text = "FrmInventario";
            this.Load += new System.EventHandler(this.FrmInventario_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.bindingBotons)).EndInit();
            this.bindingBotons.ResumeLayout(false);
            this.bindingBotons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingBotons;
        private System.Windows.Forms.ToolStripButton btnEntradas;
        private System.Windows.Forms.ToolStripButton BtnProductos;
        private System.Windows.Forms.ToolStripButton BtnMarcasCategorias;
        private System.Windows.Forms.ToolStripButton BtnReportes;
        private System.Windows.Forms.Panel pnlView;
    }
}