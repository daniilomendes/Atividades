using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro Astra = new Carro();
            Astra.Ligar();
            Astra.Mover();
            Astra.Abastecer();
            Console.ReadLine();
        }
    }
}
