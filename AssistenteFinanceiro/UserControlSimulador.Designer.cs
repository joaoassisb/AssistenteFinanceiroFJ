namespace AssistenteFinanceiro
{
    partial class UserControlSimulador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlSimulador));
            this.label1 = new System.Windows.Forms.Label();
            this.investimento = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tempo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.valor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelic = new System.Windows.Forms.Button();
            this.selic = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.valor_simulado = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Investimento:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // investimento
            // 
            this.investimento.FormattingEnabled = true;
            this.investimento.Items.AddRange(new object[] {
            "Poupança",
            "CDI",
            "LCI"});
            this.investimento.Location = new System.Drawing.Point(100, 81);
            this.investimento.Name = "investimento";
            this.investimento.Size = new System.Drawing.Size(121, 21);
            this.investimento.TabIndex = 1;
            this.investimento.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tempo (meses):";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tempo
            // 
            this.tempo.Location = new System.Drawing.Point(100, 172);
            this.tempo.Name = "tempo";
            this.tempo.Size = new System.Drawing.Size(121, 20);
            this.tempo.TabIndex = 3;
            this.tempo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor (R$):";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // valor
            // 
            this.valor.Location = new System.Drawing.Point(100, 219);
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(121, 20);
            this.valor.TabIndex = 4;
            this.valor.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.valor_simulado);
            this.groupBox1.Controls.Add(this.btnSelic);
            this.groupBox1.Controls.Add(this.selic);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tempo);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.valor);
            this.groupBox1.Controls.Add(this.investimento);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(105, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 352);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSelic
            // 
            this.btnSelic.FlatAppearance.BorderSize = 0;
            this.btnSelic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelic.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelic.ForeColor = System.Drawing.Color.White;
            this.btnSelic.Image = ((System.Drawing.Image)(resources.GetObject("btnSelic.Image")));
            this.btnSelic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelic.Location = new System.Drawing.Point(227, 109);
            this.btnSelic.Name = "btnSelic";
            this.btnSelic.Size = new System.Drawing.Size(38, 54);
            this.btnSelic.TabIndex = 10;
            this.btnSelic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelic.UseVisualStyleBackColor = true;
            this.btnSelic.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // selic
            // 
            this.selic.Location = new System.Drawing.Point(100, 128);
            this.selic.Name = "selic";
            this.selic.Size = new System.Drawing.Size(121, 20);
            this.selic.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Selic (%)";
            // 
            // valor_simulado
            // 
            this.valor_simulado.AutoSize = true;
            this.valor_simulado.Location = new System.Drawing.Point(97, 308);
            this.valor_simulado.Name = "valor_simulado";
            this.valor_simulado.Size = new System.Drawing.Size(13, 13);
            this.valor_simulado.TabIndex = 12;
            this.valor_simulado.Text = "  ";
            this.valor_simulado.Click += new System.EventHandler(this.valor_simulado_Click);
            // 
            // UserControlSimulador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UserControlSimulador";
            this.Size = new System.Drawing.Size(536, 377);
            this.Load += new System.EventHandler(this.UserControlSimulador_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox investimento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tempo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox valor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox selic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSelic;
        private System.Windows.Forms.Label valor_simulado;
    }
}
