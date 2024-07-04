using Principles_SOLID.Liskov_Substitution_Principle;
namespace Principles_SOLID;
public class Circulo : FormaGeometrica
{
    public double Raio { get; set; }

    public override double CalcularArea()
    {
        return Math.PI * Raio * Raio;
    }
}
