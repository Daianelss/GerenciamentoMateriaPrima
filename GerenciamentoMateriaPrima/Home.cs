using GerenciamentoMateriaPrima.Controller;
using GerenciamentoMateriaPrima.Helpers.Extensions;
using GerenciamentoMateriaPrima.Interfaces;
using GerenciamentoMateriaPrima.View;

namespace GerenciamentoMateriaPrima
{
    public partial class FormHome : Form, IHome
    {
        public FormHome()
        {
            InitializeComponent();
        }

        public HomeController HomeControlador { get; set; }
        public double QuebraBancaTotal { get => lblQuebraTotal.Text.ConverterParaDouble(); set => lblQuebraTotal.Text = value.ToString("F2"); }
        public double EntradaMateriaPrimaTotal { get => lblEntradaTotal.Text.ConverterParaDouble(); set => lblEntradaTotal.Text = value.ToString("F2"); }
        public double SaidaMateriaPrimaTotal { get => lblSaidaTotal.Text.ConverterParaDouble(); set => lblSaidaTotal.Text = value.ToString("F2"); }
        public double MateriaPrimaTotalNaoUtilizada { get => lblMaterialNaoUtilizado.Text.ConverterParaDouble(); set => lblMaterialNaoUtilizado.Text = value.ToString("F2"); }


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
            HomeControlador.PreencherTotais();
        }

        private void btnAbrirForm_Click(object sender, EventArgs e)
        {
            var botao = sender as Button;
            var form = new Form();

            switch (botao.Name)
            {
                case "btnBanca":
                    var movimento = new FormMovimento();
                    movimento.SetControlador(new MovimentoController(movimento));
                    form = movimento;
                    break;
                case "btnMateriaPrima":
                    var tipoMateriaPrima = new FormTipoMateriaPrima();
                    tipoMateriaPrima.SetControlador(new TipoMateriaPrimaController(tipoMateriaPrima));
                    form = tipoMateriaPrima;
                    break;
                case "btnProcesso":
                    var tipoProcesso = new FormTipoProcesso();
                    tipoProcesso.SetControlador(new TipoProcessoController(tipoProcesso));
                    form = tipoProcesso;
                    break;
                case "btnMovimentos":
                    var movimentoMateriaPrima = new FormMovimentoMateriaPrima();
                    movimentoMateriaPrima.SetControlador(new MovimentoMateriaPrimaController(movimentoMateriaPrima));
                    form = movimentoMateriaPrima;
                    break;
                case "btnFuncionario":
                    var funcionario = new FormFuncionario();
                    funcionario.SetControlador(new FuncionarioController(funcionario));
                    form = funcionario;
                    break;
                default:
                    break;
            }

            form.ShowDialog();
            HomeControlador.PreencherTotais();
        }

    }
}