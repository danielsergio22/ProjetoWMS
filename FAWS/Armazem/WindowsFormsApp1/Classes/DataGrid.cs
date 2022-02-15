using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace ProjetoIntegradoArmazem
{
    class DataGrid
    {
        public DataGrid() { }

        public void MostrarDados(OleDbCommand command, DataGridView dataGrid) 
        {

            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            DataTable dados = new DataTable();
            adapter.Fill(dados);
            dataGrid.DataSource = dados;
        }
    }
}
