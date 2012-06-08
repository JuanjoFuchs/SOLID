using NUnit.Framework;

namespace Formas.SinRefactorizar
{
    [TestFixture]
    public class CalcularAreaDeberiaRetornar
    {
        [Test]
        public void SeisParaRectanguloDeTresPorDos()
        {
            var rectangulo = new Rectangulo() {Alto = 3, Ancho = 2};
            Assert.AreEqual(6, CalculadorAreas.CalcularArea(rectangulo));
        }

        [Test]
        public void NueveParaCuadradoDeTresPorTres()
        {
            var cuadrado = new Cuadrado() {Alto = 3, Ancho = 3};
            Assert.AreEqual(9, CalculadorAreas.CalcularArea(cuadrado));
        }

        [Test]
        public void VeinteParaRectanguloDeCuatroPorCincoDesdeCuadrado()
        {
            Rectangulo rectangulo = new Cuadrado();
            rectangulo.Alto = 4;
            rectangulo.Ancho = 5;
            Assert.AreEqual(20, CalculadorAreas.CalcularArea(rectangulo));
        }
    }
}
