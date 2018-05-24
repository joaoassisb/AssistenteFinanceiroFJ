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
    public partial class alertaSalvo : Form
    {
        public alertaSalvo(string value)
        {
            InitializeComponent();
        }

        private void alertaSalvo_Load(object sender, EventArgs e)
        {
            this.Top = Screen.PrimaryScreen.Bounds.Height -60 -this.Height ;
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 60;
        }

        private void timeOut_Tick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
