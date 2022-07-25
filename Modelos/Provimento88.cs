using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Configuracao.Modelos
{
    public class Provimento88
    {
        [XmlElement("ConexaoBanco")]
        public String ConexaoBanco { get; set; }

        [XmlElement("UsuarioBanco")]
        public String UsuarioBanco { get; set; }

        [XmlElement("SenhaBanco")]
        public String SenhaBanco { get; set; }

        [XmlElement("UrlDeComunicacao")]
        public String UrlDeComunicacao { get; set; }

        [XmlElement("UsuarioSisCoaf")]
        public String UsuarioSisCoaf { get; set; }

        [XmlElement("SenhaSisCoaf")]
        public String SenhaSisCoaf { get; set; }

        [XmlElement("TipoDeConexao")]
        public String TipoDeConexao { get; set; }

        [XmlElement("AmbienteAtualizacao")]
        public String AmbienteAtualizacao { get; set; }

        [XmlElement("EnderecoSevico")]
        public String EnderecoSevico { get; set; }
    }
}
