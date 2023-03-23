namespace EjemploObserver.Interfaces
{
    public interface INotifier
    {
        void notificarTodos(string mensaje);

        void agregarObserver(IObserver observador);

        void removerObserver(IObserver observador);
    }
}
