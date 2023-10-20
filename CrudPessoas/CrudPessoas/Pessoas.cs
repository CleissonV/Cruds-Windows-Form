using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WForms.Repositorios;

namespace CrudPessoas
{
    public partial class Pessoas : Form
    {
        public Pessoas()
        {
            InitializeComponent();
        }

        public Pessoas(int id, string? nome, string? cpf, string? email)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Email = email;
        }

        public int Id { get; private set; }

        public string? Nome { get; private set; }

        public string? Cpf { get; private set; }

        public string? Email { get; private set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            var pessoaRepositorio = new PessoaRepositorio();
            BuscarTodasAsPessoas(pessoaRepositorio);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var pessoa = new Pessoas(0, txtNome.Text, txtCpf.Text, txtEmail.Text);
            var pessoaRepositorio = new PessoaRepositorio();
            pessoaRepositorio.Inserir(pessoa);
            LimparCampos();
            BuscarTodasAsPessoas(pessoaRepositorio);
        }


        private void LimparCampos()
        {
            txtCpf.Text = string.Empty;
            txtId.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }

        private void BuscarTodasAsPessoas(PessoaRepositorio pessoaRepositorio)
        {
            var pessoas = pessoaRepositorio.BuscarTodasPessoas();
            dgPessoas.DataSource = pessoas.ToList();
        }

        private void dgPessoas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;

            txtId.Text = dgv.CurrentRow.Cells["Id"]?.Value?.ToString();
            txtNome.Text = dgv.CurrentRow.Cells["Nome"]?.Value?.ToString();
            txtCpf.Text = dgv.CurrentRow.Cells["Cpf"]?.Value?.ToString();
            txtEmail.Text = dgv.CurrentRow.Cells["Email"]?.Value?.ToString();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            var pessoa = new Pessoas(Convert.ToInt32(txtId.Text), txtNome.Text, txtCpf.Text, txtEmail.Text);
            var pessoaRepositorio = new PessoaRepositorio();
            pessoaRepositorio.Atualizar(pessoa);
            LimparCampos();
            BuscarTodasAsPessoas(pessoaRepositorio);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            var pessoaRepositorio = new PessoaRepositorio();
            pessoaRepositorio.Deletar(Convert.ToInt32(txtId.Text));
            LimparCampos();
            BuscarTodasAsPessoas(pessoaRepositorio);
        }

        private void dgPessoas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}