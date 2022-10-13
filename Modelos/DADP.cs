using Configuracao.IO;
using Engegraph.Comum.Utilitarios.Seguranca;
using System.Configuration;
using System.IO;
using System.Xml;

namespace Configuracao.Modelos
{
    public class DADP
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
                        ConexaoBanco = CriptografiaEng.Descriptografar(appSettings.Settings["ConexaoBanco"].Value);
                        break;
                    case "AmbienteAtualizacao":
                        AmbienteDeAtualizacao = CriptografiaEng.Descriptografar(appSettings.Settings["AmbienteAtualizacao"].Value);
                        automatico = true;
                        break;
                    case "Porta":
                        Porta = CriptografiaEng.Descriptografar(appSettings.Settings["Porta"].Value);
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
                    case "NomeCartorio":
                        NomeCartorio = CriptografiaEng.Descriptografar(appSettings.Settings["NomeCartorio"].Value);
                        break;
                    case "NomeOficial":
                        NomeOficial = CriptografiaEng.Descriptografar(appSettings.Settings["NomeOficial"].Value);
                        break;
                    case "Cidade":
                        Cidade = CriptografiaEng.Descriptografar(appSettings.Settings["Cidade"].Value);
                        break;
                    case "Uf":
                        Uf = CriptografiaEng.Descriptografar(appSettings.Settings["Uf"].Value);
                        break;
                    case "TituloRelatorioAuxiliar":
                        TituloRelatorioAuxiliar = CriptografiaEng.Descriptografar(appSettings.Settings["TituloRelatorioAuxiliar"].Value);
                        break;
                    case "TituloRelatorioPrevio":
                        TituloRelatorioPrevio = CriptografiaEng.Descriptografar(appSettings.Settings["TituloRelatorioPrevio"].Value);
                        break;
                    case "CodNacional":
                        CodNacional = CriptografiaEng.Descriptografar(appSettings.Settings["CodNacional"].Value);
                        break;
                }
            }
        }

        public void Atualizar(AppSettingsSection appSettings)
        {
            appSettings.Settings["ConexaoBanco"].Value = CriptografiaEng.Criptografar(ConexaoBanco);
            if (automatico)
            {
                appSettings.Settings["AmbienteAtualizacao"].Value = CriptografiaEng.Criptografar(AmbienteDeAtualizacao);
            }
            else
            {
                KeyValueConfigurationElement keyValue = new KeyValueConfigurationElement("AmbienteAtualizacao", CriptografiaEng.Criptografar(AmbienteDeAtualizacao));
                appSettings.Settings.Add(keyValue);
                automatico = true;
            }
            
            appSettings.Settings["Porta"].Value = CriptografiaEng.Criptografar(Porta);
            appSettings.Settings["UsuarioBanco"].Value = CriptografiaEng.Criptografar(UsuarioBanco);
            appSettings.Settings["SenhaBanco"].Value = CriptografiaEng.Criptografar(SenhaBanco);
            appSettings.Settings["TipoDeConexao"].Value = CriptografiaEng.Criptografar(TipoDeConexao);
            appSettings.Settings["NomeCartorio"].Value = CriptografiaEng.Criptografar(NomeCartorio);
            appSettings.Settings["NomeOficial"].Value = CriptografiaEng.Criptografar(NomeOficial);
            appSettings.Settings["Cidade"].Value = CriptografiaEng.Criptografar(Cidade);
            appSettings.Settings["Uf"].Value = CriptografiaEng.Criptografar(Uf);
            appSettings.Settings["TituloRelatorioAuxiliar"].Value = CriptografiaEng.Criptografar(TituloRelatorioAuxiliar);
            appSettings.Settings["TituloRelatorioPrevio"].Value = CriptografiaEng.Criptografar(TituloRelatorioPrevio);
            appSettings.Settings["CodNacional"].Value = CriptografiaEng.Criptografar(CodNacional);
        }
    }
}
