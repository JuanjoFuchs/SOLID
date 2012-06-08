namespace Formas.SinRefactorizar
{
    public class Cuadrado : Rectangulo
    {
        private int _alto;
        private int _ancho;

        public override int Alto
        {
            get { return _alto; }
            set
            {
                _alto = value;
                _ancho = value;
            }
        }

        public override int Ancho
        {
            get { return _ancho; }
            set
            {
                _ancho = value;
                _alto = value;
            }
        }
    }
}
