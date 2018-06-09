namespace AssistenteFinanceiro
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLancamento = new System.Windows.Forms.Button();
            this.btnExtrato = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.button14 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSimulador = new System.Windows.Forms.Button();
            this.userControlSimulador1 = new AssistenteFinanceiro.UserControlSimulador();
            this.userControlLancamento1 = new AssistenteFinanceiro.UserControlLancamento();
            this.userControlHome1 = new AssistenteFinanceiro.UserControlHome();
            this.userControlExtrato1 = new AssistenteFinanceiro.UserControlExtrato();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(209, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(591, 10);
            this.panel2.TabIndex = 3;
            // 
            // btnLancamento
            // 
            this.btnLancamento.FlatAppearance.BorderSize = 0;
            this.btnLancamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLancamento.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLancamento.ForeColor = System.Drawing.Color.White;
            this.btnLancamento.Image = ((System.Drawing.Image)(resources.GetObject("btnLancamento.Image")));
            this.btnLancamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLancamento.Location = new System.Drawing.Point(12, 198);
            this.btnLancamento.Name = "btnLancamento";
            this.btnLancamento.Size = new System.Drawing.Size(197, 54);
            this.btnLancamento.TabIndex = 4;
            this.btnLancamento.Text = "       Lançamentos";
            this.btnLancamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLancamento.UseVisualStyleBackColor = true;
            this.btnLancamento.Click += new System.EventHandler(this.btnLancamento_Click);
            // 
            // btnExtrato
            // 
            this.btnExtrato.FlatAppearance.BorderSize = 0;
            this.btnExtrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtrato.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtrato.ForeColor = System.Drawing.Color.White;
            this.btnExtrato.Image = ((System.Drawing.Image)(resources.GetObject("btnExtrato.Image")));
            this.btnExtrato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExtrato.Location = new System.Drawing.Point(12, 258);
            this.btnExtrato.Name = "btnExtrato";
            this.btnExtrato.Size = new System.Drawing.Size(197, 54);
            this.btnExtrato.TabIndex = 4;
            this.btnExtrato.Text = "       Extrato";
            this.btnExtrato.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExtrato.UseVisualStyleBackColor = true;
            this.btnExtrato.Click += new System.EventHandler(this.btnExtrato_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(12, 138);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(197, 54);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "       Início";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 97);
            this.label1.TabIndex = 6;
            this.label1.Text = "Assistente Financeiro FJ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button13
            // 
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Image = ((System.Drawing.Image)(resources.GetObject("button13.Image")));
            this.button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.Location = new System.Drawing.Point(756, 16);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(32, 35);
            this.button13.TabIndex = 5;
            this.button13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.SidePanel.Location = new System.Drawing.Point(0, 137);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 54);
            this.SidePanel.TabIndex = 4;
            // 
            // button14
            // 
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.Location = new System.Drawing.Point(3, 546);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(36, 34);
            this.button14.TabIndex = 4;
            this.button14.Text = "?";
            this.button14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button14.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.btnSimulador);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.btnLancamento);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnExtrato);
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 471);
            this.panel1.TabIndex = 2;
            // 
            // btnSimulador
            // 
            this.btnSimulador.FlatAppearance.BorderSize = 0;
            this.btnSimulador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimulador.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimulador.ForeColor = System.Drawing.Color.White;
            this.btnSimulador.Image = ((System.Drawing.Image)(resources.GetObject("btnSimulador.Image")));
            this.btnSimulador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSimulador.Location = new System.Drawing.Point(11, 318);
            this.btnSimulador.Name = "btnSimulador";
            this.btnSimulador.Size = new System.Drawing.Size(197, 54);
            this.btnSimulador.TabIndex = 5;
            this.btnSimulador.Text = "       Simulador";
            this.btnSimulador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSimulador.UseVisualStyleBackColor = true;
            this.btnSimulador.Click += new System.EventHandler(this.btnSimulador_Click);
            // 
            // userControlSimulador1
            // 
            this.userControlSimulador1.Location = new System.Drawing.Point(214, 81);
            this.userControlSimulador1.Name = "userControlSimulador1";
            this.userControlSimulador1.Size = new System.Drawing.Size(586, 439);
            this.userControlSimulador1.TabIndex = 9;
            this.userControlSimulador1.Load += new System.EventHandler(this.userControlSimulador1_Load);
            // 
            // userControlLancamento1
            // 
            this.userControlLancamento1.Location = new System.Drawing.Point(237, 81);
            this.userControlLancamento1.Name = "userControlLancamento1";
            this.userControlLancamento1.Size = new System.Drawing.Size(536, 378);
            this.userControlLancamento1.TabIndex = 5;
            // 
            // userControlHome1
            // 
            this.userControlHome1.Location = new System.Drawing.Point(234, 93);
            this.userControlHome1.Name = "userControlHome1";
            this.userControlHome1.Size = new System.Drawing.Size(536, 378);
            this.userControlHome1.TabIndex = 7;
            // 
            // userControlExtrato1
            // 
            this.userControlExtrato1.Location = new System.Drawing.Point(237, 93);
            this.userControlExtrato1.Name = "userControlExtrato1";
            this.userControlExtrato1.Size = new System.Drawing.Size(551, 378);
            this.userControlExtrato1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.userControlSimulador1);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.userControlLancamento1);
            this.Controls.Add(this.userControlHome1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userControlExtrato1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLancamento;
        private System.Windows.Forms.Button btnExtrato;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label1;
        private AssistenteFinanceiro.UserControlHome userControlHome1;
        private UserControlExtrato userControlExtrato1;
        private UserControlLancamento userControlLancamento1;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSimulador;
        private UserControlSimulador userControlSimulador1;
    }
}

