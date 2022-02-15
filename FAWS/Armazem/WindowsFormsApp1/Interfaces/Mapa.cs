using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.OleDb;
using System.IO;
using Interface_WMS_Armazem.Interfaces;
using FAWS_WMS;

namespace ProjetoIntegradoArmazem
{
    public partial class frmMapa : Form
    {
        private static Control.ControlCollection ControlesMapa;
        public static Control.ControlCollection getControlesMapa { get => ControlesMapa; }
        private static Control.ControlCollection setControlesMapa { set => ControlesMapa = value; }

        public frmMapa()
        {
            InitializeComponent();



            List<TextBox> txtList = new List<TextBox>() {txtNome_do_Produto, txtCodigo_do_Produto, txtEAN};
            List<string> setList = new List<string>() {"Ex. Papel Higiênico", "Ex. 03457899 - 8", "Ex. 5901234123457" };
            SetCueBanner(ref txtList, setList);

            MetodosPreferencia.PassarCampos(lblCodigoProduto, lblDadosLocalizacao, lblEan, lblNomeProduto);
            MetodosPreferencia.PassarCampos(btnVisualizar, btnVoltar);
            MetodosPreferencia.PassarCampos(txtNome_do_Produto, txtCodigo_do_Produto, txtEAN);
            MetodosPreferencia.PassarCampos(msOpcoes);
            MetodosPreferencia.PassarCampos(picCabecalho, picLogo, picMapaArmazem);
            MetodosPreferencia.PassarCampos(tmsiAjudaMAPA, tmsiSistemaMAPA, tmsiUsuarioMAPA,
                                            tmsiopcaoPermissoesMAPA, tmsiopcaoPreferenciasMAPA,
                                            tmsiopcaoSairMAPA, tmsiopcaoSuporteMAPA, tmsiopcaoVerMatriculaMAPA);
            MetodosPreferencia.PassarCamposCabecalho(lblFatecWMS, lblDataeHora, lblNomeEmpresa, lblUsuario, lbNomeUsuarioMapa);

            setControlesMapa = Controls;
        }
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr i, string str);
        void SetCueBanner(ref List<TextBox> txts, List<string> description)
        {
            for (int i = 0; i < txts.Count; i++)
            {
                SendMessage(txts[i].Handle, 0x1501, (IntPtr)1, description[i]);
            }
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidade indisponível temporariamente.", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void timerDataHora_Tick(object sender, EventArgs e)
        {
            lblDataeHora.Text = DateTime.Now.ToString("dd/MM/yyyy, HH:mm");
        }
        private void txtNome_do_Produto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas letras", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void txtCodigo_do_Produto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void txtEAN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void opcaoSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void opcaoPreferencias_Click(object sender, EventArgs e)
        {
            frmPreferencias fPreferecias = new frmPreferencias();
            fPreferecias.ShowDialog();
        }
        private void opcaoVerMatricula_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sua matrícula é 00000000", "Matrícula de funcionário", MessageBoxButtons.OK);
        }
        private void opcaoPermissoes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidade indisponível temporariamente.", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void opcaoSuporte_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmManual>().Count() == 0)
            {
                FrmManual frm = new FrmManual();
                frm.Show();
            }
            else
            {
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm is FrmManual)
                    {
                        openForm.Show();
                    }
                }
            }
        }
        private void frmMapa_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Tem certeza que deseja sair?", "FAWS WMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
        }
        private void frmMapa_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Environment.Exit(0);
            if (Application.OpenForms.OfType<frminterfaceWMS_Armazem>().Count() == 0)
            {
                frminterfaceWMS_Armazem frm = new frminterfaceWMS_Armazem();
                frm.Show();
            }
            else
            {
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm is frminterfaceWMS_Armazem)
                    {
                        openForm.Show();
                    }
                }
            }
        }
        private void frmMapa_Load(object sender, EventArgs e)
        {
            MetodosPreferencia.MudarCorDeFundo(Controls, "padrao");
        }

        private void frmMapa_Activated(object sender, EventArgs e)
        {
            lbNomeUsuarioMapa.Text = FrmMenu.getUsuario;
        }
    }
}

