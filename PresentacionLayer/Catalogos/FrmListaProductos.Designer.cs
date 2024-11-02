namespace PresentacionLayer.Catalogos
{
    partial class FrmListaProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaProductos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBuscra = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.DG_Productos = new System.Windows.Forms.DataGridView();
            this.CODIGO_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE_PRODUCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE_MARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mskCodigo = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imgCrud = new System.Windows.Forms.ImageList(this.components);
            this.btnAgregarEntrada = new System.Windows.Forms.BindingNavigator(this.components);
            this.BtnAgregar = new System.Windows.Forms.ToolStripButton();
            this.BtnGuestPlus = new FontAwesome.Sharp.IconButton();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Productos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarEntrada)).BeginInit();
            this.btnAgregarEntrada.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBuscra
            // 
            this.txtBuscra.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(61)))), ((int)(((byte)(62)))));
            this.txtBuscra.Location = new System.Drawing.Point(283, 72);
            this.txtBuscra.Name = "txtBuscra";
            this.txtBuscra.Size = new System.Drawing.Size(161, 24);
            this.txtBuscra.TabIndex = 38;
            this.txtBuscra.TextChanged += new System.EventHandler(this.txtBuscra_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(88)))), ((int)(((byte)(111)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1287, 54);
            this.panel1.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(542, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Productos Disponibles";
            // 
            // DG_Productos
            // 
            this.DG_Productos.AllowUserToAddRows = false;
            this.DG_Productos.AllowUserToDeleteRows = false;
            this.DG_Productos.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(88)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(88)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DG_Productos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_Productos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_Productos.BackgroundColor = System.Drawing.Color.White;
            this.DG_Productos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_Productos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DG_Productos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(61)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(196)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(61)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_Productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DG_Productos.ColumnHeadersHeight = 38;
            this.DG_Productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO_PRODUCTO,
            this.NOMBRE_PRODUCT,
            this.PRECIO,
            this.NOMBRE_MARCA,
            this.cntry,
            this.CANTIDAD,
            this.Edit,
            this.delete});
            this.DG_Productos.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(88)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(88)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_Productos.DefaultCellStyle = dataGridViewCellStyle5;
            this.DG_Productos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DG_Productos.EnableHeadersVisualStyles = false;
            this.DG_Productos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(88)))), ((int)(((byte)(111)))));
            this.DG_Productos.Location = new System.Drawing.Point(15, 119);
            this.DG_Productos.Margin = new System.Windows.Forms.Padding(2);
            this.DG_Productos.Name = "DG_Productos";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_Productos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DG_Productos.RowHeadersVisible = false;
            this.DG_Productos.RowHeadersWidth = 40;
            this.DG_Productos.RowTemplate.Height = 20;
            this.DG_Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_Productos.Size = new System.Drawing.Size(1227, 416);
            this.DG_Productos.TabIndex = 31;
            this.DG_Productos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Productos_CellContentClick);
            // 
            // CODIGO_PRODUCTO
            // 
            this.CODIGO_PRODUCTO.HeaderText = "Código";
            this.CODIGO_PRODUCTO.MinimumWidth = 6;
            this.CODIGO_PRODUCTO.Name = "CODIGO_PRODUCTO";
            this.CODIGO_PRODUCTO.Width = 172;
            // 
            // NOMBRE_PRODUCT
            // 
            this.NOMBRE_PRODUCT.HeaderText = "Nombre";
            this.NOMBRE_PRODUCT.MinimumWidth = 6;
            this.NOMBRE_PRODUCT.Name = "NOMBRE_PRODUCT";
            this.NOMBRE_PRODUCT.Width = 171;
            // 
            // PRECIO
            // 
            this.PRECIO.HeaderText = "Precio";
            this.PRECIO.MinimumWidth = 6;
            this.PRECIO.Name = "PRECIO";
            this.PRECIO.Width = 172;
            // 
            // NOMBRE_MARCA
            // 
            this.NOMBRE_MARCA.HeaderText = "Marca";
            this.NOMBRE_MARCA.MinimumWidth = 6;
            this.NOMBRE_MARCA.Name = "NOMBRE_MARCA";
            this.NOMBRE_MARCA.Width = 172;
            // 
            // cntry
            // 
            this.cntry.HeaderText = "Categoría";
            this.cntry.MinimumWidth = 6;
            this.cntry.Name = "cntry";
            this.cntry.Width = 171;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.HeaderText = "Cantidad Disponible";
            this.CANTIDAD.Name = "CANTIDAD";
            // 
            // Edit
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            this.Edit.DefaultCellStyle = dataGridViewCellStyle3;
            this.Edit.FillWeight = 60F;
            this.Edit.HeaderText = "Editar";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // delete
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle4.NullValue")));
            this.delete.DefaultCellStyle = dataGridViewCellStyle4;
            this.delete.HeaderText = "Eliminar";
            this.delete.MinimumWidth = 6;
            this.delete.Name = "delete";
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(61)))), ((int)(((byte)(62)))));
            this.label3.Location = new System.Drawing.Point(506, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 35;
            this.label3.Text = "Visualizar";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cmbFilter
            // 
            this.cmbFilter.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "15",
            "20",
            "25",
            "30",
            "40",
            "50",
            "100"});
            this.cmbFilter.Location = new System.Drawing.Point(618, 69);
            this.cmbFilter.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(62, 27);
            this.cmbFilter.TabIndex = 34;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(61)))), ((int)(((byte)(62)))));
            this.label2.Location = new System.Drawing.Point(-128, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 32;
            this.label2.Text = "FILTRAR";
            // 
            // mskCodigo
            // 
            this.mskCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskCodigo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(61)))), ((int)(((byte)(62)))));
            this.mskCodigo.Location = new System.Drawing.Point(86, 73);
            this.mskCodigo.Mask = "AAAAA00000";
            this.mskCodigo.Name = "mskCodigo";
            this.mskCodigo.Size = new System.Drawing.Size(110, 24);
            this.mskCodigo.TabIndex = 41;
            this.mskCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskCodigo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(61)))), ((int)(((byte)(62)))));
            this.label1.Location = new System.Drawing.Point(29, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 42;
            this.label1.Text = "Filtrar";
            // 
            // imgCrud
            // 
            this.imgCrud.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgCrud.ImageStream")));
            this.imgCrud.TransparentColor = System.Drawing.Color.Transparent;
            this.imgCrud.Images.SetKeyName(0, "avatar-de-usuario.png");
            this.imgCrud.Images.SetKeyName(1, "eliminar.png");
            // 
            // btnAgregarEntrada
            // 
            this.btnAgregarEntrada.AddNewItem = null;
            this.btnAgregarEntrada.AutoSize = false;
            this.btnAgregarEntrada.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarEntrada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAgregarEntrada.CountItem = null;
            this.btnAgregarEntrada.DeleteItem = null;
            this.btnAgregarEntrada.Dock = System.Windows.Forms.DockStyle.None;
            this.btnAgregarEntrada.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEntrada.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.btnAgregarEntrada.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.btnAgregarEntrada.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.btnAgregarEntrada.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnAgregar});
            this.btnAgregarEntrada.Location = new System.Drawing.Point(1017, 69);
            this.btnAgregarEntrada.MoveFirstItem = null;
            this.btnAgregarEntrada.MoveLastItem = null;
            this.btnAgregarEntrada.MoveNextItem = null;
            this.btnAgregarEntrada.MovePreviousItem = null;
            this.btnAgregarEntrada.Name = "btnAgregarEntrada";
            this.btnAgregarEntrada.PositionItem = null;
            this.btnAgregarEntrada.Size = new System.Drawing.Size(198, 38);
            this.btnAgregarEntrada.TabIndex = 64;
            this.btnAgregarEntrada.Text = "bindingNavigator1";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(61)))), ((int)(((byte)(62)))));
            this.BtnAgregar.Image = global::PresentacionLayer.Properties.Resources.agregar_producto__1_;
            this.BtnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Padding = new System.Windows.Forms.Padding(10);
            this.BtnAgregar.RightToLeftAutoMirrorImage = true;
            this.BtnAgregar.Size = new System.Drawing.Size(168, 35);
            this.BtnAgregar.Text = "Agregar Entrada";
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnGuestPlus
            // 
            this.BtnGuestPlus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuestPlus.BackColor = System.Drawing.Color.Transparent;
            this.BtnGuestPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuestPlus.FlatAppearance.BorderSize = 0;
            this.BtnGuestPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuestPlus.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.BtnGuestPlus.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(61)))), ((int)(((byte)(62)))));
            this.BtnGuestPlus.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnGuestPlus.IconSize = 32;
            this.BtnGuestPlus.Location = new System.Drawing.Point(1399, 42);
            this.BtnGuestPlus.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGuestPlus.Name = "BtnGuestPlus";
            this.BtnGuestPlus.Size = new System.Drawing.Size(26, 28);
            this.BtnGuestPlus.TabIndex = 36;
            this.BtnGuestPlus.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnSearch.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(61)))), ((int)(((byte)(62)))));
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 30;
            this.btnSearch.Location = new System.Drawing.Point(243, 72);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(35, 27);
            this.btnSearch.TabIndex = 33;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // FrmListaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1287, 546);
            this.Controls.Add(this.btnAgregarEntrada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mskCodigo);
            this.Controls.Add(this.txtBuscra);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnGuestPlus);
            this.Controls.Add(this.DG_Productos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmListaProductos";
            this.Text = "LISTA DE LOS PRODUCTOS";
            this.Load += new System.EventHandler(this.FrmListaProductos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Productos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarEntrada)).EndInit();
            this.btnAgregarEntrada.ResumeLayout(false);
            this.btnAgregarEntrada.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscra;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton BtnGuestPlus;
        private System.Windows.Forms.DataGridView DG_Productos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFilter;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imgCrud;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_PRODUCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_MARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntry;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.BindingNavigator btnAgregarEntrada;
        public System.Windows.Forms.ToolStripButton BtnAgregar;
    }
}