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
        [TestCase]
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
                Amount = 150
            };

            CustomerOrderService customerOrderServiceVar = new CustomerOrderService();

            //Act
            customerOrderServiceVar.ApplyDiscount(premiumCustomer, order);

            //Assert
            Assert.AreEqual(order.Amount, 130);
        }
    }
}
