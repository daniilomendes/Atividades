using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Aviao : MeioTransporte
    {        
        public override void Mover()
        {
            Console.WriteLine($" {Modelo} voando ...");
        }
    }
}
