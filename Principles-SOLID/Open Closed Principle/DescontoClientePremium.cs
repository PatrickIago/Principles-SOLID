namespace Principles_SOLID.Open_Closed_Principle;
public class DescontoClientePremium : Desconto
{
    public override double AplicarDesconto(double preco)
    {
        return preco * 0.2; // 20% de desconto para clientes premium
    }
}