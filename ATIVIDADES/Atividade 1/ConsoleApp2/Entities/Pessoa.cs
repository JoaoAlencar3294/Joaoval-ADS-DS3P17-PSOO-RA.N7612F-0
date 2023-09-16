using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Entities
{
    class Pessoa
    {
        public string Ra { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public Pessoa()
        {
        }

        public Pessoa(string ra, string nome, string email)
        {
            Ra = ra;
            Nome = nome;
            Email = email;
        }

        
    }
}
