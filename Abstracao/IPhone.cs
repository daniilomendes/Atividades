using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao
{
    class IPhone : USB
    {
        public override void Plugar()
        {
            Console.WriteLine("Iphone plugado..");
        }
    }
}
