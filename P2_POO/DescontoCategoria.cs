using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_POO
{
   public class DescontoCategoria: IDesconto
    {
        private readonly string _categoria;
        private readonly decimal _porcentagem;

        public DescontoCategoria(string categoria, decimal porcentagem)
        {
            _categoria = categoria;
            _porcentagem = porcentagem;
        }

        public decimal CalcularDesconto(Pedido pedido)
        {
            return pedido.Itens
                .Where(i => i.Produto.Categoria == _categoria)
                .Sum(i => i.Subtotal * _porcentagem);

        }
    }
}
