namespace Control_de_Tecnicos.Controles_Usuario
{
    partial class FrmProductoTaller
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
            this.Panel2 = new System.Windows.Forms.Panel();
            this.TxtCodigoProducto = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.Label11 = new System.Windows.Forms.Label();
            this.TxtDescripcionProducto = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.TxtCodigoProducto);
            this.Panel2.Controls.Add(this.BtnGuardar);
            this.Panel2.Controls.Add(this.Label11);
            this.Panel2.Controls.Add(this.TxtDescripcionProducto);
            this.Panel2.Controls.Add(this.Label10);
            this.Panel2.Location = new System.Drawing.Point(0, 4);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(356, 202);
            this.Panel2.TabIndex = 104;
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
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Location = new System.Drawing.Point(173, 150);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(158, 30);
            this.BtnGuardar.TabIndex = 15;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
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
            // TxtDescripcionProducto
            // 
            this.TxtDescripcionProducto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtDescripcionProducto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescripcionProducto.Location = new System.Drawing.Point(54, 97);
            this.TxtDescripcionProducto.Name = "TxtDescripcionProducto";
            this.TxtDescripcionProducto.Size = new System.Drawing.Size(277, 26);
            this.TxtDescripcionProducto.TabIndex = 30;
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
            // FrmProductoTaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 218);
            this.Controls.Add(this.Panel2);
            this.Name = "FrmProductoTaller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.TextBox TxtCodigoProducto;
        private System.Windows.Forms.Button BtnGuardar;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.TextBox TxtDescripcionProducto;
        internal System.Windows.Forms.Label Label10;
    }
}