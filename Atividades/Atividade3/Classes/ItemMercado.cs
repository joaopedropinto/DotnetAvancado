namespace Atividade3.Classes;

public enum Tipo
{
    Comida,
    Bebida,
    Higiene,
    Limpeza
}
public class ItemMercado
{
    public string? Nome { get; set; }
    public Tipo Tipo { get; set; }
    public double Preco { get; set; }
}
