using Configuracao.IO;
using Configuracao.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Configuracao
{
    public partial class FormP88 : Form
    {
        public Provimento88 provimento88 = new Provimento88();
        public ManipularXML ler = new ManipularXML();
        public FormP88()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            this.carregarInformacoes();
        }

        private void cB_TipoConexao_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.cB_TipoConexao.SelectedIndex)
            {
                case 0:
                    //tB_StrConexao.
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja apagar a configuração atual?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                this.cB_TipoConexao.SelectedIndex = -1;
                this.cB_Atualizacao.SelectedIndex = -1;
                this.tB_StrConexao.Text = "";
                this.tB_Usuario.Text = "";
                this.tB_Senha.Text = "";
                this.tB_UrlComunicacao.Text = "";
                this.tB_Usuario_SisCoaf.Text = "";
                this.tB_Senha_SisCoaf.Text = "";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            provimento88.ConexaoBanco = this.tB_StrConexao.Text;
            provimento88.UsuarioBanco = this.tB_Usuario.Text;
            provimento88.SenhaBanco = this.tB_Senha.Text;
            provimento88.UrlDeComunicacao = this.tB_UrlComunicacao.Text;
            provimento88.UsuarioSisCoaf = this.tB_Usuario_SisCoaf.Text;
            provimento88.SenhaSisCoaf = this.tB_Senha_SisCoaf.Text;
            provimento88.AmbienteAtualizacao = this.cB_Atualizacao.Text;
            provimento88.TipoDeConexao = this.cB_TipoConexao.SelectedIndex.ToString();
            provimento88.EnderecoSevico = this.tBEnderecoServico.Text;

            DialogResult dr = MessageBox.Show("Deseja salvar a configuração?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
                ler.GravarDados(provimento88);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja iniciar o console?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(dr == DialogResult.Yes)
                this.iniciarSistema(1);            
        }

        public void iniciarSistema(int i)
        {
            switch (i)
            {
                case 1:
                    System.Diagnostics.Process.Start(@"P88.Console.exe");
                    break;
                case 2:
                    System.Diagnostics.Process.Start(@"Instalar.bat");
                    break;
                case 3:
                    System.Diagnostics.Process.Start(@"Desinstalar.bat");
                    break;
                case 4:
                    System.Diagnostics.Process.Start(@"P88.Console.exe");
                    break;
                case 5:
                    System.Diagnostics.Process.Start(@"..\Cliente\P88.exe");
                    break;
            }
        }

        private void bttServico_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja iniciar a instalação do serviço?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
                this.iniciarSistema(2);
        }

        private void bttDesinstalar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja iniciar a desinstalação do serviço?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
                this.iniciarSistema(3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja iniciar o cliente?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
                this.iniciarSistema(5);
        }

        public void carregarInformacoes()
        {
            ler.GetDados(this.provimento88);
            this.cB_TipoConexao.SelectedIndex = int.Parse(provimento88.TipoDeConexao);
            this.cB_Atualizacao.SelectedIndex = ler.AmbAtualizacao(provimento88.AmbienteAtualizacao);
            this.tB_StrConexao.Text = provimento88.ConexaoBanco;
            this.tB_Usuario.Text = provimento88.UsuarioBanco;
            this.tB_Senha.Text = provimento88.SenhaBanco;
            this.tB_UrlComunicacao.Text = provimento88.UrlDeComunicacao;
            this.tB_Usuario_SisCoaf.Text = provimento88.UsuarioSisCoaf;
            this.tB_Senha_SisCoaf.Text = provimento88.SenhaSisCoaf;

            if (provimento88.EnderecoSevico != string.Empty)
                this.tBEnderecoServico.Text = provimento88.EnderecoSevico;
            else
                this.tBEnderecoServico.Text = "127.0.0.1";
        }
    }
}
