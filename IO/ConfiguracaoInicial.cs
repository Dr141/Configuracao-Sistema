using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Configuracao.IO
{
    public class ConfiguracaoInicial
    {
        public void ConfiguracaoServidor(XmlDocument xml, string nomeArquivo)
        {
            try
            {
                xml.Save(nomeArquivo);
            }
            catch(Exception e)
            {
                MessageBox.Show("Erro ao criar o arquivo .config. " + e.Message);
            }            
        }

        public void ConfiguracaoCliente(XmlDocument xml, string nomeArquivo)
        {
            try
            {
                xml.Save(nomeArquivo);
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao criar o arquivo .config. " + e.Message);
            }
        }
    }
}
