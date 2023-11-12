using GerenciamentoMateriaPrima.Controller;
using GerenciamentoMateriaPrima.DataTables;
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

        private void btnTipoMateriaPrima_Click(object sender, EventArgs e)
        {
            var tipoMateriaPrima = new FormTipoMateriaPrima();
            var controller = new TipoMateriaPrimaController(tipoMateriaPrima);
            tipoMateriaPrima.SetControlador(controller);
            tipoMateriaPrima.ShowDialog();
        }

        private void btnMovimentos_Click(object sender, EventArgs e)
        {
            var movimentoMateriaPrima = new FormMovimentoMateriaPrima();
            var tipoMateriaPrima = new FormTipoMateriaPrima();
            var controller = new MovimentoMateriaPrimaController(movimentoMateriaPrima);
            var controllerTipo = new TipoMateriaPrimaController(tipoMateriaPrima);
            movimentoMateriaPrima.SetControlador(controller, controllerTipo);
            movimentoMateriaPrima.ShowDialog();
        }
    }
}