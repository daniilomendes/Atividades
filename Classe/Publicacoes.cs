using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe
{
    class Publicacoes
    {
        public string Nome { get; set; }
        public int QntPaginas { get; set; }

        public int QntPaginasReturn(int qnt)
        {
            return qnt;
        }
    }
}
