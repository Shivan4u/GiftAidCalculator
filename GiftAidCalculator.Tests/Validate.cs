using GiftAidCalculator.TestConsole.Helper;
using NUnit.Framework;
namespace GiftAidCalculator.Tests
{
    [TestFixture]
    class Validate
    {
        [Test]
        public void Invalid_decimal_input()
        {
            //Arrange
            const decimal expected = 0;
            decimal actual = 0; 

            //Act
            ValidateHelper.ValidateDecimal("invalid", out actual);

            //Assert
            Assert.AreEqual(actual,expected);
        }


        [Test]
        public void Valid_decimal_input()
        {
            //Arrange
            const decimal expected = 24.536m;
            decimal actual = 0;

            //Act
            ValidateHelper.ValidateDecimal("24.536", out actual);

            //Assert
            Assert.AreEqual(actual, expected);
        }


        [Test]
        public void Invalid_integer_input()
        {
            //Arrange
            const int expected = 0;
            int actual = 0;

            //Act
            ValidateHelper.ValidateInteger("invalid", out actual);

            //Assert
            Assert.AreEqual(actual, expected);
        }


        [Test]
        public void Valid_integer_input()
        {
            //Arrange
            const int expected = 145;
            int actual = 0;

            //Act
            ValidateHelper.ValidateInteger("145", out actual);

            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
