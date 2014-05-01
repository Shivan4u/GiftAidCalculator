using System;
using GiftAidCalculator.TestConsole.Repositry;
using NUnit.Framework;

namespace GiftAidCalculator.Tests
{
    [TestFixture]
    class As_event_promoter
    {
        [Test]
        public void Add_5_percent_supplement_for_running()
        {
            //Arrange
            //Input one for running
            const int inputEvent = 1;
            const string expected = "\n 5% supplement added for donations to running events.";
            
            //Act
            string actual = EventRepositry.GetEventTypeMessage(inputEvent);

            //Assert
            Assert.AreEqual(actual,expected);
            Console.WriteLine(actual);
        }


        [Test]
        public void Add_3_percent_supplement_for_swimming()
        {
            //Arrange
            //Input one for swimming
            const int inputEvent = 2;
            const string expected = "\n 3% supplement added for donations to swimming events.";
            
            //Act
            string actual = EventRepositry.GetEventTypeMessage(inputEvent);

            //Assert
            Assert.AreEqual(actual, expected);
            Console.WriteLine(actual);
        }


        [Test]
        public void No_supplement_for_others()
        {
            //Arrange
            //Input three for others
            const int inputEvent = 3;
            const string expected = "\n No supplement should be applied for other events.";
            
            //Act
            string actual = EventRepositry.GetEventTypeMessage(inputEvent);

            //Assert
            Assert.AreEqual(actual, expected);
            Console.WriteLine(actual);
        }

        [Test]
        public void Show_event_supplement_amount_for_running()
        {
            //Arrange
            const int eventCode = 1; //running
            const decimal donationAmount = 45.56m;
            const decimal expected = 2.278m;
            
            //Act
            decimal actual = EventRepositry.GetEventSupplementAmount(eventCode, donationAmount);


            //Assert
            Assert.AreEqual(actual,expected);
            Console.WriteLine("Calulated supplement amount for running event with donation amount '" + donationAmount + "' will be : " + actual);
        }

    }
}
