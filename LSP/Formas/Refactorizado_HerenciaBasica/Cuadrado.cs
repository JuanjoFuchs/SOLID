using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Formas.Refactorizado_HerenciaBasica
{
    public class Cuadrado : Forma
    {
        public int Lado { get; set; }

        public int Area()
        {
            return Lado * Lado;
        }
    }
}
