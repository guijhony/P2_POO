using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_POO
{
    public class Produto
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public decimal Preco { get; private set; }
        public string Categoria { get; private set; }

        public Produto(string nome, decimal preco, string categoria)
        {
          
            if (string.IsNullOrEmpty(nome))
                throw new ArgumentException("Nome do produto invalido.");

            if (preco <= 0)
                throw new ArgumentException("Preço do produto invalido.");

            if (string.IsNullOrEmpty(categoria))
                throw new ArgumentException("Categoria do produto invalida");

            Nome = nome;
            Preco = preco;
            Categoria = categoria;
            Id = Guid.NewGuid();
        }
    }
}
