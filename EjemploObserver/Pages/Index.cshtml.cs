using EjemploObserver.Implementations;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EjemploObserver.Pages
{
    public class IndexModel : PageModel
    {
        CosoQueNotifica cosoQueNotifica = new CosoQueNotifica();

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnPostEnviarMensaje() {
            Martin martin = new Martin(cosoQueNotifica);
            Octavio octavio = new Octavio(cosoQueNotifica);

            martin.suscribir();
            octavio.suscribir();

            cosoQueNotifica.notificarTodos("Una notificacion xd");
        }
    }
}