using System;
namespace Telephony
{
    public class StationaryPhone : ICalling
    {
        public string Calling(string num)
        {
            if (Validation.IsValidPhoneNumber(num))
            {
                return $"Dialing... {num}";
            }
            else
            {
                throw new ArgumentException(GlobalConstants.InvalidNumMsg); // check exc
            }            
        }
    }
}
