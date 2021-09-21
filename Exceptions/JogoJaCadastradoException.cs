using System;

namespace ApiCatalogoJogos.Exceptions
{
    public class JogoJaCadastradoException : Exception
    {
        public JogoJaCadastradoException() 
            : base("Esse jogo já esta cadastrado")
        { }
    }
}