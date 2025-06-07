using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_POO
{
   public class Relatorio
    {
        public void GerarRelatorio(List<Pedido> pedidos , IDesconto? desconto = null)
        {

            foreach (var pedido in pedidos)
            {
                Console.WriteLine($"Pedido ID: {pedido.Id}");
                Console.WriteLine($"Cliente: {pedido.Cliente.Nome}");
                Console.WriteLine($"Data: {pedido.Data}");

                foreach (var item in pedido.Itens)
                {
                    Console.WriteLine("Produto:");

                    Console.WriteLine($"{item.Produto.Nome} - Preço Unitário: {item.Produto.Preco:C} - Quantidade: {item.Quantidade} - Total: {item.Subtotal:C}");                
                }

                Console.WriteLine($"SubTotal: {pedido.ValorTotal:C}\n");

                if (desconto != null)
                {
                    decimal valorDesconto = desconto.CalcularDesconto(pedido);
                    Console.WriteLine($"Desconto Aplicado: {valorDesconto:C}");
                    Console.WriteLine($"Total com Desconto: {(pedido.ValorTotal - valorDesconto):C}\n-------------------------------------------");

                }
            }
        }
    }
}
