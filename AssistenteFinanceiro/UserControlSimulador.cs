using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssistenteFinanceiro
{
    public partial class UserControlSimulador : UserControl
    {
        public UserControlSimulador()
        {
            InitializeComponent();
            tempo.KeyPress += ApenasValorNumerico;
            valor.KeyPress += ApenasValorNumerico;
            selic.KeyPress += ApenasValorNumerico;

        }

        private void UserControlSimulador_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //valida preenchimento de formulario
            if (investimento.Text == "")
            {
                MessageBox.Show("Favor selecione o tipo do investimento", "Erro Preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                investimento.Text = "";
                return;
            }

            if (selic.Text == "")
            {
                MessageBox.Show("Favor preencha o valor da taxa Selic", "Erro Preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                selic.Text = "";
                return;
            }

            if (tempo.Text == "")
            {
                MessageBox.Show("Favor preencha o tempo do investimento", "Erro Preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tempo.Text = "";
                return;
            }

            if (valor.Text == "")
            {
                MessageBox.Show("Favor preencha o valor do investimento", "Erro Preenchimento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valor.Text = "";
                return;
            }
            //calcular investimento 
            double tr = 0.0;
            double resultado = double.Parse(valor.Text);
            if (investimento.Text == "Poupança")
            {
                for (int i = 0; i <= int.Parse(tempo.Text); i++)
                {
                    if (double.Parse(selic.Text) >= 0.085)
                    {
                        resultado += resultado * (tr + 0.005);
                    }
                    else
                    {
                        resultado += resultado * (double.Parse(selic.Text) * 0.7 + 0.005);
                    }
                }
                valor_simulado.Text = "O valor resgatado será: R$" + string.Format("{0:#.##}", resultado);
            }
            else if (investimento.Text == "CDI")
            {
                for (int i = 0; i <= int.Parse(tempo.Text); i++)
                {

                    resultado += resultado * 0.0052;


                    valor_simulado.Text = "O valor resgatado será: R$" + string.Format("{0:#.##}", resultado);
                }
            }
            else if (investimento.Text == "LCI")
            {
                for (int i = 0; i <= int.Parse(tempo.Text); i++)
                {

                    resultado += resultado * (0.0052 * 0.95);

                }
                valor_simulado.Text = "O valor resgatado será: R$" + string.Format("{0:#.##}", resultado);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserControlSimulador_Load_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AjudaSelic ajuda = new AjudaSelic();
            ajuda.ShowDialog();
            return;
        }

        private void valor_simulado_Click(object sender, EventArgs e)
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
    }
}
