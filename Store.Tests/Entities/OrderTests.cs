
namespace Store.Tests.Entities
{
    [TestClass]
    public class OrderTests
    {
        Order order = new Order(new Customer("Ana Carolina", "anacarolina@mail.com"), 10, new Discount(10, DateTime.Now));


        [TestMethod]
        [TestCategory("Domain")]
        public void OrderIsValid_GenerateGuid8Caracters() {
            Assert.AreEqual(8, order.Number.Length);
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void OrderPaymentStatusWatingPayment() { Assert.Fail(); }

        [TestMethod]
        [TestCategory("Domain")]
        public void OrderPaymentStatusWatingDelivery() { Assert.Fail(); }

        [TestMethod]
        [TestCategory("Domain")]
        public void OrderPaymentStatusCanceled() { Assert.Fail(); }

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
