using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno
            {
                Nome = "Danilo",
                Matricula = "27"
            };
            aluno.Estudar();
            

            Funcionario funcionario = new Funcionario
            {
                Nome = "Danilo",
                Departamento = "Desenvolvimento"
            };
            funcionario.Trabalhar();
            funcionario.Dormir();
            Console.ReadLine();
        }
    }
}
