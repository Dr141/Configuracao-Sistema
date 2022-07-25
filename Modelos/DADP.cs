using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
