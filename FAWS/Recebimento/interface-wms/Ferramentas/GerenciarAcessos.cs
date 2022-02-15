using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FAWS_WMS;
using interface_wms;
using interface_wms.Ferramentas;

namespace Interface_WMS_Recebimento.Ferramentas
{
    internal class GerenciarAcessos : AbasFormatacoes
    {
        private static string Usuario;
        private static string ResultLogin;

        public static string getUsuario { get => Usuario; }

        //Liberar o acesso dos campos de determinado Login
        internal static void LiberarAcesso()
        {

            Usuario = FrmMenu.getUsuario;
            ResultLogin = FrmMenu.getResultLogin;

            switch (Usuario)
            {       
                case "FATEC@PROFESSOR":
                    foreach (var item in Labelscabecalho)
                    {
                        if (item.Name == "lbNomeUsuarioPort" || item.Name == "lbNomeUsuarioRec" || item.Name == "lbNomeUsuarioDiverg"
                        || item.Name == "lbNomeMatriculaRelNF" || item.Name == "lbNomeMatriculaPedidos")
                        {
                            item.Text = FrmMenu.getUsuario;
                        }
                    }

                    foreach (var item in Txtboxes)
                    {
                        if (item.Name == "txtMatriculaPorteiroPort" || item.Name == "txtMatricConfRec" || item.Name == "txtMatricInspetorDiverg")
                        {
                            item.Text = FrmMenu.getUsuario;
                        }
                    }
                    break;

                case "RECEBIMENTO@SUPERVISOR":
                    foreach (var item in Labelscabecalho)
                    {
                        if (item.Name == "lbNomeUsuarioPort" || item.Name == "lbNomeUsuarioRec" || item.Name == "lbNomeUsuarioDiverg"
                        || item.Name == "lbNomeMatriculaRelNF" || item.Name == "lbNomeMatriculaPedidos")
                        {
                            item.Text = FrmMenu.getUsuario;
                        }
                    }

                    foreach (var item in Txtboxes)
                    {
                        if (item.Name == "txtMatriculaPorteiroPort" || item.Name == "txtMatricConfRec" || item.Name == "txtMatricInspetorDiverg")
                        {
                            item.Text = FrmMenu.getUsuario;
                        }
                    }
                    break;

                case "RECEBIMENTO@PORTEIRO01":
                    foreach (var item in Groupboxes)
                    {
                        if (item.Name == "grbCadastroRec" || item.Name == "grbControlesRec" || item.Name == "grbEmitirDivergenciaRec"
                        || item.Name == "grbDivergencias" || item.Name == "grbControleDiverg")
                        {
                            item.Enabled = false;
                        }
                    }

                    foreach (var item in Datagridviews)
                    {
                        if (item.Name == "dgvPesqRec" || item.Name == "dgvPesqDiverg")
                        {
                            item.ReadOnly = true;
                        }
                    }

                    foreach (var item in Labelscabecalho)
                    {
                        if (item.Name == "lbNomeUsuarioPort" || item.Name == "lbNomeUsuarioRec" || item.Name == "lbNomeUsuarioDiverg" 
                        || item.Name == "lbNomeMatriculaRelNF" || item.Name == "lbNomeMatriculaPedidos")
                        {
                            item.Text = FrmMenu.getUsuario;
                        }
                    }

                    foreach (var item in Txtboxes)
                    {
                        if (item.Name == "txtMatriculaPorteiroPort")
                        {
                            item.Text = FrmMenu.getUsuario;
                            break;
                        }
                    }
                    break;

                case "RECEBIMENTO@CONFERENTE01":
                    foreach (var item in Groupboxes)
                    {
                        if (item.Name == "grbInfoVeicPort" || item.Name == "grbInfoEntradaSaidaPort" || item.Name == "grbInfEntregaPort"
                        || item.Name == "grbControlesPort" || item.Name == "grbDivergencias" || item.Name == "grbControleDiverg")
                        {
                            item.Enabled = false;
                        }
                    }

                    foreach (var item in Datagridviews)
                    {
                        if (item.Name == "dgvPesqPort" || item.Name == "dgvPesqDiverg")
                        {
                            item.ReadOnly = true;
                            break;
                        }
                    }

                    foreach (var item in Labelscabecalho)
                    {
                        if (item.Name == "lbNomeUsuarioPort" || item.Name == "lbNomeUsuarioRec" || item.Name == "lbNomeUsuarioDiverg"
                         || item.Name == "lbNomeMatriculaRelNF" || item.Name == "lbNomeMatriculaPedidos")
                        {
                            item.Text = FrmMenu.getUsuario;
                        }
                    }

                    foreach (var item in Txtboxes)
                    {
                        if (item.Name == "txtMatricConfRec")
                        {
                            item.Text = FrmMenu.getUsuario;
                            break;
                        }
                    }
                    break;

                case "RECEBIMENTO@INSPETORDEQUALIDADE01":
                    foreach (var item in Groupboxes)
                    {
                        if (item.Name == "grbInfoVeicPort" || item.Name == "grbInfoEntradaSaidaPort" || item.Name == "grbInfEntregaPort"
                         || item.Name == "grbControlesPort" || item.Name == "grbCadastroRec" || item.Name == "grbControlesRec" || item.Name == "grbEmitirDivergenciaRec")
                        {
                            item.Enabled = false;
                        }
                    }

                    foreach (var item in Datagridviews)
                    {
                        if (item.Name == "dgvPesqRec" || item.Name == "dgvPesqPort")
                        {
                            item.ReadOnly = true;
                            break;
                        }
                    }

                    foreach (var item in Labelscabecalho)
                    {
                        if (item.Name == "lbNomeUsuarioPort" || item.Name == "lbNomeUsuarioRec" || item.Name == "lbNomeUsuarioDiverg"
                         || item.Name == "lbNomeMatriculaRelNF" || item.Name == "lbNomeMatriculaPedidos")
                        {
                            item.Text = FrmMenu.getUsuario;
                        }
                    }

                    foreach (var item in Txtboxes)
                    {
                        if (item.Name == "txtMatricInspetorDiverg")
                        {
                            item.Text = FrmMenu.getUsuario;
                            break;
                        }
                    }
                    break;


            }


        }




    }
}
