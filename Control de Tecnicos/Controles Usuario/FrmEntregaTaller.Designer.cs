namespace Control_de_Tecnicos.Controles_Usuario
{
    partial class FrmEntregaTaller
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxtAceptar1 = new System.Windows.Forms.Button();
            this.TxtNunFactura = new System.Windows.Forms.NumericUpDown();
            this.TxtValor = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.DtFechaEntregada = new System.Windows.Forms.DateTimePicker();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNunFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.TxtAceptar1);
            this.groupBox3.Controls.Add(this.TxtNunFactura);
            this.groupBox3.Controls.Add(this.TxtValor);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.DtFechaEntregada);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(25, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(566, 455);
            this.groupBox3.TabIndex = 102;
            this.groupBox3.TabStop = false;
            // 
            // TxtAceptar1
            // 
            this.TxtAceptar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.TxtAceptar1.FlatAppearance.BorderSize = 0;
            this.TxtAceptar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TxtAceptar1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAceptar1.ForeColor = System.Drawing.Color.White;
            this.TxtAceptar1.Location = new System.Drawing.Point(14, 402);
            this.TxtAceptar1.Name = "TxtAceptar1";
            this.TxtAceptar1.Size = new System.Drawing.Size(189, 34);
            this.TxtAceptar1.TabIndex = 120;
            this.TxtAceptar1.Text = "Guardar";
            this.TxtAceptar1.UseVisualStyleBackColor = false;
            // 
            // TxtNunFactura
            // 
            this.TxtNunFactura.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNunFactura.Location = new System.Drawing.Point(363, 226);
            this.TxtNunFactura.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.TxtNunFactura.Name = "TxtNunFactura";
            this.TxtNunFactura.Size = new System.Drawing.Size(119, 27);
            this.TxtNunFactura.TabIndex = 119;
            this.TxtNunFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtNunFactura.ThousandsSeparator = true;
            // 
            // TxtValor
            // 
            this.TxtValor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValor.Location = new System.Drawing.Point(197, 226);
            this.TxtValor.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(131, 27);
            this.TxtValor.TabIndex = 118;
            this.TxtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(362, 202);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(50, 21);
            this.label21.TabIndex = 116;
            this.label21.Text = "Valor";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(193, 202);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(135, 21);
            this.label23.TabIndex = 117;
            this.label23.Text = "Numero factura";
            // 
            // DtFechaEntregada
            // 
            this.DtFechaEntregada.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtFechaEntregada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtFechaEntregada.Location = new System.Drawing.Point(14, 226);
            this.DtFechaEntregada.Name = "DtFechaEntregada";
            this.DtFechaEntregada.Size = new System.Drawing.Size(131, 27);
            this.DtFechaEntregada.TabIndex = 115;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(10, 202);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(166, 21);
            this.label22.TabIndex = 114;
            this.label22.Text = "Entrega de entrega";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(14, 124);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(521, 54);
            this.textBox5.TabIndex = 108;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(18, 102);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 21);
            this.label19.TabIndex = 109;
            this.label19.Text = "Solucción";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(14, 41);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(521, 54);
            this.textBox3.TabIndex = 104;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 21);
            this.label7.TabIndex = 105;
            this.label7.Text = "Diagnostico";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(366, 289);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 147);
            this.pictureBox1.TabIndex = 121;
            this.pictureBox1.TabStop = false;
            // 
            // FrmEntregaTaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 490);
            this.Controls.Add(this.groupBox3);
            this.Name = "FrmEntregaTaller";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNunFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button TxtAceptar1;
        private System.Windows.Forms.NumericUpDown TxtNunFactura;
        private System.Windows.Forms.NumericUpDown TxtValor;
        internal System.Windows.Forms.Label label21;
        internal System.Windows.Forms.Label label23;
        private System.Windows.Forms.DateTimePicker DtFechaEntregada;
        internal System.Windows.Forms.Label label22;
        internal System.Windows.Forms.TextBox textBox5;
        internal System.Windows.Forms.Label label19;
        internal System.Windows.Forms.TextBox textBox3;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}