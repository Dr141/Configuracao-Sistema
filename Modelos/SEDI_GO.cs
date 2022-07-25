using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
