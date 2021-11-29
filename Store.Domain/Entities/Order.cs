﻿using Flunt.Validations;

namespace Store.Domain.Entities
{
    class Order : Entity
    {
        public Order(Customer customer, decimal deliveryFee, Discount discount)
        {
            AddNotifications(
                new Contract<Notification>()
                    .Requires()
                    .IsNotNull(customer, "Customer", "Cliente inválido")
                );

            Customer = customer;
            Date = DateTime.Now;
            Number = Guid.NewGuid().ToString().Substring(0, 8);
            Status = EOrderStatus.WatingDelivery;
            DeliveryFee = deliveryFee;
            Discount = discount;
            Items = new List<OrderItem>();
        }

        public Customer Customer { get; private set; }
        public DateTime Date { get; private set; }
        public string Number { get; private set; }
        public IList<OrderItem> Items { get; private set; }
        public EOrderStatus Status { get; private set; }
        public Discount Discount { get; set; }
        public decimal DeliveryFee { get; set; }

        public void AddItem(Product product, int quantity)
        {
            var item = new OrderItem(product, quantity);
            if (item.IsValid) //item.Notifications
                Items.Add(item);
        }

        public decimal Total()
        {
            decimal total = 0;
            foreach (var item in Items)
            {
                total += item.Total();
            }

            total += DeliveryFee;
            total -= Discount != null ? Discount.Value() : 0;

            return total;
        }

        public void Pay(decimal amount)
        {
            if (amount == Total())
                this.Status = EOrderStatus.WatingDelivery;
        }

        public void Cancel()
        {
            Status = EOrderStatus.Canceled;
        }
    }

}
