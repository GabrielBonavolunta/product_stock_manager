using product_stock_manager.Entities;
using product_stock_manager.Entities.Enums;
using System;
using System.Globalization;

namespace product_stock_manager
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Criação manual de vendedores para referência

            Seller s1 = new Seller(1, "João Victor", "joaovictor@gmail.com");
            Seller s2 = new Seller(2, "Maria Júlia", "mariajulia@gmail.com");
            Seller s3 = new Seller(3, "Gabriel da Silva", "gabrielsilva@gmail.com");
            Seller s4 = new Seller(4, "Mariana Freitas", "marianafreitas@gmail.com");
            Seller currentSeller = null;

            // Criação manual de categorias para referência

            Category c1 = new Category(1, "Smartphones");
            Category c2 = new Category(2, "Notebooks");
            Category c3 = new Category(3, "Tablets");
            Category c4 = new Category(4, "Televisões");
            Category currentCategory = null;

            // Interação com produtos (CRUD)
            char opt = 'S';
            while (opt == 'S' || opt == 's')
            {
                Console.Write("Insira um número para realizar as operações: 1 - Criar, 2 - Ler, 3 - Atualizar, 4 - Deletar, 5 - Listar: ");
                int op = 1; // Valor padrão temporário para o try/catch verificar o tipo do dado
                try
                {
                    op = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Por favor, digite um número.");
                    continue;
                }

                if (op == 1)
                {
                    Console.WriteLine("Defina os dados do produto:");
                    Console.Write("Nome: ");
                    string name = Console.ReadLine();
                    Console.Write("Preço: ");
                    double price = 0.0; // Valor padrão temporário para o try/catch verificar o tipo do dado
                    try
                    {
                        price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    }
                    catch
                    {
                        Console.WriteLine("Por favor, insira um preço válido.");
                        continue;
                    }
                    Console.WriteLine("Escolha uma categoria: 1 - Smartphones, 2 - Notebooks, 3 - Tablets, 4 - Televisões: ");
                    int catId = 1; // Valor padrão temporário para o try/catch verificar o tipo do dado
                    try
                    {
                        catId = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Por favor, digite um número.");
                        continue;
                    }
                    if (catId == 1)
                    {
                        currentCategory = c1;
                    }
                    else if (catId == 2)
                    {
                        currentCategory = c2;
                    }
                    else if (catId == 3)
                    {
                        currentCategory = c3;
                    }
                    else if (catId == 4)
                    {
                        currentCategory = c4;
                    }
                    else
                    {
                        Console.WriteLine("Categoria inválida. Por favor, digite novamente.");
                        continue;
                    }
                    Console.Write("Cor: ");
                    Color color;
                    try
                    {
                        color = Enum.Parse<Color>(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Por favor, insira uma cor válida.");
                        continue;
                    }
                    Console.Write("Escolha um vendedor: 1-4: ");
                    int sellId = 1; // Valor padrão temporário para o try/catch verificar o tipo do dado
                    try
                    {
                        sellId = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Por favor, digite um número.");
                        continue;
                    }
                    if (sellId == 1)
                    {
                        currentSeller = s1;
                    }
                    else if (sellId == 2)
                    {
                        currentSeller = s2;
                    }
                    else if (sellId == 3)
                    {
                        currentSeller = s3;
                    }
                    else if (sellId == 4)
                    {
                        currentSeller = s4;
                    }
                    else
                    {
                        Console.WriteLine("Vendedor inválido. Por favor, digite novamente.");
                        continue;
                    }

                    Product product = new Product(name, price, currentCategory, color, currentSeller);
                    currentCategory.AddProduct(product);
                }
                else if (op == 2)
                {
                    Console.WriteLine("Escolha uma categoria: 1 - Smartphones, 2 - Notebooks, 3 - Tablets, 4 - Televisões: ");
                    int catId = 1; // Valor padrão temporário para o try/catch verificar o tipo do dado
                    try
                    {
                        catId = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Por favor, digite um número.");
                        continue;
                    }
                    if (catId == 1)
                    {
                        currentCategory = c1;
                    }
                    else if (catId == 2)
                    {
                        currentCategory = c2;
                    }
                    else if (catId == 3)
                    {
                        currentCategory = c3;
                    }
                    else if (catId == 4)
                    {
                        currentCategory = c4;
                    }
                    else
                    {
                        Console.WriteLine("Categoria inválida. Por favor, digite novamente.");
                        continue;
                    }
                    Console.Write("Digite o ID do produto a ser lido: ");
                    int id = int.Parse(Console.ReadLine());
                    currentCategory.ReadProduct(id);
                }
                else if (op == 3)
                {

                    Console.WriteLine("Digite os novos dados do produto: ");

                    Console.Write("Nome: ");
                    string name = Console.ReadLine();
                    Console.Write("Preço: ");
                    double price = 0.0;
                    try
                    {
                        price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    }
                    catch
                    {
                        Console.WriteLine("Por favor, insira um preço válido.");
                        continue;
                    }
                    Console.WriteLine("Escolha uma categoria: 1 - Smartphones, 2 - Notebooks, 3 - Tablets, 4 - Televisões: ");
                    int catId = 1; // Valor padrão temporário para o try/catch verificar o tipo do dado
                    try
                    {
                        catId = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Por favor, digite um número.");
                        continue;
                    }
                    ;
                    if (catId == 1)
                    {
                        currentCategory = c1;
                    }
                    else if (catId == 2)
                    {
                        currentCategory = c2;
                    }
                    else if (catId == 3)
                    {
                        currentCategory = c3;
                    }
                    else if (catId == 4)
                    {
                        currentCategory = c4;
                    }
                    else
                    {
                        Console.WriteLine("Categoria inválida. Por favor, digite novamente.");
                        continue;
                    }
                    Console.Write("Cor: ");
                    Color color;
                    try
                    {
                        color = Enum.Parse<Color>(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Por favor, insira uma cor válida.");
                        continue;
                    }
                    Console.Write("Escolha um vendedor: 1-4: ");
                    int sellId = 1; // Valor padrão temporário para o try/catch verificar o tipo do dado
                    try
                    {
                        sellId = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Por favor, digite um número.");
                        continue;
                    }
                    if (sellId == 1)
                    {
                        currentSeller = s1;
                    }
                    else if (sellId == 2)
                    {
                        currentSeller = s2;
                    }
                    else if (sellId == 3)
                    {
                        currentSeller = s3;
                    }
                    else if (sellId == 4)
                    {
                        currentSeller = s4;
                    }
                    else
                    {
                        Console.WriteLine("Vendedor inválido. Por favor, digite novamente.");
                        continue;
                    }

                    Console.Write("Digite o ID do produto a ser atualizado.");
                    int id = 1; // Valor padrão temporário para o try/catch verificar o tipo do dado
                    try
                    {
                        id = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Por favor, digite um número.");
                        continue;
                    }
                    currentCategory.UpdateProduct(id, new Product(name, price, currentCategory, color, currentSeller));
                }
                else if (op == 4)
                {
                    Console.WriteLine("Escolha uma categoria: 1 - Smartphones, 2 - Notebooks, 3 - Tablets, 4 - Televisões: ");
                    int catId = 1; // Valor padrão temporário para o try/catch verificar o tipo do dado
                    try
                    {
                        catId = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Por favor, digite um número.");
                        continue;
                    }
                    if (catId == 1)
                    {
                        currentCategory = c1;
                    }
                    else if (catId == 2)
                    {
                        currentCategory = c2;
                    }
                    else if (catId == 3)
                    {
                        currentCategory = c3;
                    }
                    else if (catId == 4)
                    {
                        currentCategory = c4;
                    }
                    else
                    {
                        Console.WriteLine("Categoria inválida. Por favor, digite novamente.");
                        continue;
                    }
                    Console.Write("Digite o ID do produto a ser deletado: ");
                    int id = int.Parse(Console.ReadLine());
                    currentCategory.DeleteProduct(id);
                }
                else if (op == 5)
                {
                    Console.WriteLine("Escolha uma categoria para listar todos os produtos: 1 - Smartphones, 2 - Notebooks, 3 - Tablets, 4 - Televisões: ");
                    int catId = 1; // Valor padrão temporário para o try/catch verificar o tipo do dado
                    try
                    {
                        catId = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Por favor, digite um número.");
                        continue;
                    }
                    if (catId == 1)
                    {
                        currentCategory = c1;
                    }
                    else if (catId == 2)
                    {
                        currentCategory = c2;
                    }
                    else if (catId == 3)
                    {
                        currentCategory = c3;
                    }
                    else if (catId == 4)
                    {
                        currentCategory = c4;
                    }
                    else
                    {
                        Console.WriteLine("Categoria inválida. Por favor, digite novamente.");
                        continue;
                    }
                    Console.WriteLine("Listando todos os produtos...");
                    currentCategory.ListAll();
                }
                else
                {
                    Console.WriteLine("Por favor, escolha uma das 5 opções acima.");
                }
                Console.WriteLine("Continuar usando o sistema? (S/N).");
                opt = 'S'; // Valor padrão temporário para o try/catch verificar o tipo do dado
                try
                {
                    opt = char.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Por favor, digite um letra válida.");
                    continue;
                }
                if (opt == 'N' || opt == 'n')
                {
                    Console.WriteLine("Obrigado por usar o sistema de estoque de produtos!");
                }
            }
        }
    }
}