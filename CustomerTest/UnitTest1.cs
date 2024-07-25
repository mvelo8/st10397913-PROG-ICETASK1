namespace CustomerTest
{
    
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void CreateCustomer_ValidData_CorrectlyInitialized()
        {
            // Arrange
            string name = "Mpimpi Hloni";
            string email = "mpimpi12@gmail.com";
            string phone = "0589567894";
            decimal balance = 1000;
            DateTime lastPurchase = new DateTime(2023, 6, 15);

            Customer customer = new Customer(name, email, phone, balance, lastPurchase);

            // Assert
            Assert.AreEqual(name, customer[0]);
            Assert.AreEqual(email, customer["Email"]);
            Assert.AreEqual(phone, customer[2]);
            Assert.AreEqual(balance, customer["Balance"]);
            Assert.AreEqual(lastPurchase, customer["LastPurchase"]);
        }

        [TestMethod]
        public void UpdateCustomer_ValidData_CorrectlyUpdated()
        {
            // Arrange
            string name = "Mpimpi Hloni";
            string email = "mpimpi12@gamil.com";
            string phone = "0589567894";
            decimal balance = 1000;
            DateTime lastPurchase = new DateTime(2023, 6, 15);
            Customer customer = new Customer(name, email, phone, balance, lastPurchase);

            // Act
            customer[0] = "Jane Doe";
            customer["Email"] = "jane.doe@example.com";
            customer[2] = "555-5678";
            customer["Balance"] = 500.00m;
            customer["LastPurchase"] = new DateTime(2023, 8, 1);

            // Assert
            Assert.AreEqual("Jane Doe", customer[0]);
            Assert.AreEqual("jane.doe@example.com", customer["Email"]);
            Assert.AreEqual("555-5678", customer[2]);
            Assert.AreEqual(500.00m, customer["Balance"]);
            Assert.AreEqual(new DateTime(2023, 8, 1), customer["LastPurchase"]);
        }
       

        [TestMethod]
        public void GetCustomer_InvalidIndex_ReturnsNull()
        {
            // Arrange
            string name = "John Doe";
            string email = "john.doe@example.com";
            string phone = "555-1234";
            decimal balance = 1000.00m;
            DateTime lastPurchase = new DateTime(2023, 6, 15);
            Customer customer = new Customer(name, email, phone, balance, lastPurchase);

            // Act
            object result = customer[5];

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void GetCustomer_InvalidPropertyName_ReturnsNull()
        {
            // Arrange
            string name = "John Doe";
            string email = "john.doe@example.com";
            string phone = "555-1234";
            decimal balance = 1000.00m;
            DateTime lastPurchase = new DateTime(2023, 6, 15);
            Customer customer = new Customer(name, email, phone, balance, lastPurchase);

            // Act
            object result = customer["InvalidProperty"];

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void UpdateCustomer_InvalidIndex_DoesNotUpdate()
        {
            // Arrange
            string name = "John Doe";
            string email = "john.doe@example.com";
            string phone = "555-1234";
            decimal balance = 1000.00m;
            DateTime lastPurchase = new DateTime(2023, 6, 15);
            Customer customer = new Customer(name, email, phone, balance, lastPurchase);

            // Act
            customer[5] = "New Name";

            // Assert
            Assert.AreEqual(name, customer[0]);
            Assert.AreEqual(email, customer["Email"]);
            Assert.AreEqual(phone, customer[2]);
            Assert.AreEqual(balance, customer["Balance"]);
            Assert.AreEqual(lastPurchase, customer["LastPurchase"]);
        }
    }
}