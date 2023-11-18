using GerenciamentoMateriaPrima.Interfaces;

namespace GerenciamentoMateriaPrima.Controller
{
    public class HomeController
    {
        public IHome Home { get; set; }

        public HomeController(IHome home)
        {
            Home = home;
        }
    }
}
