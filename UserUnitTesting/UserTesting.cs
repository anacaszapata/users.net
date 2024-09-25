using Microsoft.AspNetCore.Mvc;
using Moq;
using userAsp.Controllers;
using userAsp.Entities;
using userAsp.Models;
using userAsp.Services;
using Xunit;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace UserUnitTesting
{
    public class UserTesting
    {
        private readonly UserController _controller;
        private readonly Mock<UsersContext> _mockContext; 
        private readonly Mock<IUserService> _mockService;

        public UserTesting()
        {
            
            _mockContext = new Mock<UsersContext>();

            
            var mockUsers = new List<userAsp.Entities.User>
            {
                new userAsp.Entities.User { Id = 1, Name = "Juan", Email = "juan@example.com" },
                new userAsp.Entities.User { Id = 2, Name = "Ana", Email = "Ana@example.com" }
            }.AsQueryable();

            
            var mockSet = new Mock<DbSet<userAsp.Entities.User>>();
            mockSet.As<IQueryable<userAsp.Entities.User>>().Setup(m => m.Provider).Returns(mockUsers.Provider);
            mockSet.As<IQueryable<userAsp.Entities.User>>().Setup(m => m.Expression).Returns(mockUsers.Expression);
            mockSet.As<IQueryable<userAsp.Entities.User>>().Setup(m => m.ElementType).Returns(mockUsers.ElementType);
            mockSet.As<IQueryable<userAsp.Entities.User>>().Setup(m => m.GetEnumerator()).Returns(mockUsers.GetEnumerator());

            _mockContext.Setup(c => c.Users).Returns(mockSet.Object);

            
            var service = new UserService(_mockContext.Object);
            _controller = new UserController(service);
        }

        [Fact]
        public void Get_Ok()
        {
            
            var result = _controller.Get();

            
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void Get_Quantity()
        {
            
            var result = (OkObjectResult)_controller.Get();

            
            var users = Assert.IsType<List<userAsp.Entities.User>>(result.Value);

            
            Assert.True(users.Count > 0);
        }
    }
}
