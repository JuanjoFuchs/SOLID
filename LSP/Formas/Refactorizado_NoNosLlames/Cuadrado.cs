using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Formas.Refactorizado_NoNosLlames
{
    public class Cuadrado : Forma
    {
        public int Lado { get; set; }

        public override int Area()
        {
            return Lado * Lado;
        }
    }
}
