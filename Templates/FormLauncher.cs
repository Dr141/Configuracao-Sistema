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
    public partial class FormLauncher : Form
    {
        public Launcher launcher = new Launcher();
        public ManipularXML ler = new ManipularXML();

        public FormLauncher()
        {
            InitializeComponent();
        }

        private void cB_TipoConexao_SelectedIndexChanged(object sender, EventArgs e)
        {
            cBGerarSelos.SelectedIndex = cB_TipoConexao.SelectedIndex;
            launcher.SqlDatabase = "Launcher";

            if (cB_TipoConexao.SelectedIndex == 0)
            {
                groupBox2.Visible = true;
                tB_caminho.Text = @"D:\Engegraph\DB";
            }
            else
            {
                groupBox2.Visible = false;
            }
        }

        private void FormLauncher_Load(object sender, EventArgs e)
        {
            this.CarregarInformacoes();
        }

        public void CarregarInformacoes()
        {
            ler.GetDados(launcher);
            cB_TipoConexao.SelectedIndex = Convert.ToInt32(launcher.TipoSgbd);
            tB_StrConexao.Text = launcher.SqlHost;
            tB_Usuario.Text = launcher.Usuario;
            tB_Senha.Text = launcher.Senha;
            cB_Atualizacao.SelectedIndex = ler.AmbAtualizacao(launcher.AmbienteAtualizacao);
        }

        public void iniciarSistema(int i)
        {
            switch (i)
            {
                case 1:
                    System.Diagnostics.Process.Start(@"Launcher.Console.exe");
                    break;
                case 2:
                    System.Diagnostics.Process.Start(@"Instalar.bat");
                    break;
                case 3:
                    System.Diagnostics.Process.Start(@"Desinstalar.bat");
                    break;
                case 4:
                    System.Diagnostics.Process.Start(@"..\Cliente\Launcher.exe");
                    break;
            }
        }

        private void bttGravar_Click(object sender, EventArgs e)
        {
            if (cB_TipoConexao.SelectedIndex == 0)
            {
                launcher.SqlDatabase = tB_caminho.Text + @"\" + cBGerarSelos.Text;
            }

            launcher.SqlHost = this.tB_StrConexao.Text;
            launcher.Usuario = this.tB_Usuario.Text;
            launcher.Senha = this.tB_Senha.Text;
            launcher.AmbienteAtualizacao = this.cB_Atualizacao.Text;
            launcher.TipoSgbd = this.cB_TipoConexao.SelectedIndex.ToString();

            DialogResult dr = MessageBox.Show("Deseja salvar a configuração?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
                ler.GravarDados(launcher);
        }

        private void bttLimpar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja apagar a configuração atual?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                this.tB_Usuario.Text = "";
                this.tB_Senha.Text = "";
                this.tB_StrConexao.Text = "";
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
    }
}
