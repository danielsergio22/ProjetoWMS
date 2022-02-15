using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FAWS_WMS.Telas
{
    public partial class FrmLimpar : Form
    {
        public FrmLimpar()
        {
            InitializeComponent();
            treLimpezaBD.ExpandAll();
        }

        //Cancelar
        private void btnCancelarLimpar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void CheckTodos(TreeNode nos)
        {
            foreach (TreeNode n in nos.Nodes)
            {
                if (!n.Checked)
                {
                    n.Checked = true;
                }
            }
        }

        private void UncheckTodos(TreeNode nos)
        {
            foreach (TreeNode n in nos.Nodes)
            {
                if (n.Checked)
                {
                    n.Checked = false;
                }
            }
        }

        private void treLimpezaBD_AfterCheck(object sender, TreeViewEventArgs e)
        {
            //if (treLimpezaBD.SelectedNode.Nodes["NoRecebimento"].Checked)
            //{
            //    CheckTodos(treLimpezaBD.SelectedNode.Nodes["NoRecebimento"]);

            //}
            //else if (!treLimpezaBD.SelectedNode.Nodes["NoRecebimento"].Checked)
            //{
            //    UncheckTodos(treLimpezaBD.SelectedNode.Nodes["NoRecebimento"]);
            //}


            //if (treLimpezaBD.Nodes["NoLimparTudo"].Checked)
            //{
            //    CheckTodos(treLimpezaBD.Nodes["NoLimparTudo"]);
            //    CheckTodos(treLimpezaBD.Nodes["NoRecebimento"]);
            //    treLimpezaBD.ExpandAll();
            //}
            //else if (!treLimpezaBD.Nodes["NoLimparTudo"].Checked)
            //{
            //    UncheckTodos(treLimpezaBD.Nodes["NoLimparTudo"]);
            //    UncheckTodos(treLimpezaBD.Nodes["NoRecebimento"]);
            //    treLimpezaBD.CollapseAll();

            //}
        }

        //Tabelas para Limpeza
        private static readonly List<string> Tabelas = new List<string>()
        {
            //Clientes e Fornecedores

            //Produtos
            { "g5_Produto" },
            { "g5_Categoria" },
            { "g5_SubCategoria" },

            //Recebimento
            { "Divergencias" },
            { "Recebimento" },
            { "Portaria" },

            //Armazém
            { "Armazenagem" },

            //Expedição
            { "g2_Estoque_Saida" },
            { "g2_Pedido" },

        };

        //Realizar Limpeza BD.
        private void btnCancelarPort_Click(object sender, EventArgs e)
        {
            try
            {
                string pasta = Application.StartupPath + @"\DB\BDP3-WMSV3.mdb";

                string StrConexao = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + pasta;

                OleDbConnection connec = new OleDbConnection(StrConexao);

                connec.Open();

                OleDbCommand comando = new OleDbCommand
                {
                    Connection = connec
                };

                var result_del = MessageBox.Show("Atenção, essa operação não poderá ser desfeita!\n\nTem certeza que deseja excluir permanentemente esses dados?  ", "FAWS WMS", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result_del == DialogResult.Yes)
                {

                    foreach (var item in Tabelas)
                    {
                        comando.CommandText = "DELETE FROM " + item;

                        comando.ExecuteNonQuery();
                    }

                    MessageBox.Show("Dados excluidos com sucesso!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                    connec.Dispose();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("ERRO" + er);
            }
        }



        //private string lerChecados(TreeNode node, string checkeds = "")
        //{
        //    foreach (TreeNode n in node.Nodes)
        //    {
        //        if (n.Checked)
        //        {
        //            checkeds += n.Text + ", ";
        //        }
        //        checkeds = lerChecados(n, checkeds);
        //    }
        //    return checkeds;
        //}
    }
}
