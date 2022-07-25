using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configuracao.Modelos
{
    public class CIP
    {
        public string SqlHost { get; set; }
        public string SqlDataBase { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string AmbienteDeAtualizacao { get; set; }
    }
}
