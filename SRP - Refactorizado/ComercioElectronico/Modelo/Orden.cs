namespace ComercioElectronico.Modelo
{
    public abstract class Orden
    {
        protected readonly Carrito _carrito;

        protected Orden(Carrito carrito)
        {
            _carrito = carrito;
        }

        public virtual void ConfirmarCompra()
        {
            // Guardar orden en la base de datos
        }
    }
}
