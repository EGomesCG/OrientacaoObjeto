using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjeto
{
    //Customizando as Exception
    public class MinhaExcecao : Exception
    {
        public Exception MensagemErro()
        {
            return new Exception("Algo deu errado. Procure o Adm do sistema!");
        }
        public Exception MensagemErro(string mgs)
        {
            return new Exception(mgs);
        }
    }
}
