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
        public List<Produto> Produtos { get; private set; }
        public DateTime Data { get; private set; }
        public decimal ValorTotal => Produtos.Sum(p => p.Preco);

        public Pedido(Cliente cliente, List<Produto> produtos)
        {
            if (cliente == null)
                throw new ArgumentException(nameof(cliente));

            if (produtos == null || produtos.Count <= 0)
                throw new ArgumentException("O pedido deve ter pelo menos 1 produto");

            Id = Guid.NewGuid();
            Cliente = cliente;
            Produtos = new List<Produto>(produtos);
            Data = DateTime.Now;
        }
    }
}
