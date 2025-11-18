namespace product_stock_manager.Entities
{
    internal class Seller
    {
        public int SellerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public Seller(int sellerId, string name, string email)
        {
            SellerId = sellerId;
            Name = name;
            Email = email;
        }
    }
}
