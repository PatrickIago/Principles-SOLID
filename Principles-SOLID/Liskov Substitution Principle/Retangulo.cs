namespace Principles_SOLID.Liskov_Substitution_Principle;
public class Retangulo : FormaGeometrica
{
    public double Largura { get; set; }
    public double Altura { get; set; }

    public override double CalcularArea()
    {
        return Largura * Altura;
    }
}
