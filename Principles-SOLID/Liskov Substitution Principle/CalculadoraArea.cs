namespace Principles_SOLID.Liskov_Substitution_Principle;
public class CalculadoraArea
{
    public double CalcularAreaTotal(FormaGeometrica[] formas)
    {
        double areaTotal = 0;
        foreach (var forma in formas)
        {
            areaTotal += forma.CalcularArea();
        }
        return areaTotal;
    }
}
