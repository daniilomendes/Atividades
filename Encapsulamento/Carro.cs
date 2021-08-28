using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    class Carro
    {
        public class Motor
        {
        }
        public class Bateria
        {
        }
        public class Carro
        {
            // Encapsulando Detalhes
            //Composição
            private Motor _motor;
            private Bateria _bateria;
            private string _nome;
            public string Nome
            {
                get
                {
                    return _nome;
                }
            }
            private void Ignicao()
            {
                Console.WriteLine("Foi dada a Ignicao do Carro");


            }
            public int NumPneus()
            {
                return 4;

            }
        }
    }
}
