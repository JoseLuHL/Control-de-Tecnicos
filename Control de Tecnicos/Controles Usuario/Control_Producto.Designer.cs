namespace Control_de_Tecnicos.Controles_Usuario
{
    partial class Control_Producto
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control_Producto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnAtras = new System.Windows.Forms.Button();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.TxtCodigoProducto = new System.Windows.Forms.TextBox();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.Label11 = new System.Windows.Forms.Label();
            this.CmbCategoria = new System.Windows.Forms.ComboBox();
            this.TxtDescripcionProducto = new System.Windows.Forms.TextBox();
            this.GrpCantidad = new System.Windows.Forms.GroupBox();
            this.BtnNuevaCantidad = new System.Windows.Forms.Button();
            this.TxtNuevaCantidad = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.TxtPrecioCompra = new System.Windows.Forms.TextBox();
            this.TxtPrecioVenta = new System.Windows.Forms.TextBox();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.TxtStock = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.TxtStockMinimo = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.DgvProducto = new System.Windows.Forms.DataGridView();
            this.DgvProductoColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvProductoColCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvProductoColDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvProductoPrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvProductoColStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvProductoColPrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvProductoColStockMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvProductoColCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label6 = new System.Windows.Forms.Label();
            this.BtnContinuar = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.Panel2.SuspendLayout();
            this.GrpCantidad.SuspendLayout();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAtras
            // 
            this.BtnAtras.BackColor = System.Drawing.Color.Transparent;
            this.BtnAtras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAtras.BackgroundImage")));
            this.BtnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnAtras.FlatAppearance.BorderSize = 0;
            this.BtnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAtras.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtras.ForeColor = System.Drawing.Color.White;
            this.BtnAtras.Location = new System.Drawing.Point(285, 8);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(49, 29);
            this.BtnAtras.TabIndex = 104;
            this.BtnAtras.UseVisualStyleBackColor = false;
            this.BtnAtras.Visible = false;
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.TxtCodigoProducto);
            this.Panel2.Controls.Add(this.BtnAceptar);
            this.Panel2.Controls.Add(this.Label11);
            this.Panel2.Controls.Add(this.CmbCategoria);
            this.Panel2.Controls.Add(this.TxtDescripcionProducto);
            this.Panel2.Controls.Add(this.GrpCantidad);
            this.Panel2.Controls.Add(this.BtnNuevo);
            this.Panel2.Controls.Add(this.TxtPrecioCompra);
            this.Panel2.Controls.Add(this.TxtPrecioVenta);
            this.Panel2.Controls.Add(this.TxtID);
            this.Panel2.Controls.Add(this.TxtStock);
            this.Panel2.Controls.Add(this.Label8);
            this.Panel2.Controls.Add(this.Label10);
            this.Panel2.Controls.Add(this.TxtStockMinimo);
            this.Panel2.Controls.Add(this.Label9);
            this.Panel2.Controls.Add(this.Label1);
            this.Panel2.Controls.Add(this.Label3);
            this.Panel2.Controls.Add(this.Label2);
            this.Panel2.Location = new System.Drawing.Point(3, 71);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(356, 490);
            this.Panel2.TabIndex = 103;
            // 
            // TxtCodigoProducto
            // 
            this.TxtCodigoProducto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtCodigoProducto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoProducto.Location = new System.Drawing.Point(54, 40);
            this.TxtCodigoProducto.MaxLength = 4;
            this.TxtCodigoProducto.Name = "TxtCodigoProducto";
            this.TxtCodigoProducto.Size = new System.Drawing.Size(96, 26);
            this.TxtCodigoProducto.TabIndex = 28;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.BtnAceptar.FlatAppearance.BorderSize = 0;
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.ForeColor = System.Drawing.Color.White;
            this.BtnAceptar.Location = new System.Drawing.Point(201, 361);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(130, 42);
            this.BtnAceptar.TabIndex = 15;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(50, 17);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(68, 20);
            this.Label11.TabIndex = 27;
            this.Label11.Text = "Código:";
            // 
            // CmbCategoria
            // 
            this.CmbCategoria.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CmbCategoria.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCategoria.FormattingEnabled = true;
            this.CmbCategoria.Location = new System.Drawing.Point(54, 155);
            this.CmbCategoria.Name = "CmbCategoria";
            this.CmbCategoria.Size = new System.Drawing.Size(277, 28);
            this.CmbCategoria.TabIndex = 29;
            // 
            // TxtDescripcionProducto
            // 
            this.TxtDescripcionProducto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtDescripcionProducto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescripcionProducto.Location = new System.Drawing.Point(54, 97);
            this.TxtDescripcionProducto.Name = "TxtDescripcionProducto";
            this.TxtDescripcionProducto.Size = new System.Drawing.Size(277, 26);
            this.TxtDescripcionProducto.TabIndex = 30;
            // 
            // GrpCantidad
            // 
            this.GrpCantidad.Controls.Add(this.BtnNuevaCantidad);
            this.GrpCantidad.Controls.Add(this.TxtNuevaCantidad);
            this.GrpCantidad.Controls.Add(this.Label7);
            this.GrpCantidad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpCantidad.Location = new System.Drawing.Point(11, 409);
            this.GrpCantidad.Name = "GrpCantidad";
            this.GrpCantidad.Size = new System.Drawing.Size(334, 74);
            this.GrpCantidad.TabIndex = 42;
            this.GrpCantidad.TabStop = false;
            this.GrpCantidad.Visible = false;
            // 
            // BtnNuevaCantidad
            // 
            this.BtnNuevaCantidad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnNuevaCantidad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevaCantidad.Location = new System.Drawing.Point(161, 37);
            this.BtnNuevaCantidad.Name = "BtnNuevaCantidad";
            this.BtnNuevaCantidad.Size = new System.Drawing.Size(91, 33);
            this.BtnNuevaCantidad.TabIndex = 27;
            this.BtnNuevaCantidad.Text = "Agregar";
            this.BtnNuevaCantidad.UseVisualStyleBackColor = false;
            // 
            // TxtNuevaCantidad
            // 
            this.TxtNuevaCantidad.BackColor = System.Drawing.Color.Yellow;
            this.TxtNuevaCantidad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNuevaCantidad.ForeColor = System.Drawing.Color.Black;
            this.TxtNuevaCantidad.Location = new System.Drawing.Point(56, 42);
            this.TxtNuevaCantidad.Name = "TxtNuevaCantidad";
            this.TxtNuevaCantidad.Size = new System.Drawing.Size(96, 26);
            this.TxtNuevaCantidad.TabIndex = 23;
            this.TxtNuevaCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(16, 19);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(136, 20);
            this.Label7.TabIndex = 24;
            this.Label7.Text = "Nueva Cantidad:";
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.BtnNuevo.FlatAppearance.BorderSize = 0;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.ForeColor = System.Drawing.Color.White;
            this.BtnNuevo.Location = new System.Drawing.Point(298, 32);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(33, 34);
            this.BtnNuevo.TabIndex = 44;
            this.BtnNuevo.Text = "+";
            this.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnNuevo.UseVisualStyleBackColor = false;
            // 
            // TxtPrecioCompra
            // 
            this.TxtPrecioCompra.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtPrecioCompra.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecioCompra.Location = new System.Drawing.Point(54, 214);
            this.TxtPrecioCompra.Name = "TxtPrecioCompra";
            this.TxtPrecioCompra.Size = new System.Drawing.Size(96, 26);
            this.TxtPrecioCompra.TabIndex = 31;
            // 
            // TxtPrecioVenta
            // 
            this.TxtPrecioVenta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtPrecioVenta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecioVenta.Location = new System.Drawing.Point(54, 269);
            this.TxtPrecioVenta.Name = "TxtPrecioVenta";
            this.TxtPrecioVenta.Size = new System.Drawing.Size(96, 26);
            this.TxtPrecioVenta.TabIndex = 32;
            // 
            // TxtID
            // 
            this.TxtID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtID.Location = new System.Drawing.Point(168, 40);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(53, 26);
            this.TxtID.TabIndex = 41;
            this.TxtID.Visible = false;
            // 
            // TxtStock
            // 
            this.TxtStock.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtStock.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStock.Location = new System.Drawing.Point(54, 325);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.Size = new System.Drawing.Size(96, 26);
            this.TxtStock.TabIndex = 33;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(50, 132);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(88, 20);
            this.Label8.TabIndex = 40;
            this.Label8.Text = "Categoría:";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(50, 74);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(100, 20);
            this.Label10.TabIndex = 35;
            this.Label10.Text = "Descripción:";
            // 
            // TxtStockMinimo
            // 
            this.TxtStockMinimo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtStockMinimo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStockMinimo.Location = new System.Drawing.Point(54, 377);
            this.TxtStockMinimo.Name = "TxtStockMinimo";
            this.TxtStockMinimo.Size = new System.Drawing.Size(96, 26);
            this.TxtStockMinimo.TabIndex = 34;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(50, 191);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(146, 20);
            this.Label9.TabIndex = 36;
            this.Label9.Text = "Precio de compra:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(50, 302);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(53, 20);
            this.Label1.TabIndex = 39;
            this.Label1.Text = "Stock:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(50, 246);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(132, 20);
            this.Label3.TabIndex = 37;
            this.Label3.Text = "Precio de venta:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(50, 354);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(108, 20);
            this.Label2.TabIndex = 38;
            this.Label2.Text = "Stock mínimo:";
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.label4);
            this.Panel1.Controls.Add(this.DgvProducto);
            this.Panel1.Controls.Add(this.Label6);
            this.Panel1.Location = new System.Drawing.Point(365, 26);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(701, 404);
            this.Panel1.TabIndex = 102;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(103, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 41);
            this.label4.TabIndex = 12;
            this.label4.Text = "Productos";
            // 
            // DgvProducto
            // 
            this.DgvProducto.AllowUserToAddRows = false;
            this.DgvProducto.AllowUserToDeleteRows = false;
            this.DgvProducto.AllowUserToResizeColumns = false;
            this.DgvProducto.AllowUserToResizeRows = false;
            this.DgvProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvProducto.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DgvProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvProducto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.DgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DgvProductoColId,
            this.DgvProductoColCodigo,
            this.DgvProductoColDescripcion,
            this.DgvProductoPrecioVenta,
            this.DgvProductoColStock,
            this.DgvProductoColPrecioCompra,
            this.DgvProductoColStockMinimo,
            this.DgvProductoColCategoria});
            this.DgvProducto.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DgvProducto.Location = new System.Drawing.Point(12, 80);
            this.DgvProducto.Name = "DgvProducto";
            this.DgvProducto.ReadOnly = true;
            this.DgvProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvProducto.Size = new System.Drawing.Size(572, 316);
            this.DgvProducto.TabIndex = 28;
            // 
            // DgvProductoColId
            // 
            this.DgvProductoColId.HeaderText = "ID";
            this.DgvProductoColId.Name = "DgvProductoColId";
            this.DgvProductoColId.ReadOnly = true;
            this.DgvProductoColId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DgvProductoColId.Visible = false;
            // 
            // DgvProductoColCodigo
            // 
            this.DgvProductoColCodigo.HeaderText = "Codigo";
            this.DgvProductoColCodigo.Name = "DgvProductoColCodigo";
            this.DgvProductoColCodigo.ReadOnly = true;
            this.DgvProductoColCodigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DgvProductoColDescripcion
            // 
            this.DgvProductoColDescripcion.HeaderText = "Descripción";
            this.DgvProductoColDescripcion.Name = "DgvProductoColDescripcion";
            this.DgvProductoColDescripcion.ReadOnly = true;
            this.DgvProductoColDescripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DgvProductoPrecioVenta
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.DgvProductoPrecioVenta.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvProductoPrecioVenta.HeaderText = "Precio / Venta";
            this.DgvProductoPrecioVenta.Name = "DgvProductoPrecioVenta";
            this.DgvProductoPrecioVenta.ReadOnly = true;
            this.DgvProductoPrecioVenta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DgvProductoColStock
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DgvProductoColStock.DefaultCellStyle = dataGridViewCellStyle4;
            this.DgvProductoColStock.HeaderText = "Stock";
            this.DgvProductoColStock.Name = "DgvProductoColStock";
            this.DgvProductoColStock.ReadOnly = true;
            this.DgvProductoColStock.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DgvProductoColPrecioCompra
            // 
            this.DgvProductoColPrecioCompra.HeaderText = "Precio Compra";
            this.DgvProductoColPrecioCompra.Name = "DgvProductoColPrecioCompra";
            this.DgvProductoColPrecioCompra.ReadOnly = true;
            this.DgvProductoColPrecioCompra.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DgvProductoColPrecioCompra.Visible = false;
            // 
            // DgvProductoColStockMinimo
            // 
            this.DgvProductoColStockMinimo.HeaderText = "Stock Minimo";
            this.DgvProductoColStockMinimo.Name = "DgvProductoColStockMinimo";
            this.DgvProductoColStockMinimo.ReadOnly = true;
            this.DgvProductoColStockMinimo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DgvProductoColStockMinimo.Visible = false;
            // 
            // DgvProductoColCategoria
            // 
            this.DgvProductoColCategoria.HeaderText = "Categoria";
            this.DgvProductoColCategoria.Name = "DgvProductoColCategoria";
            this.DgvProductoColCategoria.ReadOnly = true;
            this.DgvProductoColCategoria.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DgvProductoColCategoria.Visible = false;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(38, 57);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(349, 20);
            this.Label6.TabIndex = 43;
            this.Label6.Text = "Aqui podra realizar la gestión de sus productos";
            // 
            // BtnContinuar
            // 
            this.BtnContinuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.BtnContinuar.FlatAppearance.BorderSize = 0;
            this.BtnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnContinuar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnContinuar.ForeColor = System.Drawing.Color.White;
            this.BtnContinuar.Location = new System.Drawing.Point(498, 492);
            this.BtnContinuar.Name = "BtnContinuar";
            this.BtnContinuar.Size = new System.Drawing.Size(254, 29);
            this.BtnContinuar.TabIndex = 101;
            this.BtnContinuar.Text = "Continuar";
            this.BtnContinuar.UseVisualStyleBackColor = false;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(491, 448);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(202, 41);
            this.Label5.TabIndex = 100;
            this.Label5.Text = "Categorías";
            // 
            // Control_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.BtnContinuar);
            this.Controls.Add(this.Label5);
            this.Name = "Control_Producto";
            this.Size = new System.Drawing.Size(1096, 617);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.GrpCantidad.ResumeLayout(false);
            this.GrpCantidad.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAtras;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.TextBox TxtCodigoProducto;
        private System.Windows.Forms.Button BtnAceptar;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.ComboBox CmbCategoria;
        internal System.Windows.Forms.TextBox TxtDescripcionProducto;
        internal System.Windows.Forms.GroupBox GrpCantidad;
        internal System.Windows.Forms.Button BtnNuevaCantidad;
        internal System.Windows.Forms.TextBox TxtNuevaCantidad;
        internal System.Windows.Forms.Label Label7;
        private System.Windows.Forms.Button BtnNuevo;
        internal System.Windows.Forms.TextBox TxtPrecioCompra;
        internal System.Windows.Forms.TextBox TxtPrecioVenta;
        internal System.Windows.Forms.TextBox TxtID;
        internal System.Windows.Forms.TextBox TxtStock;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox TxtStockMinimo;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.DataGridView DgvProducto;
        internal System.Windows.Forms.DataGridViewTextBoxColumn DgvProductoColId;
        internal System.Windows.Forms.DataGridViewTextBoxColumn DgvProductoColCodigo;
        internal System.Windows.Forms.DataGridViewTextBoxColumn DgvProductoColDescripcion;
        internal System.Windows.Forms.DataGridViewTextBoxColumn DgvProductoPrecioVenta;
        internal System.Windows.Forms.DataGridViewTextBoxColumn DgvProductoColStock;
        internal System.Windows.Forms.DataGridViewTextBoxColumn DgvProductoColPrecioCompra;
        internal System.Windows.Forms.DataGridViewTextBoxColumn DgvProductoColStockMinimo;
        internal System.Windows.Forms.DataGridViewTextBoxColumn DgvProductoColCategoria;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.Button BtnContinuar;
        private System.Windows.Forms.Label Label5;
    }
}
