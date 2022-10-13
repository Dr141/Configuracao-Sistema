
namespace Configuracao
{
    partial class FormDADP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDADP));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tBPorta = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cB_Atualizacao = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cB_TipoConexao = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tB_Senha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tB_Usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tB_StrConexao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bttGravar = new System.Windows.Forms.Button();
            this.bttLimpar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bttDesinstalar = new System.Windows.Forms.Button();
            this.bttConsole = new System.Windows.Forms.Button();
            this.bttServico = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tBCodNacional = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tBOficial = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tBServentia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cBUF = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tBCidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tBTituloPrevio = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tBTituloAuxiliar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tBPorta);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cB_Atualizacao);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cB_TipoConexao);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tB_Senha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tB_Usuario);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tB_StrConexao);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 107);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do sistema";
            // 
            // tBPorta
            // 
            this.tBPorta.Location = new System.Drawing.Point(414, 19);
            this.tBPorta.Name = "tBPorta";
            this.tBPorta.Size = new System.Drawing.Size(66, 20);
            this.tBPorta.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(373, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Porta:";
            // 
            // cB_Atualizacao
            // 
            this.cB_Atualizacao.FormattingEnabled = true;
            this.cB_Atualizacao.Items.AddRange(new object[] {
            "Preview",
            "Producao",
            "Testes"});
            this.cB_Atualizacao.Location = new System.Drawing.Point(302, 18);
            this.cB_Atualizacao.Name = "cB_Atualizacao";
            this.cB_Atualizacao.Size = new System.Drawing.Size(64, 21);
            this.cB_Atualizacao.TabIndex = 2;
            this.cB_Atualizacao.SelectedIndexChanged += new System.EventHandler(this.cB_Atualizacao_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(193, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tipo de atualização:";
            // 
            // cB_TipoConexao
            // 
            this.cB_TipoConexao.FormattingEnabled = true;
            this.cB_TipoConexao.Items.AddRange(new object[] {
            "Firebird",
            "SQLServer"});
            this.cB_TipoConexao.Location = new System.Drawing.Point(108, 19);
            this.cB_TipoConexao.Name = "cB_TipoConexao";
            this.cB_TipoConexao.Size = new System.Drawing.Size(79, 21);
            this.cB_TipoConexao.TabIndex = 1;
            this.cB_TipoConexao.SelectedIndexChanged += new System.EventHandler(this.cB_TipoConexao_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tipo de conexão:";
            // 
            // tB_Senha
            // 
            this.tB_Senha.Location = new System.Drawing.Point(298, 75);
            this.tB_Senha.Name = "tB_Senha";
            this.tB_Senha.PasswordChar = '*';
            this.tB_Senha.Size = new System.Drawing.Size(182, 20);
            this.tB_Senha.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Senha:";
            // 
            // tB_Usuario
            // 
            this.tB_Usuario.Location = new System.Drawing.Point(108, 75);
            this.tB_Usuario.Name = "tB_Usuario";
            this.tB_Usuario.Size = new System.Drawing.Size(128, 20);
            this.tB_Usuario.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuário:";
            // 
            // tB_StrConexao
            // 
            this.tB_StrConexao.Location = new System.Drawing.Point(108, 46);
            this.tB_StrConexao.Name = "tB_StrConexao";
            this.tB_StrConexao.Size = new System.Drawing.Size(372, 20);
            this.tB_StrConexao.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "String de conexão:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bttGravar);
            this.groupBox4.Controls.Add(this.bttLimpar);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Location = new System.Drawing.Point(12, 333);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(222, 57);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Configuração";
            // 
            // bttGravar
            // 
            this.bttGravar.Location = new System.Drawing.Point(6, 19);
            this.bttGravar.Name = "bttGravar";
            this.bttGravar.Size = new System.Drawing.Size(57, 23);
            this.bttGravar.TabIndex = 16;
            this.bttGravar.Text = "Gravar";
            this.bttGravar.UseVisualStyleBackColor = true;
            this.bttGravar.Click += new System.EventHandler(this.bttGravar_Click);
            // 
            // bttLimpar
            // 
            this.bttLimpar.Location = new System.Drawing.Point(69, 20);
            this.bttLimpar.Name = "bttLimpar";
            this.bttLimpar.Size = new System.Drawing.Size(53, 23);
            this.bttLimpar.TabIndex = 17;
            this.bttLimpar.Text = "Limpar";
            this.bttLimpar.UseVisualStyleBackColor = true;
            this.bttLimpar.Click += new System.EventHandler(this.bttLimpar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(128, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Cliente";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bttDesinstalar);
            this.groupBox3.Controls.Add(this.bttConsole);
            this.groupBox3.Controls.Add(this.bttServico);
            this.groupBox3.Location = new System.Drawing.Point(240, 334);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(257, 56);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Instalação";
            // 
            // bttDesinstalar
            // 
            this.bttDesinstalar.Location = new System.Drawing.Point(148, 19);
            this.bttDesinstalar.Name = "bttDesinstalar";
            this.bttDesinstalar.Size = new System.Drawing.Size(72, 23);
            this.bttDesinstalar.TabIndex = 22;
            this.bttDesinstalar.Text = "Desinstalar";
            this.bttDesinstalar.UseVisualStyleBackColor = true;
            this.bttDesinstalar.Click += new System.EventHandler(this.bttDesinstalar_Click);
            // 
            // bttConsole
            // 
            this.bttConsole.Location = new System.Drawing.Point(9, 19);
            this.bttConsole.Name = "bttConsole";
            this.bttConsole.Size = new System.Drawing.Size(59, 23);
            this.bttConsole.TabIndex = 20;
            this.bttConsole.Text = "Console";
            this.bttConsole.UseVisualStyleBackColor = true;
            this.bttConsole.Click += new System.EventHandler(this.bttConsole_Click);
            // 
            // bttServico
            // 
            this.bttServico.Location = new System.Drawing.Point(74, 19);
            this.bttServico.Name = "bttServico";
            this.bttServico.Size = new System.Drawing.Size(64, 23);
            this.bttServico.TabIndex = 21;
            this.bttServico.Text = "Serviço";
            this.bttServico.UseVisualStyleBackColor = true;
            this.bttServico.Click += new System.EventHandler(this.bttServico_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tBCodNacional);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.tBOficial);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tBServentia);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cBUF);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tBCidade);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(485, 115);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados da serventia";
            // 
            // tBCodNacional
            // 
            this.tBCodNacional.Location = new System.Drawing.Point(374, 54);
            this.tBCodNacional.Name = "tBCodNacional";
            this.tBCodNacional.Size = new System.Drawing.Size(106, 20);
            this.tBCodNacional.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(336, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "CNS:";
            // 
            // tBOficial
            // 
            this.tBOficial.Location = new System.Drawing.Point(108, 84);
            this.tBOficial.Name = "tBOficial";
            this.tBOficial.Size = new System.Drawing.Size(372, 20);
            this.tBOficial.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Nome do oficial(a):";
            // 
            // tBServentia
            // 
            this.tBServentia.Location = new System.Drawing.Point(108, 26);
            this.tBServentia.Name = "tBServentia";
            this.tBServentia.Size = new System.Drawing.Size(372, 20);
            this.tBServentia.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Nome da serventia:";
            // 
            // cBUF
            // 
            this.cBUF.FormattingEnabled = true;
            this.cBUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.cBUF.Location = new System.Drawing.Point(281, 54);
            this.cBUF.Name = "cBUF";
            this.cBUF.Size = new System.Drawing.Size(49, 21);
            this.cBUF.TabIndex = 9;
            this.cBUF.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(251, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "UF:";
            // 
            // tBCidade
            // 
            this.tBCidade.Location = new System.Drawing.Point(108, 54);
            this.tBCidade.Name = "tBCidade";
            this.tBCidade.Size = new System.Drawing.Size(128, 20);
            this.tBCidade.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cidade:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tBTituloPrevio);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.tBTituloAuxiliar);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Location = new System.Drawing.Point(12, 246);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(485, 81);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Título do relatório";
            // 
            // tBTituloPrevio
            // 
            this.tBTituloPrevio.Location = new System.Drawing.Point(108, 52);
            this.tBTituloPrevio.Name = "tBTituloPrevio";
            this.tBTituloPrevio.Size = new System.Drawing.Size(372, 20);
            this.tBTituloPrevio.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Previo:";
            // 
            // tBTituloAuxiliar
            // 
            this.tBTituloAuxiliar.Location = new System.Drawing.Point(108, 26);
            this.tBTituloAuxiliar.Name = "tBTituloAuxiliar";
            this.tBTituloAuxiliar.Size = new System.Drawing.Size(372, 20);
            this.tBTituloAuxiliar.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Auxiliar:";
            // 
            // FormDADP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 397);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(524, 436);
            this.MinimumSize = new System.Drawing.Size(524, 436);
            this.Name = "FormDADP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuração - DADP";
            this.Load += new System.EventHandler(this.FormDADP_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cB_Atualizacao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cB_TipoConexao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tB_Senha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tB_Usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tB_StrConexao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bttGravar;
        private System.Windows.Forms.Button bttLimpar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bttDesinstalar;
        private System.Windows.Forms.Button bttConsole;
        private System.Windows.Forms.Button bttServico;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cBUF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tBCidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBOficial;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tBServentia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tBTituloPrevio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tBTituloAuxiliar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tBCodNacional;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tBPorta;
        private System.Windows.Forms.Label label13;
    }
}