using GerenciamentoMateriaPrima.Controller;
using GerenciamentoMateriaPrima.Interfaces;
using GerenciamentoMateriaPrima.Model;
using GerenciamentoMateriaPrima.View;

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
            

        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            var funcionario = new FormFuncionario();
            var controller = new FuncionarioController(funcionario);
            funcionario.SetControlador(controller);
            funcionario.ShowDialog();
        }
    }
}