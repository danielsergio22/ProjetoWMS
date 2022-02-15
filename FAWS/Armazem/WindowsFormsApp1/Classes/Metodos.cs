using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Runtime.InteropServices;


namespace ProjetoIntegradoArmazem
{
    public class Metodos : frminterfaceWMS_Armazem
    {
        //Construtor
        public Metodos() { }
  
        //os metodos começam aqui.
        public void DisableTextBox(TextBox textBox)
        {
            if(textBox.GetType() == typeof(TextBox))
            {
                textBox.Enabled = false;
            }
        }
        public void DisableButton(Button botao)
        {
            if (botao.GetType() == typeof(Button))
            {
                botao.Enabled = false;
            }

        }
        public void EnableTextBox(TextBox textBox)
        {
            if (textBox.GetType() == typeof(TextBox))
            {
                textBox.Enabled = true;
            }
        }
        public void EnableButton(Button botao)
        {
            if(botao.GetType() == typeof(Button))
            {
                botao.Enabled = true;
            }
        }
        public void ApenasNumeros(KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void ApenasLetras(KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas letras", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void LetraeNumero(KeyPressEventArgs e)
        {

            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsNumber(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente letras e números", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void ClearTextBox(TextBox textBox)
        {
            if (textBox is TextBox)
            {
                textBox.Clear();
            }
        }

    }
}
