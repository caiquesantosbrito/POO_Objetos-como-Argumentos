using System;
using Objeto_Argumento.Classes;

namespace Objeto_Argumento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto(1, "The Last of Us - Part 2" , 299f);
            Produto p2 = new Produto(2, "Call Of Duty - Modern Warfare" , 199f);
            Produto p3 = new Produto(3, "Cyberpunk 2077" , 399f);
            Produto p4 = new Produto(4, "Rocket League" , 199f);

            Carrinho car = new Carrinho();
            car.AdicionarProduto(p1);
            car.AdicionarProduto(p2);
            car.AdicionarProduto(p3);
            car.AdicionarProduto(p4);

            car.MostrarProdutos();

            Produto p5 = new Produto(5, "Resident Evil", 99f);

            car.AlterarItem(4, p5);

            car.MostrarProdutos();
        }
    }
}
