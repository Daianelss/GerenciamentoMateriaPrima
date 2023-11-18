using GerenciamentoMateriaPrima.Controller;
using GerenciamentoMateriaPrima.Interfaces;
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
            CarregarTotais();
        }

        private void CarregarTotais()
        {
            throw new NotImplementedException();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            var funcionario = new FormFuncionario();
            var controller = new FuncionarioController(funcionario);
            funcionario.SetControlador(controller);
            funcionario.ShowDialog();
        }

        private void btnMovimentos_Click(object sender, EventArgs e)
        {
            var movimentoMateriaPrima = new FormMovimentoMateriaPrima();
            var controller = new MovimentoMateriaPrimaController(movimentoMateriaPrima);
            movimentoMateriaPrima.SetControlador(controller);
            movimentoMateriaPrima.ShowDialog();
        }

        private void btnMateriaPrima_Click(object sender, EventArgs e)
        {
            var tipoMateriaPrima = new FormTipoMateriaPrima();
            var controller = new TipoMateriaPrimaController(tipoMateriaPrima);
            tipoMateriaPrima.SetControlador(controller);
            tipoMateriaPrima.ShowDialog();
        }

        private void btnBanca_Click(object sender, EventArgs e)
        {
            var movimento = new FormMovimento();
            var controller = new MovimentoController(movimento);
            movimento.SetControlador(controller);
            movimento.ShowDialog();

        }

        private void btnProcesso_Click(object sender, EventArgs e)
        {
            var tipoProcesso = new FormTipoProcesso();
            var controller = new TipoProcessoController(tipoProcesso);
            tipoProcesso.SetControlador(controller);
            tipoProcesso.ShowDialog();
        }
    }
}