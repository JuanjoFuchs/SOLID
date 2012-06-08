using ComercioElectronico.Modelo;

namespace ComercioElectronico.Interfaces
{
    public interface IServicioPagos
    {
        void ProcesarTarjetaDeCredito(DetallesDePago detallesDePago, decimal montoTotal);
    }
}