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
    public partial class FormCIP : Form
    {
        public ManipularXML ler = new ManipularXML();
        public CIP cip = new CIP();

        public FormCIP()
        {
            InitializeComponent();
        }

        private void FormCIP_Load(object sender, EventArgs e)
        {
            this.CarregarInformacoes();
        }

        public void CarregarInformacoes()
        {
            ler.GetDados(cip);
            this.cB_TipoConexao.SelectedIndex = 0;
            this.cB_Atualizacao.SelectedIndex = ler.AmbAtualizacao(cip.AmbienteDeAtualizacao);
            this.tB_StrConexao.Text = cip.SqlHost;
            this.tB_nomeDB.Text = cip.SqlDataBase;
            this.tB_Senha.Text = cip.Senha;
            this.tB_Usuario.Text = cip.Usuario;
        }

        private void bttLimpar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja apagar a configuração atual?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                this.cB_TipoConexao.SelectedIndex = 0;
                this.cB_Atualizacao.SelectedIndex = 0;
                this.tB_StrConexao.Text = "";
                this.tB_nomeDB.Text = "";
                this.tB_Senha.Text = "";
                this.tB_Usuario.Text = "";
            }
        }

        private void bttGravar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja salvar a configuração?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            cip.Usuario = this.tB_Usuario.Text;
            cip.Senha = this.tB_Senha.Text;
            cip.SqlDataBase = this.tB_nomeDB.Text;
            cip.SqlHost = this.tB_StrConexao.Text;
            cip.AmbienteDeAtualizacao = this.cB_Atualizacao.Text;

            if (dr == DialogResult.Yes)
                ler.GravarDados(cip);
        }

        private void button3_Click(object sender, EventArgs e)
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
                    System.Diagnostics.Process.Start(@"CIP.Console.exe");
                    break;
                case 2:
                    System.Diagnostics.Process.Start(@"Instalar.bat");
                    break;
                case 3:
                    System.Diagnostics.Process.Start(@"Desinstalar.bat");
                    break;
                case 4:
                    System.Diagnostics.Process.Start(@"..\Cliente\CIP.exe");
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
    }
}
