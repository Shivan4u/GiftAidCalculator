using System;
using GiftAidCalculator.TestConsole.BusinessObject;
using GiftAidCalculator.TestConsole.Interface;
using Moq;
using NUnit.Framework;

namespace GiftAidCalculator.Tests
{
    [TestFixture]
    class When_calculating_gift_aid
    {

        [Test]
        public void Gift_aid_should_be_calculated_by_current_tax_rate()
        {
            //Arrange
            const decimal currectTaxrate = 20;
            const decimal donationAmount = 50;
            const decimal expectedResult = 12.5m;

            var mockConfigRepositry = new Mock<IConfigRepositry>();
            mockConfigRepositry.Setup(x => x.TaxRate).Returns(currectTaxrate);
            ITaxCalculator taxCalculator = new TaxCalculator(mockConfigRepositry.Object);

            //Act
            decimal actualResult = taxCalculator.CalculateGiftAid(donationAmount);

            //Assert
            Assert.AreEqual(expectedResult,actualResult);
            Console.WriteLine("Gift aid calculated at a tax rate of " + currectTaxrate + " is: " + actualResult);
        }

    }
}
