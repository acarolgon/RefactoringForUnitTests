namespace Store.Domain.Entities
{
    class Product : Entity
    {
        public Product(string title, decimal price, bool active)
        {
            Title = title;
            Price = price;
            Active = active;
        }

        public string Title { get; private set; }
        public decimal Price { get; private set; }
        public bool Active { get; private set; }

        //método para fazer a troca dos valores
        //public void ChangeInfo(string title, decimal price, bool active)
        //{
        //    Title = title;
        //    Price = price;
        //    Active = active;
        //}
    }
}
