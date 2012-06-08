using ComercioElectronico.Interfaces;
using ComercioElectronico.Servicios;

namespace ComercioElectronico.Modelo
{
    public class OrdenWeb : Orden
    {
        private readonly IServicioNotificacion _servicioNotificacion;
        private readonly DetallesDePago _detallesDePago;
        private readonly IServicioPagos _servicioPagos;
        private readonly IReservaInventarios _reservaInventarios;

        public OrdenWeb(Carrito carrito, DetallesDePago detallesDePago) 
            : base(carrito)
        {
            _detallesDePago = detallesDePago;
            _servicioNotificacion = new ServicioNotificacion();
            _servicioPagos = new ServicioPagos();
            _reservaInventarios =new ReservaInventarios();
        }

        public override void ConfirmarCompra()
        {
            _servicioPagos.ProcesarTarjetaDeCredito(_detallesDePago, _carrito.MontoTotal);

            _reservaInventarios.ReservarInventario(_carrito.Productos);

            _servicioNotificacion.NotificarClienteOrdenCreada(_carrito);

            base.ConfirmarCompra();
        }
    }
}