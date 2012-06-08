namespace Negocio
{
    public interface IRepositorioUsuarios
    {
        int TraerPorEmailYPassword(string email, string password);
    }
}