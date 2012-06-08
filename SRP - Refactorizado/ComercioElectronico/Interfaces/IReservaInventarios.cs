using System.Collections.Generic;
using ComercioElectronico.Modelo;

namespace ComercioElectronico.Interfaces
{
    public interface IReservaInventarios
    {
        void ReservarInventario(List<Producto> productos);
    }
}