using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Formas.Refactorizado_HerenciaBasica
{
    public class Rectangulo : Forma
    {
        public int Alto { get; set; }
        public int Ancho { get; set; }

        public int Area()
        {
            return Alto * Ancho;
        }
    }
}
