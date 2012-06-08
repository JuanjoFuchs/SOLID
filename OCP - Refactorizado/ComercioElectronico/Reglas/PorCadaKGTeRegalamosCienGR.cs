using ComercioElectronico.Interfaces;
using ComercioElectronico.Modelo;

namespace ComercioElectronico.Reglas
{
    public class PorCadaKGTeRegalamosCienGR : IReglasDePrecios
    {
        public bool Aplica(Producto producto)
        {
            return producto.Unidad.StartsWith("KG")
                   && producto.Cantidad >= 1;
        }

        public decimal CalcularPrecio(Producto producto)
        {
            return producto.Precio * (producto.Cantidad - producto.Cantidad / 10);
        }
    }
}