
namespace Configuracao
{
    partial class FormSEDIGO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSEDIGO));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBGerarSelos = new System.Windows.Forms.ComboBox();
            this.cB_Atualizacao = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cB_TipoConexao = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.label7 = new System.Windows.Forms.Label();
            this.tBHash = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tBHash);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cBGerarSelos);
            this.groupBox1.Controls.Add(this.cB_Atualizacao);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cB_TipoConexao);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tB_Senha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tB_Usuario);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tB_StrConexao);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 163);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do sistema";
            // 
            // cBGerarSelos
            // 
            this.cBGerarSelos.FormattingEnabled = true;
            this.cBGerarSelos.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cBGerarSelos.Location = new System.Drawing.Point(157, 134);
            this.cBGerarSelos.Name = "cBGerarSelos";
            this.cBGerarSelos.Size = new System.Drawing.Size(105, 21);
            this.cBGerarSelos.TabIndex = 11;
            // 
            // cB_Atualizacao
            // 
            this.cB_Atualizacao.FormattingEnabled = true;
            this.cB_Atualizacao.Items.AddRange(new object[] {
            "Preview",
            "Producao",
            "Testes"});
            this.cB_Atualizacao.Location = new System.Drawing.Point(423, 19);
            this.cB_Atualizacao.Name = "cB_Atualizacao";
            this.cB_Atualizacao.Size = new System.Drawing.Size(159, 21);
            this.cB_Atualizacao.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ambiente de atualização:";
            // 
            // cB_TipoConexao
            // 
            this.cB_TipoConexao.FormattingEnabled = true;
            this.cB_TipoConexao.Items.AddRange(new object[] {
            "Firebird",
            "SQLServer"});
            this.cB_TipoConexao.Location = new System.Drawing.Point(108, 19);
            this.cB_TipoConexao.Name = "cB_TipoConexao";
            this.cB_TipoConexao.Size = new System.Drawing.Size(154, 21);
            this.cB_TipoConexao.TabIndex = 1;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Desabilitar Geração de selos:";
            // 
            // tB_Senha
            // 
            this.tB_Senha.Location = new System.Drawing.Point(423, 75);
            this.tB_Senha.Name = "tB_Senha";
            this.tB_Senha.PasswordChar = '*';
            this.tB_Senha.Size = new System.Drawing.Size(159, 20);
            this.tB_Senha.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Senha:";
            // 
            // tB_Usuario
            // 
            this.tB_Usuario.Location = new System.Drawing.Point(108, 75);
            this.tB_Usuario.Name = "tB_Usuario";
            this.tB_Usuario.Size = new System.Drawing.Size(154, 20);
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
            this.tB_StrConexao.Size = new System.Drawing.Size(474, 20);
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
            this.groupBox4.Location = new System.Drawing.Point(294, 182);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(129, 106);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Configuração";
            // 
            // bttGravar
            // 
            this.bttGravar.Location = new System.Drawing.Point(6, 19);
            this.bttGravar.Name = "bttGravar";
            this.bttGravar.Size = new System.Drawing.Size(114, 23);
            this.bttGravar.TabIndex = 9;
            this.bttGravar.Text = "Gravar";
            this.bttGravar.UseVisualStyleBackColor = true;
            this.bttGravar.Click += new System.EventHandler(this.bttGravar_Click);
            // 
            // bttLimpar
            // 
            this.bttLimpar.Location = new System.Drawing.Point(6, 48);
            this.bttLimpar.Name = "bttLimpar";
            this.bttLimpar.Size = new System.Drawing.Size(114, 23);
            this.bttLimpar.TabIndex = 10;
            this.bttLimpar.Text = "Limpar";
            this.bttLimpar.UseVisualStyleBackColor = true;
            this.bttLimpar.Click += new System.EventHandler(this.bttLimpar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Iniciar sistema";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bttDesinstalar);
            this.groupBox3.Controls.Add(this.bttConsole);
            this.groupBox3.Controls.Add(this.bttServico);
            this.groupBox3.Location = new System.Drawing.Point(435, 182);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(135, 105);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Instalação";
            // 
            // bttDesinstalar
            // 
            this.bttDesinstalar.Location = new System.Drawing.Point(9, 77);
            this.bttDesinstalar.Name = "bttDesinstalar";
            this.bttDesinstalar.Size = new System.Drawing.Size(114, 23);
            this.bttDesinstalar.TabIndex = 14;
            this.bttDesinstalar.Text = "Desinstalar serviço";
            this.bttDesinstalar.UseVisualStyleBackColor = true;
            this.bttDesinstalar.Click += new System.EventHandler(this.bttDesinstalar_Click);
            // 
            // bttConsole
            // 
            this.bttConsole.Location = new System.Drawing.Point(9, 19);
            this.bttConsole.Name = "bttConsole";
            this.bttConsole.Size = new System.Drawing.Size(114, 23);
            this.bttConsole.TabIndex = 12;
            this.bttConsole.Text = "Iniciar console";
            this.bttConsole.UseVisualStyleBackColor = true;
            this.bttConsole.Click += new System.EventHandler(this.bttConsole_Click);
            // 
            // bttServico
            // 
            this.bttServico.Location = new System.Drawing.Point(9, 48);
            this.bttServico.Name = "bttServico";
            this.bttServico.Size = new System.Drawing.Size(114, 23);
            this.bttServico.TabIndex = 13;
            this.bttServico.Text = "Serviço";
            this.bttServico.UseVisualStyleBackColor = true;
            this.bttServico.Click += new System.EventHandler(this.bttServico_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Hash do cartório:";
            // 
            // tBHash
            // 
            this.tBHash.Location = new System.Drawing.Point(108, 104);
            this.tBHash.Name = "tBHash";
            this.tBHash.Size = new System.Drawing.Size(474, 20);
            this.tBHash.TabIndex = 13;
            // 
            // FormSEDIGO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 296);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(631, 335);
            this.Name = "FormSEDIGO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuração SEDI-GO";
            this.Load += new System.EventHandler(this.FormSEDIGO_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cB_TipoConexao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tB_Senha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tB_Usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tB_StrConexao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBGerarSelos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bttGravar;
        private System.Windows.Forms.Button bttLimpar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bttDesinstalar;
        private System.Windows.Forms.Button bttConsole;
        private System.Windows.Forms.Button bttServico;
        private System.Windows.Forms.ComboBox cB_Atualizacao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBHash;
        private System.Windows.Forms.Label label7;
    }
}