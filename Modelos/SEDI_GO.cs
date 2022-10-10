using Configuracao.IO;
using System.IO;
using System.Xml;

namespace Configuracao.Modelos
{
    public class SEDI_GO
    {
        public string ConexaoBanco { get; set; }
        public string UsuarioBanco { get; set; }
        public string SenhaBanco { get; set; }
        public string Token { get; set; }
        public string CodigoCartorio { get; set; }
        public string ChaveSegurancaCartorio { get; set; }
        public string HashDoCartorio { get; set; }
        public string AmbienteProducao { get; set; }
        public string TipoDeConexao { get; set; }
        public string DesabilitarGeracaoDeSelos { get; set; }
        public string AmbienteAtualizacao { get; set; }

        public SEDI_GO()
        {
            ConfiguracaoInicial config = new ConfiguracaoInicial();

            if (!File.Exists("SeloDigital.GO.Servico.dll.config"))
            {
                config.ConfiguracaoServidor(ConfigPadraoServidor(), "SeloDigital.GO.Servico.dll.config");
            }

            if (!File.Exists(@"..\Cliente\SeloDigital.Go.Cliente.dll.config"))
            {
                config.ConfiguracaoCliente(ConfigPadraoCliente(), @"..\Cliente\SeloDigital.Go.Cliente.dll.config");
            }
        }

        private XmlDocument ConfigPadraoServidor()
        {
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(
                                "<?xml version ='1.0' encoding ='utf-8'?>" +
                                 "<configuration>" +
                                 "<appSettings>" +
                                 "<add key='ConexaoBanco' value='293239361D23363A4D19091E0C3F00E230485153B1594EA4BFBF4D51F0F4F4F30BD8'/>" +
                                 "<add key='UsuarioBanco' value='0E050717350A140735'/>" +
                                 "<add key='SenhaBanco' value='0E050717350A1407350A1F3B'/>" +
                                 "<add key='Token' value='2B1B0C143605380B3D382D313A2D1A'/>" +
                                 "<add key='CodigoCartorio' value=''/>" +
                                 "<add key='ChaveSegurancaCartorio' value=''/>" +
                                 "<add key='HashDoCartorio' value='5E4303563459165D164843190D6841B24C470649B94E1BBABCE9440DE1F7E3B35DBEE9B0EAA8A5F9'/>" +
                                 "<add key='AmbienteProducao' value='56'/>" +
                                 "<add key='TipoDeConexao' value='57'/>" +
                                 "<add key='DesabilitarGeracaoDeSelos' value='099628'/>" +
                                 "<add key='AmbienteAtualizacao' value='2934253016202139' />" +
                                 "</appSettings>" +
                                 "</configuration>"
                            );
            return xml;
        }

        private XmlDocument ConfigPadraoCliente()
        {
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(
                                "<?xml version='1.0' encoding='utf-8'?>" +
                                "<configuration>" +
                                "<appSettings>" +
                                "<add key='EnderecoServico' value='575B564B6241445B41' />" +
                                "<add key='Token' value='2B1B0C143605380B3D382D313A2D1A' />" +
                                "<add key='ClientSettingsProvider.ServiceUri' value='' />" +
                                "<add key='UltimoLogin' value='' />" +
                                "</appSettings>" +
                                "</configuration>"
                            );
            return xml;
        }

        public int GeraSelo()
        {
            switch (DesabilitarGeracaoDeSelos)
            {
                case "Sim":
                    return 0;
                case "Não":
                    return 1;
                default:
                    return 0;
            }
        }
    }
}
