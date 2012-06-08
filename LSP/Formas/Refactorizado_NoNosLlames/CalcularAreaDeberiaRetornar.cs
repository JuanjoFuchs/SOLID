using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Formas.Refactorizado_NoNosLlames
{
    [TestFixture]
    public class CalcularAreaDeberiaRetornar
    {
        [Test]
        public void SeisParaRectanguloDeTresPorDos()
        {
            var rectangulo = new Rectangulo() { Alto = 3, Ancho = 2 };
            Assert.AreEqual(6, rectangulo.Area());
        }

        [Test]
        public void NueveParaCuadradoDeTresPorTres()
        {
            var cuadrado = new Cuadrado() { Lado = 3 };
            Assert.AreEqual(9, cuadrado.Area());
        }

        [Test]
        public void VeinteParaRectanguloDeCuatroPorCincoDesdeCuadrado()
        {
            var formas = new List<Forma>()
                             {
                                 new Rectangulo{Alto = 4, Ancho = 5},
                                 new Cuadrado{Lado = 3}
                             };
            var areas = new List<int>();
            foreach (var forma in formas)
            {
                areas.Add(forma.Area());
            }
            Assert.AreEqual(20, areas[0]);
            Assert.AreEqual(9, areas[1]);
        }
    }
}
