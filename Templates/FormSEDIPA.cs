using Configuracao.IO;
using Configuracao.Modelos;
using System;
using System.Windows.Forms;

namespace Configuracao.Templates
{
    public partial class FormSEDIPA : Form
    {
        public SEDI_PA PA = new SEDI_PA();
        public ManipularXML ler = new ManipularXML();

        public FormSEDIPA()
        {
            InitializeComponent();
        }

        private void FormSEDIPA_Load(object sender, EventArgs e)
        {
            this.CarregarInformacoes();
        }

        private void CarregarInformacoes()
        {
            ler.GetDados(PA);

            tB_StrConexao.Text = PA.ConexaoBanco;
            cB_TipoConexao.SelectedIndex = validacao(PA.TipoDeConexao);
            cB_Atualizacao.SelectedIndex = ler.AmbAtualizacao(PA.AmbienteAtualizacao);
            tB_Usuario.Text = PA.UsuarioBanco;
            tB_Senha.Text = PA.SenhaBanco;
            cBProducao.SelectedIndex = validacao(PA.AmbienteProducao);
            cBProducaoTJPA.SelectedIndex = validacao(PA.AmbienteProducaoTJPA);
            tBToken.Text = PA.Token;
            tBCaminhoXML.Text = PA.CaminhoArquivoXml;
            cBValidacao.SelectedIndex = validacao(PA.ValidarRequisicaoGeracaoDeSelos);
        }

        private int validacao(string str)
        {
            switch (str.ToUpper())
            {
                case "TRUE":
                    return 0;
                case "FALSE":
                    return 1;
                default :
                    return -1;
            }
        }

        private string validacao(int str)
        {
            switch (str)
            {
                case 0:
                    return "TRUE";
                case 1:
                    return "FALSE";
                default:
                    return null;
            }
        }

        private void bttGravar_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja salvar a configuração?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            PA.ConexaoBanco = tB_StrConexao.Text;
            PA.TipoDeConexao = validacao(cB_TipoConexao.SelectedIndex);
            PA.AmbienteAtualizacao = cB_Atualizacao.Text;
            PA.UsuarioBanco = tB_Usuario.Text;
            PA.SenhaBanco = tB_Senha.Text;
            PA.AmbienteProducao = validacao(cBProducao.SelectedIndex);
            PA.AmbienteProducaoTJPA = validacao(cBProducaoTJPA.SelectedIndex);
            PA.Token = tBToken.Text;
            PA.CaminhoArquivoXml = tBCaminhoXML.Text;
            PA.ValidarRequisicaoGeracaoDeSelos = validacao(cBValidacao.SelectedIndex);

            if (dr == DialogResult.Yes)
                ler.GravarDados(PA);
        }

        private void bttLimpar_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja apagar a configuração atual?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                tB_StrConexao.Text = "";
                cB_TipoConexao.SelectedIndex = -1;
                cB_Atualizacao.SelectedIndex = -1;
                tB_Usuario.Text = "";
                tB_Senha.Text = "";
                cBProducao.SelectedIndex = -1;
                cBProducaoTJPA.SelectedIndex = -1;
                tBToken.Text = "";
                tBCaminhoXML.Text = "";
                cBValidacao.SelectedIndex = -1;
            }
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja iniciar o cliente?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
                this.iniciarSistema(4);
        }

        public void iniciarSistema(int i)
        {
            switch (i)
            {
                case 1:
                    System.Diagnostics.Process.Start(@"SeloDigital.PA.Console.exe");
                    break;
                case 2:
                    System.Diagnostics.Process.Start(@"Instalar.bat");
                    break;
                case 3:
                    System.Diagnostics.Process.Start(@"Desinstalar.bat");
                    break;
                case 4:
                    System.Diagnostics.Process.Start(@"..\Cliente\SeloDigitalPA.exe");
                    break;
            }
        }

        private void bttConsole_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja iniciar o console?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
                this.iniciarSistema(1);
        }

        private void bttServico_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja iniciar a instalação do serviço?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
                this.iniciarSistema(2);
        }

        private void bttDesinstalar_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja iniciar a desinstalação do serviço?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
                this.iniciarSistema(3);
        }
    }
}
