using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_Tecnicos.Controles_Usuario
{
    public partial class FrmTaller : Form
    {
        public FrmTaller()
        {
            InitializeComponent();
        }

        private void FrmTaller_Load(object sender, EventArgs e)
        {
            DgvAccesorio.Rows.Add("Cargador");
            DgvAccesorio.Rows.Add("Funda");
           // DgvAccesorio.Rows.Add("Cargador");
            //DgvAccesorio.Rows.Add("Cargador");
        }

        private void TxtAceptar1_Click(object sender, EventArgs e)
        {

        }
    }
}
