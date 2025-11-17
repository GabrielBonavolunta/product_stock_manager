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

        public void ReadProduct(Product p)
        {
            foreach (var item in Products)
            {
                if (item.Id == p.Id)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public void UpdateProduct(Product p)
        {
            foreach (var item in Products)
            {
                if (item.Id == p.Id)
                {
                    item.Id = p.Id;
                    item.Name = p.Name;
                    item.Price = p.Price;
                    item.Category = p.Category;
                    item.Color = p.Color;
                    item.Seller = p.Seller;

                }
            }
        }


        public void DeleteProduct(Product p)
        {
            var item = Products.FirstOrDefault(x => x.Id == p.Id);
            if (item.Id == p.Id)
            {
                Products.Remove(item);
            }
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
