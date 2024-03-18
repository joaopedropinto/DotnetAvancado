using Atividade2.Exceptions;
namespace Atividade2;
public class ContaBancaria
{
    private double saldo;

    public ContaBancaria(double saldoInicial)
    {
        if (saldoInicial < 0)
        {
            throw new ValorInvalidoException("Saldo inicial não pode ser negativo", saldoInicial);
        }
        this.saldo = saldoInicial;
    }

     public double Saldo
    {
        get { return saldo; }
    }

    public void Sacar(double valor)
    {
        if(valor <= 0){
            throw new ValorInvalidoException("Valor de saque inválido", valor);
        }
        if(valor > saldo){
            throw new SaldoInsuficienteException("Saldo insuficiente", saldo);
        }
        this.saldo -= valor;
    }

    public void Depositar(double valor)
    {
        if(valor <= 0){
            throw new ValorInvalidoException("Valor de depósito inválido", valor);
        }
        this.saldo += valor;
    }

    public void Transferir(double valor, ContaBancaria conta)
    {
        Sacar(valor);
        conta.Depositar(valor);
    }
}
