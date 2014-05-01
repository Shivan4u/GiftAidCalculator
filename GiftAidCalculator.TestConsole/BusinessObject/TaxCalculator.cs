using GiftAidCalculator.TestConsole.Interface;


namespace GiftAidCalculator.TestConsole.BusinessObject
{
  public class TaxCalculator: ITaxCalculator
    {
        private readonly IConfigRepositry _configRepositry;
        
        public TaxCalculator(IConfigRepositry configRepositry)
        {
            _configRepositry = configRepositry;
        }


        public decimal CalculateGiftAid(decimal donationAmount)
        {
            var giftAidRatio = _configRepositry.TaxRate / (100 - _configRepositry.TaxRate);
            return donationAmount * giftAidRatio;
        }

       
    }
}
