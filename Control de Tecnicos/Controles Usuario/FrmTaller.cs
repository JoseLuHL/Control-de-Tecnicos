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
    public partial class FrmTaller : Form
    {
        public FrmTaller()
        {
            InitializeComponent();
        }

        ClsSqlServer ObjServer = new ClsSqlServer();
        string codigoProducto;
        Boolean AGREGAR_MODIFICAR = true; //CUANDO ES TRUE SE VA A INSERTAR UNA NUEVA ORDER Y FALSO ACTUALIZAR

        public void BuscarCliente(string buscar)
        {
            if (TxtDocumento.Text.Trim() == "")
            {
                MessageBox.Show("Completar los campos para continuar", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataTable tabla = new DataTable();
            string SQL = "";
            if (buscar != "")
                SQL = "SELECT Cli_Documento, Cli_TipoDocumento, Cli_Nombre,                 Cli_Apellido, " + "       Cli_Sexo, Cli_Tipo,                   Cli_Direccion,            Cli_Email, Cli_Celular, " +
                      "       Cli_TelFijo, Cli_Contacto, Cli_TelContacto " +
                      "FROM   Cliente " +
                      "WHERE  Cli_Documento = '" + TxtDocumento.Text.Trim() + "'";

            tabla = ObjServer.LlenarTabla(SQL);

            if (tabla.Rows.Count > 0)
            {
                string nombre = tabla.Rows[0]["Cli_Nombre"].ToString();
                string apellido = tabla.Rows[0]["Cli_Apellido"].ToString();
                string celular = tabla.Rows[0]["Cli_Celular"].ToString();
                string telefono = tabla.Rows[0]["Cli_TelFijo"].ToString();
                string direccion = tabla.Rows[0]["Cli_Direccion"].ToString();
                string email = tabla.Rows[0]["Cli_Email"].ToString();

                LblNombreRazonSocial.Text = $"{nombre} {apellido}";
                LblCelular.Text = celular;
                LblTelefono.Text = telefono;
                LblDireccion.Text = direccion;
                LblEmail.Text = email;
                CboServicio.Focus();
            }
            else
            {
                if (MessageBox.Show("El cliente no se ha encontrado. \n ¿Desea crearlo?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)==DialogResult.OK)
                {
                    TxtDocumento.Focus();
                    TxtDocumento.SelectAll();
                    FrmCliente f = new FrmCliente();
                    f.ShowDialog();
                }
                TxtDocumento.Focus();
                TxtDocumento.SelectAll();
                LblNombre.Text = "";
                //LblNombre.BackColor = Color.WhiteSmoke;
            }            
        }

        public void LimpiarControles()
        {
            LblNombreRazonSocial.Text = "";
            LblCelular.Text = "";
            LblTelefono.Text = "";
            LblDireccion.Text = "";
            LblEmail.Text = "";
        }

        async Task CARGAR_COMBOS()
        {
            try
            {
                //CARGAR COMBO DE servicios
                await Task.Run(() => {
                    CboServicio.DataSource = ObjServer.LlenarTabla("SELECT Serv_Codigo ,Serv_Descripcion ,Serv_CodTipoServicio FROM Servicio ORDER BY Serv_Descripcion"); ;
                });
                CboServicio.DisplayMember = "Serv_Descripcion";
                CboServicio.ValueMember = "Serv_Codigo";
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }


        private async void FrmTaller_Load(object sender, EventArgs e)
        {
            DgvAccesorio.Rows.Add("Cargador");
            DgvAccesorio.Rows.Add("Funda");
            LimpiarControles();
            await CARGAR_COMBOS();

        }

        private void TxtAceptar1_Click(object sender, EventArgs e)
        {

        }

        private void TxtGenerarOrden_Click(object sender, EventArgs e)
        {

        }

        private void TxtDocumento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarCliente(TxtDocumento.Text);
            }
        }

        private void TxtDocumento_TextChanged(object sender, EventArgs e)
        {
            if (LblNombre.Text != "")
            {
                LimpiarControles();
                //LblNombre.BackColor = Color.WhiteSmoke;
            }
        }
    }
}
