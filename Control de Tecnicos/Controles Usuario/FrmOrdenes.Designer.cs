namespace Control_de_Tecnicos.Controles_Usuario
{
    partial class FrmOrdenes
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TxtDocumentoOrden = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CboServicioOrden = new System.Windows.Forms.ComboBox();
            this.DgvOrdenes = new System.Windows.Forms.DataGridView();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrdenes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.TxtDocumentoOrden);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.CboServicioOrden);
            this.groupBox4.Controls.Add(this.DgvOrdenes);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(795, 423);
            this.groupBox4.TabIndex = 102;
            this.groupBox4.TabStop = false;
            // 
            // TxtDocumentoOrden
            // 
            this.TxtDocumentoOrden.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtDocumentoOrden.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDocumentoOrden.Location = new System.Drawing.Point(456, 42);
            this.TxtDocumentoOrden.MaxLength = 50;
            this.TxtDocumentoOrden.Name = "TxtDocumentoOrden";
            this.TxtDocumentoOrden.Size = new System.Drawing.Size(157, 27);
            this.TxtDocumentoOrden.TabIndex = 100;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(452, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(161, 21);
            this.label12.TabIndex = 101;
            this.label12.Text = "Documento cliente";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 21);
            this.label11.TabIndex = 98;
            this.label11.Text = "Servicio";
            // 
            // CboServicioOrden
            // 
            this.CboServicioOrden.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CboServicioOrden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboServicioOrden.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CboServicioOrden.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboServicioOrden.FormattingEnabled = true;
            this.CboServicioOrden.Location = new System.Drawing.Point(13, 40);
            this.CboServicioOrden.Name = "CboServicioOrden";
            this.CboServicioOrden.Size = new System.Drawing.Size(412, 29);
            this.CboServicioOrden.TabIndex = 99;
            // 
            // DgvOrdenes
            // 
            this.DgvOrdenes.AllowUserToAddRows = false;
            this.DgvOrdenes.AllowUserToDeleteRows = false;
            this.DgvOrdenes.AllowUserToResizeColumns = false;
            this.DgvOrdenes.AllowUserToResizeRows = false;
            this.DgvOrdenes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvOrdenes.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DgvOrdenes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvOrdenes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.DgvOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOrdenes.EnableHeadersVisualStyles = false;
            this.DgvOrdenes.Location = new System.Drawing.Point(12, 84);
            this.DgvOrdenes.MultiSelect = false;
            this.DgvOrdenes.Name = "DgvOrdenes";
            this.DgvOrdenes.ReadOnly = true;
            this.DgvOrdenes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvOrdenes.RowHeadersVisible = false;
            this.DgvOrdenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DgvOrdenes.Size = new System.Drawing.Size(766, 318);
            this.DgvOrdenes.TabIndex = 97;
            this.DgvOrdenes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvOrdenes_CellDoubleClick);
            this.DgvOrdenes.DoubleClick += new System.EventHandler(this.DgvOrdenes_DoubleClick);
            // 
            // FrmOrdenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 447);
            this.Controls.Add(this.groupBox4);
            this.Name = "FrmOrdenes";
            this.Load += new System.EventHandler(this.FrmOrdenes_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrdenes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.TextBox TxtDocumentoOrden;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.ComboBox CboServicioOrden;
        internal System.Windows.Forms.DataGridView DgvOrdenes;
    }
}