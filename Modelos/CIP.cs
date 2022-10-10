using Configuracao.IO;
using System.IO;
using System.Xml;

namespace Configuracao.Modelos
{
    public class CIP
    {
        public string SqlHost { get; set; }
        public string SqlDataBase { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string AmbienteDeAtualizacao { get; set; }

        public CIP()
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
                                "<CIP>" +
                                "<SqlHost value='THItc9T2SODvEVB/qPRrp6cT5QgTEHCipYlRLUl4wQChqgg1ZfY8bmJNYnWVDKTQF/xBVt64uGZGOt7RYQIUcRLbfcQWlpKShFo2+YwRUJU='/>" +
                                "<SqlDataBase value='lfGTNbjRZsOlS6UPYBJJxkExUR3oI0HpXoMhVX/zF7u1tDlf8InekQZMVJuBqTipItyRj8Eypl8wPsOm0rXkAJf0hZRojWe/wnJ2vXUcgy/fkmIFNJiYjNkhTPMLV9ZD'/>" +
                                "<Usuario value='jR5f8qceUFir2BQoR+fdGP1R2f4hI8b6no/C0NReFfFKJgMMg7VvE77EwfjEyyhV69sHZX+WTrbRYltydYRaUGYY/E3fNIkDv8xWB4Fi+uQ='/>" +
                                "<Senha value='c51epNf9AcXuXLWr2jwBRCXXP087sCbQSb3QTHXHIVEXvSMDSbVpOBKbcWUnEAdqnrPkN1pomBttCLSqrjtJyP1NR31B2PM7/Pl4/bY2SIk='/>" +
                                "<AmbienteDeAtualizacao value='qxU2PeuA24FE5q5UouUWJU+CrrplVLLi4N3o4ORItMTy9Dt9JiCJ+ME6QYIw6eom9AWnJoCpaEpY/UGMUxIh1YamgELzhVpHMQQWT9bvM4E='/>" +
                                "</CIP>" +
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
                                "<CadastroIntegradoDePessoas>" +
                                "<EnderecoServico value='OczANXwM7rPdaHVwF0bIgpXSVTQlaN4W9zyXIvu2h3eavnMBqSzoUnEkAriaLuu92hfR7BEcSC4F8afHShQCx9wOeIlYhSPS8a6GlkmnFw8='/>" +
                                "<UltimoLogin value=''/>" +
                                "</CadastroIntegradoDePessoas>" +
                                "</configuration>"
                            );
            return xml;
        }
    }
}