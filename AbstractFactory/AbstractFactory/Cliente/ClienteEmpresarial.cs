using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Cliente
{
    internal class ClienteEmpresarial : ICliente
    {
        public void ExibirCliente()
        {
            Console.WriteLine("Cliente Empresarial");
        }
    }
}
