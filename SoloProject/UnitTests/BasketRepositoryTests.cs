﻿using EntityFramework.MoqHelper;
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
    class BasketRepositoryTests
    {
        [Test]
        public void AddBasketToUser_()
        {
            //Arrange
            List<User> usersInDatabase = new List<User>();
            int userId = 1;
            Mock<User> mockUser = new Mock<User>();
            mockUser.Object.UserId = userId;
            usersInDatabase.Add(mockUser.Object);
            var mockDbSet = EntityFrameworkMoqHelper.CreateMockForDbSet<User>()
                .SetupForQueryOn(usersInDatabase)
                .WithFind(usersInDatabase, "UserId");
            var mockDatabasePlatform = EntityFrameworkMoqHelper.CreateMockForDbContext<SoloProjectEntities, User>(mockDbSet);
            BasketRepository basketRepository = new BasketRepository(mockDatabasePlatform.Object);
            Mock<Basket> mockBasket = new Mock<Basket>();

            //Act
            basketRepository.AddBasketToUser(userId, mockBasket.Object);

            //Assert
            CollectionAssert.Contains(mockDatabasePlatform.Object.Users.ToList()[0].Baskets, mockBasket.Object);
        }
    }
}
