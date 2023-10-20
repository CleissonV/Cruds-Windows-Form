using CrudPessoas;
using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WForms.Repositorios
{
    public class PessoaRepositorio
    {
        

        public void Inserir(Pessoas pessoa)
        {
            using MySqlConnection conexao = (MySqlConnection) new DbConexao().GetConnection();  

            conexao.Execute("INSERT INTO PESSOA (NOME,CPF,EMAIL) VALUES(@nome,@cpf,@email);",
                new
                {
                    nome = pessoa.Nome,
                    cpf = pessoa.Cpf,
                    email = pessoa.Email
                });
        }

        public void Atualizar(Pessoas pessoa)
        {
            using MySqlConnection conexao = (MySqlConnection)new DbConexao().GetConnection();
            conexao.Execute("UPDATE PESSOA SET NOME = @nome, CPF = @cpf, EMAIL = @email WHERE ID = @id;",
                new
                {
                    nome = pessoa.Nome,
                    cpf = pessoa.Cpf,
                    email = pessoa.Email,
                    id = pessoa.Id
                });
        }

        public void Deletar(int id)
        {
            using MySqlConnection conexao = (MySqlConnection)new DbConexao().GetConnection();
            conexao.Execute("DELETE FROM PESSOA WHERE ID = @id;",
                new
                {
                    id
                });
        }

        public Pessoas BuscarPessoaPeloId(int id)
        {
            using MySqlConnection conexao = (MySqlConnection)new DbConexao().GetConnection();
#pragma warning disable CS8603 // Possível retorno de referência nula.
            return conexao.QueryFirstOrDefault<Pessoas>(@"SELECT * FROM PESSOA WHERE ID = @id", new { id });
#pragma warning restore CS8603 // Possível retorno de referência nula.
        }

        public IEnumerable<Pessoas> BuscarTodasPessoas()
        {
            using MySqlConnection conexao = (MySqlConnection)new DbConexao().GetConnection();
            return conexao.Query<Pessoas>(@"SELECT * FROM PESSOA");
        }
    }
}
