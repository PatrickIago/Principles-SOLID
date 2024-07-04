namespace Principles_SOLID.Dependency_Inversion_Principle;
public class ServicoUsuario
{
    private readonly IRepositorioUsuario _repositorio;
    public ServicoUsuario(IRepositorioUsuario repositorio)
    {
        _repositorio = repositorio;
    }

    public Usuario ObterUsuario(int id)
    {
        return _repositorio.ObterUsuario(id);
    }

    public void SalvarUsuario(Usuario usuario)
    {
        _repositorio.SalvarUsuario(usuario);
    }
}
