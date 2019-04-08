namespace Control_de_Tecnicos.Controles_Usuario
{
    partial class Control_Tecnico
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
            this.DgvClientes = new System.Windows.Forms.DataGridView();
            this.DgvClientesColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvClientesColTipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvClientesColIdentificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvClientesColNombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvClientesColCelular1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvClientesCelular2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvClientesCelCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvClientesDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvClientesColCodigoIdent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.TxtNumero2 = new System.Windows.Forms.TextBox();
            this.CboTipoIde = new System.Windows.Forms.ComboBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtIdentificacion = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(500, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(330, 20);
            this.label5.TabIndex = 61;
            this.label5.Text = "Aqui podra realizar la gestión de sus clientes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(560, 10);
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
            this.BtnNuevo.Location = new System.Drawing.Point(282, 91);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(33, 34);
            this.BtnNuevo.TabIndex = 59;
            this.BtnNuevo.Text = "+";
            this.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnNuevo.UseVisualStyleBackColor = false;
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.Controls.Add(this.DgvClientes);
            this.Panel1.Controls.Add(this.LblCantidad);
            this.Panel1.Controls.Add(this.label3);
            this.Panel1.Location = new System.Drawing.Point(321, 74);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(716, 456);
            this.Panel1.TabIndex = 58;
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
            this.DgvClientesColNombreCompleto,
            this.DgvClientesColCelular1,
            this.DgvClientesCelular2,
            this.DgvClientesCelCorreo,
            this.DgvClientesDireccion,
            this.DgvClientesColCodigoIdent});
            this.DgvClientes.EnableHeadersVisualStyles = false;
            this.DgvClientes.Location = new System.Drawing.Point(12, 57);
            this.DgvClientes.Name = "DgvClientes";
            this.DgvClientes.ReadOnly = true;
            this.DgvClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvClientes.Size = new System.Drawing.Size(688, 386);
            this.DgvClientes.TabIndex = 36;
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
            // DgvClientesColNombreCompleto
            // 
            this.DgvClientesColNombreCompleto.HeaderText = "Nombre Completo";
            this.DgvClientesColNombreCompleto.Name = "DgvClientesColNombreCompleto";
            this.DgvClientesColNombreCompleto.ReadOnly = true;
            this.DgvClientesColNombreCompleto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DgvClientesColNombreCompleto.Width = 300;
            // 
            // DgvClientesColCelular1
            // 
            this.DgvClientesColCelular1.HeaderText = "Numero Celular";
            this.DgvClientesColCelular1.MaxInputLength = 10;
            this.DgvClientesColCelular1.Name = "DgvClientesColCelular1";
            this.DgvClientesColCelular1.ReadOnly = true;
            this.DgvClientesColCelular1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DgvClientesColCelular1.Visible = false;
            // 
            // DgvClientesCelular2
            // 
            this.DgvClientesCelular2.HeaderText = "Celular 2";
            this.DgvClientesCelular2.MaxInputLength = 10;
            this.DgvClientesCelular2.Name = "DgvClientesCelular2";
            this.DgvClientesCelular2.ReadOnly = true;
            this.DgvClientesCelular2.Visible = false;
            // 
            // DgvClientesCelCorreo
            // 
            this.DgvClientesCelCorreo.HeaderText = "Correo";
            this.DgvClientesCelCorreo.Name = "DgvClientesCelCorreo";
            this.DgvClientesCelCorreo.ReadOnly = true;
            this.DgvClientesCelCorreo.Visible = false;
            // 
            // DgvClientesDireccion
            // 
            this.DgvClientesDireccion.HeaderText = "Dirección";
            this.DgvClientesDireccion.Name = "DgvClientesDireccion";
            this.DgvClientesDireccion.ReadOnly = true;
            this.DgvClientesDireccion.Visible = false;
            // 
            // DgvClientesColCodigoIdent
            // 
            this.DgvClientesColCodigoIdent.HeaderText = "CodigoIden";
            this.DgvClientesColCodigoIdent.Name = "DgvClientesColCodigoIdent";
            this.DgvClientesColCodigoIdent.ReadOnly = true;
            this.DgvClientesColCodigoIdent.Visible = false;
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.LblCantidad.Location = new System.Drawing.Point(536, 20);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(44, 31);
            this.LblCantidad.TabIndex = 4;
            this.LblCantidad.Text = "19";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(460, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cantidad:";
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.ForeColor = System.Drawing.Color.SteelBlue;
            this.Label14.Location = new System.Drawing.Point(8, 570);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(328, 18);
            this.Label14.TabIndex = 57;
            this.Label14.Text = "________________________________";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.ForeColor = System.Drawing.Color.SteelBlue;
            this.Label13.Location = new System.Drawing.Point(8, 71);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(328, 18);
            this.Label13.TabIndex = 56;
            this.Label13.Text = "________________________________";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(38, 446);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(87, 21);
            this.Label7.TabIndex = 55;
            this.Label7.Text = "Dirección:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(37, 389);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(67, 21);
            this.Label1.TabIndex = 54;
            this.Label1.Text = "Correo:";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(37, 333);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(145, 21);
            this.Label8.TabIndex = 53;
            this.Label8.Text = "Numero celular 2:";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(38, 112);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(181, 21);
            this.Label9.TabIndex = 52;
            this.Label9.Text = "Tipo de identificación:";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(38, 221);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(157, 21);
            this.Label10.TabIndex = 51;
            this.Label10.Text = "Nombre completo:";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(38, 280);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(132, 21);
            this.Label11.TabIndex = 50;
            this.Label11.Text = "Numero celular:";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(38, 164);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(122, 21);
            this.Label12.TabIndex = 49;
            this.Label12.Text = "Identificación:";
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtCorreo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCorreo.Location = new System.Drawing.Point(41, 411);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(254, 27);
            this.TxtCorreo.TabIndex = 46;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtDireccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion.Location = new System.Drawing.Point(41, 468);
            this.TxtDireccion.Multiline = true;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(254, 45);
            this.TxtDireccion.TabIndex = 47;
            // 
            // TxtNumero
            // 
            this.TxtNumero.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtNumero.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumero.Location = new System.Drawing.Point(41, 302);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(254, 27);
            this.TxtNumero.TabIndex = 44;
            // 
            // TxtNumero2
            // 
            this.TxtNumero2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtNumero2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumero2.Location = new System.Drawing.Point(41, 355);
            this.TxtNumero2.Name = "TxtNumero2";
            this.TxtNumero2.Size = new System.Drawing.Size(254, 27);
            this.TxtNumero2.TabIndex = 45;
            // 
            // CboTipoIde
            // 
            this.CboTipoIde.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CboTipoIde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTipoIde.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CboTipoIde.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboTipoIde.FormattingEnabled = true;
            this.CboTipoIde.Location = new System.Drawing.Point(41, 134);
            this.CboTipoIde.Name = "CboTipoIde";
            this.CboTipoIde.Size = new System.Drawing.Size(254, 29);
            this.CboTipoIde.TabIndex = 41;
            // 
            // TxtNombre
            // 
            this.TxtNombre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(41, 243);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(254, 27);
            this.TxtNombre.TabIndex = 43;
            // 
            // TxtIdentificacion
            // 
            this.TxtIdentificacion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtIdentificacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdentificacion.Location = new System.Drawing.Point(41, 186);
            this.TxtIdentificacion.Name = "TxtIdentificacion";
            this.TxtIdentificacion.Size = new System.Drawing.Size(254, 27);
            this.TxtIdentificacion.TabIndex = 42;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Location = new System.Drawing.Point(41, 519);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(254, 29);
            this.BtnGuardar.TabIndex = 48;
            this.BtnGuardar.Text = "Aceptar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            // 
            // Control_Tecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.TxtCorreo);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.TxtNumero);
            this.Controls.Add(this.TxtNumero2);
            this.Controls.Add(this.CboTipoIde);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtIdentificacion);
            this.Controls.Add(this.BtnGuardar);
            this.Name = "Control_Tecnico";
            this.Size = new System.Drawing.Size(1040, 625);
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
        internal System.Windows.Forms.DataGridViewTextBoxColumn DgvClientesColID;
        internal System.Windows.Forms.DataGridViewTextBoxColumn DgvClientesColTipoDocumento;
        internal System.Windows.Forms.DataGridViewTextBoxColumn DgvClientesColIdentificacion;
        internal System.Windows.Forms.DataGridViewTextBoxColumn DgvClientesColNombreCompleto;
        internal System.Windows.Forms.DataGridViewTextBoxColumn DgvClientesColCelular1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn DgvClientesCelular2;
        internal System.Windows.Forms.DataGridViewTextBoxColumn DgvClientesCelCorreo;
        internal System.Windows.Forms.DataGridViewTextBoxColumn DgvClientesDireccion;
        internal System.Windows.Forms.DataGridViewTextBoxColumn DgvClientesColCodigoIdent;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Label14;
        private System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.TextBox TxtCorreo;
        internal System.Windows.Forms.TextBox TxtDireccion;
        internal System.Windows.Forms.TextBox TxtNumero;
        internal System.Windows.Forms.TextBox TxtNumero2;
        internal System.Windows.Forms.ComboBox CboTipoIde;
        internal System.Windows.Forms.TextBox TxtNombre;
        internal System.Windows.Forms.TextBox TxtIdentificacion;
        private System.Windows.Forms.Button BtnGuardar;
    }
}
