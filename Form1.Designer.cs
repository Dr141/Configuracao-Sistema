
namespace Configuracao
{
    partial class FormP88
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormP88));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tBEnderecoServico = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cB_Atualizacao = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cB_TipoConexao = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tB_UrlComunicacao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tB_Senha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tB_Usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tB_StrConexao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tB_Senha_SisCoaf = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tB_Usuario_SisCoaf = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bttGravar = new System.Windows.Forms.Button();
            this.bttLimpar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bttConsole = new System.Windows.Forms.Button();
            this.bttServico = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bttDesinstalar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tBEnderecoServico);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cB_Atualizacao);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cB_TipoConexao);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tB_UrlComunicacao);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tB_Senha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tB_Usuario);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tB_StrConexao);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do sistema";
            // 
            // tBEnderecoServico
            // 
            this.tBEnderecoServico.Location = new System.Drawing.Point(156, 137);
            this.tBEnderecoServico.Name = "tBEnderecoServico";
            this.tBEnderecoServico.Size = new System.Drawing.Size(115, 20);
            this.tBEnderecoServico.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Endereço de IP servidor CIP:";
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
            "SQLServer",
            "SQLCE"});
            this.cB_TipoConexao.Location = new System.Drawing.Point(108, 19);
            this.cB_TipoConexao.Name = "cB_TipoConexao";
            this.cB_TipoConexao.Size = new System.Drawing.Size(154, 21);
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
            // tB_UrlComunicacao
            // 
            this.tB_UrlComunicacao.Location = new System.Drawing.Point(108, 106);
            this.tB_UrlComunicacao.Name = "tB_UrlComunicacao";
            this.tB_UrlComunicacao.Size = new System.Drawing.Size(651, 20);
            this.tB_UrlComunicacao.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Url de comunicação:";
            // 
            // tB_Senha
            // 
            this.tB_Senha.Location = new System.Drawing.Point(462, 75);
            this.tB_Senha.Name = "tB_Senha";
            this.tB_Senha.PasswordChar = '*';
            this.tB_Senha.Size = new System.Drawing.Size(297, 20);
            this.tB_Senha.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Senha:";
            // 
            // tB_Usuario
            // 
            this.tB_Usuario.Location = new System.Drawing.Point(108, 75);
            this.tB_Usuario.Name = "tB_Usuario";
            this.tB_Usuario.Size = new System.Drawing.Size(297, 20);
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
            this.tB_StrConexao.Size = new System.Drawing.Size(651, 20);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tB_Senha_SisCoaf);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tB_Usuario_SisCoaf);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(472, 105);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados SisCoaf";
            // 
            // tB_Senha_SisCoaf
            // 
            this.tB_Senha_SisCoaf.Location = new System.Drawing.Point(108, 62);
            this.tB_Senha_SisCoaf.Name = "tB_Senha_SisCoaf";
            this.tB_Senha_SisCoaf.PasswordChar = '*';
            this.tB_Senha_SisCoaf.Size = new System.Drawing.Size(336, 20);
            this.tB_Senha_SisCoaf.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Senha:";
            // 
            // tB_Usuario_SisCoaf
            // 
            this.tB_Usuario_SisCoaf.Location = new System.Drawing.Point(108, 28);
            this.tB_Usuario_SisCoaf.Name = "tB_Usuario_SisCoaf";
            this.tB_Usuario_SisCoaf.Size = new System.Drawing.Size(336, 20);
            this.tB_Usuario_SisCoaf.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Usuário:";
            // 
            // bttGravar
            // 
            this.bttGravar.Location = new System.Drawing.Point(6, 19);
            this.bttGravar.Name = "bttGravar";
            this.bttGravar.Size = new System.Drawing.Size(114, 23);
            this.bttGravar.TabIndex = 9;
            this.bttGravar.Text = "Gravar";
            this.bttGravar.UseVisualStyleBackColor = true;
            this.bttGravar.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttLimpar
            // 
            this.bttLimpar.Location = new System.Drawing.Point(6, 48);
            this.bttLimpar.Name = "bttLimpar";
            this.bttLimpar.Size = new System.Drawing.Size(114, 23);
            this.bttLimpar.TabIndex = 10;
            this.bttLimpar.Text = "Limpar";
            this.bttLimpar.UseVisualStyleBackColor = true;
            this.bttLimpar.Click += new System.EventHandler(this.button2_Click);
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
            // bttConsole
            // 
            this.bttConsole.Location = new System.Drawing.Point(9, 19);
            this.bttConsole.Name = "bttConsole";
            this.bttConsole.Size = new System.Drawing.Size(114, 23);
            this.bttConsole.TabIndex = 12;
            this.bttConsole.Text = "Iniciar console";
            this.bttConsole.UseVisualStyleBackColor = true;
            this.bttConsole.Click += new System.EventHandler(this.button4_Click);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bttDesinstalar);
            this.groupBox3.Controls.Add(this.bttConsole);
            this.groupBox3.Controls.Add(this.bttServico);
            this.groupBox3.Location = new System.Drawing.Point(653, 188);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(135, 105);
            this.groupBox3.TabIndex = 15;
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bttGravar);
            this.groupBox4.Controls.Add(this.bttLimpar);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Location = new System.Drawing.Point(501, 187);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(129, 106);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Configuração";
            // 
            // FormP88
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 301);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 340);
            this.Name = "FormP88";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuração";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tB_Senha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tB_Usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tB_StrConexao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tB_UrlComunicacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cB_Atualizacao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cB_TipoConexao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tB_Senha_SisCoaf;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tB_Usuario_SisCoaf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bttGravar;
        private System.Windows.Forms.Button bttLimpar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tBEnderecoServico;
        private System.Windows.Forms.Button bttConsole;
        private System.Windows.Forms.Button bttServico;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bttDesinstalar;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

