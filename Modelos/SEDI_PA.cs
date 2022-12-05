using Configuracao.IO;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace Configuracao.Modelos
{
    public class SEDI_PA : Criptografia
    {
        public string ConexaoBanco { get; set; }
        public string UsuarioBanco { get; set; }
        public string SenhaBanco { get; set; }
        public string TipoDeConexao { get; set; }
        public string AmbienteProducao { get; set; }
        public string AmbienteAtualizacao { get; set; }
        public string AmbienteProducaoTJPA { get; set; }
        public string Token { get; set; }
        public string CaminhoArquivoXml { get; set; }
        public string ValidarRequisicaoGeracaoDeSelos { get; set; }

        public SEDI_PA() 
        {
            ConfiguracaoInicial config = new ConfiguracaoInicial();

            if (!File.Exists("Configuracoes.config") && Directory.Exists(@"Servidor"))
            {
                config.ConfiguracaoServidor(ConfigPadraoServidor(), "Configuracoes.config");
            }

            if (!File.Exists(@"..\Cliente\Configuracoes.config") && Directory.Exists(@"..\Cliente"))
            {
                config.ConfiguracaoCliente(ConfigPadraoCliente(), @"..\Cliente\Configuracoes.config");
            }
        }

        private XmlDocument ConfigPadraoCliente()
        {
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(
                                "<?xml version='1.0' encoding='utf-8'?>" +
                                "<configuration>" +
                                "<SeloPA>" +
                                "<IpServidor value='575B564B6241445B41'/>" +
                                "<CaminhoArquivoXml value='3A392B3D0E2E230511081318071A1BEF11203C0EE40310EFE1EF112DDEABC6'/>" +
                                "</SeloPA>" +
                                "</configuration>"
                            );
            return xml;
        }

        private XmlDocument ConfigPadraoServidor()
        {
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(
                                "<?xml version ='1.0' encoding ='utf-8'?>" +
                                "<configuration>" +
                                "<SeloDigitalPA>" +
                                "<ConexaoBanco value='272539361D23363A4D39293E2C1F20C230485153B1594EA4BFBF4D51D0D4D4D32BD8'/>" +
                                "<UsuarioBanco value='0E050717350A140735'/>" +
                                "<SenhaBanco value='0E050717350A1407350A1F3B'/>" +
                                "<TipoDeConexao value='57'/>" +
                                "<AmbienteProducao value='03001411'/>" +
                                "<AmbienteAtualizacao value='0914051036000139'/>" +
                                "<AmbienteProducaoTJPA value='03001411'/>" +
                                "<Token value='02135201310A1151144F1E4A433B10B0165E054AE54353E8BFEF4841BBA4E7B30BEDB8BC'/>" +
                                "<CaminhoArquivoXml value='3A392B3D0E2E230511081318071A1BEF11203C0EE40310EFE1EF112DDEABC6'/>" +
                                "<ValidarRequisicaoGeracaoDeSelos value='03001411'/>" +
                                "</SeloDigitalPA>" +
                                "</configuration>"
                            );
            return xml;
        }

        public void Map(XElement XML)
        {
            AmbienteAtualizacao = DecriptografarNormal(XML.Descendants("AmbienteAtualizacao").First().LastAttribute.Value);
            ConexaoBanco = DecriptografarNormal(XML.Descendants("ConexaoBanco").First().LastAttribute.Value);
            UsuarioBanco = DecriptografarNormal(XML.Descendants("UsuarioBanco").First().LastAttribute.Value);
            SenhaBanco = DecriptografarNormal(XML.Descendants("SenhaBanco").First().LastAttribute.Value);
            TipoDeConexao = DecriptografarNormal(XML.Descendants("TipoDeConexao").First().LastAttribute.Value);
            AmbienteProducao = DecriptografarNormal(XML.Descendants("AmbienteProducao").First().LastAttribute.Value);
            AmbienteProducaoTJPA = DecriptografarNormal(XML.Descendants("AmbienteProducaoTJPA").First().LastAttribute.Value);
            Token = DecriptografarNormal(XML.Descendants("Token").First().LastAttribute.Value);
            CaminhoArquivoXml = DecriptografarNormal(XML.Descendants("CaminhoArquivoXml").First().LastAttribute.Value);
            ValidarRequisicaoGeracaoDeSelos = DecriptografarNormal(XML.Descendants("ValidarRequisicaoGeracaoDeSelos").First().LastAttribute.Value);
        }

        public void Atualizar(XElement XML)
        {
            XML.Descendants("AmbienteAtualizacao").First().LastAttribute.Value = CriptografarNormal(AmbienteAtualizacao);
            XML.Descendants("ConexaoBanco").First().LastAttribute.Value = CriptografarNormal(ConexaoBanco);
            XML.Descendants("UsuarioBanco").First().LastAttribute.Value = CriptografarNormal(UsuarioBanco);
            XML.Descendants("SenhaBanco").First().LastAttribute.Value = CriptografarNormal(SenhaBanco);
            XML.Descendants("TipoDeConexao").First().LastAttribute.Value = CriptografarNormal(TipoDeConexao);
            XML.Descendants("AmbienteProducao").First().LastAttribute.Value = CriptografarNormal(AmbienteProducao);
            XML.Descendants("AmbienteProducaoTJPA").First().LastAttribute.Value = CriptografarNormal(AmbienteProducaoTJPA);
            XML.Descendants("Token").First().LastAttribute.Value = CriptografarNormal(Token);
            XML.Descendants("CaminhoArquivoXml").First().LastAttribute.Value = CriptografarNormal(CaminhoArquivoXml);
            XML.Descendants("ValidarRequisicaoGeracaoDeSelos").First().LastAttribute.Value = CriptografarNormal(ValidarRequisicaoGeracaoDeSelos);
        }
    }
}
