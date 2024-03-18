namespace Atividade2.Structs;
public struct Triangulo<T>
{
    public Ponto<T> P1 { get; }
    public Ponto<T> P2 { get; }
    public Ponto<T> P3 { get; }

    public Triangulo(Ponto<T> p1, Ponto<T> p2, Ponto<T> p3)
    {
        P1 = p1;
        P2 = p2;
        P3 = p3;
    }
}