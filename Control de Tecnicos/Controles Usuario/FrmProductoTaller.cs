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

namespace Control_de_Tecnicos.Controles_Usuario
{
    public partial class FrmProductoTaller : Form
    {
        public FrmProductoTaller()
        {
            InitializeComponent();
        }
        ClsSqlServer ObjServer = new ClsSqlServer();
        string documentoC;
        public void GUARDAR_DATOS()
        {
            if (TxtDescripcionProducto.Text != "" & TxtCodigoProducto.Text != "")
            {
                if (MessageBox.Show("¿Esta seguro de guardar la Información? ", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    try
                    {
                        string SQL = "";
                        SQL = string.Format("INSERT INTO [dbo].[Producto]([Prod_Codigo],[Prod_Descripcion],Prod_CodTipoOperacion) VALUES ('{0}', '{1}',1)", TxtCodigoProducto.Text,TxtDescripcionProducto.Text);
                        ObjServer.CadnaSentencia = SQL;
                        ObjServer.Sentencia();
                        
                        Limpiar();

                        MessageBox.Show("Registro guardado", "Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("La operación no puedo completarse debido a: \n 1 - No dispone de una conexión  \n 2 - Ya se ha registrado este documento  \n 3 - La información ingresada no corresponde a la requerida  \n Vuelva a intentarlo!!! " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
                MessageBox.Show("La operación no puedo completarse debido a: \n 1 - falta de datos obligatorio \n 2 - Ya se ha registrado este documento  \n 3 - La información ingresada no corresponde a la requerida  \n Vuelva a intentarlo!!! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void Limpiar()
        {
            TxtCodigoProducto.Text = "";
            TxtDescripcionProducto.Clear();
        }
        private void FrmProductoTaller_Load(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            GUARDAR_DATOS();
        }
    }
}
