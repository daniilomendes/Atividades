using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto13
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora cal = new Calculadora();
            int a = 10;
            int b = 20;
            int c = 10;
            int d = 20;
            int r = cal.Soma(a,b);
            int r2 = cal.Soma(c,d);
            Console.WriteLine("A soma de número {0} mais o numero {1} é igual a {2}", a, b, r);
            Console.WriteLine("A soma de número {0} mais o numero {1} é igual a {2}", c, d, r2);
            Console.ReadLine();
        }        
    }
}
