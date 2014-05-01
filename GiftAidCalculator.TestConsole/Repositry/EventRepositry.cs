using GiftAidCalculator.TestConsole.Entities;

namespace GiftAidCalculator.TestConsole.Repositry
{
   public class EventRepositry
    {

       /// <summary>
       /// Gets the event type supplement message.
       /// </summary>
       /// <param name="eventCode"></param>
       /// <returns></returns>
       public static string GetEventTypeMessage(int eventCode)
        {
            string result = string.Empty;
           
            //validation for invalid event code.
            if (eventCode > 3 || eventCode <1){ eventCode = 3;}
            
            switch (eventCode)
            {
                case (int)GenericEntities.EventType.Running:
                    result = "\n 5% supplement added for donations to running events.";
                    break;
                case (int)GenericEntities.EventType.Swimming:
                    result = "\n 3% supplement added for donations to swimming events.";
                    break;
                case (int)GenericEntities.EventType.Others:
                    result = "\n No supplement should be applied for other events.";
                    break; 
            }

            return result;
        }


       /// <summary>
       /// Calculate event supplement amount.
       /// </summary>
       /// <param name="eventCode"></param>
       /// <param name="donationAmount"></param>
       /// <returns></returns>
       public static decimal GetEventSupplementAmount(int eventCode, decimal donationAmount)
       {
           decimal result = 0;
           decimal eventSupplement = 0;

           //validation for invalid event code.
           if (eventCode > 2 || eventCode < 0) { eventCode = 2; }


           switch (eventCode)
           {
               case (int)GenericEntities.EventType.Running:
                   eventSupplement = 5;
                   break;
               case (int)GenericEntities.EventType.Swimming:
                   eventSupplement = 3;
                   break;
               case (int)GenericEntities.EventType.Others:
                   eventSupplement = 0;
                   break;
           }
           result = donationAmount*(eventSupplement/100);

           return result;
       }
    }
}
