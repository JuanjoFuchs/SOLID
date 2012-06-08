using ComercioElectronico.Modelo;

namespace ComercioElectronico.Interfaces
{
    public interface IReglasDePrecios
    {
        bool Aplica(Producto producto);
        decimal CalcularPrecio(Producto producto);
    }
}