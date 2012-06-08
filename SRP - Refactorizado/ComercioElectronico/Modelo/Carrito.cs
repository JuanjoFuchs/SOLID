using System.Collections.Generic;

namespace ComercioElectronico.Modelo
{
    public class Carrito
    {
        public decimal MontoTotal { get; set; }

        public List<Producto> Productos { get; set; }
    }
}
