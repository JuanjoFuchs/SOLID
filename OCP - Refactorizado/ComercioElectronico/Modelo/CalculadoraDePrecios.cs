using System.Collections.Generic;
using System.Linq;
using ComercioElectronico.Interfaces;
using ComercioElectronico.Reglas;

namespace ComercioElectronico.Modelo
{
    public class CalculadoraDePrecios : ICalculadoraDePrecios
    {
        private readonly List<IReglasDePrecios> _reglas;

        public CalculadoraDePrecios()
        {
            _reglas = new List<IReglasDePrecios>();
            _reglas.Add(new LlevaTresPagaDosReglaPrecio());
            _reglas.Add(new PorCadaKGTeRegalamosCienGR());
            _reglas.Add(new UnoCuarentaTresPorUnSol());
        }

        public decimal CalcularTotal(Producto producto)
        {
            return _reglas.First(r => r.Aplica(producto)).CalcularPrecio(producto);
        }
    }
}