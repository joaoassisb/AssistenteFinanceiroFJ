using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace AssistenteFinanceiro
{
    public partial class UserControlLancamento : UserControl
    {
        public event EventHandler salvarClicked;
        public UserControlLancamento()
        {
            InitializeComponent();
            btnSalvar.Click += (s, e) => this.salvarClicked?.Invoke(this, e);
            valor.KeyPress += ApenasValorNumerico;
            descricao.KeyPress += ApenasTexto;
        }

        private void UserControlLancamento_Load(object sender, EventArgs e)
        {

        }
        
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (tipo.Text == "")
            {
                MessageBox.Show("Favor selecione o tipo do lançamento", "Erro Preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tipo.Text = "";
                return; 
            }

            if (descricao.Text == "")
            {
                MessageBox.Show("Favor preencha a descrição do lançamento", "Erro Preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                descricao.Text = "";
                return;
            }

            if (valor.Text == "")
            {
                MessageBox.Show("Favor preencha o valor do lançamento", "Erro Preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valor.Text = "";
                return;
            }

            string path = @"documento.txt";
            Stream f = File.Open(path, FileMode.Append);
            StreamWriter file = new StreamWriter(f);

            file.WriteLine(data.Value.ToShortDateString() + ';' + tipo.Text + ';' + descricao.Text + ';' + valor.Text);

            tipo.Text = "";
            descricao.Text = "";
            valor.Text = "";
            file.Close();

            alertaSalvo alerta = new alertaSalvo("salvo");
            alerta.ShowDialog();
            return;
        }

        private void valor_TextChanged(object sender, EventArgs e)
        {
        
        }
        
        private void ApenasValorNumerico(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txt.Text.Contains(','));
                }
                else
                {
                    e.Handled = true;
                    alertaErro alertaErro = new alertaErro("numero");
                    alertaErro.ShowDialog();
                }
            }
        }

        private void ApenasTexto(object sender, KeyPressEventArgs e)
        {
            string strAcentos = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇç~´'^";
             if(strAcentos.IndexOf(e.KeyChar)>0)
            {
                alertaErro alertaErro = new alertaErro("acento");
                alertaErro.ShowDialog();
                e.Handled = true;
            }
             

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void descricao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
