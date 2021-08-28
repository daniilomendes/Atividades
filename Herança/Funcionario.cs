using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    class Funcionario : Pessoa
    {
        public string Nome;
        public string Departamento;

        public void Trabalhar() {
            Console.WriteLine(Nome+ "está trabalhando no departamento ..." + Departamento);

        }
    }
}
