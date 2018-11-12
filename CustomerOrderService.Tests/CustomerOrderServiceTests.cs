using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CustomerOrderService;

namespace CustomerOrderService.Tests
{
    [TestFixture]
    public class CustomerOrderServiceTests
    {
        [Test]
        [Category("Discount10")]
        public void When_PremiumCustomer_Expect_10PercentDiscount()
        {
            //Arrange
            Customer premiumCustomer = new Customer
            {
                CustomerId = 1,
                CustomerName = "Mahesh",
                CustomerType = CustomerType.Premium
            };

            Order order = new Order
            {
                OrderId = 1,
                ProductId = 212,
                ProductQuantity = 1,
                Amount = 300
            };

            CustomerOrderService customerOrderServiceVar = new CustomerOrderService();

            //Act
            customerOrderServiceVar.ApplyDiscount10Percent(premiumCustomer, order);

            //Assert
            //Assert.AreEqual(order.Amount, 270);
            //Assert.Fail("The test is failed.");
            if (order.Amount < 280)
            {
                Assert.Fail("The test is passed.");
            }
            else
            {
             Assert.Pass("The test is failed");
            }
        }

        [Test]
        [Category("Discount20")]
        public void When_PremiumCustomer_Expect_20PercentDiscount()
        {
            //Arrange
            Customer premiumCustomer = new Customer
            {
                CustomerId = 1,
                CustomerName = "Mahesh",
                CustomerType = CustomerType.Premium
            };

            Order order = new Order
            {
                OrderId = 1,
                ProductId = 212,
                ProductQuantity = 1,
                Amount = 500
            };

            CustomerOrderService customerOrderServiceVar = new CustomerOrderService();

            //Act
            customerOrderServiceVar.ApplyDiscount20Percent(premiumCustomer, order);

            //Assert
            //Assert.AreEqual(order.Amount, 400);
            //Assert.Fail("The test is failed.");

            if (order.Amount > 230)
            {
                Assert.Fail("The test is failed");
            }
        }
    }
}
