using System;
using P2_POO;

class Program
{
    static void Main(string[] args)
    {
        Cliente cliente1 = new Cliente("Guilherme", "gui@gmail.com", "000000000/00");
        //testando se ia dar erro declarando dados ivalidos
        //Cliente cliente2 = new Cliente("", "", "");

        Produto produto1 = new Produto("Notebook", 3000.00m, "Eletronico");
        Produto produto2 = new Produto("Geladeira", 5000m, "Eletrodomestico");
        Produto produto3 = new Produto("Boneca", 100m, "Brinquedo");

        var itensPedido1 = new List<ItemPedido>
        {
            new ItemPedido(produto1, 1),
            new ItemPedido(produto2, 2)
        };

        var itensPedido2 = new List<ItemPedido>
        {
            new ItemPedido(produto2, 1),
            new ItemPedido(produto3, 3)
        };

        Pedido pedido1 = new Pedido(cliente1, itensPedido1);
        Pedido pedido2 = new Pedido(cliente1, itensPedido2);

        DescontoCategoria desconto1 = new DescontoCategoria("Eletronico", 0.10m);
        DescontoCategoria desconto2 = new DescontoCategoria("Eletrodomestico", 0.30m);

        var pedidos = new List<Pedido> { pedido1, pedido2};

        var relatorio = new Relatorio();
        relatorio.GerarRelatorio(new List<Pedido> { pedido1 }, desconto1);
        relatorio.GerarRelatorio(new List<Pedido> { pedido2 });


    }
}

