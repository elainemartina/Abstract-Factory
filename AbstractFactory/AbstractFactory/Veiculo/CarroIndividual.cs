using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Veiculo
{
    internal class CarroIndividual : IVeiculo
    {
        public void Dirigir()
        {
            Console.WriteLine("Dirigindo Carro Individual");
        }
    }
}
