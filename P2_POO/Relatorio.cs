using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_POO
{
    class Relatorio
    {
        public void GerarRelatorio(List<Pedido> pedidos)
        {

            foreach (var pedido in pedidos)
            {
                Console.WriteLine($"Pedido ID: {pedido.Id}");
                Console.WriteLine($"Cliente: {pedido.Cliente.Nome}");
                Console.WriteLine($"Data: {pedido.Data}");

                foreach (var produto in pedido.Produtos)
                {
                    Console.WriteLine("Produtos:");

                    Console.WriteLine($" {produto.Nome} - Preço: {produto.Preco:C} - Categoria: {produto.Categoria}");
                }

                Console.WriteLine($"Valor Total: {pedido.ValorTotal:C}");
            }
        }
    }
}
