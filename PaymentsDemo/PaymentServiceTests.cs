using Microsoft.AspNetCore.Mvc;
using Moq;
using PaymentDemo.Controllers;
using PaymentDemo.Interfaces;
using PaymentDemo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentsDemo
{
    public class PaymentServiceTests
    {

        //service tests 
        [Fact]
        public void MakePayment_ReturnsTrue_WhenGatewayApproves()
        {
            //Arrange
            var gatewayMock = new Mock<IPaymentGateway>();
            gatewayMock.Setup(g => g.ProcessPayment(It.IsAny<decimal>())).Returns(true);

            var service = new PaymentService(gatewayMock.Object);

            //Act
            var result = service.MakePayment(500);

            //Assert
            Assert.True(result);
        }


        [Fact]
        public void MakePayment_ReturnsFalse_WhenGatewayDeclines()
        {
            //Arrange
            var gatewayMock = new Mock<IPaymentGateway>();
            gatewayMock.Setup(g => g.ProcessPayment(It.IsAny<decimal>())).Returns(false);

            var service = new PaymentService(gatewayMock.Object);

            //Act
            var result = service.MakePayment(1500);

            //Assert
            Assert.False(result);

        }

        [Fact]
        public void MakePayment_CallsGatewayOnce()
        {
            var gatewayMock = new Mock<IPaymentGateway>();
            gatewayMock.Setup(g => g.ProcessPayment(It.IsAny<decimal>())).Returns(true);

            var service = new PaymentService(gatewayMock.Object);

            service.MakePayment(500);

            gatewayMock.Verify(g => g.ProcessPayment(It.IsAny<decimal>()), Times.Once);

        }

        //controller tests

        [Fact]
        public async Task Pay_ReturnsOk_WhenServiceApproves()
        {
            var serviceMock = new Mock<PaymentService>(MockBehavior.Strict, new Mock<IPaymentGateway>().Object);
            serviceMock.Setup(s => s.MakePayment(It.IsAny<decimal>())).Returns(true);

            var controller = new PaymentsController(serviceMock.Object);

            var result = controller.Pay(500);
            var okResult = Assert.IsType<OkObjectResult>(result);
            Assert.Equal("Payment Processed", okResult.Value);

        }

        [Fact]
        public void Pay_ReturnsBadRequest_WhenServiceDeclines()
        {
            var serviceMock = new Mock<PaymentService>(MockBehavior.Strict, new Mock<IPaymentGateway>().Object);
            serviceMock.Setup(s => s.MakePayment(It.IsAny<decimal>())).Returns(false);

            var controller = new PaymentsController(serviceMock.Object);

            var result = controller.Pay(1500);
            var badRequest = Assert.IsType< BadRequestObjectResult > (result);
            Assert.Equal("Payment failed", badRequest.Value);



        }
    }
}
