using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pessoa_exemplo.Models;
using pessoa_exemplo.Repository;

namespace pessoa_exemplo.Business {
    public class PessoaBusiness {

        private readonly PessoaRepository _pessoaRepository;

        public PessoaBusiness ()
        {
           
            _pessoaRepository = new PessoaRepository();
        }

        public IEnumerable<Pessoa> ListarPessoas ()
        {
            return _pessoaRepository.ListAll();
        }
        public void DeletarPessoa() {

        }
        public void AtualizarPessoa() {

        }
        public void CadastrarPessoa() {

        }
    }
}
