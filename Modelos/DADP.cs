using Configuracao.IO;
using System.Configuration;
using System.IO;
using System.Xml;

namespace Configuracao.Modelos
{
    public class DADP : Cliptrografia
    {
        public string ConexaoBanco { get; set; }
        public string UsuarioBanco { get; set; }
        public string SenhaBanco { get; set; }
        public string NomeCartorio { get; set; }
        public string CodigoCliente { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string NomeOficial { get; set; }
        public string TituloRelatorioAuxiliar { get; set; }
        public string TituloRelatorioPrevio { get; set; }
        public string CodNacional { get; set; }
        public string TipoDeConexao { get; set; }
        public string Porta { get; set; }
        public string AmbienteDeAtualizacao { get; set; }
        private bool automatico { get; set; }

        public DADP()
        {
            ConfiguracaoInicial config = new ConfiguracaoInicial();

            if (!File.Exists("Dadp.Servidor.dll.config"))
            {
                config.ConfiguracaoServidor(ConfigPadraoServidor(), "Dadp.Servidor.dll.config");
            }

            if (!File.Exists(@"..\Cliente\Dadp.Cliente.dll.config"))
            {
                config.ConfiguracaoCliente(ConfigPadraoCliente(), @"..\Cliente\Dadp.Cliente.dll.config");
            }
        }

        private XmlDocument ConfigPadraoServidor()
        {
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(
                                "<?xml version ='1.0' encoding ='utf-8'?>" +
                                 "<configuration>" +
                                 "<appSettings>" +
                                 "<add key='ConexaoBanco' value='363127216F0A0008121D0E1E2A6545AD445D5053B6454FB7FAE80A1EE7C2'/>" +
                                 "<add key='UsuarioBanco' value='0E050717350A140735'/>" +
                                 "<add key='SenhaBanco' value='0E050717350A1407350A1F3B'/>" +
                                 "<add key='Porta' value=''/>" +
                                 "<add key='NomeCartorio' value=''/>" +
                                 "<add key='CodigoCliente' value=''/>" +
                                 "<add key='Cidade' value=''/>" +
                                 "<add key='Uf' value='2138'/>" +
                                 "<add key='NomeOficial' value=''/>" +
                                 "<add key='TituloRelatorioAuxiliar' value=''/>" +
                                 "<add key='TituloRelatorioPrevio' value='' />" +
                                 "<add key='CodNacional' value='' />" +
                                 "<add key='TipoDeConexao' value='57'/>" +
                                 "</appSettings>" +
                                 "<system.data>" +
                                     "<DbProviderFactories>" +
                                        "<remove invariant='FirebirdSql.Data.FirebirdClient'/>" +
                                        "<add name='FirebirdClient Data Provider' invariant='FirebirdSql.Data.FirebirdClient' description='.NET Framework Data Provider for Firebird' type='FirebirdSql.Data.FirebirdClient.FirebirdClientFactory, FirebirdSql.Data.FirebirdClient' />" +
                                     "</DbProviderFactories>" +
                                 "</system.data>" +
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
                                "<add key='EnderecoServidor' value='575B564B6241445B41' />" +
                                "<add key='StackTrace' value='03060A0414' />" +
                                "</appSettings>" +
                                "</configuration>"
                            );
            return xml;
        }

        public void Map(AppSettingsSection appSettings)
        {
            automatico = false;

            foreach (var a in appSettings.Settings.AllKeys)
            {
                switch (a)
                {
                    case "ConexaoBanco":
                        ConexaoBanco = DecriptografarNormal(appSettings.Settings["ConexaoBanco"].Value);
                        break;
                    case "AmbienteAtualizacao":
                        AmbienteDeAtualizacao = DecriptografarNormal(appSettings.Settings["AmbienteAtualizacao"].Value);
                        automatico = true;
                        break;
                    case "Porta":
                        Porta = DecriptografarNormal(appSettings.Settings["Porta"].Value);
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
                    case "NomeCartorio":
                        NomeCartorio = DecriptografarNormal(appSettings.Settings["NomeCartorio"].Value);
                        break;
                    case "NomeOficial":
                        NomeOficial = DecriptografarNormal(appSettings.Settings["NomeOficial"].Value);
                        break;
                    case "Cidade":
                        Cidade = DecriptografarNormal(appSettings.Settings["Cidade"].Value);
                        break;
                    case "Uf":
                        Uf = DecriptografarNormal(appSettings.Settings["Uf"].Value);
                        break;
                    case "TituloRelatorioAuxiliar":
                        TituloRelatorioAuxiliar = DecriptografarNormal(appSettings.Settings["TituloRelatorioAuxiliar"].Value);
                        break;
                    case "TituloRelatorioPrevio":
                        TituloRelatorioPrevio = DecriptografarNormal(appSettings.Settings["TituloRelatorioPrevio"].Value);
                        break;
                    case "CodNacional":
                        CodNacional = DecriptografarNormal(appSettings.Settings["CodNacional"].Value);
                        break;
                }
            }
        }

        public void Atualizar(AppSettingsSection appSettings)
        {
            appSettings.Settings["ConexaoBanco"].Value = CriptografarNormal(ConexaoBanco);
            if (automatico)
            {
                appSettings.Settings["AmbienteAtualizacao"].Value = CriptografarNormal(AmbienteDeAtualizacao);
            }
            else if(AmbienteDeAtualizacao != null)
            {
                KeyValueConfigurationElement keyValue = new KeyValueConfigurationElement("AmbienteAtualizacao", CriptografarNormal(AmbienteDeAtualizacao));
                appSettings.Settings.Add(keyValue);
                automatico = true;
            }
            
            appSettings.Settings["Porta"].Value = CriptografarNormal(Porta);
            appSettings.Settings["UsuarioBanco"].Value = CriptografarNormal(UsuarioBanco);
            appSettings.Settings["SenhaBanco"].Value = CriptografarNormal(SenhaBanco);
            appSettings.Settings["TipoDeConexao"].Value = CriptografarNormal(TipoDeConexao);
            appSettings.Settings["NomeCartorio"].Value = CriptografarNormal(NomeCartorio);
            appSettings.Settings["NomeOficial"].Value = CriptografarNormal(NomeOficial);
            appSettings.Settings["Cidade"].Value = CriptografarNormal(Cidade);
            appSettings.Settings["Uf"].Value = CriptografarNormal(Uf);
            appSettings.Settings["TituloRelatorioAuxiliar"].Value = CriptografarNormal(TituloRelatorioAuxiliar);
            appSettings.Settings["TituloRelatorioPrevio"].Value = CriptografarNormal(TituloRelatorioPrevio);
            appSettings.Settings["CodNacional"].Value = CriptografarNormal(CodNacional);
        }
    }
}
