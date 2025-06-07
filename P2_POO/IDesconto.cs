using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_POO
{
     public interface IDesconto
    {
        decimal CalcularDesconto(Pedido pedido);
    }
}
