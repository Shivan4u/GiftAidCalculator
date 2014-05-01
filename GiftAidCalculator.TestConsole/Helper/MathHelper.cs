using System;

namespace GiftAidCalculator.TestConsole.Helper
{
  public  static class MathHelper
    {
        //This can also be set as configurable member.
        private const int DecimalPoints = 2;


        public static decimal RoundDecimal(decimal giftAidAmount)
        {
            return decimal.Round(giftAidAmount, DecimalPoints, MidpointRounding.AwayFromZero);
        }
    }
}
