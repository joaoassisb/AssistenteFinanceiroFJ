using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssistenteFinanceiro
{
    public partial class alertaErro : Form
    {
        public alertaErro(string erro)
        {
            InitializeComponent();
            if (erro == "acento")
            {
                this.label1.Text = "Caracteres especiais não aceitos";
            }
            if (erro == "numero")
            {
                this.label1.Text = "Somente números";
            }
        }

        private void alertaErro_Load(object sender, EventArgs e)
        {
            this.Top = Screen.PrimaryScreen.Bounds.Height - 60 - this.Height;
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 60;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
