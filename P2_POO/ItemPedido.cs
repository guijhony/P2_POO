using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_POO
{
    public class ItemPedido
    {
        public Produto Produto { get; private set; }
        public int Quantidade { get; private set; }
        public decimal Subtotal => Produto.Preco * Quantidade;

        public ItemPedido(Produto produto, int quantidade)
        {
            if (produto == null)
                throw new ArgumentNullException(nameof(produto));

            if (quantidade <= 0)
                throw new ArgumentException("A quantidade deve ser maior que zero.");

            Produto = produto;
            Quantidade = quantidade;
        }
    }
}
