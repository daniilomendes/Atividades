using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook sony = new Notebook("Sony Vaio");
            sony.Porta1 = new IPhone();
            var iphone = new IPhone();
            iphone.Plugar();
            sony.Porta2 = new Mouse();
            var mouse = new Mouse();
            mouse.Plugar();
            sony.Porta3 = new Teclado();
            var teclado = new Teclado();
            teclado.Plugar();
            Console.ReadLine();
        }
    }
}
