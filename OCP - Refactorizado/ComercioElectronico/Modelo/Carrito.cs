using System.Collections.Generic;
using ComercioElectronico.Interfaces;

namespace ComercioElectronico.Modelo
{
    public class Carrito
    {
        private readonly List<Producto> _productos;
        private readonly ICalculadoraDePrecios _calculadoraDePrecios;

        public Carrito()
            : this(new CalculadoraDePrecios())
        {
        }

        public Carrito(ICalculadoraDePrecios calculadoraDePrecios)
        {
            _calculadoraDePrecios = calculadoraDePrecios;
            _productos = new List<Producto>();
        }

        public IEnumerable<Producto> Productos
        {
            get { return _productos; }
        }

        public string EmailCliente { get; set; }

        public void Agregar(Producto producto)
        {
            _productos.Add(producto);
        }

        public decimal CalcularTotal()
        {
            decimal total = 0m;
            foreach (var producto in Productos)
            {
                total += _calculadoraDePrecios.CalcularTotal(producto);
            }
            return total;
        }
    }
}
