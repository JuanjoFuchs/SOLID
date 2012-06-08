using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Formas.Refactorizado_NoNosLlames
{
    public class Rectangulo : Forma
    {
        public int Alto { get; set; }
        public int Ancho { get; set; }

        public override int Area()
        {
            return Alto * Ancho;
        }
    }
}
