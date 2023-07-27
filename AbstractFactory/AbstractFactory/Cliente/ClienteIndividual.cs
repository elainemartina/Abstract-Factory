using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Cliente
{
    internal class ClienteIndividual : ICliente
    {
        public void ExibirCliente()
        {
            Console.WriteLine("Cliente Individual");
        }
    }
}
