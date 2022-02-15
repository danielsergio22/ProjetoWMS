﻿
namespace FAWS_WMS
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.lblSystemName = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.mtbPass = new System.Windows.Forms.MaskedTextBox();
            this.lnkData = new System.Windows.Forms.LinkLabel();
            this.TipDicas = new System.Windows.Forms.ToolTip(this.components);
            this.epErroLogin = new System.Windows.Forms.ErrorProvider(this.components);
            this.epErroSenha = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnEnter = new System.Windows.Forms.Button();
            this.picBK = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.epErroLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epErroSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBK)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSystemName
            // 
            this.lblSystemName.AutoSize = true;
            this.lblSystemName.BackColor = System.Drawing.Color.Transparent;
            this.lblSystemName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSystemName.Location = new System.Drawing.Point(71, 192);
            this.lblSystemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSystemName.Name = "lblSystemName";
            this.lblSystemName.Size = new System.Drawing.Size(161, 19);
            this.lblSystemName.TabIndex = 1;
            this.lblSystemName.Text = "Fatec Warehouse System";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblUser.Location = new System.Drawing.Point(69, 235);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(86, 28);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Usuário:";
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.SkyBlue;
            this.txtUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtUser.Location = new System.Drawing.Point(68, 240);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(269, 29);
            this.txtUser.TabIndex = 1;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TipDicas.SetToolTip(this.txtUser, "Insira o seu Usuário.");
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblPass.Location = new System.Drawing.Point(69, 315);
            this.lblPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(73, 28);
            this.lblPass.TabIndex = 4;
            this.lblPass.Text = "Senha:";
            // 
            // mtbPass
            // 
            this.mtbPass.BackColor = System.Drawing.Color.SkyBlue;
            this.mtbPass.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbPass.Location = new System.Drawing.Point(68, 320);
            this.mtbPass.Margin = new System.Windows.Forms.Padding(4);
            this.mtbPass.Name = "mtbPass";
            this.mtbPass.Size = new System.Drawing.Size(269, 29);
            this.mtbPass.TabIndex = 2;
            this.mtbPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TipDicas.SetToolTip(this.mtbPass, "Insira a sua Senha.");
            this.mtbPass.UseSystemPasswordChar = true;
            this.mtbPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            this.mtbPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbPass_KeyPress);
            // 
            // lnkData
            // 
            this.lnkData.ActiveLinkColor = System.Drawing.Color.White;
            this.lnkData.AutoSize = true;
            this.lnkData.LinkColor = System.Drawing.Color.Black;
            this.lnkData.Location = new System.Drawing.Point(127, 484);
            this.lnkData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkData.Name = "lnkData";
            this.lnkData.Size = new System.Drawing.Size(210, 17);
            this.lnkData.TabIndex = 4;
            this.lnkData.TabStop = true;
            this.lnkData.Text = "Não sei meus dados de acesso.";
            this.lnkData.VisitedLinkColor = System.Drawing.Color.Black;
            this.lnkData.Click += new System.EventHandler(this.lnkData_Click);
            // 
            // TipDicas
            // 
            this.TipDicas.AutomaticDelay = 200;
            this.TipDicas.IsBalloon = true;
            // 
            // epErroLogin
            // 
            this.epErroLogin.ContainerControl = this;
            // 
            // epErroSenha
            // 
            this.epErroSenha.ContainerControl = this;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.SystemColors.Window;
            this.btnEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnter.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnEnter.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnEnter.Image = ((System.Drawing.Image)(resources.GetObject("btnEnter.Image")));
            this.btnEnter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnter.Location = new System.Drawing.Point(200, 388);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(137, 50);
            this.btnEnter.TabIndex = 3;
            this.btnEnter.Text = "ENTRAR";
            this.btnEnter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // picBK
            // 
            this.picBK.Image = ((System.Drawing.Image)(resources.GetObject("picBK.Image")));
            this.picBK.Location = new System.Drawing.Point(-4, -25);
            this.picBK.Margin = new System.Windows.Forms.Padding(4);
            this.picBK.Name = "picBK";
            this.picBK.Size = new System.Drawing.Size(415, 558);
            this.picBK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBK.TabIndex = 0;
            this.picBK.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 521);
            this.Controls.Add(this.lnkData);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblSystemName);
            this.Controls.Add(this.mtbPass);
            this.Controls.Add(this.picBK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(421, 568);
            this.MinimumSize = new System.Drawing.Size(421, 568);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FAWS WMS - Login";
            this.Activated += new System.EventHandler(this.FrmLogin_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.login_FormClosing);
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epErroLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epErroSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBK;
        private System.Windows.Forms.Label lblSystemName;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.MaskedTextBox mtbPass;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.LinkLabel lnkData;
        private System.Windows.Forms.ToolTip TipDicas;
        private System.Windows.Forms.ErrorProvider epErroLogin;
        private System.Windows.Forms.ErrorProvider epErroSenha;
    }
}

