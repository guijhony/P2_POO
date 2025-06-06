using System;
using P2_POO;

class Program
{
    static void Main(string[] args)
    {
        Cliente cliente1 = new Cliente("Guilherme", "gui@gmail.com", "000000000/00");

        Produto produto1 = new Produto("Notebook", 3000.00m, "Eletronico");
        Produto produto2 = new Produto("Geladeira", 5000m, "Eletrodomssticos");
        Produto produto3 = new Produto("Boneca", 100m, "Brinquedo");
        
        Pedido pedido1 = new Pedido(cliente1, new List<Produto> { produto1, produto2 });

        var pedidos = new List<Pedido> { pedido };

        
        var relatorio = new Relatorio();
        relatorio.GerarRelatorio(pedidos);
    }
}

