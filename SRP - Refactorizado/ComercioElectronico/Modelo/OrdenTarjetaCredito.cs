using ComercioElectronico.Interfaces;
using ComercioElectronico.Servicios;

namespace ComercioElectronico.Modelo
{
    public class OrdenTarjetaCredito : Orden
    {
        private readonly DetallesDePago _detallesDePago;
        private readonly IServicioPagos _servicioPagos;

        public OrdenTarjetaCredito(Carrito carrito, DetallesDePago detallesDePago)
            : base(carrito)
        {
            _detallesDePago = detallesDePago;
            _servicioPagos = new ServicioPagos();
        }

        public override void ConfirmarCompra()
        {
            _servicioPagos.ProcesarTarjetaDeCredito(_detallesDePago, _carrito.MontoTotal);

            base.ConfirmarCompra();
        }
    }
}