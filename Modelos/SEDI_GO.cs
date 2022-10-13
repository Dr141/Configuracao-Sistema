using Configuracao.IO;
using Engegraph.Comum.Utilitarios.Seguranca;
using System.Configuration;
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
        private bool automatico { get; set; }

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
                        ConexaoBanco = CriptografiaEng.Descriptografar(appSettings.Settings["ConexaoBanco"].Value);
                        break;
                    case "AmbienteAtualizacao":
                        AmbienteAtualizacao = CriptografiaEng.Descriptografar(appSettings.Settings["AmbienteAtualizacao"].Value);
                        automatico = true;
                        break;
                    case "HashDoCartorio":
                        HashDoCartorio = CriptografiaEng.Descriptografar(appSettings.Settings["HashDoCartorio"].Value);
                        break;
                    case "UsuarioBanco":
                        UsuarioBanco = CriptografiaEng.Descriptografar(appSettings.Settings["UsuarioBanco"].Value);
                        break;
                    case "SenhaBanco":
                        SenhaBanco = CriptografiaEng.Descriptografar(appSettings.Settings["SenhaBanco"].Value);
                        break;
                    case "TipoDeConexao":
                        TipoDeConexao = CriptografiaEng.Descriptografar(appSettings.Settings["TipoDeConexao"].Value);
                        break;
                    case "DesabilitarGeracaoDeSelos":
                        DesabilitarGeracaoDeSelos = CriptografiaEng.Descriptografar(appSettings.Settings["DesabilitarGeracaoDeSelos"].Value);
                        break;
                    case "AmbienteProducao":
                        AmbienteProducao = CriptografiaEng.Descriptografar(appSettings.Settings["AmbienteProducao"].Value);
                        break;
                    case "Token":
                        Token = CriptografiaEng.Descriptografar(appSettings.Settings["Token"].Value);
                        break;
                    case "CodigoCartorio":
                        CodigoCartorio = CriptografiaEng.Descriptografar(appSettings.Settings["CodigoCartorio"].Value);
                        break;
                    case "ChaveSegurancaCartorio":
                        ChaveSegurancaCartorio = CriptografiaEng.Descriptografar(appSettings.Settings["ChaveSegurancaCartorio"].Value);
                        break;
                }
            }
        }

        public void Atualizar(AppSettingsSection appSettings)
        {
            appSettings.Settings["ConexaoBanco"].Value = CriptografiaEng.Criptografar(ConexaoBanco);

            if (automatico)
            {
                appSettings.Settings["AmbienteAtualizacao"].Value = CriptografiaEng.Criptografar(AmbienteAtualizacao);
            }
            else
            {
                KeyValueConfigurationElement keyValue = new KeyValueConfigurationElement("AmbienteAtualizacao", CriptografiaEng.Criptografar(AmbienteAtualizacao));
                appSettings.Settings.Add(keyValue);
                automatico = true;
            }            
            
            appSettings.Settings["HashDoCartorio"].Value = CriptografiaEng.Criptografar(HashDoCartorio);
            appSettings.Settings["UsuarioBanco"].Value = CriptografiaEng.Criptografar(UsuarioBanco);
            appSettings.Settings["SenhaBanco"].Value = CriptografiaEng.Criptografar(SenhaBanco);
            appSettings.Settings["TipoDeConexao"].Value = CriptografiaEng.Criptografar(TipoDeConexao);
            appSettings.Settings["DesabilitarGeracaoDeSelos"].Value = CriptografiaEng.Criptografar(DesabilitarGeracaoDeSelos);
            appSettings.Settings["AmbienteProducao"].Value = CriptografiaEng.Criptografar(AmbienteProducao);
            appSettings.Settings["Token"].Value = CriptografiaEng.Criptografar(Token);
            appSettings.Settings["CodigoCartorio"].Value = CriptografiaEng.Criptografar(CodigoCartorio);
            appSettings.Settings["ChaveSegurancaCartorio"].Value = CriptografiaEng.Criptografar(ChaveSegurancaCartorio);
        }
    }
}
