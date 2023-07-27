using AbstractFactory.Cliente;
using AbstractFactory.Veiculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Fabrica
{
    public interface IClienteVeiculoFabrica
    {
        IVeiculo CriarVeiculo();
        ICliente CriarCliente();
    }
}
