namespace Principles_SOLID.Single_Responsibility_Principle;
public class CalculadoraFrete
{
    public double CalcularFrete(Produto produto)
    {
        // Lógica para calcular o frete baseado no tipo de produto
        if (produto.Peso > 10)
        {
            return produto.Valor * 0.05; // Frete mais caro para produtos pesados
        }
        else
        {
            return produto.Valor * 0.02; // Frete mais barato para produtos leves
        }
    }
}
