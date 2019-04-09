namespace Control_de_Tecnicos
{
    partial class FrmInicio_Presentacion
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.craciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Articulo = new System.Windows.Forms.ToolStripMenuItem();
            this.ArticuloTaller = new System.Windows.Forms.ToolStripMenuItem();
            this.ArticuloInstalacion = new System.Windows.Forms.ToolStripMenuItem();
            this.Cliente = new System.Windows.Forms.ToolStripMenuItem();
            this.ClienteNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.ClienteInactivar = new System.Windows.Forms.ToolStripMenuItem();
            this.Servicio = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.Producto = new System.Windows.Forms.ToolStripMenuItem();
            this.Usuario = new System.Windows.Forms.ToolStripMenuItem();
            this.operaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tallar = new System.Windows.Forms.ToolStripMenuItem();
            this.generarOrdenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instalaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Camara = new System.Windows.Forms.ToolStripMenuItem();
            this.Instalacion = new System.Windows.Forms.ToolStripMenuItem();
            this.Mantenimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.Reparacion = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GestionSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.craciónToolStripMenuItem,
            this.operaciónToolStripMenuItem,
            this.reporteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(900, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // craciónToolStripMenuItem
            // 
            this.craciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Articulo,
            this.Cliente,
            this.Servicio,
            this.productoToolStripMenuItem,
            this.Producto,
            this.Usuario,
            this.GestionSistema});
            this.craciónToolStripMenuItem.Name = "craciónToolStripMenuItem";
            this.craciónToolStripMenuItem.Size = new System.Drawing.Size(120, 25);
            this.craciónToolStripMenuItem.Text = "Cración         ";
            this.craciónToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Articulo
            // 
            this.Articulo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArticuloTaller,
            this.ArticuloInstalacion});
            this.Articulo.Name = "Articulo";
            this.Articulo.Size = new System.Drawing.Size(230, 26);
            this.Articulo.Text = "Artículo";
            this.Articulo.Click += new System.EventHandler(this.Articulo_Click);
            // 
            // ArticuloTaller
            // 
            this.ArticuloTaller.Name = "ArticuloTaller";
            this.ArticuloTaller.Size = new System.Drawing.Size(166, 26);
            this.ArticuloTaller.Text = "Taller";
            this.ArticuloTaller.Click += new System.EventHandler(this.ArticuloTaller_Click);
            // 
            // ArticuloInstalacion
            // 
            this.ArticuloInstalacion.Name = "ArticuloInstalacion";
            this.ArticuloInstalacion.Size = new System.Drawing.Size(166, 26);
            this.ArticuloInstalacion.Text = "Instalación";
            this.ArticuloInstalacion.Click += new System.EventHandler(this.ArticuloInstalacion_Click);
            // 
            // Cliente
            // 
            this.Cliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClienteNuevo,
            this.ClienteInactivar});
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(230, 26);
            this.Cliente.Text = "Cliente";
            // 
            // ClienteNuevo
            // 
            this.ClienteNuevo.Name = "ClienteNuevo";
            this.ClienteNuevo.Size = new System.Drawing.Size(152, 26);
            this.ClienteNuevo.Text = "Nuevo";
            this.ClienteNuevo.Click += new System.EventHandler(this.ClienteNuevo_Click);
            // 
            // ClienteInactivar
            // 
            this.ClienteInactivar.Name = "ClienteInactivar";
            this.ClienteInactivar.Size = new System.Drawing.Size(152, 26);
            this.ClienteInactivar.Text = "Inactivar";
            this.ClienteInactivar.Click += new System.EventHandler(this.ClienteInactivar_Click);
            // 
            // Servicio
            // 
            this.Servicio.Name = "Servicio";
            this.Servicio.Size = new System.Drawing.Size(230, 26);
            this.Servicio.Text = "Servicio";
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(227, 6);
            // 
            // Producto
            // 
            this.Producto.Name = "Producto";
            this.Producto.Size = new System.Drawing.Size(230, 26);
            this.Producto.Text = "Producto";
            // 
            // Usuario
            // 
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(230, 26);
            this.Usuario.Text = "Usuario";
            // 
            // operaciónToolStripMenuItem
            // 
            this.operaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tallar,
            this.instalaciónToolStripMenuItem});
            this.operaciónToolStripMenuItem.Name = "operaciónToolStripMenuItem";
            this.operaciónToolStripMenuItem.Size = new System.Drawing.Size(130, 25);
            this.operaciónToolStripMenuItem.Text = "Operación      ";
            // 
            // Tallar
            // 
            this.Tallar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarOrdenToolStripMenuItem,
            this.entregarToolStripMenuItem});
            this.Tallar.Name = "Tallar";
            this.Tallar.Size = new System.Drawing.Size(166, 26);
            this.Tallar.Text = "Taller";
            this.Tallar.Click += new System.EventHandler(this.Tallar_Click);
            // 
            // generarOrdenToolStripMenuItem
            // 
            this.generarOrdenToolStripMenuItem.Name = "generarOrdenToolStripMenuItem";
            this.generarOrdenToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.generarOrdenToolStripMenuItem.Text = "Generar Orden";
            this.generarOrdenToolStripMenuItem.Click += new System.EventHandler(this.generarOrdenToolStripMenuItem_Click);
            // 
            // entregarToolStripMenuItem
            // 
            this.entregarToolStripMenuItem.Name = "entregarToolStripMenuItem";
            this.entregarToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.entregarToolStripMenuItem.Text = "Ordenes";
            this.entregarToolStripMenuItem.Click += new System.EventHandler(this.entregarToolStripMenuItem_Click);
            // 
            // instalaciónToolStripMenuItem
            // 
            this.instalaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Camara,
            this.Instalacion,
            this.Mantenimiento,
            this.Reparacion});
            this.instalaciónToolStripMenuItem.Name = "instalaciónToolStripMenuItem";
            this.instalaciónToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.instalaciónToolStripMenuItem.Text = "Instalación";
            // 
            // Camara
            // 
            this.Camara.Name = "Camara";
            this.Camara.Size = new System.Drawing.Size(201, 26);
            this.Camara.Text = "Camara";
            // 
            // Instalacion
            // 
            this.Instalacion.Name = "Instalacion";
            this.Instalacion.Size = new System.Drawing.Size(201, 26);
            this.Instalacion.Text = "Instalación";
            // 
            // Mantenimiento
            // 
            this.Mantenimiento.Name = "Mantenimiento";
            this.Mantenimiento.Size = new System.Drawing.Size(201, 26);
            this.Mantenimiento.Text = "Mantenimiento";
            // 
            // Reparacion
            // 
            this.Reparacion.Name = "Reparacion";
            this.Reparacion.Size = new System.Drawing.Size(201, 26);
            this.Reparacion.Text = "Reparación";
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(85, 25);
            this.reporteToolStripMenuItem.Text = "Reporte";
            // 
            // GestionSistema
            // 
            this.GestionSistema.Name = "GestionSistema";
            this.GestionSistema.Size = new System.Drawing.Size(230, 26);
            this.GestionSistema.Text = "Gestion del sistema";
            this.GestionSistema.Click += new System.EventHandler(this.GestionSistema_Click);
            // 
            // FrmInicio_Presentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(900, 443);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmInicio_Presentacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem craciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Articulo;
        private System.Windows.Forms.ToolStripMenuItem Cliente;
        private System.Windows.Forms.ToolStripMenuItem Servicio;
        private System.Windows.Forms.ToolStripMenuItem operaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Tallar;
        private System.Windows.Forms.ToolStripMenuItem instalaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Camara;
        private System.Windows.Forms.ToolStripMenuItem Instalacion;
        private System.Windows.Forms.ToolStripMenuItem Mantenimiento;
        private System.Windows.Forms.ToolStripMenuItem Reparacion;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Producto;
        private System.Windows.Forms.ToolStripMenuItem Usuario;
        private System.Windows.Forms.ToolStripMenuItem ClienteNuevo;
        private System.Windows.Forms.ToolStripMenuItem ClienteInactivar;
        private System.Windows.Forms.ToolStripMenuItem generarOrdenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ArticuloTaller;
        private System.Windows.Forms.ToolStripMenuItem ArticuloInstalacion;
        private System.Windows.Forms.ToolStripMenuItem GestionSistema;
    }
}