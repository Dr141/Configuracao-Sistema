using Configuracao.IO;
using Configuracao.Modelos;
using System;
using System.Windows.Forms;

namespace Configuracao
{
    public partial class FormSEDIGO : Form
    {
        SEDI_GO SEDI = new SEDI_GO();
        ManipularXML ler = new ManipularXML();

        public FormSEDIGO()
        {
            InitializeComponent();
        }

        private void FormSEDIGO_Load(object sender, EventArgs e)
        {
            this.CarregarInformacao();
        }

        public void CarregarInformacao()
        {
            ler.GetDados(SEDI);

            this.tB_StrConexao.Text = SEDI.ConexaoBanco;
            this.tB_Usuario.Text = SEDI.UsuarioBanco;
            this.tB_Senha.Text = SEDI.SenhaBanco;
            this.tBHash.Text = SEDI.HashDoCartorio;
            this.cB_TipoConexao.SelectedIndex = int.Parse(SEDI.TipoDeConexao);
            this.cB_Atualizacao.SelectedIndex = ler.AmbAtualizacao(SEDI.AmbienteAtualizacao);
            this.cBGerarSelos.SelectedIndex = SEDI.GeraSelo();
        }

        private void bttLimpar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja apagar a configuração atual?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                this.cB_TipoConexao.SelectedIndex = -1;
                this.cB_Atualizacao.SelectedIndex = -1;
                this.tB_StrConexao.Text = "";
                this.tB_Usuario.Text = "";
                this.tB_Senha.Text = "";
                this.tBHash.Text = "";
                this.cBGerarSelos.SelectedIndex = -1;
            }
        }

        public void iniciarSistema(int i)
        {
            switch (i)
            {
                case 1:
                    System.Diagnostics.Process.Start(@"SeloDigital.GO.Console.exe");
                    break;
                case 2:
                    System.Diagnostics.Process.Start(@"Instalar.bat");
                    break;
                case 3:
                    System.Diagnostics.Process.Start(@"Desinstalar.bat");
                    break;
                case 4:
                    System.Diagnostics.Process.Start(@"..\Cliente\SeloDigitalGO.exe");
                    break;
            }
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

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja iniciar o cliente?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
                this.iniciarSistema(4);
        }

        private void bttGravar_Click(object sender, EventArgs e)
        {
            SEDI.ConexaoBanco = this.tB_StrConexao.Text;
            SEDI.UsuarioBanco = this.tB_Usuario.Text;
            SEDI.SenhaBanco = this.tB_Senha.Text;
            SEDI.HashDoCartorio = this.tBHash.Text;
            SEDI.AmbienteAtualizacao = this.cB_Atualizacao.Text;
            SEDI.TipoDeConexao = this.cB_TipoConexao.SelectedIndex.ToString();
            SEDI.DesabilitarGeracaoDeSelos = this.cBGerarSelos.Text;

            DialogResult dr = MessageBox.Show("Deseja salvar a configuração?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
                ler.GravarDados(SEDI);
        }
    }
}
