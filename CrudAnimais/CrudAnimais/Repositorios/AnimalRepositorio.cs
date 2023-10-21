using CrudAnimais;
using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WForms.Repositorios
{
    public class AnimalRepositorio
    {
        

        public void Inserir(Animais animal)
        {
            using MySqlConnection conexao = (MySqlConnection) new DbConexao().GetConnection();  

            conexao.Execute("INSERT INTO ANIMAL (NOME,RACA,PROPRIETARIO) VALUES(@nome,@raca,@proprietario);",
                new
                {
                    nome = animal.Nome,
                    raca = animal.Raca,
                    proprietario = animal.Proprietario
                });
        }

        public void Atualizar(Animais animal)
        {
            using MySqlConnection conexao = (MySqlConnection)new DbConexao().GetConnection();
            conexao.Execute("UPDATE ANIMAL SET NOME = @nome, RACA = @raca, PROPRIETARIO = @proprietario WHERE ID = @id;",
                new
                {
                    nome = animal.Nome,
                    raca = animal.Raca,
                    proprietario = animal.Proprietario,
                    id = animal.Id
                });
        }

        public void Deletar(int id)
        {
            using MySqlConnection conexao = (MySqlConnection)new DbConexao().GetConnection();
            conexao.Execute("DELETE FROM ANIMAL WHERE ID = @id;",
                new
                {
                    id
                });
        }

        public Animais BuscarAnimalPeloId(int id)
        {
            using MySqlConnection conexao = (MySqlConnection)new DbConexao().GetConnection();
#pragma warning disable CS8603 // Possível retorno de referência nula.
            return conexao.QueryFirstOrDefault<Animais>(@"SELECT * FROM ANIMAL WHERE ID = @id", new { id });
#pragma warning restore CS8603 // Possível retorno de referência nula.
        }

        public IEnumerable<Animais> BuscarTodosAnimais()
        {
            using MySqlConnection conexao = (MySqlConnection)new DbConexao().GetConnection();
            return conexao.Query<Animais>(@"SELECT * FROM ANIMAL");
        }
    }
}
