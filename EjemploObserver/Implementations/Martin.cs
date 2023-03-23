using EjemploObserver.Interfaces;

namespace EjemploObserver.Implementations
{
    public class Martin : IObserver
    {
        private CosoQueNotifica _cosoQueNotifica;

        public Martin(CosoQueNotifica cosoQueNotifica)
        {
            _cosoQueNotifica = cosoQueNotifica;
        }

        public void notificar(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        public void suscribir() {
            _cosoQueNotifica.agregarObserver(this);
        }

        public void desuscribir() {
            _cosoQueNotifica.removerObserver(this);
        }
    }
}
