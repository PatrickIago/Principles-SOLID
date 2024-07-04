using Principles_SOLID.Open_Closed_Principle;
public class CalculadoraDesconto
{
    private Desconto _desconto;

    public CalculadoraDesconto(Desconto desconto)
    {
        _desconto = desconto;
    }

    public double CalcularPrecoComDesconto(double preco)
    {
        return preco - _desconto.AplicarDesconto(preco);
    }
}