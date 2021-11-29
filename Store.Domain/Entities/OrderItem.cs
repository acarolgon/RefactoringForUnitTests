namespace Store.Domain.Entities
{
    class OrderItem : Entity
    {

        public OrderItem(Product product, int quantity)
        {
            AddNotifications(new Contract<Notification>()
                .Requires()
                .IsNotNull(product, "Product", "Produto inválido")
                .IsGreaterThan(quantity, 0, "Quantity", "A quantidade deve ser maior que zero"));

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
