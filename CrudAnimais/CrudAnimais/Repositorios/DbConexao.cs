using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WForms.Repositorios
{
    public class DbConexao : IDisposable
    {
        private readonly IDbConnection connection;

#pragma warning disable CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
        public DbConexao()
#pragma warning restore CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
        {
            try
            {
                connection = new MySqlConnection("server=localhost;uid=root;database=trabalho_crud");
                connection.Open();
            }
            catch(Exception ex) {
                MessageBox.Show("Ocorreu um erro ao conectar ao BD" + ex.Message);
            }
            

        }

        public IDbConnection GetConnection()
        {
            if(connection.State != ConnectionState.Open)
                connection.Open();
            return connection;
        }

        public void Dispose()
        {
            connection?.Dispose();
        }
    }
}
