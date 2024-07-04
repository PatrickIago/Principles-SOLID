namespace Principles_SOLID.Dependency_Inversion_Principle;
public interface IRepositorioUsuario
{
    Usuario ObterUsuario(int id);
    void SalvarUsuario(Usuario usuario);
}
