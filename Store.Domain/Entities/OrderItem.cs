namespace Store.Domain.Entities
{
    class OrderItem : Entity
    {
        public OrderItem(Product product, decimal price, int quantity)
        {
            Product = product;
            Price = Product != null ? product.Price : 0;
            Quantity = quantity;
        }

        public Product Product { get; private set; }
        public decimal Price { get; set; }
        public int Quantity { get; private set; }

        public decimal Total() => Price * Quantity;
    }
}
