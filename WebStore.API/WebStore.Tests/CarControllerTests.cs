using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using WebStore.Domain;
using WebStore.Service.Interface;
using WebstoreApi.Controllers;
using Xunit;

namespace WebStore.Tests
{
    public class CarControllerTests
    {
        [Fact]
        public void PostSucess()
        {
            var carServices = new Mock<ICarService>();
            var logger = new Mock<ILogger<CarController>>();

            carServices.Setup(s => s.Add(It.IsAny<Car>()));
            var carController = new CarController(carServices.Object, logger.Object);

            var result = carController.Post(new Car { Brand = "BMW", Model="X5", Year="2019" });

            Assert.NotNull(result);
            Assert.IsType<OkObjectResult>(result.Result);

            var httpObjResult = result.Result as OkObjectResult;

            Assert.NotNull(httpObjResult);
            Assert.True(httpObjResult.StatusCode == 200);

            var value = httpObjResult.Value;

            Assert.NotNull(value);
            Assert.False(string.IsNullOrWhiteSpace(value.ToString()));
            Assert.Same("success", value);

        }

        [Fact]
        public void GetSucess()
        {
            var carServices = new Mock<ICarService>();
            var logger = new Mock<ILogger<CarController>>();

            carServices.Setup(s => s.Add(It.IsAny<Car>()));
            carServices.Setup(s => s.GetAll());
            var carController = new CarController(carServices.Object, logger.Object);

            var result = carController.Post(new Car { Brand = "BMW", Model = "X5", Year = "2019" });
             
            Assert.NotNull(result);
            Assert.IsType<OkObjectResult>(result.Result);

            var httpObjResult = result.Result as OkObjectResult;

            Assert.NotNull(httpObjResult);
            Assert.True(httpObjResult.StatusCode == 200);

            var value = httpObjResult.Value;

            Assert.NotNull(value);
            Assert.False(string.IsNullOrWhiteSpace(value.ToString()));
            Assert.Same("success", value);

        }


    }
}
