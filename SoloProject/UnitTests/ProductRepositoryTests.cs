using EntityFramework.MoqHelper;
using ModelPoco;
using Moq;
using NUnit.Framework;
using SoloProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestFixture]
    class ProductRepositoryTests
    {
        [Test]
        public void GetAllProducts_ReturnsAnEmptyList_WhenCalled()
        {
            //Arrange
            List<Product> productsInDatabase = new List<Product>();
            var mockDbSet = EntityFrameworkMoqHelper.CreateMockForDbSet<Product>().SetupForQueryOn(productsInDatabase);
            var mockDatabasePlatform = EntityFrameworkMoqHelper.CreateMockForDbContext<SoloProjectEntities, Product>(mockDbSet);
            ProductRepository productRepository = new ProductRepository(mockDatabasePlatform.Object);
            int expectedResult = 0;

            //Act
            List<Product> actualResult = productRepository.GetAllProducts();

            //Assert
            Assert.AreEqual(expectedResult, actualResult.Count);
        }

        [Test]
        public void GetAllProducts_ReturnsAListOfOne_WhenCalledWithOneProductInDatabase()
        {
            //Arrange
            List<Product> productsInDatabase = new List<Product>();
            Mock<Product> mockUser = new Mock<Product>();
            productsInDatabase.Add(mockUser.Object);
            var mockDbSet = EntityFrameworkMoqHelper.CreateMockForDbSet<Product>().SetupForQueryOn(productsInDatabase);
            var mockDatabasePlatform = EntityFrameworkMoqHelper.CreateMockForDbContext<SoloProjectEntities, Product>(mockDbSet);
            ProductRepository productRepository = new ProductRepository(mockDatabasePlatform.Object);
            int expectedResult = 1;

            //Act
            List<Product> actualResult = productRepository.GetAllProducts();

            //Assert
            Assert.AreEqual(expectedResult, actualResult.Count);
        }

        [Test]
        public void GetAllProducts_ReturnsAListOfTwo_WhenCalledWithTwoProductsInDatabase()
        {
            //Arrange
            List<Product> productsInDatabase = new List<Product>();
            Mock<Product> mockProduct = new Mock<Product>();
            productsInDatabase.Add(mockProduct.Object);
            Mock<Product> mockProduct2 = new Mock<Product>();
            productsInDatabase.Add(mockProduct2.Object);
            var mockDbSet = EntityFrameworkMoqHelper.CreateMockForDbSet<Product>().SetupForQueryOn(productsInDatabase);
            var mockDatabasePlatform = EntityFrameworkMoqHelper.CreateMockForDbContext<SoloProjectEntities, Product>(mockDbSet);
            ProductRepository productRepository = new ProductRepository(mockDatabasePlatform.Object);
            int expectedResult = 2;

            //Act
            List<Product> actualResult = productRepository.GetAllProducts();

            //Assert
            Assert.AreEqual(expectedResult, actualResult.Count);
        }

        [Test]
        public void GetProductById_ReturnsNull_WhenPassedProductIdThatDoesNotExistInDatabase()
        {
            //Arrange
            List<Product> productsInDatabase = new List<Product>();
            int userId = 6;
            Mock<Product> mockProduct = new Mock<Product>();
            productsInDatabase.Add(mockProduct.Object);
            var mockDbSet = EntityFrameworkMoqHelper.CreateMockForDbSet<Product>()
                .SetupForQueryOn(productsInDatabase);
            var mockDatabasePlatform = EntityFrameworkMoqHelper.CreateMockForDbContext<SoloProjectEntities, Product>(mockDbSet);
            ProductRepository productRepository = new ProductRepository(mockDatabasePlatform.Object);

            //Act
            Product actualResult = productRepository.GetProductById(userId);

            //Assert
            Assert.IsNull(actualResult);
        }

        [Test]
        public void GetProductById_ReturnsProductFromDatabasePlatformWithProductIdMatchingIntPassedIntoTheMethod_WhenPassedAnInt()
        {
            //Arrange
            List<Product> productsInDatabase = new List<Product>();
            int productId = 1;
            Mock<Product> mockProduct = new Mock<Product>();
            mockProduct.Object.ProductId = productId;
            productsInDatabase.Add(mockProduct.Object);
            var mockDbSet = EntityFrameworkMoqHelper.CreateMockForDbSet<Product>()
                .SetupForQueryOn(productsInDatabase)
                .WithFind(productsInDatabase, "ProductId");
            var mockDatabasePlatform = EntityFrameworkMoqHelper.CreateMockForDbContext<SoloProjectEntities, Product>(mockDbSet);
            ProductRepository productRepository = new ProductRepository(mockDatabasePlatform.Object);

            //Act
            Product actualResult = productRepository.GetProductById(productId);

            //Assert
            Assert.AreSame(mockProduct.Object, actualResult);
        }

        [Test]
        public void GetProductByString_ReturnsZeroProductsFromDatabasePlatformWithSearchTerm_WhenPassedAString()
        {
            //Arrange
            List<Product> productsInDatabase = new List<Product>();
            string product = "product";
            Mock<Product> mockProduct = new Mock<Product>();
            mockProduct.Object.SearchTerms = product;
            productsInDatabase.Add(mockProduct.Object);
            var mockDbSet = EntityFrameworkMoqHelper.CreateMockForDbSet<Product>()
                .SetupForQueryOn(productsInDatabase);
            var mockDatabasePlatform = EntityFrameworkMoqHelper.CreateMockForDbContext<SoloProjectEntities, Product>(mockDbSet);
            ProductRepository productRepository = new ProductRepository(mockDatabasePlatform.Object);
            int expectedNumber = 0;
            string fakeSearchTerm = "Does not exist";

            //Act
            List<Product> actualResult = productRepository.GetProductByString(fakeSearchTerm);

            //Assert
            Assert.AreEqual(expectedNumber, actualResult.Count);
        }

        

        [Test]
        public void GetProductByString_ReturnsOneUserFromDatabasePlatformWithEmailAddressMatchingStringPassedIntoTheMethod_WhenPassedString()
        {
            //Arrange
            List<Product> usersInDatabase = new List<Product>();
            string product = "product";
            Mock<Product> expectedResult = new Mock<Product>();
            expectedResult.Object.SearchTerms = product;
            usersInDatabase.Add(expectedResult.Object);
            var mockDbSet = EntityFrameworkMoqHelper.CreateMockForDbSet<Product>()
                .SetupForQueryOn(usersInDatabase);
            var mockDatabasePlatform = EntityFrameworkMoqHelper.CreateMockForDbContext<SoloProjectEntities, Product>(mockDbSet);
            ProductRepository productRepository = new ProductRepository(mockDatabasePlatform.Object);
            int expectedNumber = 1;

            //Act
            List<Product> actualResult = productRepository.GetProductByString(product);

            //Assert
            Assert.AreEqual(expectedNumber, actualResult.Count);
        }

        [Test]
        public void GetProductByString_ReturnsZeroProductFromDatabasePlatformWithEmailAddressMatchingStringPassedIntoTheMethod_WhenPassedString()
        {
            //Arrange
            List<Product> productsInDatabase = new List<Product>();
            string searchTerm = "Phone";
            Mock<Product> expectedResult = new Mock<Product>();
            expectedResult.Object.SearchTerms = searchTerm;
            productsInDatabase.Add(expectedResult.Object);
            var mockDbSet = EntityFrameworkMoqHelper.CreateMockForDbSet<Product>()
                .SetupForQueryOn(productsInDatabase);
            var mockDatabasePlatform = EntityFrameworkMoqHelper.CreateMockForDbContext<SoloProjectEntities, Product>(mockDbSet);
            ProductRepository productRepository = new ProductRepository(mockDatabasePlatform.Object);
            List<Product> expectedList = productsInDatabase.ToList();

            //Act
            List<Product> actualResult = productRepository.GetProductByString(searchTerm);

            //Assert
            Assert.AreEqual(expectedList, actualResult);
        }

        [Test]
        public void GetProductByString_ReturnsOneProductFromDatabasePlatformWithSearchTermMatchingStringPassedIntoTheMethodWithTwoProductsInDatabase_WhenPassedString()
        {
            //Arrange
            List<Product> productsInDatabase = new List<Product>();
            string product = "Product";
            string product2 = "Product2";
            Mock<Product> mockProduct = new Mock<Product>();
            mockProduct.Object.SearchTerms = product;
            productsInDatabase.Add(mockProduct.Object);
            Mock<Product> mockProduct2 = new Mock<Product>();
            mockProduct2.Object.SearchTerms = product2;
            productsInDatabase.Add(mockProduct2.Object);
            var mockDbSet = EntityFrameworkMoqHelper.CreateMockForDbSet<Product>()
                .SetupForQueryOn(productsInDatabase);
            var mockDatabasePlatform = EntityFrameworkMoqHelper.CreateMockForDbContext<SoloProjectEntities, Product>(mockDbSet);
            ProductRepository productRepository = new ProductRepository(mockDatabasePlatform.Object);
            int expectedNumber = 1;

            //Act
            List<Product> actualResult = productRepository.GetProductByString(product2);

            //Assert
            Assert.AreEqual(expectedNumber, actualResult.Count);
        }

        [Test]
        public void GetProductByString_ReturnsTwoProductsFromDatabasePlatformWithSearchTermMatchingStringPassedIntoTheMethodWithTwoProductsInDatabase_WhenPassedString()
        {
            //Arrange
            List<Product> productsInDatabase = new List<Product>();
            string product = "Product";
            string product2 = "Product";
            Mock<Product> mockProduct = new Mock<Product>();
            mockProduct.Object.SearchTerms = product;
            productsInDatabase.Add(mockProduct.Object);
            Mock<Product> mockProduct2 = new Mock<Product>();
            mockProduct2.Object.SearchTerms = product2;
            productsInDatabase.Add(mockProduct2.Object);
            var mockDbSet = EntityFrameworkMoqHelper.CreateMockForDbSet<Product>()
                .SetupForQueryOn(productsInDatabase);
            var mockDatabasePlatform = EntityFrameworkMoqHelper.CreateMockForDbContext<SoloProjectEntities, Product>(mockDbSet);
            ProductRepository productRepository = new ProductRepository(mockDatabasePlatform.Object);
            int expectedNumber = 2;

            //Act
            List<Product> actualResult = productRepository.GetProductByString(product2);

            //Assert
            Assert.AreEqual(expectedNumber, actualResult.Count);
        }

        [Test]
        public void AddProduct_ReturnsProductFromDatabasePlatformWithEmployeeIdMatchingIntPassedIntoTheMethod_WhenPassedAnInt()
        {
            //Arrange
            List<Product> productsInDatabase = new List<Product>();
            var mockDbSet = EntityFrameworkMoqHelper.CreateMockForDbSet<Product>()
                .SetupForQueryOn(productsInDatabase)
                .WithAdd(productsInDatabase);
            var mockDatabasePlatform = EntityFrameworkMoqHelper.CreateMockForDbContext<SoloProjectEntities, Product>(mockDbSet);
            ProductRepository productRepository = new ProductRepository(mockDatabasePlatform.Object);
            Mock<Product> expectedResult = new Mock<Product>();

            //Act
            productRepository.AddProduct(expectedResult.Object);

            //Assert
            Assert.IsTrue(mockDbSet.Object.Contains(expectedResult.Object));
        }

        [Test]
        public void EditProduct_ProductObjectInDatabasePlatformWithProductIdMatchingProductIdOfProductrObjectPassedInHasSameName_WhenPassedAProductObject()
        {
            //Arrange
            List<Product> productsInDatabase = new List<Product>();
            int productId = 1;
            Mock<Product> mockProduct = new Mock<Product>();
            mockProduct.Object.ProductId = productId;
            mockProduct.Object.Name = "Product";
            productsInDatabase.Add(mockProduct.Object);
            var mockDbSet = EntityFrameworkMoqHelper.CreateMockForDbSet<Product>()
                .SetupForQueryOn(productsInDatabase)
                .WithFind(productsInDatabase, "ProductId");
            var mockDatabasePlatform = EntityFrameworkMoqHelper.CreateMockForDbContext<SoloProjectEntities, Product>(mockDbSet);
            ProductRepository productRepository = new ProductRepository(mockDatabasePlatform.Object);
            string expectedResult = "New product";
            Mock<Product> mockUpdatedProduct = new Mock<Product>();
            mockUpdatedProduct.Object.ProductId = productId;
            mockUpdatedProduct.Object.Name = expectedResult;

            //Act
            productRepository.EditProduct(mockUpdatedProduct.Object);

            //Assert
            Assert.AreEqual(expectedResult, productsInDatabase[0].Name);
        }

        [Test]
        public void RemoveProduct_ProductObjectInDatabasePlatformWithProductIdMatchingIntPassedIsNoLongerInDatabasePlatform_WhenPassedAnInt()
        {
            //Arrange
            List<Product> productsInDatabase = new List<Product>();
            int productId = 1;
            Mock<Product> mockProduct = new Mock<Product>();
            mockProduct.Object.ProductId = productId;
            productsInDatabase.Add(mockProduct.Object);
            var mockDbSet = EntityFrameworkMoqHelper.CreateMockForDbSet<Product>()
               .SetupForQueryOn(productsInDatabase)
               .WithFind(productsInDatabase, "ProductId")
               .WithRemove(productsInDatabase);
            var mockDatabasePlatform = EntityFrameworkMoqHelper.CreateMockForDbContext<SoloProjectEntities, Product>(mockDbSet);
            ProductRepository productRepository = new ProductRepository(mockDatabasePlatform.Object);

            //Act
            productRepository.RemoveProduct(productId);

            //Assert
            Assert.IsFalse(productsInDatabase.Contains(mockProduct.Object));
        }
    }
}
