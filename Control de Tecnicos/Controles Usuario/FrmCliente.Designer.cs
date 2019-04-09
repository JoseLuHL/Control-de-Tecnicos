namespace Control_de_Tecnicos
{
    partial class FrmCliente
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
            this.control_Cliente1 = new Control_de_Tecnicos.Controles_Usuario.Control_Cliente();
            this.SuspendLayout();
            // 
            // control_Cliente1
            // 
            this.control_Cliente1.AutoScroll = true;
            this.control_Cliente1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.control_Cliente1.Location = new System.Drawing.Point(0, 0);
            this.control_Cliente1.Name = "control_Cliente1";
            this.control_Cliente1.Size = new System.Drawing.Size(641, 648);
            this.control_Cliente1.TabIndex = 0;
            this.control_Cliente1.Load += new System.EventHandler(this.control_Cliente1_Load);
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 648);
            this.Controls.Add(this.control_Cliente1);
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private Controles_Usuario.Control_Cliente control_Cliente1;
    }
}