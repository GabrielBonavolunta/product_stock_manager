using product_stock_manager.Entities;

namespace product_stock_manager.Services
{
    interface ICategory
    {
        void ListAll();

        void AddProduct(Product product);

        void ReadProduct(Product product);

        void UpdateProduct(Product product);

        void DeleteProduct(Product product);
    }
}
