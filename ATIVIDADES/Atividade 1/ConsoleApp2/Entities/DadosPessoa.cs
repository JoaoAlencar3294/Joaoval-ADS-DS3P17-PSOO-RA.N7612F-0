using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Entities
{
    class DadosPessoa : Pessoa
    {
        public string Endereco { get; set; }
        public string Telefone { get; set; }

        public DadosPessoa()
        {
            
        }
        public DadosPessoa(string ra, string  nome, string email, string endereco, string telefone) : base(ra, nome, email)
        {
            Endereco = endereco;
            Telefone = telefone;
        }


    }
}
