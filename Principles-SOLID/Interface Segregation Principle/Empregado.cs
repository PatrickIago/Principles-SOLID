namespace Principles_SOLID.Interface_Segregation_Principle;
public class Empregado : ITrabalhador, IEmpregado
{
    public void ReceberSalario()
    {
        // Lógica para o empregado receber seu salário
    }

    public void Trabalhar()
    {
        // Lógica para o empregado realizar seu trabalho
    }
}
