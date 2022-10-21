using Engegraph.Comum.Utilitarios.Seguranca;

namespace Configuracao.Modelos
{
    public class Criptografia
    {
        public string CriptografarNormal(string str)
        {
            if (str != null || str != "")
            {
                return CriptografiaEng.Criptografar(str);
            }
            return null;
        }

        public string DecriptografarNormal(string str)
        {
            if (str != null || str != "")
            {
                return CriptografiaEng.Descriptografar(str);
            }
            return null;
        }

        public string CriptografarComplexa(string str)
        {
            if (str != null || str !="")
            {
                return XAesSimples.Criptografar(str);
            }
            return null;
        }

        public string DecriptografarComplexa(string str)
        {
            if (str != null || str != "")
            {
                return XAesSimples.Decriptografar(str);
            }
            return null;
        }

    }
}
