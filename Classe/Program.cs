using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Livro().RetornaNome("VINICIUS"));
            Console.ReadLine();

            //Heranca
            Console.WriteLine(new Livro().QntPaginasReturn(10));
            Console.ReadLine();
        }
    }
}
