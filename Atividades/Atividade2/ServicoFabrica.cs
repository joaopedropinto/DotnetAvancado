using Atividade2.Interfaces;
namespace Atividade2;
public class ServicoFabrica<T> where T : IServico, new()
{
    public T NovaInstancia()
    {
        return new T();
    }
}
