using ComercioElectronico.Modelo;

namespace ComercioElectronico.Interfaces
{
    public interface ICalculadoraDePrecios
    {
        decimal CalcularTotal(Producto producto);
    }
}