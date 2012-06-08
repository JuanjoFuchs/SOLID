using ComercioElectronico.Interfaces;
using ComercioElectronico.Modelo;

namespace ComercioElectronico.Reglas
{
    public class UnoCuarentaTresPorUnSol : IReglasDePrecios
    {
        public bool Aplica(Producto producto)
        {
            return producto.Unidad.StartsWith("GOLOSINA")
                   && producto.Precio == 0.4m
                   && producto.Cantidad % 3 == 0;
        }

        public decimal CalcularPrecio(Producto producto)
        {
            return producto.Cantidad / 3;
        }
    }
}