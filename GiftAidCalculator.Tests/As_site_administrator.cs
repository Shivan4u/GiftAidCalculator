using System;
using GiftAidCalculator.TestConsole.Interface;
using GiftAidCalculator.TestConsole.Repositry;
using NUnit.Framework;

namespace GiftAidCalculator.Tests
{
    [TestFixture]
    class As_site_administrator
    {
        [Test]
        public void Get_me_current_tax_rate()
        {
            //Arrange
            const decimal setCurrentTaxRate = 15.5m;
            const decimal expectedCurrentTaxRate = 15.5m;

            IConfigRepositry configRepositry = new ConfigRepositry();
            
            //Act
            configRepositry.TaxRate = setCurrentTaxRate;
            decimal actualCurrentTaxRate = configRepositry.TaxRate;

            //Assert
            Assert.AreEqual(actualCurrentTaxRate,expectedCurrentTaxRate);
            Console.WriteLine("Current Tax Rate ["+ actualCurrentTaxRate + " %] is set and retrieved from data store.");
        }
    }
}
