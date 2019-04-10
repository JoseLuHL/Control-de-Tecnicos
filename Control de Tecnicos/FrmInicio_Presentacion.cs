using Control_de_Tecnicos.Controles_Usuario;
using Historia_Clinica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_Tecnicos
{
    public partial class FrmInicio_Presentacion : Form
    {
        public FrmInicio_Presentacion()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void ClienteNuevo_Click(object sender, EventArgs e)
        {
            FrmCliente f = new FrmCliente();
            f.ShowDialog();
        }

        private void ClienteInactivar_Click(object sender, EventArgs e)
        {
            FrmActivarUsuario f = new FrmActivarUsuario();
            f.ShowDialog();
        }

        private void Tallar_Click(object sender, EventArgs e)
        {
           
        }

        private void generarOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTaller f = new FrmTaller();
            f.ShowDialog();
        }

        private void entregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOrdenes f = new FrmOrdenes();
            f.ShowDialog();
        }

        private void Articulo_Click(object sender, EventArgs e)
        {
            
        }

        private void ArticuloTaller_Click(object sender, EventArgs e)
        {
            FrmProductoTaller f = new FrmProductoTaller();
            f.ShowDialog();
        }

        private void ArticuloInstalacion_Click(object sender, EventArgs e)
        {
            FrmProductoInstalacion f = new FrmProductoInstalacion();
            f.ShowDialog();
        }

        private void GestionSistema_Click(object sender, EventArgs e)
        {
            FrmGestionarSistema f = new FrmGestionarSistema();
            f.ShowDialog();
        }

        private void ClienteEditar_Click(object sender, EventArgs e)
        {
            FrmCliente f = new FrmCliente();
            //f.
            f.ShowDialog();
        }
    }
}
