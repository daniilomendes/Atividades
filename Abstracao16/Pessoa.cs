using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao16
{
    public abstract class Pessoa
    {
        public string nome { get; set; }
        public string sexo { get; set; }

        public Pessoa RetonaVari(Pessoa pessoa)
        {

            return pessoa;
        }
    }
}
