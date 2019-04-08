using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace Historia_Clinica
{
    public abstract class  ClsGestores
    {
       // public abstract void Saludar();
        //Propiedades
        //public abstract string Sentencia {  set; }
        public abstract string CadnaSentencia { set; }
        //protected string myVar;

        //protected string CadnaSentencia
        //{
        //    get { return myVar; }
        //    set { myVar = value; }
        //}
        public abstract string CadenaCnn { set; }
        //public abstract DataTable 
        //Metodos a ejecutar
        public abstract void Conectar();
        public abstract void Sentencia();
        public abstract void CargarDatos(DataGridView Dgv, string Consulta);
        public abstract DataTable LlenarTabla(string Consulta);
    }
}
