using Atividade2.Interfaces;
namespace Atividade2;
public class ExemploServico : IServico
{
    public void Executar(){
        Console.WriteLine($"Executando exemplo de servico!");
    }
}
