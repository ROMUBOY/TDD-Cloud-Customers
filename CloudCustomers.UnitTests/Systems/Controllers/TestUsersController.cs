using CloudCustomers.API.Controllers;
using CloudCustomers.API.Models;
using CloudCustomers.API.Services;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace CloudCustomers.UnitTests.Systems.Controllers
{
    public class TestUsersController
    {
        [Fact]
        public async void Get_OnSuccess_ReturnStatusCode200()
        {
            // Arrange
            var MockUserService = new Mock<IUsersService>();
            MockUserService
                .Setup(service => service.GetAllUsers())
                .ReturnsAsync(new List<User>());

            var sut = new UsersController(MockUserService.Object);

            // Act
            var result = (OkObjectResult) await sut.Get();

            // Assert
            result.StatusCode.Should().Be(200);
        }

        [Fact]
        public async void Get_OnSuccess_InvokesUsersService()
        {
            // Arrange
            var MockUserService = new Mock<IUsersService>();
            MockUserService
                .Setup(service => service.GetAllUsers())
                .ReturnsAsync(new List<User>());

            var sut = new UsersController(MockUserService.Object);

            // Act
            var result = (OkObjectResult)await sut.Get();

            // Assert
            MockUserService.Verify(service => service.GetAllUsers(), Times.Once());
        }

        [Fact]
        public async void Get_OnSuccess_ReturnsListOfUsers()
        {
            // Arrange
            var MockUserService = new Mock<IUsersService>();
            MockUserService
                .Setup(service => service.GetAllUsers())
                .ReturnsAsync(new List<User>());

            var sut = new UsersController(MockUserService.Object);

            // Act            
            var result = await sut.Get();
            var objectResult = (OkObjectResult)result;

            // Assert
            result.Should().BeOfType<OkObjectResult>();
            objectResult.Value.Should().BeOfType<List<User>>();
        }
    }
}