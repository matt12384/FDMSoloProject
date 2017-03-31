using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelPoco;
using EntityFramework.MoqHelper;
using SoloProject;
using Moq;

namespace UnitTests
{
    class UsersRepositoryTests
    {
        [Test]
        public void GetAllUsers_ReturnsAnEmptyListWhenNoUsersInDatabase_WhenCalled()
        {
            //Arrange
            List<User> usersInDatabase = new List<User>();
            var mockDbSet = EntityFrameworkMoqHelper.CreateMockForDbSet<User>().SetupForQueryOn(usersInDatabase);
            var mockDatabasePlatform = EntityFrameworkMoqHelper.CreateMockForDbContext<SoloProjectEntities, User>(mockDbSet);
            UsersRepository usersRepository = new UsersRepository(mockDatabasePlatform.Object);
            int expectedResult = 0;

            //Act
            List<User> actualResult = usersRepository.GetAllUsers();

            //Assert
            Assert.AreEqual(expectedResult, actualResult.Count);
        }

        [Test]
        public void GetAllUsers_ReturnsAListOfOneWhenOneUserIsInDatabase_WhenCalled()
        {
            //Arrange
            List<User> usersInDatabase = new List<User>();
            Mock<User> mockUser = new Mock<User>();
            usersInDatabase.Add(mockUser.Object);
            var mockDbSet = EntityFrameworkMoqHelper.CreateMockForDbSet<User>().SetupForQueryOn(usersInDatabase);
            var mockDatabasePlatform = EntityFrameworkMoqHelper.CreateMockForDbContext<SoloProjectEntities, User>(mockDbSet);
            UsersRepository usersRepository = new UsersRepository(mockDatabasePlatform.Object);
            int expectedResult = 1;

            //Act
            List<User> actualResult = usersRepository.GetAllUsers();

            //Assert
            Assert.AreEqual(expectedResult, actualResult.Count);
        }

        [Test]
        public void GetAllUsers_ReturnsAListOfTwoWhenTwoUsersAreInDatabase_WhenCalled()
        {
            //Arrange
            List<User> usersInDatabase = new List<User>();
            Mock<User> mockUser = new Mock<User>();
            usersInDatabase.Add(mockUser.Object);
            Mock<User> mockUser2 = new Mock<User>();
            usersInDatabase.Add(mockUser2.Object);
            var mockDbSet = EntityFrameworkMoqHelper.CreateMockForDbSet<User>().SetupForQueryOn(usersInDatabase);
            var mockDatabasePlatform = EntityFrameworkMoqHelper.CreateMockForDbContext<SoloProjectEntities, User>(mockDbSet);
            UsersRepository usersRepository = new UsersRepository(mockDatabasePlatform.Object);
            int expectedResult = 2;

            //Act
            List<User> actualResult = usersRepository.GetAllUsers();

            //Assert
            Assert.AreEqual(expectedResult, actualResult.Count);
        }

        [Test]
        public void GetUserById_ReturnsNull_WhenPassedUserIdThatDoesNotExistInDatabase()
        {
            //Arrange
            List<User> usersInDatabase = new List<User>();
            int userId = 6;
            Mock<User> mockUser = new Mock<User>();
            usersInDatabase.Add(mockUser.Object);
            var mockDbSet = EntityFrameworkMoqHelper.CreateMockForDbSet<User>()
                .SetupForQueryOn(usersInDatabase)
                .WithFind(usersInDatabase, "UserId");
            var mockDatabasePlatform = EntityFrameworkMoqHelper.CreateMockForDbContext<SoloProjectEntities, User>(mockDbSet);
            UsersRepository usersRepository = new UsersRepository(mockDatabasePlatform.Object);

            //Act
            User actualResult = usersRepository.GetUserById(userId);

            //Assert
            Assert.AreSame(null, actualResult);
        }

        [Test]
        public void GetUserById_ReturnsUserFromDatabasePlatformWithUserIdMatchingIntPassedIntoTheMethod_WhenPassedAnInt()
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
            UsersRepository usersRepository = new UsersRepository(mockDatabasePlatform.Object);

            //Act
            User actualUser = usersRepository.GetUserById(userId);

            //Assert
            Assert.AreSame(mockUser.Object, actualUser);
        }

        [Test]
        public void GetUserByEmailAddress_ReturnsZeroFromDatabasePlatformWithEmailAddressMatchingStringPassedIntoTheMethod_WhenPassedString()
        {
            //Arrange
            List<User> usersInDatabase = new List<User>();
            string emailAddress = "email@email.com";
            Mock<User> mockUser = new Mock<User>();
            mockUser.Object.EmailAddress = emailAddress;
            usersInDatabase.Add(mockUser.Object);
            var mockDbSet = EntityFrameworkMoqHelper.CreateMockForDbSet<User>()
                .SetupForQueryOn(usersInDatabase);
            var mockDatabasePlatform = EntityFrameworkMoqHelper.CreateMockForDbContext<SoloProjectEntities, User>(mockDbSet);
            UsersRepository usersRepository = new UsersRepository(mockDatabasePlatform.Object);
            int expectedNumber = 0;
            string fakeEmail = "fakeEmail@email.com";

            //Act
            List<User> actualResult = usersRepository.GetUserByString(fakeEmail);

            //Assert
            Assert.AreEqual(expectedNumber, actualResult.Count);
        }

        [Test]
        public void GetUserByEmailAddress_ReturnsOneUserFromDatabasePlatformWithEmailAddressMatchingStringPassedIntoTheMethod_WhenPassedString()
        {
            //Arrange
            List<User> usersInDatabase = new List<User>();
            string emailAddress = "email@email.com";
            Mock<User> mockUser = new Mock<User>();
            mockUser.Object.EmailAddress = emailAddress;
            usersInDatabase.Add(mockUser.Object);
            var mockDbSet = EntityFrameworkMoqHelper.CreateMockForDbSet<User>()
                .SetupForQueryOn(usersInDatabase);
            var mockDatabasePlatform = EntityFrameworkMoqHelper.CreateMockForDbContext<SoloProjectEntities, User>(mockDbSet);
            UsersRepository usersRepository = new UsersRepository(mockDatabasePlatform.Object);
            int expectedNumber = 1;

            //Act
            List<User> actualResult = usersRepository.GetUserByString(emailAddress);

            //Assert
            Assert.AreEqual(expectedNumber, actualResult.Count);
        }

        [Test]
        public void GetUserByEmailAddress_ReturnsOneUserFromDatabasePlatformWithEmailAddressMatchingStringPassedIntoTheMethodWithTwoUsersInDatabase_WhenPassedString()
        {
            //Arrange
            List<User> usersInDatabase = new List<User>();
            string emailAddress = "email@email.com";
            string emailAddress2 = "email2@email.com";
            Mock<User> mockUser = new Mock<User>();
            mockUser.Object.EmailAddress = emailAddress;
            usersInDatabase.Add(mockUser.Object);
            Mock<User> mockUser2 = new Mock<User>();
            mockUser2.Object.EmailAddress = emailAddress2;
            usersInDatabase.Add(mockUser2.Object);
            var mockDbSet = EntityFrameworkMoqHelper.CreateMockForDbSet<User>()
                .SetupForQueryOn(usersInDatabase);
            var mockDatabasePlatform = EntityFrameworkMoqHelper.CreateMockForDbContext<SoloProjectEntities, User>(mockDbSet);
            UsersRepository usersRepository = new UsersRepository(mockDatabasePlatform.Object);
            int expectedNumber = 1;

            //Act
            List<User> actualResult = usersRepository.GetUserByString(emailAddress2);

            //Assert
            Assert.AreEqual(expectedNumber, actualResult.Count);
        }

        [Test]
        public void GetUserByEmailAddress_UserFoundByMethodIsTheSameAsUserInDatabase_WhenPassedString()
        {
            //Arrange
            List<User> usersInDatabase = new List<User>();
            string emailAddress = "email@email.com";
            Mock<User> mockUser = new Mock<User>();
            mockUser.Object.EmailAddress = emailAddress;
            usersInDatabase.Add(mockUser.Object);
            var mockDbSet = EntityFrameworkMoqHelper.CreateMockForDbSet<User>()
                .SetupForQueryOn(usersInDatabase);
            var mockDatabasePlatform = EntityFrameworkMoqHelper.CreateMockForDbContext<SoloProjectEntities, User>(mockDbSet);
            UsersRepository usersRepository = new UsersRepository(mockDatabasePlatform.Object);
            List<User> expectedList = usersInDatabase.ToList();

            //Act
            List<User> actualResult = usersRepository.GetUserByString(emailAddress);

            //Assert
            Assert.AreEqual(expectedList, actualResult);
        }

        [Test]
        public void GetUserByEmailAddress_ReturnsTwoUsersFromDatabasePlatformWithEmailAddressMatchingStringPassedIntoTheMethod_WhenPassedString()
        {
            //Arrange
            List<User> usersInDatabase = new List<User>();
            string emailAddress = "email@email.com";
            Mock<User> mockUser = new Mock<User>();
            mockUser.Object.EmailAddress = emailAddress;

            usersInDatabase.Add(mockUser.Object);
            Mock<User> mockUser2 = new Mock<User>();
            mockUser2.Object.EmailAddress = emailAddress;
            usersInDatabase.Add(mockUser2.Object);
            var mockDbSet = EntityFrameworkMoqHelper.CreateMockForDbSet<User>()
                .SetupForQueryOn(usersInDatabase);
            var mockDatabasePlatform = EntityFrameworkMoqHelper.CreateMockForDbContext<SoloProjectEntities, User>(mockDbSet);
            UsersRepository usersRepository = new UsersRepository(mockDatabasePlatform.Object);
            int expectedNumber = 2;

            //Act
            List<User> actualResult = usersRepository.GetUserByString(emailAddress);

            //Assert
            Assert.AreEqual(expectedNumber, actualResult.Count);
        }

        [Test]
        public void AddUser_AddsUserToDatabase_WhenPassedAUserObject()
        {
            //Arrange
            List<User> usersInDatabase = new List<User>();
            var mockDbSet = EntityFrameworkMoqHelper.CreateMockForDbSet<User>()
                .SetupForQueryOn(usersInDatabase)
                .WithAdd(usersInDatabase);
            var mockDatabasePlatform = EntityFrameworkMoqHelper.CreateMockForDbContext<SoloProjectEntities, User>(mockDbSet);
            UsersRepository usersRepository = new UsersRepository(mockDatabasePlatform.Object);
            Mock<User> expectedUser = new Mock<User>();
            //Act
            usersRepository.AddUser(expectedUser.Object);

            //Assert
            Assert.IsTrue(mockDbSet.Object.Contains(expectedUser.Object));
        }

        [Test]
        public void EditUser_FirstNameChanges_WhenPassedAUserObject()
        {
            //Arrange
            List<User> usersInDatabase = new List<User>();
            int userId = 1;
            Mock<User> mockUser = new Mock<User>();
            mockUser.Object.UserId = userId;
            mockUser.Object.FirstName = "Name";
            usersInDatabase.Add(mockUser.Object);
            var mockDbSet = EntityFrameworkMoqHelper.CreateMockForDbSet<User>()
                .SetupForQueryOn(usersInDatabase)
                .WithFind(usersInDatabase, "UserId");
            var mockDatabasePlatform = EntityFrameworkMoqHelper.CreateMockForDbContext<SoloProjectEntities, User>(mockDbSet);
            UsersRepository usersRepository = new UsersRepository(mockDatabasePlatform.Object);
            string expectedResult = "New name";
            Mock<User> mockUpdatedUsername = new Mock<User>();
            mockUpdatedUsername.Object.UserId = userId;
            mockUpdatedUsername.Object.FirstName = expectedResult;

            //Act
            usersRepository.EditUser(mockUpdatedUsername.Object);

            //Assert
            Assert.AreEqual(expectedResult, usersInDatabase[0].FirstName);
        }

        [Test]
        public void EditPassword_ChangesPasswordInDatabase_WhenPassedAUserObject()
        {
            //Arrange
            List<User> usersInDatabase = new List<User>();
            int userId = 1;
            Mock<User> mockUser = new Mock<User>();
            mockUser.Object.UserId = userId;
            mockUser.Object.Password = "Password";
            usersInDatabase.Add(mockUser.Object);
            var mockDbSet = EntityFrameworkMoqHelper.CreateMockForDbSet<User>()
                .SetupForQueryOn(usersInDatabase)
                .WithFind(usersInDatabase, "UserId");
            var mockDatabasePlatform = EntityFrameworkMoqHelper.CreateMockForDbContext<SoloProjectEntities, User>(mockDbSet);
            UsersRepository usersRepository = new UsersRepository(mockDatabasePlatform.Object);
            string expectedNewPassword = "New password";
            Mock<User> mockUpdatedUsername = new Mock<User>();
            mockUpdatedUsername.Object.UserId = userId;
            mockUpdatedUsername.Object.Password = expectedNewPassword;

            //Act
            usersRepository.EditPassword(mockUpdatedUsername.Object);

            //Assert
            Assert.AreEqual(expectedNewPassword, usersInDatabase[0].Password);
        }

        [Test]
        public void RemoveUser_UserObjectInDatabasePlatformWithUserIdMatchingIntPassedIsNoLongerInDatabasePlatform_WhenPassedAnInt()
        {
            //Arrange
            List<User> usersInDatabase = new List<User>();
            int userId = 1;
            Mock<User> mockUser = new Mock<User>();
            mockUser.Object.UserId = userId;
            usersInDatabase.Add(mockUser.Object);
            var mockDbSet = EntityFrameworkMoqHelper.CreateMockForDbSet<User>()
               .SetupForQueryOn(usersInDatabase)
               .WithFind(usersInDatabase, "UserId")
               .WithRemove(usersInDatabase);
            var mockDatabasePlatform = EntityFrameworkMoqHelper.CreateMockForDbContext<SoloProjectEntities, User>(mockDbSet);
            UsersRepository usersRepository = new UsersRepository(mockDatabasePlatform.Object);

            //Act
            usersRepository.RemoveUser(userId);

            //Assert
            Assert.IsFalse(usersInDatabase.Contains(mockUser.Object));
        }

        //[Test]
        //public void IsValid_ReturnsTrueWhenUserObecjtInDatabaseHasSameUsernameAndPasswordAsString_WhenPassedStrings()
        //{
        //    //Arrange
        //    List<User> usersInDatabase = new List<User>();
        //    int userId = 1;
        //    string emailAddress = "email@email.com";
        //    string password = "password";
        //    Mock<User> mockUser = new Mock<User>();
        //    mockUser.Object.UserId = userId;
        //    mockUser.Object.EmailAddress = emailAddress;
        //    mockUser.Object.Password = password;
        //    var mockDbSet = EntityFrameworkMoqHelper.CreateMockForDbSet<User>()
        //      .SetupForQueryOn(usersInDatabase);
        //    var mockDatabasePlatform = EntityFrameworkMoqHelper.CreateMockForDbContext<SoloProjectEntities, User>(mockDbSet);
        //    UsersRepository projectRepository = new UsersRepository(mockDatabasePlatform.Object);

        //    //Act
        //    bool value = projectRepository.IsValid(emailAddress, password);

        //    //Assert
        //    Assert.IsTrue(value);
        //}
    }
}
