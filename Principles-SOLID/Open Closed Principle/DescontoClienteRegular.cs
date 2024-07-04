namespace Principles_SOLID.Open_Closed_Principle;
public class DescontoClienteRegular : Desconto
{
    public override double AplicarDesconto(double preco)
    {
        return preco * 0.1; // 10% de desconto para clientes regulares
    }
}
