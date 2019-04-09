namespace Control_de_Tecnicos.Controles_Usuario
{
    partial class Control_Cliente
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.DgvClientes = new System.Windows.Forms.DataGridView();
            this.DgvClientesColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvClientesColTipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvClientesColIdentificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvClientesColNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvClientesColApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvClientesColSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvClientesColTipoPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvClientesDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvClientesCelCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvClientesColNumeroCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvClientesColTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvClientesColContacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvClientesColCelContacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtCelular = new System.Windows.Forms.TextBox();
            this.TxtFijo = new System.Windows.Forms.TextBox();
            this.CboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.TxtDocumento = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.LblApellido = new System.Windows.Forms.Label();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.LblSexo = new System.Windows.Forms.Label();
            this.CboSexo = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtNombreContacto = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TxtTelContacto = new System.Windows.Forms.TextBox();
            this.CboTipoPersona = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(145, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(330, 20);
            this.label5.TabIndex = 61;
            this.label5.Text = "Aqui podra realizar la gestión de sus clientes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(220, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 41);
            this.label4.TabIndex = 60;
            this.label4.Text = "Clientes";
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.BtnNuevo.FlatAppearance.BorderSize = 0;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.ForeColor = System.Drawing.Color.White;
            this.BtnNuevo.Location = new System.Drawing.Point(590, 6);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(33, 34);
            this.BtnNuevo.TabIndex = 59;
            this.BtnNuevo.Text = "+";
            this.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Visible = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.Controls.Add(this.BtnBuscar);
            this.Panel1.Controls.Add(this.TxtBuscar);
            this.Panel1.Controls.Add(this.DgvClientes);
            this.Panel1.Location = new System.Drawing.Point(546, 588);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(128, 71);
            this.Panel1.TabIndex = 58;
            this.Panel1.Visible = false;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscar.Location = new System.Drawing.Point(166, 101);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 27);
            this.BtnBuscar.TabIndex = 73;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.Location = new System.Drawing.Point(87, 101);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(73, 27);
            this.TxtBuscar.TabIndex = 73;
            // 
            // DgvClientes
            // 
            this.DgvClientes.AllowUserToAddRows = false;
            this.DgvClientes.AllowUserToDeleteRows = false;
            this.DgvClientes.AllowUserToResizeColumns = false;
            this.DgvClientes.AllowUserToResizeRows = false;
            this.DgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvClientes.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.DgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DgvClientesColID,
            this.DgvClientesColTipoDocumento,
            this.DgvClientesColIdentificacion,
            this.DgvClientesColNombres,
            this.DgvClientesColApellidos,
            this.DgvClientesColSexo,
            this.DgvClientesColTipoPersona,
            this.DgvClientesDireccion,
            this.DgvClientesCelCorreo,
            this.DgvClientesColNumeroCelular,
            this.DgvClientesColTelefono,
            this.DgvClientesColContacto,
            this.DgvClientesColCelContacto});
            this.DgvClientes.EnableHeadersVisualStyles = false;
            this.DgvClientes.Location = new System.Drawing.Point(247, 61);
            this.DgvClientes.MultiSelect = false;
            this.DgvClientes.Name = "DgvClientes";
            this.DgvClientes.ReadOnly = true;
            this.DgvClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvClientes.Size = new System.Drawing.Size(128, 35);
            this.DgvClientes.TabIndex = 36;
            this.DgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvClientes_CellClick);
            // 
            // DgvClientesColID
            // 
            this.DgvClientesColID.HeaderText = "#";
            this.DgvClientesColID.Name = "DgvClientesColID";
            this.DgvClientesColID.ReadOnly = true;
            this.DgvClientesColID.Width = 35;
            // 
            // DgvClientesColTipoDocumento
            // 
            this.DgvClientesColTipoDocumento.HeaderText = "Tipo de documento";
            this.DgvClientesColTipoDocumento.Name = "DgvClientesColTipoDocumento";
            this.DgvClientesColTipoDocumento.ReadOnly = true;
            this.DgvClientesColTipoDocumento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DgvClientesColIdentificacion
            // 
            this.DgvClientesColIdentificacion.HeaderText = "Identificación";
            this.DgvClientesColIdentificacion.MaxInputLength = 10;
            this.DgvClientesColIdentificacion.Name = "DgvClientesColIdentificacion";
            this.DgvClientesColIdentificacion.ReadOnly = true;
            this.DgvClientesColIdentificacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DgvClientesColIdentificacion.Width = 115;
            // 
            // DgvClientesColNombres
            // 
            this.DgvClientesColNombres.HeaderText = "Nombres";
            this.DgvClientesColNombres.Name = "DgvClientesColNombres";
            this.DgvClientesColNombres.ReadOnly = true;
            this.DgvClientesColNombres.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DgvClientesColNombres.Width = 250;
            // 
            // DgvClientesColApellidos
            // 
            this.DgvClientesColApellidos.HeaderText = "Apellidos";
            this.DgvClientesColApellidos.Name = "DgvClientesColApellidos";
            this.DgvClientesColApellidos.ReadOnly = true;
            this.DgvClientesColApellidos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DgvClientesColApellidos.Width = 250;
            // 
            // DgvClientesColSexo
            // 
            this.DgvClientesColSexo.HeaderText = "Sexo";
            this.DgvClientesColSexo.Name = "DgvClientesColSexo";
            this.DgvClientesColSexo.ReadOnly = true;
            this.DgvClientesColSexo.Visible = false;
            // 
            // DgvClientesColTipoPersona
            // 
            this.DgvClientesColTipoPersona.HeaderText = "Tipo Persona";
            this.DgvClientesColTipoPersona.Name = "DgvClientesColTipoPersona";
            this.DgvClientesColTipoPersona.ReadOnly = true;
            this.DgvClientesColTipoPersona.Visible = false;
            // 
            // DgvClientesDireccion
            // 
            this.DgvClientesDireccion.HeaderText = "Dirección";
            this.DgvClientesDireccion.Name = "DgvClientesDireccion";
            this.DgvClientesDireccion.ReadOnly = true;
            this.DgvClientesDireccion.Visible = false;
            // 
            // DgvClientesCelCorreo
            // 
            this.DgvClientesCelCorreo.HeaderText = "Correo";
            this.DgvClientesCelCorreo.Name = "DgvClientesCelCorreo";
            this.DgvClientesCelCorreo.ReadOnly = true;
            this.DgvClientesCelCorreo.Visible = false;
            // 
            // DgvClientesColNumeroCelular
            // 
            this.DgvClientesColNumeroCelular.HeaderText = "Numero Celular";
            this.DgvClientesColNumeroCelular.MaxInputLength = 10;
            this.DgvClientesColNumeroCelular.Name = "DgvClientesColNumeroCelular";
            this.DgvClientesColNumeroCelular.ReadOnly = true;
            this.DgvClientesColNumeroCelular.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DgvClientesColNumeroCelular.Visible = false;
            // 
            // DgvClientesColTelefono
            // 
            this.DgvClientesColTelefono.HeaderText = "Telefono";
            this.DgvClientesColTelefono.MaxInputLength = 10;
            this.DgvClientesColTelefono.Name = "DgvClientesColTelefono";
            this.DgvClientesColTelefono.ReadOnly = true;
            this.DgvClientesColTelefono.Visible = false;
            // 
            // DgvClientesColContacto
            // 
            this.DgvClientesColContacto.HeaderText = "Contacto";
            this.DgvClientesColContacto.Name = "DgvClientesColContacto";
            this.DgvClientesColContacto.ReadOnly = true;
            this.DgvClientesColContacto.Visible = false;
            // 
            // DgvClientesColCelContacto
            // 
            this.DgvClientesColCelContacto.HeaderText = "CelContacto";
            this.DgvClientesColCelContacto.Name = "DgvClientesColCelContacto";
            this.DgvClientesColCelContacto.ReadOnly = true;
            this.DgvClientesColCelContacto.Visible = false;
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.ForeColor = System.Drawing.Color.SteelBlue;
            this.Label14.Location = new System.Drawing.Point(15, 613);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(328, 18);
            this.Label14.TabIndex = 57;
            this.Label14.Text = "________________________________";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(321, 350);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(87, 21);
            this.Label7.TabIndex = 55;
            this.Label7.Text = "Dirección:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(51, 350);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(67, 21);
            this.Label1.TabIndex = 54;
            this.Label1.Text = "Correo:";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(474, 279);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(97, 21);
            this.Label8.TabIndex = 53;
            this.Label8.Text = "Numero fijo";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(51, 139);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(181, 21);
            this.Label9.TabIndex = 52;
            this.Label9.Text = "Tipo de identificación:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(51, 209);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(79, 21);
            this.LblNombre.TabIndex = 51;
            this.LblNombre.Text = "Nombres";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(323, 279);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(132, 21);
            this.Label11.TabIndex = 50;
            this.Label11.Text = "Numero celular:";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(323, 136);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(122, 21);
            this.Label12.TabIndex = 49;
            this.Label12.Text = "Identificación:";
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtCorreo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCorreo.Location = new System.Drawing.Point(45, 372);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(254, 27);
            this.TxtCorreo.TabIndex = 8;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtDireccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion.Location = new System.Drawing.Point(317, 372);
            this.TxtDireccion.Multiline = true;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(254, 90);
            this.TxtDireccion.TabIndex = 9;
            // 
            // TxtCelular
            // 
            this.TxtCelular.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtCelular.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCelular.Location = new System.Drawing.Point(317, 301);
            this.TxtCelular.MaxLength = 10;
            this.TxtCelular.Name = "TxtCelular";
            this.TxtCelular.Size = new System.Drawing.Size(129, 27);
            this.TxtCelular.TabIndex = 6;
            this.TxtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDocumento_KeyPress);
            // 
            // TxtFijo
            // 
            this.TxtFijo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtFijo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFijo.Location = new System.Drawing.Point(452, 301);
            this.TxtFijo.MaxLength = 10;
            this.TxtFijo.Name = "TxtFijo";
            this.TxtFijo.Size = new System.Drawing.Size(119, 27);
            this.TxtFijo.TabIndex = 7;
            this.TxtFijo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDocumento_KeyPress);
            // 
            // CboTipoDocumento
            // 
            this.CboTipoDocumento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTipoDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CboTipoDocumento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboTipoDocumento.FormattingEnabled = true;
            this.CboTipoDocumento.Location = new System.Drawing.Point(45, 161);
            this.CboTipoDocumento.Name = "CboTipoDocumento";
            this.CboTipoDocumento.Size = new System.Drawing.Size(254, 29);
            this.CboTipoDocumento.TabIndex = 1;
            // 
            // TxtNombres
            // 
            this.TxtNombres.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNombres.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombres.Location = new System.Drawing.Point(45, 236);
            this.TxtNombres.MaxLength = 50;
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(254, 27);
            this.TxtNombres.TabIndex = 3;
            this.TxtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreContacto_KeyPress);
            // 
            // TxtDocumento
            // 
            this.TxtDocumento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtDocumento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDocumento.Location = new System.Drawing.Point(317, 163);
            this.TxtDocumento.MaxLength = 10;
            this.TxtDocumento.Name = "TxtDocumento";
            this.TxtDocumento.Size = new System.Drawing.Size(224, 27);
            this.TxtDocumento.TabIndex = 2;
            this.TxtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDocumento_KeyPress);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Location = new System.Drawing.Point(45, 560);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(254, 29);
            this.BtnGuardar.TabIndex = 48;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellido.Location = new System.Drawing.Point(322, 212);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(80, 21);
            this.LblApellido.TabIndex = 63;
            this.LblApellido.Text = "Apellidos";
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtApellidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtApellidos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellidos.Location = new System.Drawing.Point(317, 236);
            this.TxtApellidos.MaxLength = 50;
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(254, 27);
            this.TxtApellidos.TabIndex = 4;
            this.TxtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreContacto_KeyPress);
            // 
            // LblSexo
            // 
            this.LblSexo.AutoSize = true;
            this.LblSexo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSexo.Location = new System.Drawing.Point(51, 275);
            this.LblSexo.Name = "LblSexo";
            this.LblSexo.Size = new System.Drawing.Size(46, 21);
            this.LblSexo.TabIndex = 65;
            this.LblSexo.Text = "Sexo";
            // 
            // CboSexo
            // 
            this.CboSexo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboSexo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CboSexo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboSexo.FormattingEnabled = true;
            this.CboSexo.Location = new System.Drawing.Point(45, 299);
            this.CboSexo.Name = "CboSexo";
            this.CboSexo.Size = new System.Drawing.Size(254, 29);
            this.CboSexo.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(48, 413);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(180, 21);
            this.label15.TabIndex = 68;
            this.label15.Text = "Nombre del contacto";
            // 
            // TxtNombreContacto
            // 
            this.TxtNombreContacto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtNombreContacto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNombreContacto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreContacto.Location = new System.Drawing.Point(45, 435);
            this.TxtNombreContacto.MaxLength = 80;
            this.TxtNombreContacto.Name = "TxtNombreContacto";
            this.TxtNombreContacto.Size = new System.Drawing.Size(254, 27);
            this.TxtNombreContacto.TabIndex = 10;
            this.TxtNombreContacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreContacto_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(48, 467);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(145, 21);
            this.label16.TabIndex = 70;
            this.label16.Text = "Telefono cotacto";
            // 
            // TxtTelContacto
            // 
            this.TxtTelContacto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtTelContacto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelContacto.Location = new System.Drawing.Point(45, 489);
            this.TxtTelContacto.MaxLength = 10;
            this.TxtTelContacto.Name = "TxtTelContacto";
            this.TxtTelContacto.Size = new System.Drawing.Size(148, 27);
            this.TxtTelContacto.TabIndex = 11;
            this.TxtTelContacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDocumento_KeyPress);
            // 
            // CboTipoPersona
            // 
            this.CboTipoPersona.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CboTipoPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTipoPersona.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CboTipoPersona.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboTipoPersona.FormattingEnabled = true;
            this.CboTipoPersona.Location = new System.Drawing.Point(43, 97);
            this.CboTipoPersona.Name = "CboTipoPersona";
            this.CboTipoPersona.Size = new System.Drawing.Size(254, 29);
            this.CboTipoPersona.TabIndex = 0;
            this.CboTipoPersona.SelectedIndexChanged += new System.EventHandler(this.CboTipoPersona_SelectedIndexChanged);
            this.CboTipoPersona.SelectionChangeCommitted += new System.EventHandler(this.CboTipoPersona_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 21);
            this.label3.TabIndex = 71;
            this.label3.Text = "Tipo de persona";
            // 
            // Control_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.CboTipoPersona);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtTelContacto);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TxtNombreContacto);
            this.Controls.Add(this.CboSexo);
            this.Controls.Add(this.LblSexo);
            this.Controls.Add(this.LblApellido);
            this.Controls.Add(this.TxtApellidos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.TxtCorreo);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.TxtCelular);
            this.Controls.Add(this.TxtFijo);
            this.Controls.Add(this.CboTipoDocumento);
            this.Controls.Add(this.TxtNombres);
            this.Controls.Add(this.TxtDocumento);
            this.Controls.Add(this.BtnGuardar);
            this.Name = "Control_Cliente";
            this.Size = new System.Drawing.Size(568, 588);
            this.Load += new System.EventHandler(this.Control_Cliente_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnNuevo;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.DataGridView DgvClientes;
        private System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label LblNombre;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.TextBox TxtCorreo;
        internal System.Windows.Forms.TextBox TxtDireccion;
        internal System.Windows.Forms.TextBox TxtCelular;
        internal System.Windows.Forms.TextBox TxtFijo;
        internal System.Windows.Forms.ComboBox CboTipoDocumento;
        internal System.Windows.Forms.TextBox TxtNombres;
        internal System.Windows.Forms.TextBox TxtDocumento;
        private System.Windows.Forms.Button BtnGuardar;
        internal System.Windows.Forms.Label LblApellido;
        internal System.Windows.Forms.TextBox TxtApellidos;
        internal System.Windows.Forms.Label LblSexo;
        internal System.Windows.Forms.ComboBox CboSexo;
        internal System.Windows.Forms.Label label15;
        internal System.Windows.Forms.TextBox TxtNombreContacto;
        internal System.Windows.Forms.Label label16;
        internal System.Windows.Forms.TextBox TxtTelContacto;
        internal System.Windows.Forms.ComboBox CboTipoPersona;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnBuscar;
        internal System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvClientesColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvClientesColTipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvClientesColIdentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvClientesColNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvClientesColApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvClientesColSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvClientesColTipoPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvClientesDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvClientesCelCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvClientesColNumeroCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvClientesColTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvClientesColContacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvClientesColCelContacto;
    }
}
