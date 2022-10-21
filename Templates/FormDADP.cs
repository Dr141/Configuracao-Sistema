using Configuracao.IO;
using Configuracao.Modelos;
using System;
using System.Windows.Forms;

namespace Configuracao
{
    public partial class FormDADP : Form
    {
        DADP dadp = new DADP();
        ManipularXML ler = new ManipularXML();
        public FormDADP(string caminho = null)
        {
            if (caminho != null)
                ler.caminhoArquivo = caminho;

            InitializeComponent();
        }

        private void FormDADP_Load(object sender, EventArgs e)
        {
            if (ler.caminhoArquivo == null)
                ler.GetDados(dadp);
            else
                ler.GetDados(dadp, ler.caminhoArquivo);

            this.HabilitarCodNascional();
            this.HabilitarPorta();
            this.CarregarInformacao();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.HabilitarCodNascional();
        }


        public void HabilitarCodNascional()
        {
            if (this.cBUF.Text == "MA")
            {
                this.label12.Visible = true;
                this.tBCodNacional.Visible = true;
            }
            else
            {
                this.label12.Visible = false;
                this.tBCodNacional.Visible = false;
            }
        }

        private void cB_TipoConexao_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.HabilitarPorta();
        }

        public void HabilitarPorta()
        {
            if (this.cB_TipoConexao.SelectedIndex == 0)
            {
                this.label13.Visible = true;
                this.tBPorta.Visible = true;
                this.tBPorta.Text = "3050";
            }
            else
            {
                this.label13.Visible = false;
                this.tBPorta.Visible = false;
                this.tBPorta.Text = "";
            }
        }

        public void CarregarInformacao()
        {
            this.tBPorta.Text = dadp.Porta;
            this.tB_StrConexao.Text = dadp.ConexaoBanco;
            this.tB_Usuario.Text = dadp.UsuarioBanco;
            this.tB_Senha.Text = dadp.SenhaBanco;
            this.tBServentia.Text = dadp.NomeCartorio;
            this.tBCidade.Text = dadp.Cidade;
            this.cBUF.SelectedItem = dadp.Uf;
            this.tBCodNacional.Text = dadp.CodNacional;
            this.tBOficial.Text = dadp.NomeOficial;
            this.tBTituloAuxiliar.Text = dadp.TituloRelatorioAuxiliar;
            this.tBTituloPrevio.Text = dadp.TituloRelatorioPrevio;
            this.cB_TipoConexao.SelectedIndex = int.Parse(dadp.TipoDeConexao);
            this.cB_Atualizacao.SelectedIndex = ler.AmbAtualizacao(dadp.AmbienteDeAtualizacao);
        }

        public void GravarInformações()
        {
            dadp.Porta = this.tBPorta.Text;
            dadp.ConexaoBanco = this.tB_StrConexao.Text;
            dadp.UsuarioBanco = this.tB_Usuario.Text;
            dadp.SenhaBanco = this.tB_Senha.Text;
            dadp.NomeCartorio = this.tBServentia.Text;
            dadp.Cidade = this.tBCidade.Text;
            dadp.Uf = this.cBUF.Text;
            dadp.CodNacional = this.tBCodNacional.Text;
            dadp.NomeOficial = this.tBOficial.Text;
            dadp.TituloRelatorioAuxiliar = this.tBTituloAuxiliar.Text;
            dadp.TituloRelatorioPrevio = this.tBTituloPrevio.Text;
            dadp.TipoDeConexao = this.cB_TipoConexao.SelectedIndex.ToString();
        }

        private void bttGravar_Click(object sender, EventArgs e)
        {
            this.GravarInformações();
            DialogResult dr = MessageBox.Show("Deseja salvar a configuração?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
                if (ler.caminhoArquivo == null)
                    ler.GravarDados(dadp);
                else
                    ler.GravarDados(dadp, ler.caminhoArquivo);
        }

        private void bttLimpar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja apagar a configuração atual?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                this.tBPorta.Text = "";
                this.tB_StrConexao.Text = "";
                this.tB_Usuario.Text = "";
                this.tB_Senha.Text = "";
                this.tBServentia.Text = "";
                this.tBCidade.Text = "";
                this.cBUF.SelectedIndex = -1;
                this.tBCodNacional.Text = "";
                this.tBOficial.Text = "";
                this.tBTituloAuxiliar.Text = "";
                this.tBTituloPrevio.Text = "";
                this.cB_TipoConexao.SelectedIndex = -1;
                this.cB_Atualizacao.SelectedIndex = -1;
            }
        }

        public void iniciarSistema(int i)
        {
            switch (i)
            {
                case 1:
                    System.Diagnostics.Process.Start(@"Dadp.Servidor.Console.exe");
                    break;
                case 2:
                    System.Diagnostics.Process.Start(@"Instalar.bat");
                    break;
                case 3:
                    System.Diagnostics.Process.Start(@"Desinstalar.bat");
                    break;
                case 4:
                    System.Diagnostics.Process.Start(@"..\Cliente\Dadp.exe");
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja iniciar o cliente?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
                this.iniciarSistema(4);
        }

        private void bttConsole_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja iniciar o console?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
                this.iniciarSistema(1);
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

        private void cB_Atualizacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            dadp.AmbienteDeAtualizacao = cB_Atualizacao.Text;
        }
    }
}
