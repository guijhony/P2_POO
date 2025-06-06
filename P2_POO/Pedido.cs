using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace P2_POO
{
    public class Pedido
    {
        public Guid Id { get; private set; }
        public Cliente Cliente { get; private set; }
        public List<ItemPedido> Itens { get; private set; }
        public DateTime Data { get; private set; }
        public decimal ValorTotal => Itens.Sum(i => i.Subtotal);

        public Pedido(Cliente cliente, List<ItemPedido> itens)
        {
            if (cliente == null)
                throw new ArgumentException(nameof(cliente));

            if (itens == null || itens.Count <= 0)
                throw new ArgumentException("O pedido deve ter pelo menos 1 produto");

            Id = Guid.NewGuid();
            Cliente = cliente;
            Itens = new List<ItemPedido>(itens);
            Data = DateTime.Now;
        }
    }
}
