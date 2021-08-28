using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao16
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente
            {
                nome = "nome",
                sexo = "sexo"
            };

            Console.WriteLine(new Cliente().RetonaVari(cliente));
        }
    }
}
