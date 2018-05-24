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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //inicializar UserControlHome como padrão
            home();
            
            userControlLancamento1.salvarClicked += (s, e) =>
             {                
             };
            
            //salvar alterações
            userControlExtrato1.CellValueChanged += (s, e) =>
            {
                userControlExtrato1.salvarExtrato();
            };

            userControlExtrato1.UserDeletedRow += (s, e) =>
            {
                userControlExtrato1.salvarExtrato();
            };
        }

        private void home()
        {
            //MENU ALTERADO
            //modifica panelSide e altera exibição de controle
            // le arquivo para exibição de saldo

            SidePanel.Height = btnHome.Height;
            SidePanel.Top = btnHome.Top;
            userControlHome1.leTxt();
            userControlHome1.BringToFront();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            home();
        }

        private void userControlHome1_Load(object sender, EventArgs e)
        {

        }

        private void btnLancamento_Click(object sender, EventArgs e)
        {
            //MENU ALTERADO 
            //modifica panelSide e altera exibição de controle
            SidePanel.Height = btnLancamento.Height;
            SidePanel.Top = btnLancamento.Top;
            userControlLancamento1.BringToFront();
        }

        private void btnExtrato_Click(object sender, EventArgs e)
        {
            //MENU ALTERADO 
            //modifica panelSide e altera exibição de controle
            //apaga DataGrid
            //le arquivo para exibição no DataGrid

            userControlExtrato1.apagarDataGrid();

            userControlExtrato1.leTxt();

            SidePanel.Height = btnExtrato.Height;
            SidePanel.Top = btnExtrato.Top;
            userControlExtrato1.BringToFront();
        }

        private void userControlLancamento1_Load(object sender, EventArgs e)
        {
        }

        private void userControlExtrato1_Load(object sender, EventArgs e)
        {
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void userControlHome1_Load_1(object sender, EventArgs e)
        {
        }
        private void userControlSimulador1_Load_1(object sender, EventArgs e)
        {
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSimulador_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnSimulador.Height;
            SidePanel.Top = btnSimulador.Top;
            userControlSimulador1.BringToFront();
        }

        private void userControlSimulador1_Load(object sender, EventArgs e)
        {

        }
    }
}
