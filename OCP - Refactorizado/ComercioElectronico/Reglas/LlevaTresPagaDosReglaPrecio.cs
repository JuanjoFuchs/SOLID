using ComercioElectronico.Interfaces;
using ComercioElectronico.Modelo;

namespace ComercioElectronico.Reglas
{
    public class LlevaTresPagaDosReglaPrecio : IReglasDePrecios
    {
        public bool Aplica(Producto producto)
        {
            return producto.Unidad.StartsWith("UNIDAD")
                   && producto.Cantidad % 3 == 0;
        }

        public decimal CalcularPrecio(Producto producto)
        {
            return producto.Precio * (producto.Cantidad - producto.Cantidad / 3);
        }
    }
}