﻿namespace Control_de_Tecnicos
{
    partial class Form1
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
            this.control_Ordenes1 = new Control_de_Tecnicos.Controles_Usuario.Control_Ordenes();
            this.SuspendLayout();
            // 
            // control_Ordenes1
            // 
            this.control_Ordenes1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.control_Ordenes1.Location = new System.Drawing.Point(0, 0);
            this.control_Ordenes1.Name = "control_Ordenes1";
            this.control_Ordenes1.Size = new System.Drawing.Size(800, 450);
            this.control_Ordenes1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.control_Ordenes1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private Controles_Usuario.Control_Ordenes control_Ordenes1;
    }
}