using AbstractFactory.Cliente;
using AbstractFactory.Fabrica;
using AbstractFactory.Veiculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IClienteVeiculoFabrica empresarialFabrica = new EmpresarialClienteVeiculoFabrica();
            IVeiculo carroEmpresarial = empresarialFabrica.CriarVeiculo();
            ICliente clienteEmpresarial = empresarialFabrica.CriarCliente();

            IClienteVeiculoFabrica individualFabrica = new IndividualClienteVeiculoFabrica();
            IVeiculo carroIndividual = individualFabrica.CriarVeiculo();
            ICliente clienteIndividual = individualFabrica.CriarCliente();

            clienteEmpresarial.ExibirCliente();
            carroEmpresarial.Dirigir();

            clienteIndividual.ExibirCliente();
            carroIndividual.Dirigir();

            Console.ReadKey();
        }
    }
}
