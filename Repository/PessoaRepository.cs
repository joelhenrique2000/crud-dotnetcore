using pessoa_exemplo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Threading.Tasks;
using System.Data.SqlClient;
using pessoa_exemplo.Repository.Interfaces;

namespace pessoa_exemplo.Repository
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly string _connectionString;

        public PessoaRepository() {
            _connectionString = "Server=localhost\\SQLEXPRESS; Database = ESTUDO1; Trusted_Connection = true";
        }

        // public PessoaRepository(IConfiguration configuration)
        //{
        //    _connectionString = configuration.GetConnectionString("PessoaDataServer");
        // }

        public IEnumerable<Pessoa> ListAll() {
            using var connection = new SqlConnection(_connectionString);

            var pessoaData = connection.Query<Pessoa>("SELECT * FROM PESSOA;").ToList();

            return pessoaData;
        }

        public int Insert(string nome, string sobrenome, string email, string telefone) {
            using var connection = new SqlConnection(_connectionString);

            var query = "INSERT INTO PESSOA (Nome, Sobrenome, Email, Telefone) VALUES (@nome, @sobrenome, @email, @telefone);";

            var resultado = connection.Execute(query, new { nome = nome, sobrenome = sobrenome, email = email, telefone = telefone });

            return resultado;
        }

        public int Update(long codigo, string nome, string sobrenome, string email, string telefone) {
            using var connection = new SqlConnection(_connectionString);

            var query = "UPDATE PESSOA SET nome = @nome, sobrenome = @sobrenome, email = @email, telefone = @telefone, WHERE Codigo = @codigo";

            var result = connection.Execute(query, new { codigo = codigo, nome = nome, sobrenome = sobrenome, email = email, telefone = telefone });

            return result;
        }

        public int Delete(long codigo) {
            using var connection = new SqlConnection(_connectionString);

            var query = "DELETE FROM PESSOA WHERE Codigo = @codigo";

            var result = connection.Execute(query, new { codigo = codigo });

            return result;
        }
    }
}
