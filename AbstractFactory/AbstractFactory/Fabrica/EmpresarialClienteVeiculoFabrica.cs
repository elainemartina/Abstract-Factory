using AbstractFactory.Cliente;
using AbstractFactory.Veiculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Fabrica
{
    internal class EmpresarialClienteVeiculoFabrica : IClienteVeiculoFabrica
    {
        public IVeiculo CriarVeiculo()
        {
            return new CarroEmpresarial();
        }

        public ICliente CriarCliente()
        {
            return new ClienteEmpresarial();
        }
    }
}
