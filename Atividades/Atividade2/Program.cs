using Atividade2;
using Atividade2.Exceptions;
using Atividade2.Structs;

#region Exercicio1
Console.WriteLine($"Exercicio 1");

try
{
    ContaBancaria conta1 = new ContaBancaria(10000);
    ContaBancaria conta2 = new ContaBancaria(5000);
    Console.WriteLine($"Saldo inicial da conta 1: {conta1.Saldo}");
    Console.WriteLine($"Saldo inicial da conta 2: {conta2.Saldo}");

    Console.WriteLine($"Depositando 200 na conta 1");
    conta1.Depositar(200);
    Console.WriteLine($"Saldo da conta 1 após depósito: {conta1.Saldo}");

    Console.WriteLine($"Sacando 50 da conta 2");
    conta2.Sacar(50);
    Console.WriteLine($"Saldo da conta 2 após saque: {conta2.Saldo}");

    Console.WriteLine($"Transferindo 500 da conta 1 para a conta 2");
    conta1.Transferir(500, conta2);
    Console.WriteLine($"Saldo da conta 1 após transferência: {conta1.Saldo}");
    Console.WriteLine($"Saldo da conta 2 após transferência: {conta2.Saldo}");

    Console.WriteLine($"Testando erros");
    Console.WriteLine($"Depositando -50 na conta 1");
    conta1.Depositar(-50);
    Console.WriteLine($"Saldo da conta 1 após depósito: {conta1.Saldo}");
    Console.WriteLine($"Sacando 1000 da conta 1");
    conta1.Sacar(1000);
    Console.WriteLine($"Saldo da conta 1 após saque: {conta1.Saldo}");

}
catch (ValorInvalidoException ex)
{
    Console.WriteLine($"Erro: {ex.Message}. Valor inválido: {ex.ValorInvalido}");
}
catch (SaldoInsuficienteException ex)
{
    Console.WriteLine($"Erro: {ex.Message}. Saldo disponível: {ex.SaldoDisponivel}");
}

try
{
    ContaBancaria conta1 = new ContaBancaria(10000);
    Console.WriteLine($"Saldo da conta 1: {conta1.Saldo}");
    Console.WriteLine($"Sacando 11000 da conta 1");
    conta1.Sacar(11000);
}
catch (ValorInvalidoException ex)
{
    Console.WriteLine($"Erro: {ex.Message}. Valor inválido: {ex.ValorInvalido}");
}
catch (SaldoInsuficienteException ex)
{
    Console.WriteLine($"Erro: {ex.Message}. Saldo disponível: {ex.SaldoDisponivel}");
}
#endregion

#region Exercicio2
Console.WriteLine($"\nExercicio 2");
try
{
    Object? o = null;
    Console.WriteLine(o.ToString());
}
catch (Exception ex)
{
    Console.WriteLine($"Aconteceu um erro: {ex}");
}
#endregion

#region Exercicio3
Console.WriteLine($"\nExercicio 3");

Console.WriteLine("Opções de exercícios:");
foreach (Exercicio exercicio in Enum.GetValues(typeof(Exercicio)))
{
    Console.WriteLine($"{(int)exercicio}: {exercicio}");
}
Console.WriteLine("Digite o número correspondente ao exercício desejado:");
try
{
    int opcao = int.Parse(Console.ReadLine());
    if (opcao < 1 || opcao > 3)
    {
        Console.WriteLine("Erro: Opção inválida. Por favor, digite 1, 2 ou 3.");
        return;
    }
    Exercicio exercicioEscolhido = (Exercicio)opcao;
    Console.WriteLine($"Exercício escolhido: {exercicioEscolhido}");
}
catch (FormatException)
{
    Console.WriteLine($"Opção inválida. Tente novamente.");

}


#endregion

#region Exercicio4

Console.WriteLine($"\nExercicio 4");
ServicoFabrica<ExemploServico> fabricaExemplo = new ServicoFabrica<ExemploServico>();
ExemploServico servicoExemplo = fabricaExemplo.NovaInstancia();
servicoExemplo.Executar();

#endregion

#region Exercicio5
Console.WriteLine($"\nExercicio 5");

Ponto<int> pontoInt = new Ponto<int>(1, 2, 3);
Ponto<double> pontoDouble = new Ponto<double>(1.5, 2.5, 3.5);
Ponto<string> pontoString = new Ponto<string>("A", "B", "C");

Console.WriteLine("Pontos:");
Console.WriteLine($"Int: {pontoInt}");
Console.WriteLine($"Double: {pontoDouble}");
Console.WriteLine($"String: {pontoString}");

Triangulo<int> trianguloInt = new Triangulo<int>(new Ponto<int>(1, 2, 3), new Ponto<int>(2, 3, 1), new Ponto<int>(3, 1, 2));
Triangulo<double> trianguloDouble = new Triangulo<double>(new Ponto<double>(0.1, 0.2, 0.3), new Ponto<double>(1.5, 0.4, 2.7), new Ponto<double>(0.9, 1.8, 2.1));
Triangulo<string> trianguloString = new Triangulo<string>(new Ponto<string>("A", "A", "A"), new Ponto<string>("B", "B", "B"), new Ponto<string>("C", "C", "C"));

static void printTriangulo<Task>(Triangulo<Task> triangulo)
{
    Console.WriteLine($"1º Ponto: ({triangulo.P1.X}, {triangulo.P1.Y}, {triangulo.P1.Z})");
    Console.WriteLine($"2º Ponto: ({triangulo.P2.X}, {triangulo.P2.Y}, {triangulo.P2.Z})");
    Console.WriteLine($"3º Ponto: ({triangulo.P3.X}, {triangulo.P3.Y}, {triangulo.P3.Z})");
}

Console.WriteLine("\nTriângulos:");
Console.WriteLine($"Int:");
printTriangulo(trianguloInt);
Console.WriteLine($"Double:");
printTriangulo(trianguloDouble);
Console.WriteLine($"String:");
printTriangulo(trianguloString);
#endregion

enum Exercicio
{
    Academia = 1,
    Luta = 2,
    Corrida = 3
}

