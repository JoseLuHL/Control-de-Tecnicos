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
    public partial class FrmActivarUsuario : Form
    {
        public FrmActivarUsuario()
        {
            InitializeComponent();
        }

        DataTable tabla = new DataTable(); //esta tabla se utiliza para cargar los clientes
        ClsSqlServer ObjServer = new ClsSqlServer();
        string documentoC;
        public void BuscarCliente()
        {
            //DgvClientes.Rows.Clear();

            string SQL = "";
                SQL = "SELECT Cli_Documento, Cli_TipoDocumento, Cli_Nombre, Cli_Apellido, " + "       Cli_Sexo, Cli_Tipo, Cli_Direccion, Cli_Email, Cli_Celular, " +
                      "       Cli_TelFijo, Cli_Contacto, Cli_TelContacto,Cli_CodEstado " +
                      "FROM   Cliente " +
                      "WHERE  Cli_Documento='"+TxtDocumento.Text+"'";

            tabla = ObjServer.LlenarTabla(SQL);
            if (tabla.Rows.Count > 0)
            {
                string documento = tabla.Rows[0]["Cli_Documento"].ToString();
                string nombre = tabla.Rows[0]["Cli_Nombre"].ToString();
                string apellido = tabla.Rows[0]["Cli_Apellido"].ToString();
                LblNombre.Text = $"{nombre} {apellido}";
                if (tabla.Rows[0]["Cli_CodEstado"].ToString()=="A")
                {
                    RdbActivar.Checked = true;
                }
                else
                {
                    RdbDesactivar.Checked = true;
                }
            }
            else
                MessageBox.Show("No se ha encontrado el cliente","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            

        }

        private void FrmActivarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void TxtDocumento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                BuscarCliente();
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string activar;
            if (RdbActivar.Checked)
                activar = "A";
            else
                activar = "D";

            string sql = "UPDATE [dbo].[Cliente]   SET [Cli_CodEstado] = '"+ activar + "' WHERE Cli_Documento='" +TxtDocumento.Text + "'";
            ObjServer.CadnaSentencia = sql;
            ObjServer.Sentencia();
            MessageBox.Show("Operación completada", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            LblNombre.Text = "";
            TxtDocumento.Text = "";
            RdbActivar.Checked = false;
            RdbDesactivar.Checked = false;

        }
    }
}
