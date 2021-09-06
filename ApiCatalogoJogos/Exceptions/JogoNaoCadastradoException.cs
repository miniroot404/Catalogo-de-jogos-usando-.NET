using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoJogos.Entities
{
    public class JogoNaoCadastradoException : Exception
    {

        public JogoNaoCadastradoException()
            : base("Este Jogo não está cadastrado.")
        { }
    }
}
