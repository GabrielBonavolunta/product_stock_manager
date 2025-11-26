using product_stock_manager.Entities.Enums;
using System.Globalization;

namespace product_stock_manager.Entities
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public double Price { get; set; }

        public Category Category { get; set; }
        public Color Color { get; set; }

        public Seller Seller { get; set; }

        public Product(string name, double price, Category category, Color color, Seller seller)
        {
            Name = name;
            Price = price;
            Category = category;
            Color = color;
            Seller = seller;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Produto: {Name}, Preço: {Price.ToString("F2", CultureInfo.InvariantCulture)}, Categoria: {Category?.Name}, Cor: {Color}, Vendedor: {Seller?.Name}";
        }

    }
}
