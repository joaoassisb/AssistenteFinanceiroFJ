namespace AssistenteFinanceiro
{
    partial class UserControlHome
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelSaldo = new System.Windows.Forms.Label();
            this.lblRendas = new System.Windows.Forms.Label();
            this.lblGastos = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rendasCadastradas = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLancamentos = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblLancamentos);
            this.groupBox1.Controls.Add(this.labelSaldo);
            this.groupBox1.Controls.Add(this.lblRendas);
            this.groupBox1.Controls.Add(this.lblGastos);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rendasCadastradas);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(2, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 195);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // labelSaldo
            // 
            this.labelSaldo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaldo.Location = new System.Drawing.Point(348, 153);
            this.labelSaldo.Name = "labelSaldo";
            this.labelSaldo.Size = new System.Drawing.Size(171, 24);
            this.labelSaldo.TabIndex = 24;
            this.labelSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelSaldo.Click += new System.EventHandler(this.labelSaldo_Click);
            // 
            // lblRendas
            // 
            this.lblRendas.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRendas.Location = new System.Drawing.Point(348, 84);
            this.lblRendas.Name = "lblRendas";
            this.lblRendas.Size = new System.Drawing.Size(171, 24);
            this.lblRendas.TabIndex = 23;
            this.lblRendas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGastos
            // 
            this.lblGastos.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGastos.Location = new System.Drawing.Point(344, 120);
            this.lblGastos.Name = "lblGastos";
            this.lblGastos.Size = new System.Drawing.Size(175, 24);
            this.lblGastos.TabIndex = 22;
            this.lblGastos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(525, 24);
            this.label7.TabIndex = 21;
            this.label7.Text = "Saldo:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(525, 24);
            this.label5.TabIndex = 20;
            this.label5.Text = "Gastos Cadastrados:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rendasCadastradas
            // 
            this.rendasCadastradas.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rendasCadastradas.Location = new System.Drawing.Point(0, 84);
            this.rendasCadastradas.Name = "rendasCadastradas";
            this.rendasCadastradas.Size = new System.Drawing.Size(525, 24);
            this.rendasCadastradas.TabIndex = 19;
            this.rendasCadastradas.Text = "Rendas Cadastradas: ";
            this.rendasCadastradas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(525, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "Lançamentos Cadastrados: ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.lancamentosCadastrados_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-5, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(544, 31);
            this.label4.TabIndex = 21;
            this.label4.Text = "Resumo dos Lançamentos";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-4, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(543, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Utilize o menu lateral a esquerda para navegar .";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-2, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(541, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Bem vindo ao Assistente Financeiro FJ ! ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "Início";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLancamentos
            // 
            this.lblLancamentos.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLancamentos.Location = new System.Drawing.Point(366, 48);
            this.lblLancamentos.Name = "lblLancamentos";
            this.lblLancamentos.Size = new System.Drawing.Size(153, 24);
            this.lblLancamentos.TabIndex = 24;
            this.lblLancamentos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UserControlHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserControlHome";
            this.Size = new System.Drawing.Size(536, 378);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label rendasCadastradas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGastos;
        private System.Windows.Forms.Label lblRendas;
        private System.Windows.Forms.Label lblLancamentos;
        private System.Windows.Forms.Label labelSaldo;
    }
}
