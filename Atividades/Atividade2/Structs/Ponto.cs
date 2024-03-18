namespace Atividade2.Structs;
public struct Ponto<T>
{
    public T X { get; }
    public T Y { get; }
    public T Z { get; }

    public Ponto(T x, T y, T z)
    {
        X = x;
        Y = y;
        Z = z;
    }
}