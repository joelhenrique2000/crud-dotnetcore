using pessoa_exemplo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace pessoa_exemplo.Repository
{
    public class PessoaRepository
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
            using (var connection = new SqlConnection(""))
                using var connection = new SqlConnection(_connectionString);

            var pessoaData = connection.Query<Pessoa>("SELECT * FROM PESSOA;");

            return pessoaData;
        }
    }
}
