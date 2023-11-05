using GerenciamentoMateriaPrima.Controller;
using GerenciamentoMateriaPrima.Interfaces;
using GerenciamentoMateriaPrima.Model;

namespace GerenciamentoMateriaPrima
{
    public partial class formHome : Form, IHome
    {

        public HomeController HomeControlador { get; set; }
        public formHome()
        {
            InitializeComponent();
        }

        public void SetControlador(HomeController homeControlador)
        {
            HomeControlador = homeControlador;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            var funcionario = new Funcionario { Nome = "José Euclides", Status = 0 };
            HomeControlador.GravarFuncionario(funcionario);
            IEnumerable<Funcionario> funcionarios = HomeControlador.ListarFuncionarios();

            dtgTeste.DataSource = HomeControlador.PreencherFuncionario(funcionarios);

        }
    }
}