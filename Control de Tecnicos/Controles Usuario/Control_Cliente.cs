using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Historia_Clinica.Conexion;
using Historia_Clinica;

namespace Control_de_Tecnicos.Controles_Usuario
{
    public partial class Control_Cliente : UserControl
    {
        ClsSqlServer ObjServer = new ClsSqlServer();
        string documentoC;
        public Control_Cliente()
        {
            InitializeComponent();
        }

        public void CARGAR_TIPO_IDENTIFICACION(String VAL)
        {
            //CARGAR COMBO DE TIPO DOCUMENTO
                CboTipoDocumento.DataSource = ObjServer.LlenarTabla("SELECT TipoIde_Codigo   ,TipoIde_Descripcion FROM dbo.TipoDocumento where [TipoIde_CodTipoPersona]='"+VAL+"' ORDER BY TipoIde_Descripcion"); ;
            CboTipoDocumento.DisplayMember = "TipoIde_Descripcion";
            CboTipoDocumento.ValueMember = "TipoIde_Codigo";
        }

        async Task CARGAR_COMBOS()
        {
            try
            {
                //CARGAR COMBO DE TIPO PERSONA
                await Task.Run(() =>
                {
                    CboTipoPersona.DataSource = ObjServer.LlenarTabla("SELECT Tip_Codigo  ,Tipo_Descripcion  FROM dbo.TipoPersona ORDER BY Tipo_Descripcion desc");
                });
                CboTipoPersona.DisplayMember = "Tipo_Descripcion";
                CboTipoPersona.ValueMember = "Tip_Codigo";

                CARGAR_TIPO_IDENTIFICACION("N");
                //CARGAR COMBO DE TIPO SEXO
                await Task.Run(() =>
                {
                    CboSexo.DataSource = ObjServer.LlenarTabla("SELECT Sex_Codigo ,Sex_Descripcion FROM dbo.Sexo ORDER BY Sex_Descripcion");
                });
                CboSexo.DisplayMember = "Sex_Descripcion";
                CboSexo.ValueMember = "Sex_Codigo";


            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            


        }

        private async void Control_Cliente_Load(object sender, EventArgs e)
        {
            await CARGAR_COMBOS();

            BuscarCliente(""); // BUSCAR Y CARGAR LOS CLINTES
        }

        DataTable tabla = new DataTable(); //esta tabla se utiliza para cargar los clientes

        //METODO PARA BUSCAR Y CARGAR LOS CLINTES
        public void BuscarCliente( string buscar)
        {
            DgvClientes.Rows.Clear();

            string SQL = "";
            if (buscar != "")
                SQL = "SELECT Cli_Documento, Cli_TipoDocumento, Cli_Nombre, Cli_Apellido, " +     "       Cli_Sexo, Cli_Tipo, Cli_Direccion, Cli_Email, Cli_Celular, " +
                      "       Cli_TelFijo, Cli_Contacto, Cli_TelContacto " +
                      "FROM   Cliente " +
                      "WHERE  Cli_Nombre LIKE ('%" + buscar + "%')";
            else
                SQL = "SELECT Cli_Documento, Cli_TipoDocumento, Cli_Nombre, Cli_Apellido, " +     "       Cli_Sexo, Cli_Tipo, Cli_Direccion, Cli_Email, Cli_Celular, " +
                      "       Cli_TelFijo, Cli_Contacto, Cli_TelContacto " +
                      "FROM   Cliente ";        
               
            tabla = ObjServer.LlenarTabla(SQL);
            if (tabla.Rows.Count > 0)
            {
                int j=0;
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    string tipoIdentificacion = tabla.Rows[i]["Cli_TipoDocumento"].ToString();
                    string documento = tabla.Rows[i]["Cli_Documento"].ToString();
                    string nombre = tabla.Rows[i]["Cli_Nombre"].ToString();
                    string apellido = tabla.Rows[i]["Cli_Apellido"].ToString();
                    string sexo = tabla.Rows[i]["Cli_Sexo"].ToString();
                    string tipoPersona = tabla.Rows[i]["Cli_Tipo"].ToString();
                    string direccion = tabla.Rows[i]["Cli_Direccion"].ToString();
                    string eMail = tabla.Rows[i]["Cli_Email"].ToString();
                    string celular = tabla.Rows[i]["Cli_Celular"].ToString();
                    string telFijo = tabla.Rows[i]["Cli_TelFijo"].ToString();
                    string contacto = tabla.Rows[i]["Cli_Contacto"].ToString();
                    string telContacto = tabla.Rows[i]["Cli_TelContacto"].ToString();

                    j = i+1;
                    DgvClientes.Rows.Add( j,  tipoIdentificacion, documento, nombre,                              apellido, sexo, tipoPersona, direccion, eMail,
                                          celular, telFijo, contacto, telContacto);

                }
            }
            else
                DgvClientes.Rows.Clear();

        }

        private void selecctionarAgregado(string documento)
        {
            DgvClientes.ClearSelection();
            for (int i = 0; i < DgvClientes.Rows.Count; i++)
            {
                if (DgvClientes.Rows[i].Cells["DgvClientesColIdentificacion"].Value.ToString() == documento)
                {
                    DgvClientes.CurrentCell = DgvClientes.Rows[i].Cells["DgvClientesColIdentificacion"];
                    break;
                }
            }
        }

        //METODO PARA GUARDAR LOS CLIENTES
        public void GUARDAR_DATOS()
        {
            if (TxtDocumento.Text != "" && TxtNombres.Text != "" && TxtApellidos.Text != "")
            {
                if (MessageBox.Show("¿Esta seguro de guardar la Información? ", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    try
                    {

                        string SQL = "";
                        SQL = string.Format("INSERT INTO [dbo].[Cliente] "+
                                               "([Cli_Documento]      "+
                                               ",[Cli_TipoDocumento]  "+
                                               ",[Cli_Nombre]         "+
                                               ",[Cli_Apellido]       "+
                                               ",[Cli_Sexo]           "+
                                               ",[Cli_Tipo]           "+
                                               ",[Cli_Direccion]      "+
                                               ",[Cli_Email]          "+
                                               ",[Cli_Celular]        "+
                                               ",[Cli_TelFijo]        "+
                                               ",[Cli_Contacto]       "+
                                               ",[Cli_TelContacto],Cli_CodEstado)   " +
                                         "VALUES "+
                                               "('{0}'"+
                                               ",'{1}'" +
                                               ",'{2}'" +
                                               ",'{3}'" +
                                               ",'{4}'" +
                                               ",'{5}'" +
                                               ",'{6}'" +
                                               ",'{7}'" +
                                               ",'{8}'" +
                                               ",'{9}'" +
                                               ",'{10}'" +
                                               ",'{11}','A')",TxtDocumento.Text.Trim(),CboTipoDocumento.SelectedValue.ToString(),TxtNombres.Text,TxtApellidos.Text.Trim(),CboSexo.SelectedValue.ToString(),CboTipoPersona.SelectedValue.ToString(),TxtDireccion.Text.Trim(),TxtCorreo.Text.Trim(),TxtCelular.Text.Trim(),TxtFijo.Text.Trim(),TxtNombreContacto.Text.Trim(),TxtTelContacto.Text.Trim());

                        documentoC = TxtDocumento.Text;
                        ObjServer.CadnaSentencia = SQL;
                        ObjServer.Sentencia();
                        BuscarCliente("");
                        selecctionarAgregado(documentoC);
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
            TxtDocumento.Clear();
            TxtNombres.Clear();
            TxtNombreContacto.Clear();
            TxtTelContacto.Clear();
            TxtApellidos.Clear();
            TxtCelular.Clear();
            TxtCorreo.Clear();
            TxtDireccion.Clear();
            TxtFijo.Clear();
            TxtTelContacto.Clear();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!Guardar_o_Modificar)
                ACTUALIZAR_DATOS();
            else
                GUARDAR_DATOS();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (TxtBuscar.Text.Trim() != "")
            {
                BuscarCliente(TxtBuscar.Text);
            }
            else
                MessageBox.Show("Ingese texto a buscar","",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

            TxtBuscar.Focus();
            TxtBuscar.SelectAll();
        }

        public void ACTUALIZAR_DATOS()
        {
            if (TxtDocumento.Text != "" && TxtNombres.Text != "" && TxtApellidos.Text != "")
            {
                if (MessageBox.Show("¿Esta seguro de actualizar la Información? ", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    try
                    {
                    string SQL = string.Format( SQL = "UPDATE Cliente " +
                          " SET Cli_TipoDocumento = '{0}' "+ 
                          "    ,Cli_Nombre = '{1}'              "+
                          "    ,Cli_Apellido = '{2}'          " +
                          "    ,Cli_Sexo = '{3}'                   " +
                          "    ,Cli_Tipo = '{4}'                     " +
                          "    ,Cli_Direccion = '{5}'       " +
                          "    ,Cli_Email = '{6}'                " +
                          "    ,Cli_Celular = '{7}'            " +
                          "    ,Cli_TelFijo = '{8}'           " +
                          "    ,Cli_Contacto = '{9}'          " +
                          "    ,Cli_TelContacto = '{10}'    " +
                         "WHERE Cli_Documento = '{11}'", CboTipoDocumento.SelectedValue.ToString(), TxtNombres.Text, TxtApellidos.Text.Trim(), CboSexo.SelectedValue.ToString(), CboTipoPersona.SelectedValue.ToString(), TxtDireccion.Text.Trim(), TxtCorreo.Text.Trim(), TxtCelular.Text.Trim(), TxtFijo.Text.Trim(), TxtNombreContacto.Text.Trim(), TxtTelContacto.Text.Trim(),TxtDocumento.Text.Trim());

                        documentoC = TxtDocumento.Text;
                        ObjServer.CadnaSentencia = SQL;
                        ObjServer.Sentencia();
                        BuscarCliente("");
                        selecctionarAgregado(documentoC);
                        Limpiar();
                        MessageBox.Show("Registro actualizado", "Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("La operación no puedo completarse debido a: \n 1 - No dispone de una conexión  \n 2 - Ya se ha registrado este documento  \n 3 - La información ingresada no corresponde a la requerida  \n Vuelva a intentarlo!!! " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                Guardar_o_Modificar=true;
            }
            else
                MessageBox.Show("La operación no puedo completarse debido a: \n 1 - falta de datos obligatorio \n 2 - Ya se ha registrado este documento  \n 3 - La información ingresada no corresponde a la requerida  \n Vuelva a intentarlo!!! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        Boolean Guardar_o_Modificar; //SE UTILIZA PARA SABER CUANDO SE VA A INSERTAR Y MODIFICAR UN REGISTRO
        private void DgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        if (e.RowIndex > -1)
        {
            Limpiar();
            if (tabla.Rows.Count > 0)
            {
                    Guardar_o_Modificar = false; 

                    string tipoIdentificacion = tabla.Rows[e.RowIndex]["Cli_TipoDocumento"].ToString();
                    string documento = tabla.Rows[e.RowIndex]["Cli_Documento"].ToString();
                    string nombre = tabla.Rows[e.RowIndex]["Cli_Nombre"].ToString();
                    string apellido = tabla.Rows[e.RowIndex]["Cli_Apellido"].ToString();
                    string sexo = tabla.Rows[e.RowIndex]["Cli_Sexo"].ToString();
                    string tipoPersona = tabla.Rows[e.RowIndex]["Cli_Tipo"].ToString();
                    string direccion = tabla.Rows[e.RowIndex]["Cli_Direccion"].ToString();
                    string eMail = tabla.Rows[e.RowIndex]["Cli_Email"].ToString();
                    string celular = tabla.Rows[e.RowIndex]["Cli_Celular"].ToString();
                    string telFijo = tabla.Rows[e.RowIndex]["Cli_TelFijo"].ToString();
                    string contacto = tabla.Rows[e.RowIndex]["Cli_Contacto"].ToString();
                    string telContacto = tabla.Rows[e.RowIndex]["Cli_TelContacto"].ToString();

                    
                    TxtDocumento.Enabled = true;
                    TxtDocumento.Text = documento;
                    CboTipoDocumento.SelectedValue = tipoIdentificacion;
                    TxtNombres.Text = nombre;
                    TxtApellidos.Text = apellido;
                    CboSexo.SelectedValue = sexo;
                    CboTipoPersona.SelectedValue = tipoPersona;
                    TxtDireccion.Text = direccion;
                    TxtCorreo.Text = eMail;
                    TxtCelular.Text = celular;
                    TxtFijo.Text = telFijo;
                    TxtNombreContacto.Text = contacto;
                    TxtTelContacto.Text = telContacto;              
            }
        }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Guardar_o_Modificar = true;
            DgvClientes.ClearSelection();
            Limpiar();
        }

        private void TxtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsNumeroLetras numeroLetras = new ClsNumeroLetras();
            numeroLetras.Solo_Numeros(e);
        }

        private void TxtNombreContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsNumeroLetras numeroLetras = new ClsNumeroLetras();
            numeroLetras.Solo_Letras(e);
        }

        private void CboTipoPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboTipoPersona.SelectedValue.ToString()=="J")
            {
                //CboTipoDocumento.SelectedValue = "NIT";
                //CboTipoDocumento.Enabled = false;
                LblNombre.Text = "Razon social";
                LblApellido.Text = "Sigla";
                LblSexo.Visible = false;
                CboSexo.Visible = false;
                TxtApellidos.Location= new Point(45, 299);
                LblApellido.Location = new Point(51, 275);            
                TxtApellidos.Size= new Size(129,27);
                TxtNombres.Size=new Size(500, 27);
            }
            else
            {
                CboTipoDocumento.SelectedValue = "CC";
                CboTipoDocumento.Enabled = true;
                LblNombre.Text = "Nombres";
                LblApellido.Text = "Apellidos";
                LblSexo.Visible = true;
                CboSexo.Visible = true;
                TxtApellidos.Location = new Point(317,236);
                LblApellido.Location = new Point(322,212);
                TxtApellidos.Size = new Size(254, 27);
                TxtNombres.Size = new Size(254,27);
            }
        }

        private void CboTipoPersona_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CARGAR_TIPO_IDENTIFICACION(CboTipoPersona.SelectedValue.ToString());
        }
    }
}
