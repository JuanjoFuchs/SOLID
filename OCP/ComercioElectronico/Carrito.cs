using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComercioElectronico
{
    public class Carrito
    {
        private readonly List<Producto> _productos;

        public Carrito()
        {
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
                // Lleva 3 paga 2
                if (producto.Unidad.StartsWith("UNIDAD")
                    && producto.Cantidad % 3 == 0)
                {
                    total += producto.Precio * (producto.Cantidad - producto.Cantidad / 3);
                }
                // Por cada KG te regalamos 100 GR
                else if (producto.Unidad.StartsWith("KG")
                    && producto.Cantidad >= 1)
                {
                    total += producto.Precio * (producto.Cantidad - producto.Cantidad / 10);
                }
                // Y estamos pensando en mas 
                // promociones descabelladas!!
            }
            return total;
        }
    }
}
