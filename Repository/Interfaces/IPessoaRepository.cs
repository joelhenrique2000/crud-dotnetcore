using pessoa_exemplo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 
namespace pessoa_exemplo.Repository.Interfaces {
    public interface IPessoaRepository
    {
        public IEnumerable<Pessoa> ListAll();
        public int Insert(string nome, string sobrenome, string email, string telefone);
        public int Update(long codigo, string nome, string sobrenome, string email, string telefone);
        public int Delete(long codigo);
    }
}
