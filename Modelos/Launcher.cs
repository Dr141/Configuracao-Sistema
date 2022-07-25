using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configuracao.Modelos
{
    public class Launcher
    {
        public string SqlHost { get; set; }
        public string SqlDatabase { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string TipoSgbd { get; set; }
        public string AmbienteAtualizacao { get; set; }
    }
}
