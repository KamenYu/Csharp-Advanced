using System;
namespace Telephony
{
    public class Smartphone : ICalling, IBrowsing
    {
        public string Browsing(string url)
        {
            if (Validation.IsValidURL(url))
            {
                return $"Browsing: {url}!";
            }
            else
            {
                throw new ArgumentException(GlobalConstants.InvalidURLMsg); // maybe check exc  
            }            
        }

        public string Calling(string num)
        {
            if (Validation.IsValidPhoneNumber(num))
            {
                return $"Calling... {num}";
            }
            else
            {
                throw new ArgumentException(GlobalConstants.InvalidNumMsg); // maybe check exc 
            }                      
        }
    }    
}
