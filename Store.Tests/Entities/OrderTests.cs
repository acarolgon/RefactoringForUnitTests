namespace Store.Tests.Entities
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        [TestCategory("Domain")]
        public void OrderGenerateGuid8Caracters() { Assert.Fail(); }

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
