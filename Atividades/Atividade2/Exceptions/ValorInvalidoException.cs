namespace Atividade2.Exceptions;
public class ValorInvalidoException : Exception
{
    public double ValorInvalido { get; }
    public ValorInvalidoException(string mensagem, double valorInvalido) : base(mensagem)
    {
        ValorInvalido = valorInvalido;
    }
}
