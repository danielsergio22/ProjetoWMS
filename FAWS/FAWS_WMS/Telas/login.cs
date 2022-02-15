﻿using FAWS_WMS.Entrada;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FAWS_WMS
{
    public partial class FrmLogin : Form
    {
        private static string User;
        private static string Pass;
        private static string ResultLogin = "";

        internal static string getUser { get => User;}        
        private static string setUser { set => User = value; }
        private static string getPass { get => Pass; }
        private static string setPass { set => Pass = value; }
        internal static string getResultLogin { get => ResultLogin; }

        internal FrmLogin()
        {
            InitializeComponent();

        }

        private void login_Load(object sender, EventArgs e)
        {
            lblSystemName.Parent = picBK;
            lblSystemName.BackColor = Color.Transparent;
            lblUser.Parent = picBK;
            lblUser.BackColor = Color.Transparent;
            lblPass.Parent = picBK;
            lblPass.BackColor = Color.Transparent;
            lnkData.Parent = picBK;
            lnkData.BackColor = Color.Transparent;
        }

        private void lnkData_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Não consegue acessar? Entre em contato através do e-mail abaixo:\n\n(faws.ads@fatec.sp.gov.br)", "FAWS WMS");
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            setUser = txtUser.Text;
            setPass = mtbPass.Text;

            if (Login.RealizarLogin(txtUser.Text, mtbPass.Text, out ResultLogin))
            {
               
                this.Hide();
                if (Application.OpenForms.OfType<FrmMenu>().Count() == 0)
                {
                    FrmMenu frm = new FrmMenu();
                    frm.ShowDialog();
                }
                else
                {
                    Application.OpenForms.OfType<FrmMenu>().First().WindowState = FormWindowState.Normal;
                    Application.OpenForms.OfType<FrmMenu>().First().BringToFront();
                }   
            }
            else if (getResultLogin.Equals("password"))
            {
                mtbPass.BackColor = Color.LightCoral;
                epErroSenha.SetError(mtbPass, "Senha incorreta!");

                txtUser.Text = getUser;
                mtbPass.Focus();
            }
            else if (getResultLogin.Equals("user&password"))
            {
                txtUser.BackColor = Color.LightCoral;
                epErroLogin.SetError(txtUser, "Usuário incorreto!");

                mtbPass.BackColor = Color.LightCoral;
                epErroSenha.SetError(mtbPass, "Senha incorreta!");

                txtUser.Focus();
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            if (txtUser.Text != string.Empty)
            {
                txtUser.BackColor = Color.SkyBlue;
                epErroLogin.Clear();
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (mtbPass.Text != string.Empty)
            {
                mtbPass.BackColor = Color.SkyBlue;
                epErroSenha.Clear();
            }
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void FrmLogin_Activated(object sender, EventArgs e)
        {        
            txtUser.Text = string.Empty;
            mtbPass.Text = string.Empty;
            txtUser.Focus();           
        }

        private void mtbPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnEnter.PerformClick();
            }
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnEnter.PerformClick();
            }
        }
    }
}
