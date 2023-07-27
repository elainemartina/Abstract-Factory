using AbstractFactory.Cliente;
using AbstractFactory.Veiculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Fabrica
{
    internal class IndividualClienteVeiculoFabrica : IClienteVeiculoFabrica
    {
        public IVeiculo CriarVeiculo()
        {
            return new CarroIndividual();
        }

        public ICliente CriarCliente()
        {
            return new ClienteIndividual();
        }
    }
}
