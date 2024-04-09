using NUnit.Framework;
using Moq;
using NUnit.Framework.Internal;
using System.Net.NetworkInformation;

namespace Assign_Testing.Tests
{
    [TestFixture]
    public class InsuranceServiceTests
    {
        [Test]
        public void GetInsurancePremium_ReturnPremium_IsRuralAgeLow()
        {
            //Arrange
            var mockInsuranceService = new Mock<IInsuranceService>();
            mockInsuranceService.Setup(x => x.GetDiscount()).Returns(30);
            var insuranceService = new InsuranceService(mockInsuranceService.Object);

            //Act

            double result = insuranceService.CalcPremium(0, "rural");


            //Assert
            Assert.That(result, Is.EqualTo(0));
        }
        [Test]
        public void GetInsurancePremium_ReturnPremium_IsRuralAgeMedium()
        {
            //Arrange
            var mockInsuranceService = new Mock<IInsuranceService>();
            mockInsuranceService.Setup(x => x.GetDiscount()).Returns(30);
            var insuranceService = new InsuranceService(mockInsuranceService.Object);

            //Act

            double result = insuranceService.CalcPremium(20, "rural");


            //Assert
            Assert.That(result, Is.EqualTo(5));
        }
        [Test]
        public void GetInsurancePremium_ReturnPremium_IsRuralAgeHigh()
        {
            //Arrange
            var mockInsuranceService = new Mock<IInsuranceService>();
            mockInsuranceService.Setup(x => x.GetDiscount()).Returns(30);
            var insuranceService = new InsuranceService(mockInsuranceService.Object);

            //Act

            double result = insuranceService.CalcPremium(40, "rural");


            //Assert
            Assert.That(result, Is.EqualTo(3.5));
        }
        [Test]
        public void GetInsurancePremium_ReturnPremium_IsRuralAgeDiscount()
        {
            //Arrange
            var mockInsuranceService = new Mock<IInsuranceService>();
            mockInsuranceService.Setup(x => x.GetDiscount()).Returns(30);
            var insuranceService = new InsuranceService(mockInsuranceService.Object);

            //Act

            double result = insuranceService.CalcPremium(55, "rural");


            //Assert
            Assert.That(result, Is.EqualTo(2.45));
        }
        [Test]
        public void GetInsurancePremium_ReturnPremium_IsUrbanAgeLow()
        {
            //Arrange
            var mockInsuranceService = new Mock<IInsuranceService>();
            mockInsuranceService.Setup(x => x.GetDiscount()).Returns(30);
            var insuranceService = new InsuranceService(mockInsuranceService.Object);

            //Act

            double result = insuranceService.CalcPremium(0, "urban");


            //Assert
            Assert.That(result, Is.EqualTo(0));
        }
        [Test]
        public void GetInsurancePremium_ReturnPremium_IsUrbanAgeMedium()
        {
            //Arrange
            var mockInsuranceService = new Mock<IInsuranceService>();
            mockInsuranceService.Setup(x => x.GetDiscount()).Returns(30);
            var insuranceService = new InsuranceService(mockInsuranceService.Object);

            //Act

            double result = insuranceService.CalcPremium(20, "urban");


            //Assert
            Assert.That(result, Is.EqualTo(6));
        }
        [Test]
        public void GetInsurancePremium_ReturnPremium_IsUrbanAgeHigh()
        {
            //Arrange
            var mockInsuranceService = new Mock<IInsuranceService>();
            mockInsuranceService.Setup(x => x.GetDiscount()).Returns(30);
            var insuranceService = new InsuranceService(mockInsuranceService.Object);

            //Act

            double result = insuranceService.CalcPremium(40, "urban");


            //Assert
            Assert.That(result, Is.EqualTo(5));
        }
        [Test]
        public void GetInsurancePremium_ReturnPremium_IsUrbanAgeDiscount()
        {
            //Arrange
            var mockInsuranceService = new Mock<IInsuranceService>();
            mockInsuranceService.Setup(x => x.GetDiscount()).Returns(30);
            var insuranceService = new InsuranceService(mockInsuranceService.Object);

            //Act

            double result = insuranceService.CalcPremium(55, "urban");


            //Assert  // 5 - 30% = 3.5
            Assert.That(result, Is.EqualTo(3.5));
        }
    }
}
