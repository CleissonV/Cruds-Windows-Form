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

namespace CrudProdutos
{
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
        }

        public Produtos(int id, string? nome, string? tipo, string? codigo)
        {
            Id = id;
            Nome = nome;
            Tipo = tipo;
            Codigo = codigo;
        }

        public int Id { get; private set; }

        public string? Nome { get; private set; }

        public string? Tipo { get; private set; }

        public string? Codigo { get; private set; }

        private void Produtos_Load(object sender, EventArgs e)
        {
            var produtoRepositorio = new ProdutoRepositorio();
            BuscarTodosOsProdutos(produtoRepositorio);
        }

        private void btnAdiconar_Click(object sender, EventArgs e)
        {
            var produto = new Produtos(0, txtNome.Text, txtTipo.Text, txtCodigo.Text);
            var produtoRepositorio = new ProdutoRepositorio();
            produtoRepositorio.Inserir(produto);
            LimparCampos();
            BuscarTodosOsProdutos(produtoRepositorio);
        }

        private void LimparCampos()
        {
            txtCodigo.Text = string.Empty;
            txtId.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtTipo.Text = string.Empty;
        }

        private void BuscarTodosOsProdutos(ProdutoRepositorio produtoRepositorio)
        {
            var produtos = produtoRepositorio.BuscarTodosProdutos();
            dgProdutos.DataSource = produtos.ToList();
        }


        private void btnAlterar_Click_1(object sender, EventArgs e)
        {
            var produto = new Produtos(Convert.ToInt32(txtId.Text), txtNome.Text, txtTipo.Text, txtCodigo.Text);
            var produtoRepositorio = new ProdutoRepositorio();
            produtoRepositorio.Atualizar(produto);
            LimparCampos();
            BuscarTodosOsProdutos(produtoRepositorio);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var produtoRepositorio = new ProdutoRepositorio();
            produtoRepositorio.Deletar(Convert.ToInt32(txtId.Text));
            LimparCampos();
            BuscarTodosOsProdutos(produtoRepositorio);
        }

        private void dgProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;

            txtId.Text = dgv.CurrentRow.Cells["Id"]?.Value?.ToString();
            txtNome.Text = dgv.CurrentRow.Cells["Nome"]?.Value?.ToString();
            txtTipo.Text = dgv.CurrentRow.Cells["Tipo"]?.Value?.ToString();
            txtCodigo.Text = dgv.CurrentRow.Cells["Codigo"]?.Value?.ToString();
        }
    }
}