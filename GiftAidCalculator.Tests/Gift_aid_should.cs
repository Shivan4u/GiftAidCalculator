using System;
using GiftAidCalculator.TestConsole.BusinessObject;
using GiftAidCalculator.TestConsole.Helper;
using GiftAidCalculator.TestConsole.Interface;
using Moq;
using NUnit.Framework;

namespace GiftAidCalculator.Tests
{
    [TestFixture]
    class Gift_aid_should
    {
        
        private decimal CalculateGiftAid()
        {
            const decimal currectTaxrate = 15.65m;
            const decimal donationAmount = 50.50m;

            var mockConfigRepositry = new Mock<IConfigRepositry>();
            mockConfigRepositry.Setup(x => x.TaxRate).Returns(currectTaxrate);
            ITaxCalculator taxCalculator = new TaxCalculator(mockConfigRepositry.Object);

            return taxCalculator.CalculateGiftAid(donationAmount);
        }

        [Test]
        public void Be_rounded_to_two_decimal_digits()
        {
            //Arrange
            const decimal expectedValue = 9.37m;
            var calculatedGiftAid = CalculateGiftAid();

            //Act
            decimal actualValue = MathHelper.RoundDecimal(calculatedGiftAid);

            //Assert
            Assert.AreEqual(actualValue,expectedValue);
            Console.WriteLine("Actual calculated gift aid was [ " + calculatedGiftAid + " ] which is rounded to 2 decimal points : " + actualValue);


        }
    }
}
