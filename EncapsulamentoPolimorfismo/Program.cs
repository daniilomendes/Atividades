using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamentoPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Bone bone = new Bone();
            bone.Tamanho = "G";
            bone.provar();
        }
    }
}
