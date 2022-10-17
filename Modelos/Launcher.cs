using Configuracao.IO;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace Configuracao.Modelos
{
    public class Launcher : Cliptrografia
    {
        public string SqlHost { get; set; }
        public string SqlDatabase { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string TipoSgbd { get; set; }
        public string AmbienteAtualizacao { get; set; }

        public Launcher()
        {
            ConfiguracaoInicial config = new ConfiguracaoInicial();

            if (!File.Exists("Configuracoes.config"))
            {
                config.ConfiguracaoServidor(ConfigPadraoServidor(), "Configuracoes.config");
            }

            if (!File.Exists(@"..\Cliente\Configuracoes.config"))
            {
                config.ConfiguracaoCliente(ConfigPadraoCliente(), @"..\Cliente\Configuracoes.config");
            }
        }

        private XmlDocument ConfigPadraoServidor()
        {
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(
                                "<?xml version ='1.0' encoding ='utf-8'?>" +
                                 "<configuration>" +
                                 "<Launcher>" +
                                 @" <!--
                                    Exemplo SqlDatabase:
                                    Se tipo de SGBD = 0 => D:\Engegraph\DB\Launcher.sdf
                                    Se tipo de SGBD = 1 => Launcher
                                    -->" +
                                 "<SqlHost value='Z6r0Smiwd9llDCMAi2xZdqguevaHISdTBbURXx8it5wOeQt0McTK35q9UNCO+KtmTX4lu9VwmrpvjfoQhST0UKR8i/heklJW7Frbz57IqTw='/>" +
                                 "<SqlDatabase value='ajtdIiwGXxdecYlsf3eePsxjaTRQYdMw8LRRw09ywXx5TtSTTw/fGgBwrrGTrJTfYIkxTqULZL/jttuTUGU7nNPQlxbgw3N6EWRs0Tcy/SI='/>" +
                                 "<Usuario value='JS9/xbA+G7VyPoiYslZ+1z2FRbEfTW3uRi+Splv5gF4zp3gLFb4THPwB4JY0wh7NZh3XXFCAcF42ltSBaD60PaPHaXo17SqvyAxSkUhIMvY='/>" +
                                 "<Senha value='FeMaV+3Z6pqRq80f5TCFXksvG3hf4E/bvF9mJOfNoZZtGyGKr8gHPzinMH3pTVVwpntIP/GNuQk747hoQ80dDTqb+Z0HXm4DHHfSgkkil9c='/>" +
                                 "<TipoSgbd value='1hhIhpO1lny6EMPMVM/oSUR/DNmkdOrFBuva4rUvCYXCQYryR8ERS3WEOLkQGWPFQ6uU7/O+mcw5DP84WyrVFhrT6wF6dSCgO4v8Xr47ypg='/>" +
                                 "<AmbienteAtualizacao value='WMYWTHXzgwUqBmKeIfBPIBFKJXiIYO+irLRRRLVXPZJaMfcFhg8ZPPIiD55uvCpeVwsZTIQyNwGGyxE0ljiCYTTe1MdAiFmcpgQWB0ZgLTs=' />" +
                                 "</Launcher>" +
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
                                "<Launcher>" +
                                    "<IpServidor value='muWLvuizrpvogiBtS7wi5/V9KlFw9n0MSiDWLShPRXHBG2WMqAWMWIBU8pzAHzgzWrHhNUixG812GzvZARBaYqXitnPO7enjgtsn5+81ibU=' />" +
                                    "<UsarBiometria value='C7bU0s917toZRAQGiUP1YturtNmuamZ3u8Odc5UwCbTONhLOZ9Odk5erwmWWpJgixEGklksS057AUBbm9ZM4+pzu3RzZzCItXkv+k+5pDAg=' />" +
                                "</Launcher>" +
                                "</configuration>"
                            );
            return xml;
        }

        public void Map(XElement XML)
        {
            SqlHost = DecriptografarComplexa(XML.Descendants("SqlHost").First().LastAttribute.Value);
            Usuario = DecriptografarComplexa(XML.Descendants("Usuario").First().LastAttribute.Value);
            Senha = DecriptografarComplexa(XML.Descendants("Senha").First().LastAttribute.Value);
            TipoSgbd = DecriptografarComplexa(XML.Descendants("TipoSgbd").First().LastAttribute.Value);
            AmbienteAtualizacao = DecriptografarComplexa(XML.Descendants("AmbienteAtualizacao").First().LastAttribute.Value);
        }
    }
}