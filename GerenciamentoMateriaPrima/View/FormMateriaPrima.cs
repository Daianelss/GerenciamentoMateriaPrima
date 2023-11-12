using GerenciamentoMateriaPrima.Controller;

namespace GerenciamentoMateriaPrima.View
{
    public partial class FormMateriaPrima : Form
    {
        public TipoMateriaPrimaController TipoMateriaPrimaContrador { get; set; }
        public FormMateriaPrima()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void FormMateriaPrima_Load(object sender, EventArgs e)
        {
            /*
            if (lblNomeTipoMateriaPrima.Text != "lblIdTipoMateriaPrima")
            {
                var funcionario = new Funcionario { Id = int.Parse(lblIdFuncionario.Text), Nome = TxtNomeFuncionario.Text, Status = int.Parse(lblStatusFuncionario.Text) };
                FuncionarioControlador.AtualizarFuncionario(funcionario);
                IEnumerable<Funcionario> funcionarios = FuncionarioControlador.ListarFuncionarios();
                dtgFuncionario.DataSource = FuncionarioControlador.PreencherFuncionario(funcionarios);
            }

            else
            {

                var funcionario = new Funcionario { Nome = TxtNomeFuncionario.Text, Status = 0 };
                FuncionarioControlador.GravarFuncionario(funcionario);
                IEnumerable<Funcionario> funcionarios = FuncionarioControlador.ListarFuncionarios();
                dtgFuncionario.DataSource = FuncionarioControlador.PreencherFuncionario(funcionarios);

            }
            // dtgFuncionario.Update();
            */
        }

    }
}