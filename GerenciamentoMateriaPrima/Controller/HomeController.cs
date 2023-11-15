using GerenciamentoMateriaPrima.Context;
using GerenciamentoMateriaPrima.DAL;
using GerenciamentoMateriaPrima.DataTables;
using GerenciamentoMateriaPrima.Interfaces;
using GerenciamentoMateriaPrima.Model;
using System.Data;

namespace GerenciamentoMateriaPrima.Controller
{
    public class HomeController
    {
        public IHome Home { get; set; }
        private readonly FuncionarioDal _funcionarioDal;

        public HomeController(IHome home)
        {
            Home = home;
            _funcionarioDal = new FuncionarioDal(new GerenciamentoMateriaPrimaContext());
        }
    }
}
