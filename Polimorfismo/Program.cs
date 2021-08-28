using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            MeioTransporte c = new Carro();

            c.Modelo = "Astra";
            c.Mover();

            MeioTransporte a = new Aviao();
            a.Modelo = "F22";
            a.Mover();
            Console.ReadLine();

        }
    }
}
