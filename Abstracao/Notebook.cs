using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao
{
    class Notebook
    {
        private string _nome;
        public USB Porta1 { get; set; }
        public USB Porta2 { get; set; }
        public USB Porta3 { get; set; }
        public string getNome()
        {
            return _nome;

        }
        public Notebook(string nome)
        {
            _nome = nome;

        }
    }
}
