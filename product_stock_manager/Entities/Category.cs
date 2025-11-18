using product_stock_manager.Services;

namespace product_stock_manager.Entities
{
    internal class Category : ICategory
    {
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
            Products.Add(p);
        }

        public bool ReadProduct(int id)
        {
            var item = Products.FirstOrDefault(x => x.Id == id);
            if (item == null)
            {
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
