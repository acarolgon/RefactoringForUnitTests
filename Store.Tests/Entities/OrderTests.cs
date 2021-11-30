
using Store.Domain.Enums;

namespace Store.Tests.Entities
{
    [TestClass]
    public class OrderTests
    {
        private readonly Customer _customer = new Customer("Ana Carolina", "anacarolina@mail.com");
        private readonly Product _product = new Product("Product 1", 10, true);
        private readonly Discount discount = new Discount(10, DateTime.Now.AddDays(5));

        [TestMethod]
        [TestCategory("Domain")]
        public void OrderIsValid_GenerateGuid8Caracters()
        {
            var order = new Order(_customer, 0, null);
            Assert.AreEqual(8, order.Number.Length);
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void OrderIsValid_PaymentStatusWatingPayment()
        {
            var order = new Order(_customer, 0, null);
            Assert.AreEqual(EOrderStatus.WatingPayment, order.Status);
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void OrderIsValid_PaymentStatusWatingDelivery()
        {
            var order = new Order(_customer, 0, null);
            order.AddItem(_product, 1);
            order.Pay(10);
            Assert.AreEqual(EOrderStatus.WatingDelivery, order.Status);
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void OrderPaymentStatusCanceled() {
            var order = new Order(_customer, 0, null);
            order.Cancel();
            Assert.AreEqual(EOrderStatus.Canceled, order.Status);
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void OrderProductNull() { Assert.Fail(); }

        [TestMethod]
        [TestCategory("Domain")]
        public void OrderQuantityIsZero() { Assert.Fail(); }

        [TestMethod]
        [TestCategory("Domain")]
        public void OrderTotalIs50() { Assert.Fail(); }

        [TestMethod]
        [TestCategory("Domain")]
        public void OrderExpiredDiscountTotalIs60() { Assert.Fail(); }

        [TestMethod]
        [TestCategory("Domain")]
        public void OrderInvalidDiscountTotalIs60() { Assert.Fail(); }

        [TestMethod]
        [TestCategory("Domain")]
        public void OrderDiscountIs10TotalIs50() { Assert.Fail(); }

        [TestMethod]
        [TestCategory("Domain")]
        public void OrderDeliveryFeeIs10TotalIs60() { Assert.Fail(); }

        [TestMethod]
        [TestCategory("Domain")]
        public void OrderInvalidCustomer() { Assert.Fail(); }
    }
}
