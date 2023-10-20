using CrudProdutos;
using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WForms.Repositorios
{
    public class ProdutoRepositorio
    {
        

        public void Inserir(Produtos produto)
        {
            using MySqlConnection conexao = (MySqlConnection) new DbConexao().GetConnection();  

            conexao.Execute("INSERT INTO PRODUTO (NOME,CODIGO,TIPO) VALUES(@nome,@codigo,@tipo);",
                new
                {
                    nome = produto.Nome,
                    codigo = produto.Codigo,
                    tipo = produto.Tipo
                });
        }

        public void Atualizar(Produtos produto)
        {
            using MySqlConnection conexao = (MySqlConnection)new DbConexao().GetConnection();
            conexao.Execute("UPDATE PRODUTO SET NOME = @nome, CODIGO = @codigo, TIPO = @tipo WHERE ID = @id;",
                new
                {
                    nome = produto.Nome,
                    codigo = produto.Codigo,
                    tipo = produto.Tipo,
                    id = produto.Id
                });
        }

        public void Deletar(int id)
        {
            using MySqlConnection conexao = (MySqlConnection)new DbConexao().GetConnection();
            conexao.Execute("DELETE FROM PRODUTO WHERE ID = @id;",
                new
                {
                    id
                });
        }

        public Produtos BuscarProdutoPeloId(int id)
        {
            using MySqlConnection conexao = (MySqlConnection)new DbConexao().GetConnection();
#pragma warning disable CS8603 // Possível retorno de referência nula.
            return conexao.QueryFirstOrDefault<Produtos>(@"SELECT * FROM PRODUTO WHERE ID = @id", new { id });
#pragma warning restore CS8603 // Possível retorno de referência nula.
        }

        public IEnumerable<Produtos> BuscarTodosProdutos()
        {
            using MySqlConnection conexao = (MySqlConnection)new DbConexao().GetConnection();
            return conexao.Query<Produtos>(@"SELECT * FROM PRODUTO");
        }
    }
}
