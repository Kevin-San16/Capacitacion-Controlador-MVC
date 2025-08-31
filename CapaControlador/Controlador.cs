using CapaModelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaControlador
{
    public class Controlador
    {
        Sentencias sn = new Sentencias();

        // LLenar una tabla CAPA CONTROLADOR


        public DataTable llenarTbl(string emp)
        {
            OdbcDataAdapter dt = sn.llenarTbl(emp);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }


    }
}
