namespace Formas.SinRefactorizar
{
    public class CalculadorAreas
    {
        public static int CalcularArea(Rectangulo rectangulo)
        {
            return rectangulo.Alto * rectangulo.Ancho;
        }

        public static int CalcularArea(Cuadrado cuadrado)
        {
            return cuadrado.Alto * cuadrado.Ancho;
        }
    }
}
