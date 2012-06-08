using ComercioElectronico.Modelo;

namespace ComercioElectronico.Interfaces
{
    public interface IServicioNotificacion
    {
        void NotificarClienteOrdenCreada(Carrito carrito);
    }
}