using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamentoPolimorfismo
{
    class Roupa
    {
        public string Tamanho { get; set; }
        public string Cor { get; set; }

        public virtual void provar()
        {

        }
    }
}
