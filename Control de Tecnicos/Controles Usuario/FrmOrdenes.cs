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
    public partial class FrmOrdenes : Form
    {
        public FrmOrdenes()
        {
            InitializeComponent();
        }
        ClsSqlServer ObjServer = new ClsSqlServer();
        string codigoProducto;
        Boolean AGREGAR_MODIFICAR = true; //CUANDO ES TRUE SE VA A INSERTAR UNA NUEVA ORDER Y FALSO ACTUALIZAR
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
            DgvOrdenes.RowCount = 10;
            DgvOrdenes.Columns[col].Width = 60;

            foreach (DataRow item in tabla.Rows)
            {
                int ESTADO = Convert.ToInt32(item["Ord_Estado"]);
                DgvOrdenes.Rows[fila].Cells[col].Value = item["Ord_Numero"].ToString();
                DgvOrdenes.Rows[fila].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                Color color;

                switch (ESTADO)
                {
                    case 1:
                        color = Color.CornflowerBlue;
                        break;
                    case 2:
                        color = Color.SeaGreen;
                        break;
                    case 3:
                        color = Color.Yellow;
                        break;
                    case 4:
                        color = Color.Green;
                        break;

                    default:
                        color = Color.Red;
                        break;
                }

                DgvOrdenes.Rows[fila].Cells[col].Style.BackColor = color;

                x++;
                fila++;

                if (x == 10)
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

        private void FrmOrdenes_Load(object sender, EventArgs e)
        {
            CargarOrdenes();
        }

        private void DgvOrdenes_DoubleClick(object sender, EventArgs e)
        {

        }

        private void DgvOrdenes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (DgvOrdenes.Rows.Count > 0)
                {
                    if (DgvOrdenes.CurrentCell.Value != null)
                    {
                        int NumeroOrden = Convert.ToInt32(DgvOrdenes.CurrentCell.Value);
                        FrmEntregaTaller f = new FrmEntregaTaller();
                        f.ShowDialog();
                        //CARGAR_ORDEN_CLIENTE(NumeroOrden);
                        //AGREGAR_MODIFICAR = false;
                    }
                }
            }
        }
    }
}
