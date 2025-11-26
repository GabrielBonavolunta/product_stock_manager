using product_stock_manager.Services;

namespace product_stock_manager.Entities
{
    internal class Category : ICategory
    {
        private int _lastId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();

        public Category(int categoryId, string name)
        {
            CategoryId = categoryId;
            Name = name;
        }

        public void AddProduct(Product p)
        {
            p.Id = _lastId++;
            Products.Add(p);
        }

        public bool ReadProduct(int id)
        {
            var item = Products.FirstOrDefault(x => x.Id == id);
            if (item == null)
            {
                Console.WriteLine("Erro na leitura: ID não existe.");
                return false;
            }

            Console.WriteLine(item);
            return true;
        }

        public bool UpdateProduct(int id, Product newProduct)
        {
            var item = Products.FirstOrDefault(x => x.Id == id);

            if (item == null)
            {
                Console.WriteLine("Erro na atualização: ID não existe.");
                return false;
            }

            item.Name = newProduct.Name;
            item.Price = newProduct.Price;
            item.Category = newProduct.Category;
            item.Color = newProduct.Color;
            item.Seller = newProduct.Seller;

            return true;


        }


        public bool DeleteProduct(int id)
        {
            var item = Products.FirstOrDefault(x => x.Id == id);
            if (item == null)
            {
                Console.WriteLine("Erro ao remover: ID não existe.");
                return false;
            }

            Products.Remove(item);
            return true;
        }

        public void ListAll()
        {
            foreach (var item in Products)
            {
                Console.WriteLine(item);
            }
        }
    }
}
