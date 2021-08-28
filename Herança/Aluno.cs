using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    class Aluno : Pessoa
    {
        public string Nome;
        public string Matricula;

        public void Estudar()
        {
            Console.WriteLine(Nome + "está estudando");
        }
    }
}
