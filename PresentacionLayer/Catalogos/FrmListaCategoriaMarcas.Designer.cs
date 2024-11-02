namespace PresentacionLayer.Catalogos
{
    partial class FrmListaCategoriaMarcas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaCategoriaMarcas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigoMarca = new System.Windows.Forms.MaskedTextBox();
            this.txtBuscarMarca = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFilterMarca = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DG_Marcas = new System.Windows.Forms.DataGridView();
            this.CODIGO_MARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE_MARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DG_Categorias = new System.Windows.Forms.DataGridView();
            this.CODIGO_CATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE_CATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscarCategoria = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbFilterCategoria = new System.Windows.Forms.ComboBox();
            this.txtCodigoCategoria = new System.Windows.Forms.MaskedTextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.imgCrud = new System.Windows.Forms.ImageList(this.components);
            this.imgCrud1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Marcas)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Categorias)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(61)))), ((int)(((byte)(62)))));
            this.label5.Location = new System.Drawing.Point(8, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 19);
            this.label5.TabIndex = 49;
            this.label5.Text = "Filtrar";
            // 
            // txtCodigoMarca
            // 
            this.txtCodigoMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoMarca.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(61)))), ((int)(((byte)(62)))));
            this.txtCodigoMarca.Location = new System.Drawing.Point(65, 7);
            this.txtCodigoMarca.Mask = "AAAAAAAA";
            this.txtCodigoMarca.Name = "txtCodigoMarca";
            this.txtCodigoMarca.Size = new System.Drawing.Size(110, 24);
            this.txtCodigoMarca.TabIndex = 48;
            this.txtCodigoMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoMarca_KeyPress);
            // 
            // txtBuscarMarca
            // 
            this.txtBuscarMarca.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(61)))), ((int)(((byte)(62)))));
            this.txtBuscarMarca.Location = new System.Drawing.Point(241, 7);
            this.txtBuscarMarca.Name = "txtBuscarMarca";
            this.txtBuscarMarca.Size = new System.Drawing.Size(161, 24);
            this.txtBuscarMarca.TabIndex = 47;
            this.txtBuscarMarca.TextChanged += new System.EventHandler(this.txtBuscarMarca_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(88)))), ((int)(((byte)(111)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 54);
            this.panel1.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(501, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Marcas y Categorías";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(61)))), ((int)(((byte)(62)))));
            this.label3.Location = new System.Drawing.Point(447, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 45;
            this.label3.Text = "Visualizar";
            // 
            // cmbFilterMarca
            // 
            this.cmbFilterMarca.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilterMarca.FormattingEnabled = true;
            this.cmbFilterMarca.Items.AddRange(new object[] {
            "15",
            "20",
            "25",
            "30",
            "40",
            "50",
            "100"});
            this.cmbFilterMarca.Location = new System.Drawing.Point(534, 6);
            this.cmbFilterMarca.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFilterMarca.Name = "cmbFilterMarca";
            this.cmbFilterMarca.Size = new System.Drawing.Size(62, 27);
            this.cmbFilterMarca.TabIndex = 44;
            this.cmbFilterMarca.SelectedIndexChanged += new System.EventHandler(this.cmbFilterMarca_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.DG_Marcas);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txtBuscarMarca);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cmbFilterMarca);
            this.panel2.Controls.Add(this.txtCodigoMarca);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Location = new System.Drawing.Point(12, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(608, 413);
            this.panel2.TabIndex = 50;
            // 
            // DG_Marcas
            // 
            this.DG_Marcas.AllowUserToAddRows = false;
            this.DG_Marcas.AllowUserToDeleteRows = false;
            this.DG_Marcas.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(88)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(88)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DG_Marcas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_Marcas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_Marcas.BackgroundColor = System.Drawing.Color.White;
            this.DG_Marcas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_Marcas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DG_Marcas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(61)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(196)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(61)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_Marcas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DG_Marcas.ColumnHeadersHeight = 38;
            this.DG_Marcas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO_MARCA,
            this.NOMBRE_MARCA,
            this.Edit,
            this.delete});
            this.DG_Marcas.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(88)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(88)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_Marcas.DefaultCellStyle = dataGridViewCellStyle5;
            this.DG_Marcas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DG_Marcas.EnableHeadersVisualStyles = false;
            this.DG_Marcas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(88)))), ((int)(((byte)(111)))));
            this.DG_Marcas.Location = new System.Drawing.Point(24, 88);
            this.DG_Marcas.Margin = new System.Windows.Forms.Padding(2);
            this.DG_Marcas.Name = "DG_Marcas";
            this.DG_Marcas.RowHeadersVisible = false;
            this.DG_Marcas.RowHeadersWidth = 40;
            this.DG_Marcas.RowTemplate.Height = 20;
            this.DG_Marcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_Marcas.Size = new System.Drawing.Size(545, 319);
            this.DG_Marcas.TabIndex = 52;
            this.DG_Marcas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Marcas_CellContentClick);
            // 
            // CODIGO_MARCA
            // 
            this.CODIGO_MARCA.HeaderText = "Código";
            this.CODIGO_MARCA.MinimumWidth = 6;
            this.CODIGO_MARCA.Name = "CODIGO_MARCA";
            this.CODIGO_MARCA.Width = 172;
            // 
            // NOMBRE_MARCA
            // 
            this.NOMBRE_MARCA.HeaderText = "Nombre de la Marca";
            this.NOMBRE_MARCA.MinimumWidth = 6;
            this.NOMBRE_MARCA.Name = "NOMBRE_MARCA";
            this.NOMBRE_MARCA.Width = 171;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(61)))), ((int)(((byte)(62)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(3, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(598, 35);
            this.panel3.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(233, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Marcas ";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnSearch.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(61)))), ((int)(((byte)(62)))));
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 30;
            this.btnSearch.Location = new System.Drawing.Point(205, 7);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(35, 27);
            this.btnSearch.TabIndex = 43;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.DG_Categorias);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.txtBuscarCategoria);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.cmbFilterCategoria);
            this.panel4.Controls.Add(this.txtCodigoCategoria);
            this.panel4.Controls.Add(this.iconButton1);
            this.panel4.Location = new System.Drawing.Point(639, 65);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(608, 413);
            this.panel4.TabIndex = 51;
            // 
            // DG_Categorias
            // 
            this.DG_Categorias.AllowUserToAddRows = false;
            this.DG_Categorias.AllowUserToDeleteRows = false;
            this.DG_Categorias.AllowUserToResizeColumns = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(88)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(88)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DG_Categorias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DG_Categorias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_Categorias.BackgroundColor = System.Drawing.Color.White;
            this.DG_Categorias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_Categorias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DG_Categorias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(61)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(196)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(61)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_Categorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DG_Categorias.ColumnHeadersHeight = 38;
            this.DG_Categorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO_CATEGORIA,
            this.NOMBRE_CATEGORIA,
            this.dataGridViewImageColumn1,
            this.dataGridViewImageColumn2});
            this.DG_Categorias.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(88)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(88)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_Categorias.DefaultCellStyle = dataGridViewCellStyle10;
            this.DG_Categorias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DG_Categorias.EnableHeadersVisualStyles = false;
            this.DG_Categorias.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(88)))), ((int)(((byte)(111)))));
            this.DG_Categorias.Location = new System.Drawing.Point(28, 88);
            this.DG_Categorias.Margin = new System.Windows.Forms.Padding(2);
            this.DG_Categorias.Name = "DG_Categorias";
            this.DG_Categorias.RowHeadersVisible = false;
            this.DG_Categorias.RowHeadersWidth = 40;
            this.DG_Categorias.RowTemplate.Height = 20;
            this.DG_Categorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_Categorias.Size = new System.Drawing.Size(554, 319);
            this.DG_Categorias.TabIndex = 53;
            this.DG_Categorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Categorias_CellContentClick);
            // 
            // CODIGO_CATEGORIA
            // 
            this.CODIGO_CATEGORIA.HeaderText = "Código";
            this.CODIGO_CATEGORIA.MinimumWidth = 6;
            this.CODIGO_CATEGORIA.Name = "CODIGO_CATEGORIA";
            this.CODIGO_CATEGORIA.Width = 172;
            // 
            // NOMBRE_CATEGORIA
            // 
            this.NOMBRE_CATEGORIA.HeaderText = "Nombre de la Categoría";
            this.NOMBRE_CATEGORIA.MinimumWidth = 6;
            this.NOMBRE_CATEGORIA.Name = "NOMBRE_CATEGORIA";
            this.NOMBRE_CATEGORIA.Width = 180;
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle8.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle8.NullValue")));
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewImageColumn1.FillWeight = 60F;
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewImageColumn2
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle9.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle9.NullValue")));
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewImageColumn2.HeaderText = "Eliminar";
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(61)))), ((int)(((byte)(62)))));
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(3, 52);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(598, 35);
            this.panel5.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(235, 1);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Categorías";
            // 
            // txtBuscarCategoria
            // 
            this.txtBuscarCategoria.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(61)))), ((int)(((byte)(62)))));
            this.txtBuscarCategoria.Location = new System.Drawing.Point(241, 7);
            this.txtBuscarCategoria.Name = "txtBuscarCategoria";
            this.txtBuscarCategoria.Size = new System.Drawing.Size(161, 24);
            this.txtBuscarCategoria.TabIndex = 47;
            this.txtBuscarCategoria.TextChanged += new System.EventHandler(this.txtBuscarCategoria_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(61)))), ((int)(((byte)(62)))));
            this.label6.Location = new System.Drawing.Point(447, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 19);
            this.label6.TabIndex = 45;
            this.label6.Text = "Visualizar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(61)))), ((int)(((byte)(62)))));
            this.label7.Location = new System.Drawing.Point(8, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 19);
            this.label7.TabIndex = 49;
            this.label7.Text = "Filtrar";
            // 
            // cmbFilterCategoria
            // 
            this.cmbFilterCategoria.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilterCategoria.FormattingEnabled = true;
            this.cmbFilterCategoria.Items.AddRange(new object[] {
            "15",
            "20",
            "25",
            "30",
            "40",
            "50",
            "100"});
            this.cmbFilterCategoria.Location = new System.Drawing.Point(534, 6);
            this.cmbFilterCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFilterCategoria.Name = "cmbFilterCategoria";
            this.cmbFilterCategoria.Size = new System.Drawing.Size(62, 27);
            this.cmbFilterCategoria.TabIndex = 44;
            this.cmbFilterCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbFilterCategoria_SelectedIndexChanged);
            // 
            // txtCodigoCategoria
            // 
            this.txtCodigoCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoCategoria.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(61)))), ((int)(((byte)(62)))));
            this.txtCodigoCategoria.Location = new System.Drawing.Point(65, 7);
            this.txtCodigoCategoria.Mask = "AAAAAAAA";
            this.txtCodigoCategoria.Name = "txtCodigoCategoria";
            this.txtCodigoCategoria.Size = new System.Drawing.Size(110, 24);
            this.txtCodigoCategoria.TabIndex = 48;
            this.txtCodigoCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoCategoria_KeyPress);
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(61)))), ((int)(((byte)(62)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(205, 7);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(35, 27);
            this.iconButton1.TabIndex = 43;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // imgCrud
            // 
            this.imgCrud.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgCrud.ImageStream")));
            this.imgCrud.TransparentColor = System.Drawing.Color.Transparent;
            this.imgCrud.Images.SetKeyName(0, "avatar-de-usuario.png");
            this.imgCrud.Images.SetKeyName(1, "eliminar.png");
            // 
            // imgCrud1
            // 
            this.imgCrud1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgCrud1.ImageStream")));
            this.imgCrud1.TransparentColor = System.Drawing.Color.Transparent;
            this.imgCrud1.Images.SetKeyName(0, "avatar-de-usuario.png");
            this.imgCrud1.Images.SetKeyName(1, "eliminar.png");
            // 
            // FrmListaCategoriaMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 490);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmListaCategoriaMarcas";
            this.Text = "LISTA DE CATEGORÍAS Y MARCAS";
            this.Load += new System.EventHandler(this.FrmListaCategoriaMarcas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Marcas)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Categorias)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtCodigoMarca;
        private System.Windows.Forms.TextBox txtBuscarMarca;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFilterMarca;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscarCategoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbFilterCategoria;
        private System.Windows.Forms.MaskedTextBox txtCodigoCategoria;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.DataGridView DG_Marcas;
        private System.Windows.Forms.DataGridView DG_Categorias;
        private System.Windows.Forms.ImageList imgCrud;
        private System.Windows.Forms.ImageList imgCrud1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_MARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_MARCA;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_CATEGORIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_CATEGORIA;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
    }
}