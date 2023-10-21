using WForms.Repositorios;

namespace CrudAnimais
{
    public partial class Animais : Form
    {
        public Animais()
        {
            InitializeComponent();
        }

        public Animais(int id, string? nome, string? raca, string? proprietario)
        {
            Id = id;
            Nome = nome;
            Raca = raca;
            Proprietario = proprietario;
        }

        public int Id { get; private set; }

        public string? Nome { get; private set; }

        public string? Raca { get; private set; }

        public string? Proprietario { get; private set; }

        private void Animais_Load(object sender, EventArgs e)
        {
            var animalRepositorio = new AnimalRepositorio();
            BuscarTodosOsAnimais(animalRepositorio);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var animal = new Animais(0, txtNome.Text, txtRaca.Text, txtProprietario.Text);
            var animalRepositorio = new AnimalRepositorio();
            animalRepositorio.Inserir(animal);
            LimparCampos();
            BuscarTodosOsAnimais(animalRepositorio);
        }

        private void LimparCampos()
        {
            txtRaca.Text = string.Empty;
            txtId.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtProprietario.Text = string.Empty;
        }

        private void BuscarTodosOsAnimais(AnimalRepositorio pessoaRepositorio)
        {
            var pessoas = pessoaRepositorio.BuscarTodosAnimais();
            dgAnimais.DataSource = pessoas.ToList();
        }

        private void dgAnimais_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;

            txtId.Text = dgv.CurrentRow.Cells["Id"]?.Value?.ToString();
            txtNome.Text = dgv.CurrentRow.Cells["Nome"]?.Value?.ToString();
            txtRaca.Text = dgv.CurrentRow.Cells["Raca"]?.Value?.ToString();
            txtProprietario.Text = dgv.CurrentRow.Cells["Proprietario"]?.Value?.ToString();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            var animal = new Animais(Convert.ToInt32(txtId.Text), txtNome.Text, txtRaca.Text, txtProprietario.Text);
            var animalRepositorio = new AnimalRepositorio();
            animalRepositorio.Atualizar(animal);
            LimparCampos();
            BuscarTodosOsAnimais(animalRepositorio);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            var animalRepositorio = new AnimalRepositorio();
            animalRepositorio.Deletar(Convert.ToInt32(txtId.Text));
            LimparCampos();
            BuscarTodosOsAnimais(animalRepositorio);
        }
    }
}