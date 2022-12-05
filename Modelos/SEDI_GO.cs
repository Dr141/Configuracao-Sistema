using Configuracao.IO;
using System.Configuration;
using System.IO;
using System.Xml;

namespace Configuracao.Modelos
{
    public class SEDI_GO : Criptografia
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
        private bool automatico { get; set; }

        public SEDI_GO()
        {
            ConfiguracaoInicial config = new ConfiguracaoInicial();

            if (!File.Exists("SeloDigital.GO.Servico.dll.config") && Directory.Exists(@"Servidor"))
            {
                config.ConfiguracaoServidor(ConfigPadraoServidor(), "SeloDigital.GO.Servico.dll.config");
            }

            if (!File.Exists(@"..\Cliente\SeloDigital.Go.Cliente.dll.config") && Directory.Exists(@"..\Cliente"))
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
                                 "<add key='HashDoCartorio' value=''/>" +
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

        public void Map(AppSettingsSection appSettings)
        {
            automatico = false;

            foreach (var item in appSettings.Settings.AllKeys)
            {
                switch (item)
                {
                    case "ConexaoBanco":
                        ConexaoBanco = DecriptografarNormal(appSettings.Settings["ConexaoBanco"].Value);
                        break;
                    case "AmbienteAtualizacao":
                        AmbienteAtualizacao = DecriptografarNormal(appSettings.Settings["AmbienteAtualizacao"].Value);
                        automatico = true;
                        break;
                    case "HashDoCartorio":
                        HashDoCartorio = DecriptografarNormal(appSettings.Settings["HashDoCartorio"].Value);
                        break;
                    case "UsuarioBanco":
                        UsuarioBanco = DecriptografarNormal(appSettings.Settings["UsuarioBanco"].Value);
                        break;
                    case "SenhaBanco":
                        SenhaBanco = DecriptografarNormal(appSettings.Settings["SenhaBanco"].Value);
                        break;
                    case "TipoDeConexao":
                        TipoDeConexao = DecriptografarNormal(appSettings.Settings["TipoDeConexao"].Value);
                        break;
                    case "DesabilitarGeracaoDeSelos":
                        DesabilitarGeracaoDeSelos = DecriptografarNormal(appSettings.Settings["DesabilitarGeracaoDeSelos"].Value);
                        break;
                    case "AmbienteProducao":
                        AmbienteProducao = DecriptografarNormal(appSettings.Settings["AmbienteProducao"].Value);
                        break;
                    case "Token":
                        Token = DecriptografarNormal(appSettings.Settings["Token"].Value);
                        break;
                    case "CodigoCartorio":
                        CodigoCartorio = DecriptografarNormal(appSettings.Settings["CodigoCartorio"].Value);
                        break;
                    case "ChaveSegurancaCartorio":
                        ChaveSegurancaCartorio = DecriptografarNormal(appSettings.Settings["ChaveSegurancaCartorio"].Value);
                        break;
                }
            }
        }

        public void Atualizar(AppSettingsSection appSettings)
        {
            appSettings.Settings["ConexaoBanco"].Value = CriptografarNormal(ConexaoBanco);

            if (automatico)
            {
                appSettings.Settings["AmbienteAtualizacao"].Value = CriptografarNormal(AmbienteAtualizacao);
            }
            else if(AmbienteAtualizacao != null)
            {
                KeyValueConfigurationElement keyValue = new KeyValueConfigurationElement("AmbienteAtualizacao", CriptografarNormal(AmbienteAtualizacao));
                appSettings.Settings.Add(keyValue);
                automatico = true;
            }            
            
            appSettings.Settings["HashDoCartorio"].Value = CriptografarNormal(HashDoCartorio);
            appSettings.Settings["UsuarioBanco"].Value = CriptografarNormal(UsuarioBanco);
            appSettings.Settings["SenhaBanco"].Value = CriptografarNormal(SenhaBanco);
            appSettings.Settings["TipoDeConexao"].Value = CriptografarNormal(TipoDeConexao);
            appSettings.Settings["DesabilitarGeracaoDeSelos"].Value = CriptografarNormal(DesabilitarGeracaoDeSelos);
            appSettings.Settings["AmbienteProducao"].Value = CriptografarNormal(AmbienteProducao);
            appSettings.Settings["Token"].Value = CriptografarNormal(Token);
            appSettings.Settings["CodigoCartorio"].Value = CriptografarNormal(CodigoCartorio);
            appSettings.Settings["ChaveSegurancaCartorio"].Value = CriptografarNormal(ChaveSegurancaCartorio);
        }
    }
}
