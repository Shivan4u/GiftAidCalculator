using System;
using GiftAidCalculator.TestConsole.BusinessObject;
using GiftAidCalculator.TestConsole.Helper;
using GiftAidCalculator.TestConsole.Interface;
using GiftAidCalculator.TestConsole.Repositry;

namespace GiftAidCalculator.TestConsole
{
	class Program
	{
		static void Main()
		{
			IConfigRepositry config = new ConfigRepositry();

            Console.WriteLine("Please enter the tax rate:");
		    
            decimal taxRate;
            if (ValidateHelper.ValidateDecimal(Console.ReadLine(), out taxRate))
            {
                config.TaxRate = taxRate;
                Console.WriteLine("**************   Promotion     ******************");
                Console.WriteLine("*****    5% Supplement added on running     *****");
                Console.WriteLine("*****    3% Supplement added on swimming    *****");
                Console.WriteLine("**************   Promotion     ******************\n");
                Console.WriteLine("\n Input 1 for Running, 2 for Swimming and 3 for other events.");

                int eventInput;
                if (ValidateHelper.ValidateInteger(Console.ReadLine(), out eventInput))
                {

                    Console.WriteLine("\n Please Enter donation amount:");
                
                    decimal donationAmount;
                    if (ValidateHelper.ValidateDecimal(Console.ReadLine(), out donationAmount))
                    {
                        var calculateTax = new TaxCalculator(config);


                        decimal giftAid = MathHelper.RoundDecimal(calculateTax.CalculateGiftAid(donationAmount));
                        Console.WriteLine("\n Gift aid calculated at the rate of "+ taxRate+" is:" + giftAid + "\n");

                        Console.WriteLine(EventRepositry.GetEventTypeMessage(eventInput)+ "\n");

                        Console.WriteLine("\n The calculated gift amount is: " + (donationAmount +giftAid + MathHelper.RoundDecimal(EventRepositry.GetEventSupplementAmount(eventInput, donationAmount))) + "\n");
                       

                        Console.WriteLine("\n Press any key to exit.");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
                Console.ReadLine();
            }

		}

	}
}
