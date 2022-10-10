using Configuracao.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public DADP()
        {
            ConfiguracaoInicial config = new ConfiguracaoInicial();

            if (!File.Exists("Configuracoes.config"))
            {
                config.ConfiguracaoServidor(ConfigPadraoServidor(), "Configuracoes.config");
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
                                 "<add key='ConexaoBanco' value='293239361D23363A4D19091E0C3F00E230485153B1594EA4BFBF4D51F0F4F4F30BD8'/>" +
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
                                "<add key='EnderecoServico' value='575B564B6241445B41' />" +
                                "<add key='StackTrace' value='03060A0414' />" +
                                "</appSettings>" +
                                "</configuration>"
                            );
            return xml;
        }
    }
}
