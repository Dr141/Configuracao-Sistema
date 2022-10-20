using Configuracao.IO;
using Configuracao.Modelos;
using System.Windows.Forms;

namespace Configuracao.Templates
{
    public partial class FormPrincipal : Form
    {
        private string caminhoArquivo { get; set; }
        public ManipularXML ler = new ManipularXML();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void buttCIP_MouseClick(object sender, MouseEventArgs e)
        {
            SelecionarArquivo();
            CIP cip = new CIP();
            ler.GetDados(cip, caminhoArquivo);
        }

        private void SelecionarArquivo()
        {
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "Selecionar config";

            openFileDialog.InitialDirectory = @"";

            openFileDialog.Filter = "(*.config)|*.config";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            DialogResult dr = this.openFileDialog.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                caminhoArquivo  = openFileDialog.FileName;
            }
        }

        private void buttDADP_MouseClick(object sender, MouseEventArgs e)
        {
            SelecionarArquivo();            
        }

        private void buttLauncher_MouseClick(object sender, MouseEventArgs e)
        {
            SelecionarArquivo();
        }

        private void buttP88_MouseClick(object sender, MouseEventArgs e)
        {
            SelecionarArquivo();
        }

        private void buttSEDIGO_MouseClick(object sender, MouseEventArgs e)
        {
            SelecionarArquivo();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            SelecionarArquivo();
        }
    }
}
