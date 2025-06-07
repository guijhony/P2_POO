using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_POO
{
    public class DescontoQuantidade:IDesconto
    {
        private readonly int _quantidade;
        private readonly decimal _porcentage;

        public DescontoQuantidade(int quantidade, decimal porcentage)
        {
            _quantidade = quantidade;
            _porcentage = porcentage;
        }

        public decimal CalcularDesconto(Pedido pedido)
        {
            return pedido.Itens
                .Where(i => i.Quantidade >= _quantidade)
                .Sum(i => i.Subtotal * _porcentage);
        }
    }
}
