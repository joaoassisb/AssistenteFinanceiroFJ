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
    public partial class UserControlHome : UserControl
    {
        public UserControlHome()
        {
            InitializeComponent();
        }

        public void leTxt()
        {
            string path = @"documento.txt";
            string[] Linha = System.IO.File.ReadAllLines(path);
            AssistenteFinanceiroClass assistente = new AssistenteFinanceiroClass();

            if (Linha.Length == 0)
            {
                return;
            }

            for (int i = 0; i < Linha.Length; i++)
            {
                string[] campos = Linha[i].Split(';');
                var lancamento = new Lancamento(Convert.ToDateTime(campos[0].ToString()), campos[1].ToString(), campos[2].ToString(), Convert.ToDouble(campos[3].ToString()));
                assistente.lancamentos.Add(lancamento);
            }
            double saldo = assistente.calculaSaldo();
            labelSaldo.Text = " R$" +Convert.ToString(saldo);
            if (saldo <0 )
            {
                labelSaldo.ForeColor = Color.Red;
            }
            else
            {
                labelSaldo.ForeColor = Color.Green;
            }

            if(saldo - Math.Truncate(saldo) == 0)
            {
                labelSaldo.Text = " R$" + Convert.ToString(saldo)+",00";
            }
            lblLancamentos.Text = assistente.calculaLancamentos().ToString();

            double gastos = assistente.calculaGastos();
            lblGastos.Text = " R$"+ string.Format("{0:#.##}", assistente.calculaGastos());

            if (gastos - Math.Truncate(gastos) == 0)
            {
                lblGastos.Text = "R$" + Convert.ToString(gastos) + ",00";
            }

            double rendas = assistente.calculaRendas();
            lblRendas.Text = " R$" + string.Format("{0:#.##}", assistente.calculaRendas());

            if (rendas - Math.Truncate(rendas) == 0)
            {
                lblRendas.Text = "R$" + Convert.ToString(rendas) + ",00";
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lancamentosCadastrados_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void labelSaldo_Click(object sender, EventArgs e)
        {

        }
    }
}
