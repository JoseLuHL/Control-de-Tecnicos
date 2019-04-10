namespace Control_de_Tecnicos.Controles_Usuario
{
    partial class FrmTaller
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.TxtDocumento = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.LblCelular = new System.Windows.Forms.Label();
            this.LblNombreRazonSocial = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CboMarca = new System.Windows.Forms.ComboBox();
            this.CboEquipo = new System.Windows.Forms.ComboBox();
            this.TxtGenerarOrden = new System.Windows.Forms.Button();
            this.DgvAccesorio = new System.Windows.Forms.DataGridView();
            this.DgvAccesorioColCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvAccesorioColAccesorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvAccesorioColCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DgvAccesorioColSerial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.Label();
            this.TxtSerial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.TxtObservacion = new System.Windows.Forms.TextBox();
            this.CboResponsableArreglo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CboServicio = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.CboQuienrecibe = new System.Windows.Forms.ComboBox();
            this.LblFechaInicio = new System.Windows.Forms.Label();
            this.DtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAccesorio)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(340, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(288, 20);
            this.label5.TabIndex = 88;
            this.label5.Text = "Aqui podra realizar la gestión del taller";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(442, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 41);
            this.label4.TabIndex = 87;
            this.label4.Text = "Taller";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(395, 15);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(76, 21);
            this.LblNombre.TabIndex = 82;
            this.LblNombre.Text = "Telefono";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(20, 18);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(122, 21);
            this.Label12.TabIndex = 80;
            this.Label12.Text = "Identificación:";
            // 
            // TxtDocumento
            // 
            this.TxtDocumento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtDocumento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDocumento.Location = new System.Drawing.Point(14, 45);
            this.TxtDocumento.MaxLength = 10;
            this.TxtDocumento.Name = "TxtDocumento";
            this.TxtDocumento.Size = new System.Drawing.Size(224, 27);
            this.TxtDocumento.TabIndex = 0;
            this.TxtDocumento.TextChanged += new System.EventHandler(this.TxtDocumento_TextChanged);
            this.TxtDocumento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtDocumento_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblDireccion);
            this.groupBox1.Controls.Add(this.LblEmail);
            this.groupBox1.Controls.Add(this.LblTelefono);
            this.groupBox1.Controls.Add(this.LblCelular);
            this.groupBox1.Controls.Add(this.LblNombreRazonSocial);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Label12);
            this.groupBox1.Controls.Add(this.TxtDocumento);
            this.groupBox1.Controls.Add(this.LblNombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(936, 138);
            this.groupBox1.TabIndex = 100;
            this.groupBox1.TabStop = false;
            // 
            // LblDireccion
            // 
            this.LblDireccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblDireccion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDireccion.Location = new System.Drawing.Point(517, 43);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(403, 31);
            this.LblDireccion.TabIndex = 98;
            this.LblDireccion.Text = "3123589025";
            // 
            // LblEmail
            // 
            this.LblEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblEmail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(452, 84);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(468, 30);
            this.LblEmail.TabIndex = 97;
            this.LblEmail.Text = "3123589025";
            // 
            // LblTelefono
            // 
            this.LblTelefono.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblTelefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTelefono.Location = new System.Drawing.Point(399, 43);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(112, 29);
            this.LblTelefono.TabIndex = 96;
            this.LblTelefono.Text = "3123589025";
            // 
            // LblCelular
            // 
            this.LblCelular.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblCelular.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCelular.Location = new System.Drawing.Point(269, 45);
            this.LblCelular.Name = "LblCelular";
            this.LblCelular.Size = new System.Drawing.Size(112, 29);
            this.LblCelular.TabIndex = 95;
            this.LblCelular.Text = "3123589025";
            // 
            // LblNombreRazonSocial
            // 
            this.LblNombreRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblNombreRazonSocial.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreRazonSocial.Location = new System.Drawing.Point(14, 79);
            this.LblNombreRazonSocial.Name = "LblNombreRazonSocial";
            this.LblNombreRazonSocial.Size = new System.Drawing.Size(367, 44);
            this.LblNombreRazonSocial.TabIndex = 94;
            this.LblNombreRazonSocial.Text = "Nombre/Razon social";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(513, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 21);
            this.label11.TabIndex = 93;
            this.label11.Text = "Dirección";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(395, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 21);
            this.label10.TabIndex = 92;
            this.label10.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(265, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 21);
            this.label8.TabIndex = 91;
            this.label8.Text = "Celular";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LblFechaInicio);
            this.groupBox2.Controls.Add(this.DtFechaInicio);
            this.groupBox2.Controls.Add(this.CboMarca);
            this.groupBox2.Controls.Add(this.CboEquipo);
            this.groupBox2.Controls.Add(this.TxtGenerarOrden);
            this.groupBox2.Controls.Add(this.DgvAccesorio);
            this.groupBox2.Controls.Add(this.Marca);
            this.groupBox2.Controls.Add(this.TxtSerial);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.TxtObservacion);
            this.groupBox2.Controls.Add(this.CboResponsableArreglo);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.CboServicio);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.CboQuienrecibe);
            this.groupBox2.Location = new System.Drawing.Point(12, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(936, 298);
            this.groupBox2.TabIndex = 101;
            this.groupBox2.TabStop = false;
            // 
            // CboMarca
            // 
            this.CboMarca.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboMarca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CboMarca.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboMarca.FormattingEnabled = true;
            this.CboMarca.Location = new System.Drawing.Point(278, 102);
            this.CboMarca.Name = "CboMarca";
            this.CboMarca.Size = new System.Drawing.Size(148, 29);
            this.CboMarca.TabIndex = 3;
            // 
            // CboEquipo
            // 
            this.CboEquipo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CboEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CboEquipo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboEquipo.FormattingEnabled = true;
            this.CboEquipo.Location = new System.Drawing.Point(14, 100);
            this.CboEquipo.Name = "CboEquipo";
            this.CboEquipo.Size = new System.Drawing.Size(258, 29);
            this.CboEquipo.TabIndex = 2;
            // 
            // TxtGenerarOrden
            // 
            this.TxtGenerarOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.TxtGenerarOrden.FlatAppearance.BorderSize = 0;
            this.TxtGenerarOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TxtGenerarOrden.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGenerarOrden.ForeColor = System.Drawing.Color.White;
            this.TxtGenerarOrden.Location = new System.Drawing.Point(671, 258);
            this.TxtGenerarOrden.Name = "TxtGenerarOrden";
            this.TxtGenerarOrden.Size = new System.Drawing.Size(239, 34);
            this.TxtGenerarOrden.TabIndex = 8;
            this.TxtGenerarOrden.Text = "Generar Orden";
            this.TxtGenerarOrden.UseVisualStyleBackColor = false;
            this.TxtGenerarOrden.Click += new System.EventHandler(this.TxtGenerarOrden_Click);
            // 
            // DgvAccesorio
            // 
            this.DgvAccesorio.AllowUserToAddRows = false;
            this.DgvAccesorio.AllowUserToDeleteRows = false;
            this.DgvAccesorio.AllowUserToResizeColumns = false;
            this.DgvAccesorio.AllowUserToResizeRows = false;
            this.DgvAccesorio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvAccesorio.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DgvAccesorio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvAccesorio.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvAccesorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAccesorio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DgvAccesorioColCodigo,
            this.DgvAccesorioColAccesorio,
            this.DgvAccesorioColCheck,
            this.DgvAccesorioColSerial});
            this.DgvAccesorio.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DgvAccesorio.EnableHeadersVisualStyles = false;
            this.DgvAccesorio.Location = new System.Drawing.Point(603, 17);
            this.DgvAccesorio.MultiSelect = false;
            this.DgvAccesorio.Name = "DgvAccesorio";
            this.DgvAccesorio.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvAccesorio.RowHeadersVisible = false;
            this.DgvAccesorio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvAccesorio.Size = new System.Drawing.Size(327, 171);
            this.DgvAccesorio.TabIndex = 106;
            // 
            // DgvAccesorioColCodigo
            // 
            this.DgvAccesorioColCodigo.HeaderText = "Codigo";
            this.DgvAccesorioColCodigo.Name = "DgvAccesorioColCodigo";
            this.DgvAccesorioColCodigo.Visible = false;
            // 
            // DgvAccesorioColAccesorio
            // 
            this.DgvAccesorioColAccesorio.HeaderText = "Accesorios";
            this.DgvAccesorioColAccesorio.MaxInputLength = 10;
            this.DgvAccesorioColAccesorio.Name = "DgvAccesorioColAccesorio";
            this.DgvAccesorioColAccesorio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DgvAccesorioColAccesorio.Width = 250;
            // 
            // DgvAccesorioColCheck
            // 
            this.DgvAccesorioColCheck.HeaderText = "";
            this.DgvAccesorioColCheck.Name = "DgvAccesorioColCheck";
            this.DgvAccesorioColCheck.Width = 26;
            // 
            // DgvAccesorioColSerial
            // 
            this.DgvAccesorioColSerial.HeaderText = "serial";
            this.DgvAccesorioColSerial.Name = "DgvAccesorioColSerial";
            // 
            // Marca
            // 
            this.Marca.AutoSize = true;
            this.Marca.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Marca.Location = new System.Drawing.Point(274, 78);
            this.Marca.Name = "Marca";
            this.Marca.Size = new System.Drawing.Size(62, 21);
            this.Marca.TabIndex = 105;
            this.Marca.Text = "Marca";
            // 
            // TxtSerial
            // 
            this.TxtSerial.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtSerial.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSerial.Location = new System.Drawing.Point(432, 100);
            this.TxtSerial.MaxLength = 10;
            this.TxtSerial.Name = "TxtSerial";
            this.TxtSerial.Size = new System.Drawing.Size(152, 27);
            this.TxtSerial.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(432, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 21);
            this.label2.TabIndex = 102;
            this.label2.Text = "Serial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 103;
            this.label3.Text = "Equipo";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(342, 224);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(195, 21);
            this.label20.TabIndex = 110;
            this.label20.Text = "Responsable del arreglo";
            // 
            // TxtObservacion
            // 
            this.TxtObservacion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtObservacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtObservacion.Location = new System.Drawing.Point(14, 151);
            this.TxtObservacion.Multiline = true;
            this.TxtObservacion.Name = "TxtObservacion";
            this.TxtObservacion.Size = new System.Drawing.Size(570, 57);
            this.TxtObservacion.TabIndex = 5;
            // 
            // CboResponsableArreglo
            // 
            this.CboResponsableArreglo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CboResponsableArreglo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboResponsableArreglo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CboResponsableArreglo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboResponsableArreglo.FormattingEnabled = true;
            this.CboResponsableArreglo.Location = new System.Drawing.Point(336, 249);
            this.CboResponsableArreglo.Name = "CboResponsableArreglo";
            this.CboResponsableArreglo.Size = new System.Drawing.Size(297, 29);
            this.CboResponsableArreglo.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 21);
            this.label9.TabIndex = 99;
            this.label9.Text = "Observación";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 21);
            this.label6.TabIndex = 96;
            this.label6.Text = "Servicio";
            // 
            // CboServicio
            // 
            this.CboServicio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CboServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboServicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CboServicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboServicio.FormattingEnabled = true;
            this.CboServicio.Location = new System.Drawing.Point(14, 42);
            this.CboServicio.Name = "CboServicio";
            this.CboServicio.Size = new System.Drawing.Size(570, 29);
            this.CboServicio.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(20, 224);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(110, 21);
            this.label18.TabIndex = 106;
            this.label18.Text = "Quien recibe";
            // 
            // CboQuienrecibe
            // 
            this.CboQuienrecibe.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CboQuienrecibe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboQuienrecibe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CboQuienrecibe.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboQuienrecibe.FormattingEnabled = true;
            this.CboQuienrecibe.Location = new System.Drawing.Point(14, 249);
            this.CboQuienrecibe.Name = "CboQuienrecibe";
            this.CboQuienrecibe.Size = new System.Drawing.Size(316, 29);
            this.CboQuienrecibe.TabIndex = 6;
            // 
            // LblFechaInicio
            // 
            this.LblFechaInicio.AutoSize = true;
            this.LblFechaInicio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaInicio.Location = new System.Drawing.Point(670, 204);
            this.LblFechaInicio.Name = "LblFechaInicio";
            this.LblFechaInicio.Size = new System.Drawing.Size(85, 17);
            this.LblFechaInicio.TabIndex = 111;
            this.LblFechaInicio.Text = "Fecha inicio";
            // 
            // DtFechaInicio
            // 
            this.DtFechaInicio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtFechaInicio.Location = new System.Drawing.Point(671, 224);
            this.DtFechaInicio.Name = "DtFechaInicio";
            this.DtFechaInicio.Size = new System.Drawing.Size(116, 26);
            this.DtFechaInicio.TabIndex = 112;
            // 
            // FrmTaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(960, 524);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "FrmTaller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmTaller_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAccesorio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label LblNombre;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.TextBox TxtDocumento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.TextBox TxtObservacion;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.ComboBox CboServicio;
        internal System.Windows.Forms.TextBox TxtSerial;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label LblEmail;
        internal System.Windows.Forms.Label LblTelefono;
        internal System.Windows.Forms.Label LblCelular;
        internal System.Windows.Forms.Label LblNombreRazonSocial;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label LblDireccion;
        internal System.Windows.Forms.Label Marca;
        internal System.Windows.Forms.DataGridView DgvAccesorio;
        internal System.Windows.Forms.Label label20;
        internal System.Windows.Forms.ComboBox CboResponsableArreglo;
        internal System.Windows.Forms.Label label18;
        internal System.Windows.Forms.ComboBox CboQuienrecibe;
        private System.Windows.Forms.Button TxtGenerarOrden;
        internal System.Windows.Forms.ComboBox CboMarca;
        internal System.Windows.Forms.ComboBox CboEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvAccesorioColCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvAccesorioColAccesorio;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DgvAccesorioColCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvAccesorioColSerial;
        internal System.Windows.Forms.Label LblFechaInicio;
        private System.Windows.Forms.DateTimePicker DtFechaInicio;
    }
}