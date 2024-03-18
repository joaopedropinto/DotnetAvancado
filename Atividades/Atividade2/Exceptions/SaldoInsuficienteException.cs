namespace Atividade2.Exceptions;
public class SaldoInsuficienteException : Exception
{
    public double SaldoDisponivel { get; }

    public SaldoInsuficienteException(string mensagem, double saldoDisponivel) : base(mensagem)
    {
        SaldoDisponivel = saldoDisponivel;
    }
}
