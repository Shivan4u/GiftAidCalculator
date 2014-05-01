
namespace GiftAidCalculator.TestConsole.Helper
{
  public class ValidateHelper
    {

        public static bool ValidateDecimal(string strInput, out decimal dOutput)
        {
            dOutput = 0;
            bool result = decimal.TryParse(strInput, out dOutput);
            return result;
        }

        public static bool ValidateInteger(string strInput, out int dOutput)
        {
            dOutput = 0;
            bool result = int.TryParse(strInput, out dOutput);
            return result;
        }
    }
}
