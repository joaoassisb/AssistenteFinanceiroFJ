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

namespace AssistenteFinanceiro
{
    public partial class UserControlExtrato : UserControl
    {
        public event DataGridViewCellEventHandler CellValueChanged;
        public event DataGridViewRowEventHandler UserDeletedRow;

        public UserControlExtrato()
        {
            InitializeComponent();
            dataGridView1.CellValueChanged += (s, e) => this.CellValueChanged?.Invoke(this, e);
            dataGridView1.UserDeletedRow += (s, e) => this.UserDeletedRow?.Invoke(this, e);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

                dataGridView1.Rows.Add(lancamento.data.ToShortDateString(), lancamento.tipo, lancamento.descricao, lancamento.valor);
            }
        }

        public void salvar_Click(object sender, EventArgs e)
        {
            apagarArquivo();

            string path = @"documento.txt";
            Stream f = File.Open(path, FileMode.Append);
            StreamWriter file = new StreamWriter(f);

            for (int rows = 0; rows < dataGridView1.Rows.Count; rows++)
            {
                file.WriteLine(dataGridView1.Rows[rows].Cells[0].Value.ToString() + ';' + dataGridView1.Rows[rows].Cells[1].Value.ToString() + ';' + dataGridView1.Rows[rows].Cells[2].Value.ToString() + ';' + dataGridView1.Rows[rows].Cells[3].Value.ToString());
            }

            file.Close();
        }

        public void apagarArquivo()
        {
            string filename = @"documento.txt";
            FileStream fileStream = File.Open(filename, FileMode.Open);
            fileStream.SetLength(0);
            fileStream.Close();
        }

        public void apagarDataGrid()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
        }

        private void salvar_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void salvarExtrato()
        {
            apagarArquivo();

            string path = @"documento.txt";
            Stream f = File.Open(path, FileMode.Append);
            StreamWriter file = new StreamWriter(f);

            for (int rows = 0; rows < dataGridView1.Rows.Count; rows++)
            {
                file.WriteLine(dataGridView1.Rows[rows].Cells[0].Value.ToString() + ';' + dataGridView1.Rows[rows].Cells[1].Value.ToString() + ';' + dataGridView1.Rows[rows].Cells[2].Value.ToString() + ';' + dataGridView1.Rows[rows].Cells[3].Value.ToString());
            }

            file.Close();
        }

        private void UserControlExtrato_Load(object sender, EventArgs e)
        {

        }
    }
}
