using System;
using System.Globalization;

namespace Products {
    class Program {
        static void Main(string[] args) {

            Product product = new Product();

            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            product.Name = Console.ReadLine();

            Console.Write("Preço: ");
            product.Value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            product.Amount = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + product);

            Console.WriteLine();
            Console.Write("Digite o numero de produtos a ser adicionado:");
            int value = int.Parse(Console.ReadLine());
            product.AddProducts(value);

            Console.WriteLine("Dados atualizados: " + product);

            Console.WriteLine();
            Console.Write("Digite o numero de produtos a ser removido:");
            value = int.Parse(Console.ReadLine());
            product.RemoveProducts(value);

            Console.WriteLine("Dados atualizados: " + product);

        }
    }
}
