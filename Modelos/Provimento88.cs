using Configuracao.IO;
using System;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace Configuracao.Modelos
{
    public class Provimento88 : Cliptrografia
    {
        public String ConexaoBanco { get; set; }
        public String UsuarioBanco { get; set; }
        public String SenhaBanco { get; set; }
        public String UrlDeComunicacao { get; set; }
        public String UsuarioSisCoaf { get; set; }
        public String SenhaSisCoaf { get; set; }
        public String TipoDeConexao { get; set; }
        public String AmbienteAtualizacao { get; set; }
        public String EnderecoSevico { get; set; }

        public Provimento88()
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
                                "<?xml version='1.0' encoding='utf-8'?>" +
                                "<configuration>" +
                                "<Provimento88>" +
                                "<ConexaoBanco value='/rOcFv/RPjvWjuvCpz9A1N9Y+t45t29syOoY28LSehusqC204npkZwVVLBqjxHaiYhWuvmXFsIShEluzn/S4Qv9nVL8jx7MlJYhVAK6IEZt6b+kaYqHfHF85duWkPRm8BOHPj9k7IqydL49eBhZZMA=='/>" +
                                "<UsuarioBanco value='qlnJtATz1lkO/eov7ZEuOLqBsLyfAHiFiVf4RM8d6bE3yag2A4tWpiDF1EYqYhlBomM/Aw5qWmFjyqtUd6+9cGhT7BI5CTda/Tpg09KrR1I='/>" +
                                "<SenhaBanco value='k1kYm6dGN6pgzcsgfK4aVHK4emkOpac+7kuV8BzCEByUW9yAIPmwPvZmWqGLgOWWOxjRwC5Sfs5WAvv3oedwWmtGnpc5873imbrjGgVE+Bg='/>" +
                                "<UrlDeComunicacao value='84o0Ts5cf3dG/5sjZWk10DOE0qSA18tcM3DgdRiD8VPuAgM66IFVIdaVlz24MgkmE58E996vOlTTlW02kZhGkha9kD1fGoG0OhdykMO77AJzmCDI4x0VSehBbGF4hxXU5HEfAzo17NLaMlKYLkCDruiCK1wlBTZ/GmTlJfEFjhY/oW8mdDPqU/KSB2ji+Bav'/>" +
                                "<UsuarioSisCoaf value='JvCFe3m36h3mNGgH1duWj+gurhAR95RP+sJhWZGLDWgbrxls211cOeN+ibNGQwxTbNNuE7dbqB8w5jc6Bhcwva5qw5sxNY81lWN9xG5AXM4='/>" +
                                "<SenhaSisCoaf value='9izUnsRkGgTl/cMTZ6HCGXIokSs0+MXKWgvoRb60gPQN9QRIUiETCnkwcsUbabezmHC4gGhayXprSWGLkxIOIBMwgCq4XJQUGTOaYLHppkAbTWUPjb6rMWebuV50jSUK'/>" +
                                "<TipoDeConexao value ='AlBeCY+alcC2/zMpgo4I7beSIxn1jGqKnZCM2nOJceUairjMwcql3vv7YaF0BuB3G0BYljtBoZ0lzY0RtszYeiVFUnLmMkUdQEY8Xl3Njow='/>" +
                                "<AmbienteAtualizacao value='qxU2PeuA24FE5q5UouUWJU+CrrplVLLi4N3o4ORItMTy9Dt9JiCJ+ME6QYIw6eom9AWnJoCpaEpY/UGMUxIh1YamgELzhVpHMQQWT9bvM4E=' />" +
                                "<!--CIP-->" +
                                "<EnderecoServico value='TAh0mUrUea8o4Yug3xkR8+gyVbBt0tNnVG256z3w3BFZAEU6drGwIIpZBZMxF/O0ltzSoQq+xne4mhupvZKHUPPVx3KDQAw6glyjnN15Z2Q='/>" +
                                "</Provimento88>" +
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
                                "<Provimento88>" +
                                "<EnderecoServico value='BMy8R8KT8F2Gydl/8HFIBe6ThckVEYNcIcHAF1GPp2RVH1h+U2p2w988vuK8rHI54dO379JXdz9DFmKVRZjaWnDJ6xZgzJ5jmFdt8xLIwlM='/>" +
                                "<UltimoLogin value=''/>" +
                                "<NomeCertificadoServentia value=''/>" +
                                "<PassCertificado value=''/>" +
                                "</Provimento88>" +
                                "<CadastroIntegradoDePessoas>" +
                                "<EnderecoServico value='BMy8R8KT8F2Gydl/8HFIBe6ThckVEYNcIcHAF1GPp2RVH1h+U2p2w988vuK8rHI54dO379JXdz9DFmKVRZjaWnDJ6xZgzJ5jmFdt8xLIwlM='/>" +
                                "<UltimoLogin value=''/>" +
                                "</CadastroIntegradoDePessoas>" +
                                "</configuration>"
                            );
            return xml;
        }

        public void Map(XElement XML)
        {
            ConexaoBanco = DecriptografarComplexa(XML.Descendants("ConexaoBanco").First().LastAttribute.Value);
            UsuarioBanco = DecriptografarComplexa(XML.Descendants("UsuarioBanco").First().LastAttribute.Value);
            SenhaBanco = DecriptografarComplexa(XML.Descendants("SenhaBanco").First().LastAttribute.Value);
            UrlDeComunicacao = DecriptografarComplexa(XML.Descendants("UrlDeComunicacao").First().LastAttribute.Value);
            UsuarioSisCoaf = DecriptografarComplexa(XML.Descendants("UsuarioSisCoaf").First().LastAttribute.Value);
            SenhaSisCoaf = DecriptografarComplexa(XML.Descendants("SenhaSisCoaf").First().LastAttribute.Value);
            TipoDeConexao = DecriptografarComplexa(XML.Descendants("TipoDeConexao").First().LastAttribute.Value);
            AmbienteAtualizacao = DecriptografarComplexa(XML.Descendants("AmbienteAtualizacao").First().LastAttribute.Value);
            EnderecoSevico = DecriptografarComplexa(XML.Descendants("EnderecoServico").First().LastAttribute.Value);
        }

        public void Atualizar(XElement XML)
        {
            XML.Descendants("ConexaoBanco").First().LastAttribute.Value = CriptografarComplexa(ConexaoBanco);
            XML.Descendants("UsuarioBanco").First().LastAttribute.Value = CriptografarComplexa(UsuarioBanco);
            XML.Descendants("SenhaBanco").First().LastAttribute.Value = CriptografarComplexa(SenhaBanco);
            XML.Descendants("UrlDeComunicacao").First().LastAttribute.Value = CriptografarComplexa(UrlDeComunicacao);
            XML.Descendants("UsuarioSisCoaf").First().LastAttribute.Value = CriptografarComplexa(UsuarioSisCoaf);
            XML.Descendants("SenhaSisCoaf").First().LastAttribute.Value = CriptografarComplexa(SenhaSisCoaf);
            XML.Descendants("TipoDeConexao").First().LastAttribute.Value = CriptografarComplexa(TipoDeConexao);
            XML.Descendants("AmbienteAtualizacao").First().LastAttribute.Value = CriptografarComplexa(AmbienteAtualizacao);
            XML.Descendants("EnderecoServico").First().LastAttribute.Value = CriptografarComplexa(EnderecoSevico);
        }
    }
}