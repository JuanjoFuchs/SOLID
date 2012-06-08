using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComercioElectronico
{
    public enum MetodoDePago
    {
        Efectivo,
        TarjetaDeCredito
    }

    public class DetallesDePago
    {
        public MetodoDePago MetodoDePago { get; set; }
    }
}
