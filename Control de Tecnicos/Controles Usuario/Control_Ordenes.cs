using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Historia_Clinica;
using System.Data.SqlClient;
using Historia_Clinica.Conexion;

namespace Control_de_Tecnicos.Controles_Usuario
{
    public partial class Control_Ordenes : UserControl
    {
        public Control_Ordenes()
        {
            InitializeComponent();
        }

        ClsSqlServer ObjServer = new ClsSqlServer();
        string codigoProducto;

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

                //MessageBox.Show(DgvTecnicoColCargo.Items.Count.ToString());
                //CARGAR COMBO DE TIPO CARGOS
                DgvTecnicoColCargo.DataSource = ObjServer.LlenarTabla("SELECT Carg_Codigo,Carg_Descripcion FROM Cargo ORDER BY Carg_Descripcion");
                DgvTecnicoColCargo.DisplayMember = "Carg_Descripcion";
                DgvTecnicoColCargo.ValueMember = "Carg_Codigo";

                //CARGAR COMBO DE SERVICIO DE LA ORDEN 
                CboServicioOrden.DataSource = ObjServer.LlenarTabla("SELECT Serv_Codigo ,Serv_Descripcion ,Serv_CodTipoServicio FROM Servicio ORDER BY Serv_Descripcion");
                CboServicioOrden.DisplayMember = "Serv_Descripcion";
                CboServicioOrden.ValueMember = "Serv_Codigo";

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private async void Control_Ordenes_Load(object sender, EventArgs e)
        {
           await CARGAR_COMBOS();

            //cargar los datos para el autocomplete del textbox TxtArticulo
            TxtArticulo.AutoCompleteCustomSource = AutoCompleClass.AutocompleteProducto();
            TxtArticulo.AutoCompleteMode = AutoCompleteMode.Suggest;
            TxtArticulo.AutoCompleteSource = AutoCompleteSource.CustomSource;

            //cargar los datos para el autocomplete del textbox TxtArticulo
            TxtDocCliente.AutoCompleteCustomSource = AutoCompleClass.AutocompleteCliente();
            TxtDocCliente.AutoCompleteMode = AutoCompleteMode.Suggest;
            TxtDocCliente.AutoCompleteSource = AutoCompleteSource.CustomSource;
            CargarOrdenes();

        }

        private void DgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
        //METODO PARA BUSCAR CLIENTE
        public void BuscarCliente(string buscar)
        {
            if (TxtDocumento.Text.Trim()=="")
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
                      "WHERE  Cli_Documento = '" +TxtDocumento.Text.Trim() + "'";


            tabla = ObjServer.LlenarTabla(SQL);
            if (tabla.Rows.Count > 0)
            {
                string nombre = tabla.Rows[0]["Cli_Nombre"].ToString();
                string apellido = tabla.Rows[0]["Cli_Apellido"].ToString();
                string celular = tabla.Rows[0]["Cli_Celular"].ToString();
                LblNombre.BackColor = Color.Green;
                LblNombre.Text = $"{nombre} {apellido} {"Celular:"} {celular}";
            }
            else
            {
                MessageBox.Show("Sin resultado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LblNombre.Text = "";
                LblNombre.BackColor = Color.WhiteSmoke;
            }
            TxtDocumento.Focus();
            TxtDocumento.SelectAll();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            BuscarCliente(TxtDocumento.Text);
        }

        private void TxtDocumento_TextChanged(object sender, EventArgs e)
        {
            if (LblNombre.Text!="")
            {
                LblNombre.Text = "";
                LblNombre.BackColor = Color.WhiteSmoke;
            }
        }

        private void TxtDocumento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                BuscarCliente(TxtDocumento.Text);
            }
        }

        public DataTable CargarProducto(string codigo)
        {
            string consulta = "SELECT [Prod_Codigo],[Prod_Descripcion],[Prod_Marca],[Prod_Seral],[Prod_Canales] ,[Prod_MegaPixeles],[Prod_Referencia] ,[Prod_Color] ,[Prod_Tipo] ,[Prod_Zona] ,[Prod_BotonPanico] ,[Prod_ModuloCalle] ,[Prod_Pantallas] ,[Prod_Garantia] FROM[dbo].[Producto] where Prod_Codigo='"+codigo+"'";
            DataTable TablaProductos = new DataTable(); //Esta tabla se utiliza para almacenar los productos 
            TablaProductos = ObjServer.LlenarTabla(consulta);

            return TablaProductos;
        }
        
        private void TxtArticulo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TxtArticulo.Text!="")
                {
                    string[] codigo = TxtArticulo.Text.Split('-');
                    if (codigo.Length > 1)
                    {
                        string Cod = (codigo[0].Length > codigo[1].Length) ? codigo[1] : codigo[0];
                        codigoProducto = Cod;
                        TxtCantidad.Text = "1";
                        TxtCantidad.Focus();
                        TxtCantidad.SelectAll();
                    }
                    else
                        MessageBox.Show("Seleccionar un producto","", MessageBoxButtons.OK,MessageBoxIcon.None);
                }                                       
            }
        }

        private void TxtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable tabla = new DataTable();
                tabla = CargarProducto(codigoProducto);
                
                if (tabla.Rows.Count > 0)
                {
                    string Codigo = tabla.Rows[0]["Prod_Codigo"].ToString();
                    int x = 0; //Reprenta la fila 
                    int y = 0; //indica si el producto enta en el DGV 

                    string nombcol = "DgvProductosColCantidad";
                    int colcantidad = 0;
                    int cantidad = Convert.ToInt32(TxtCantidad.Text.Trim());
                    foreach (DataGridViewRow item in DgvProductos.Rows)
                    {
                        if (Codigo==item.Cells["DgvProductosColCodigo"].Value.ToString())
                        {
                            colcantidad = Convert.ToInt32(DgvProductos.Rows[x].Cells["DgvProductosColCantidad"].Value);
                            DgvProductos.Rows[x].Cells[nombcol].Value = colcantidad + cantidad;
                            TxtCantidad.Text = "1";
                            TxtArticulo.Clear();
                            TxtArticulo.Focus();
                            y++;
                            break;
                        }
                        x++;
                    }

                    if (y==0)
                    {
                        DgvProductos.Rows.Add(tabla.Rows[0]["Prod_Codigo"].ToString(), tabla.Rows[0]["Prod_Descripcion"].ToString(), TxtCantidad.Text.Trim());
                        TxtCantidad.Text = "1";
                        TxtArticulo.Clear();
                        TxtArticulo.Focus();
                    }
                    DgvProductos.ClearSelection();
                }
            }
        }
               
        public static class AutoCompleClass
        {
            //metodo para cargar los datos de la bd
            public static DataTable Datos(string consulta)
            {
                //TablaProductos = new DataTable();
                DataTable dt = new DataTable();
                SqlConnection conexion = new SqlConnection(CadenaConexion.cadena());//cadena conexion

                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataAdapter adap = new SqlDataAdapter(comando);

                adap.Fill(dt);
                //adap.Fill(dt);
                return dt;
            }

            //metodo para cargar la coleccion de datos para el autocomplete
            public static AutoCompleteStringCollection AutocompleteProducto()
            {
                string consulta = "SELECT [Prod_Codigo],[Prod_Descripcion],[Prod_Marca],[Prod_Seral],[Prod_Canales] ,[Prod_MegaPixeles],[Prod_Referencia] ,[Prod_Color] ,[Prod_Tipo] ,[Prod_Zona] ,[Prod_BotonPanico] ,[Prod_ModuloCalle] ,[Prod_Pantallas] ,[Prod_Garantia] FROM[dbo].[Producto]";
                DataTable dt = Datos(consulta);
                AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
                //recorrer y cargar los items para el autocompletado
                foreach (DataRow row in dt.Rows)
                {
                    coleccion.Add($"{Convert.ToString(row["Prod_Descripcion"])}{"-"}{Convert.ToString(row["Prod_Codigo"])}");
                    coleccion.Add($"{Convert.ToString(row["Prod_Codigo"])}{"-"}{Convert.ToString(row["Prod_Descripcion"])} ");
                }                  
                return coleccion;
            }

            //metodo para cargar la coleccion de datos para el autocomplete
            public static AutoCompleteStringCollection AutocompleteCliente()
            {
                string consulta = "SELECT [Cli_Documento] ,[Cli_TipoDocumento],[Cli_Nombre],[Cli_Apellido],[Cli_Sexo] ,[Cli_Tipo],[Cli_Direccion],[Cli_Email],[Cli_Celular],[Cli_TelFijo] ,[Cli_Contacto],[Cli_TelContacto] FROM[dbo].[Cliente]";
                DataTable dt = Datos(consulta);
                AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
                string nombre = "";
                string apellidos = "";
                string documento = "";
                //recorrer y cargar los items para el autocompletado
                foreach (DataRow row in dt.Rows)
                {
                    nombre = Convert.ToString(row["Cli_Nombre"]);
                    apellidos = Convert.ToString(row["Cli_Apellido"]);
                    documento = Convert.ToString(row["Cli_Documento"]);

                    coleccion.Add($"{nombre} {apellidos} {"-"}{documento}");
                    coleccion.Add($"{documento}{"-"}{nombre} {apellidos}");
                }

                return coleccion;
            }

        }

        private void BtnArticulo_Click(object sender, EventArgs e)
        {

        }

        private void TxtArticulo_Click(object sender, EventArgs e)
        {
            TxtArticulo.Focus();
            TxtArticulo.SelectAll();
        }

        private void DgvProductos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back )
            {
                int fila = DgvProductos.CurrentCell.RowIndex;
                if (fila >= 0 )
                {
                    DgvProductos.Rows.RemoveAt(fila);
                }
            }
        }

        public Boolean IsNumerica(String numero)
        {
            try
            {
                int.Parse(numero);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private void TxtDocCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                string[] usuario = TxtDocCliente.Text.Split('-');
                //MessageBox.Show(TxtDocCliente.Text);
                if (usuario.Length>1)
                {
                    string documento = "";
                    string nombre = "";
                    if (IsNumerica(usuario[0].Trim()))
                        documento = usuario[0];
                    else
                        documento = usuario[1];

                    if (!IsNumerica(usuario[0].Trim()))
                        nombre = usuario[0];
                    else
                        nombre = usuario[1];

                    int x = 0; //Reprenta la fila 
                    int y = 0; //indica si el producto enta en el DGV 

                    foreach (DataGridViewRow item in DgvTecnico.Rows)
                    {
                        if (documento == item.Cells["DgvTecnicoColDocumento"].Value.ToString())
                        {
                            MessageBox.Show("El trabajador ya esta en la lista", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            y++;
                            break;
                        }
                        x++;
                    }

                    if (y == 0)
                    {
                        DgvProductos.ClearSelection();
                        DgvTecnico.Rows.Add(documento, nombre, 1);
                    }
                }
            }
        }

        private void DgvTecnico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                int fila = DgvTecnico.CurrentCell.RowIndex;
                if (fila >= 0)
                {
                    DgvTecnico.Rows.RemoveAt(fila);
                }
            }
        }

        public void CargarOrdenes()
        {
            DgvOrdenes.Rows.Clear();
            DataTable tabla = new DataTable();
            string sql = "SELECT [Ord_Numero]           " +
                            ",[Ord_Fecha]               " +
                            ",[Ord_Hora]                " +
                            ",[Ord_CodServicio]         " +
                            ",[Ord_ObsEntrada]          " +
                            ",[Ord_DocUsuario]          " +
                            ",[Ord_DocCliente]          " +
                            ",[Ord_FechaInicio]         " +
                            ",[Ord_ObsResultadoRevision]" +
                            ",[Ord_Factura]             " +
                            ",[Ord_Valor]               " +
                            ",[Ord_Garantia]            " +
                            ",[Ord_ObsSalida]           " +
                            ",[Ord_FechaTerminacion]    " +
                            ",[Ord_FechaEntrega]        " +
                            ",[Ord_Estado]              " +
                            "FROM[dbo].[Orden] ORDER BY Ord_Numero DESC";
            tabla = ObjServer.LlenarTabla(sql);
            int x = 0;
            int col = 0;
            int fila = 0;
            DgvOrdenes.Columns.Add("Col1", "");
            DgvOrdenes.Rows.Add("");
            DgvOrdenes.RowCount = 4;
            DgvOrdenes.Columns[col].Width = 60;
            foreach (DataRow item in tabla.Rows)
            {              
                DgvOrdenes.Rows[fila].Cells[col].Value = item["Ord_Numero"].ToString();
                DgvOrdenes.Rows[fila].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                x++;
                fila++;

                if (x==4)
                {                  
                    DgvOrdenes.Columns.Add("Col1", "");
                    col++;
                    x = 0;
                    fila = 0;
                    DgvOrdenes.Columns[col].Width = 60;
                }
            }
            ObjServer.EstilosDgv(DgvOrdenes);


        }

        private void TxtAceptar1_Click(object sender, EventArgs e)
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

                    sql = "";
                    sql = string.Format("INSERT INTO  dbo.Orden(Ord_Numero,Ord_Fecha, Ord_Hora,   Ord_CodServicio, " +
                                  "Ord_ObsEntrada, Ord_DocUsuario, Ord_DocCliente,              " +
                                  "Ord_FechaInicio, Ord_ObsResultadoRevision, Ord_Factura,      " +
                                  "Ord_Valor, Ord_Garantia, Ord_ObsSalida, Ord_FechaTerminacion," +
                                  "Ord_FechaEntrega, Ord_Estado)                                " +
                                  "VALUES({10},GETDATE(),CONVERT (time,GETDATE()),{0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}',{8},'{9}',GETDATE(), GETDATE(),1)", CboServicio.SelectedValue, TxtObservacion.Text, "123", TxtDocumento.Text, DtFechaInicio.Text, TxtObservacionRevision.Text, TxtNunFactura.Text, TxtValor.Value, TxtGarantia.Text, TxtObservacionSalida.Text, NumeroOrden);

                    comman.CommandText = sql;
                    comman.ExecuteNonQuery();

                    //ObjServer.CadnaSentencia = sql;
                    //ObjServer.Sentencia();
                    string codproducto = "";
                    int cantidad = 0;

                    foreach (DataGridViewRow item in DgvProductos.Rows)
                    {
                        codproducto = item.Cells["DgvProductosColCodigo"].Value.ToString();
                        cantidad = Convert.ToInt32(item.Cells["DgvProductosColCantidad"].Value);

                        sql = string.Format("INSERT INTO [dbo].[OrdenDetalle] " +
                                "([OrdDet_Numero]        " +
                                ",[OrdDet_CodProducto]   " +
                                ",[OrdDet_Cantidad])      " +
                                " VALUES                 " +
                                "({0} ,'{1}', {2})", NumeroOrden, codproducto, cantidad);

                        comman.CommandText = sql;
                        comman.ExecuteNonQuery();
                        //ObjServer.CadnaSentencia = sql;
                        //ObjServer.Sentencia();
                    }

                    string usuario = "";
                    int cargo = 0;

                    foreach (DataGridViewRow item in DgvTecnico.Rows)
                    {
                        usuario = item.Cells["DgvTecnicoColDocumento"].Value.ToString();
                        cargo = Convert.ToInt32(item.Cells["DgvTecnicoColCargo"].Value);

                        sql = string.Format("INSERT INTO[dbo].[UsuarioOrden]    " +
                                             "([UsuOrden_DocUsu]                  " +
                                             ",[UsuOrden_NumOrden]              " +
                                             ",[UsuOrden_CodTipoAsignado])      " +
                                             "  VALUES                          " +
                                             "('{0}', {1}, {2})", usuario, NumeroOrden, cargo);
                        comman.CommandText = sql;
                        comman.ExecuteNonQuery();
                        //ObjServer.CadnaSentencia = sql;
                        //ObjServer.Sentencia();
                    }
                    
                    SQLtrans.Commit();
                    MessageBox.Show("Registro guardado", "Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    NumeroOrden = -1;
                    //int numero = NumeroOrden + 1;
                    string sql = string.Format("UPDATE [dbo].[NumeroOrden] SET [_NunOrden] = {0}", NumeroOrden);
                    ObjServer.CadnaSentencia = sql;
                    ObjServer.Sentencia();

                    MessageBox.Show("La operación no puedo completarse debido a: \n 1 - No dispone de una conexión  \n 2 - Ya se ha registrado este documento  \n 3 - La información ingresada no corresponde a la requerida  \n Vuelva a intentarlo!!! " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //MessageBox.Show(ex.ToString());
                    try
                    { SQLtrans.Rollback(); }
                    catch (Exception exRollback)
                    {
                        //Console.WriteLine(exRollback.Message); 
                    }
                }
            }
        }

        private void RdbProgramada_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbProgramada.Checked)
            {
                LblFechaInicio.Visible = true;
                DtFechaInicio.Visible = true;                
            }
            else
            {
                LblFechaInicio.Visible = false;
                DtFechaInicio.Visible = false;
            }
        }
    }
}
//public void GUARDAR_DATOS()
//{



//}
