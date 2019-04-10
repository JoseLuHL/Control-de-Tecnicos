using Historia_Clinica;
using Historia_Clinica.Conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
                SQL = "SELECT Cli_Documento, Cli_TipoDocumento, Cli_Nombre,                 Cli_Apellido, " + "       Cli_Sexo, Cli_Tipo,  Cli_CodEstado,   Cli_Direccion,            Cli_Email, Cli_Celular, " +
                      "       Cli_TelFijo, Cli_Contacto, Cli_TelContacto " +
                      "FROM   Cliente " +
                      "WHERE  Cli_Documento = '" + TxtDocumento.Text.Trim() + "'";

            tabla = ObjServer.LlenarTabla(SQL);

            if (tabla.Rows.Count > 0)
            {
                if (tabla.Rows[0]["Cli_CodEstado"].ToString() == "A")
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
                    MessageBox.Show("El cliente esta inactivo", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            CboQuienrecibe.SelectedValue = 0;
            CboResponsableArreglo.SelectedValue = 0;
            CboServicio.SelectedValue = 0;
            CboEquipo.SelectedValue = 0;
            CboMarca.SelectedValue = 0;
            TxtSerial.Clear();
            TxtObservacion.Clear();
            foreach (DataGridViewRow item in DgvAccesorio.Rows)
            {
                item.Cells["DgvAccesorioColSerial"].Value = null;
                if (Convert.ToBoolean(item.Cells["DgvAccesorioColCheck"].Value))
                {
                    item.Cells["DgvAccesorioColCheck"].Value = 0;
                }
            }
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

                //CARGAR COMBO DE QUIEN RECIBE
                await Task.Run(() => {
                    CboQuienrecibe.DataSource = ObjServer.LlenarTabla("SELECT [Us_Documento] ,[Us_Tipo] ,[Us_Nombre] ,[Us_Contraseña] ,[Us_CodRol] ,[Us_Estado] FROM [dbo].[Usuario] ORDER BY Us_Nombre"); ;
                });
                CboQuienrecibe.DisplayMember = "Us_Nombre";
                CboQuienrecibe.ValueMember = "Us_Documento";

                //CARGAR COMBO DE RESPONSABLE
                await Task.Run(() => {
                    CboResponsableArreglo.DataSource = ObjServer.LlenarTabla("SELECT [Us_Documento] ,[Us_Tipo] ,[Us_Nombre] ,[Us_Contraseña] ,[Us_CodRol] ,[Us_Estado] FROM [dbo].[Usuario] ORDER BY Us_Nombre"); ;
                });
                CboResponsableArreglo.DisplayMember = "Us_Nombre";
                CboResponsableArreglo.ValueMember = "Us_Documento";
                
                //CARGAR COMBO DE EQUIPO
                await Task.Run(() => {
                    CboEquipo.DataSource = ObjServer.LlenarTabla("SELECT[Prod_Codigo] ,[Prod_Descripcion] ,[Prod_CodTipoOperacion] FROM[dbo].[Producto] WHERE[Prod_CodTipoOperacion] = 1  order by CONVERT(nvarchar,[Prod_Descripcion])"); ;
                });
                CboEquipo.DisplayMember = "Prod_Descripcion";
                CboEquipo.ValueMember = "Prod_Codigo";

                //CARGAR COMBO DE MARCA
                await Task.Run(() => {
                    CboMarca.DataSource = ObjServer.LlenarTabla("SELECT [Marc_Codigo]   ,[Marc_Descripcion] FROM [dbo].[Marca] ORDER BY [Marc_Codigo]"); ;
                });
                CboMarca.DisplayMember = "Marc_Descripcion";
                CboMarca.ValueMember = "Marc_Codigo";

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        public void CargarAccesorios()
        {
            DgvAccesorio.Rows.Clear();
            DataTable tabla = new DataTable();
            string sql = "SELECT [Acce_Codigo] ,[Acce_Descripcion]  FROM [dbo].[Accesorio] ORDER BY Acce_Descripcion";

            tabla = ObjServer.LlenarTabla(sql);
            int x = 0;
            foreach (DataRow item in tabla.Rows)
            {
                string codigo = item["Acce_Codigo"].ToString();
                string descripcion = item["Acce_Descripcion"].ToString();
                DgvAccesorio.Rows.Add(codigo,descripcion);
                DgvAccesorio.Rows[x].Cells[1].Style.BackColor = Color.Gainsboro;
                DgvAccesorio.Rows[x].Cells[1].ReadOnly = true;
                
                x++;
            }
        }

        private async void FrmTaller_Load(object sender, EventArgs e)
        {
            DgvAccesorio.Rows.Add("Cargador");
            DgvAccesorio.Rows.Add("Funda");
            LimpiarControles();
            await CARGAR_COMBOS();
            ObjServer.EstilosDgv(DgvAccesorio);
            CargarAccesorios();

            CboQuienrecibe.SelectedValue = 0;
            CboResponsableArreglo.SelectedValue = 0;
            CboServicio.SelectedValue = 0;
        }

        private void TxtAceptar1_Click(object sender, EventArgs e)
        {

        }

        private void TxtGenerarOrden_Click(object sender, EventArgs e)
        {
            GUARDAR_ORDEN();
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

        public void GUARDAR_ORDEN()
        {
            if (LblNombre.Text == "")
            {
                MessageBox.Show("Seleccionar un cliente para continuar", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Esta seguro de guardar la Información? ", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                DataTable tabla;
                int NumeroOrden = 0;
                //Establecemos el Objeto que nos va a permitir conectarnos a la base de Datos()
                SqlConnection cnn = new SqlConnection(CadenaConexion.cadena());
                //Abrimos la conexión()
                cnn.Open();
                //Comenzamos la transacción ()
                SqlTransaction SQLtrans = cnn.BeginTransaction();
                try
                {
                    SqlCommand comman = cnn.CreateCommand();
                    comman.Transaction = SQLtrans;
                    string sql = "";

                    #region PARA OBTENER EL NUMER DE FACTURA
                    sql = "SELECT [_NunOrden] FROM [dbo].[NumeroOrden]";
                    tabla = new DataTable();
                    tabla = ObjServer.LlenarTabla(sql);

                    if (tabla.Rows.Count <= 0)
                    {
                        NumeroOrden = 1;
                        sql = string.Format("INSERT INTO [dbo].[NumeroOrden] ([_NunOrden]) VALUES ({0})", NumeroOrden);
                        ObjServer.CadnaSentencia = sql;
                        ObjServer.Sentencia();
                    }
                    else
                    {
                        NumeroOrden = Convert.ToInt32(tabla.Rows[0]["_NunOrden"].ToString()) + 1;
                        //int numero = NumeroOrden + 1;
                        sql = string.Format("UPDATE [dbo].[NumeroOrden] SET [_NunOrden] = {0}", NumeroOrden);
                        ObjServer.CadnaSentencia = sql;
                        ObjServer.Sentencia();
                    }
                    #endregion
                    string fechaNull = null;
                    int estado = 2;


                    sql = "";
                    sql = string.Format("INSERT INTO  dbo.Orden(Ord_Numero,Ord_Fecha, Ord_Hora,   Ord_CodServicio, " +
                                  "Ord_ObsEntrada, Ord_DocUsuario, Ord_DocCliente,              " +
                                  "Ord_FechaInicio,  Ord_Factura,      " +
                                  " Ord_Estado)          " +
                                  "VALUES("+NumeroOrden+",'"+DtFechaInicio.Text+"',CONVERT(time,GETDATE()),"+CboServicio.SelectedValue+",'"+ TxtObservacion.Text+"','"+CboQuienrecibe.SelectedValue+"','"+ TxtDocumento.Text+"',"+" GETDATE(), GETDATE(),"+estado+")");
                    comman.CommandText = sql;
                    comman.ExecuteNonQuery();

                    //GUARDAR EL EQUIPO
                    sql = string.Format("INSERT INTO [dbo].[OrdenDetalle] " +
                               "([OrdDet_Numero]        " +
                               ",[OrdDet_CodProducto]   " +
                               ",[OrdDet_Serial]        " +
                               ",[OrdDet_CodMarca]      " +
                               ",[OrdDet_IsAccesorio])  " +
                               " VALUES                 " +
                               "({0} ,'{1}', '{2}', {3}, 0)", NumeroOrden, CboEquipo.SelectedValue.ToString(), TxtSerial.Text, CboMarca.SelectedValue);
                    comman.CommandText = sql;
                    comman.ExecuteNonQuery();

                    string codaccesorio = "";
                    string serial = "";
                    foreach (DataGridViewRow item in DgvAccesorio.Rows)
                    {                      
                            if (Convert.ToBoolean(item.Cells["DgvAccesorioColCheck"].Value))
                            {
                                codaccesorio = item.Cells["DgvAccesorioColCodigo"].Value.ToString();
                                serial = (item.Cells["DgvAccesorioColSerial"].Value!=null)? item.Cells["DgvAccesorioColSerial"].Value.ToString():"";

                                sql = string.Format("INSERT INTO [dbo].[OrdenAccesorio] "+
                                                   "([OrdAcc_Numero]                    "+
                                                   ",[OrdAcc_CodAccesorio]              "+
                                                   ",[OrdAcc_Serial])                   "+
                                                   " VALUES                 " +
                                                   "({0} ,'{1}', '{2}')", NumeroOrden, codaccesorio, serial);
                                comman.CommandText = sql;
                                comman.ExecuteNonQuery();
                        }                        
                    }

                    string usuario = "";
                   
                    string encargado = "";
                    encargado = CboResponsableArreglo.SelectedValue.ToString();
                    sql = string.Format("INSERT INTO[dbo].[UsuarioOrden]    " +
                                         "([UsuOrden_DocUsu]                  " +
                                         ",[UsuOrden_NumOrden]              " +
                                         ",[UsuOrden_CodTipoAsignado])      " +
                                         "  VALUES                          " +
                                         "('{0}', {1}, {2})", encargado, NumeroOrden, 2);
                    comman.CommandText = sql;
                    comman.ExecuteNonQuery();

                    SQLtrans.Commit();
                    LimpiarControles();
                    MessageBox.Show("Registro guardado", "Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    NumeroOrden = -1;
                    //int numero = NumeroOrden + 1;
                    string sql = string.Format("UPDATE [dbo].[NumeroOrden] SET [_NunOrden] = [_NunOrden]-{0}", NumeroOrden);
                    ObjServer.CadnaSentencia = sql;
                    ObjServer.Sentencia();

                    MessageBox.Show("La operación no puedo completarse debido a: \n 1 - No dispone de una conexión  \n 2 - Ya se ha registrado este documento  \n 3 - La información ingresada no corresponde a la requerida  \n Vuelva a intentarlo!!! " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    try
                    { SQLtrans.Rollback(); }
                    catch (Exception exRollback)
                    {
                        //Console.WriteLine(exRollback.Message);
                    }
                }
            }
        }

    }
}
