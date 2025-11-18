using product_stock_manager.Entities;

namespace product_stock_manager.Services
{
    interface ICategory
    {
        void ListAll();

        void AddProduct(Product product);

        bool ReadProduct(int id);

        bool UpdateProduct(int id, Product newProduct);

        bool DeleteProduct(int id);
    }
}
