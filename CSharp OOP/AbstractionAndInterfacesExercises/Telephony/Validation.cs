namespace Telephony
{
    public static class Validation
    {
        public static bool IsValidPhoneNumber(string line)
        {
            char[] chars = line.ToCharArray();

            foreach (var c in chars)
            {
                if (char.IsDigit(c))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsValidURL(string line)
        {
            char[] chars = line.ToCharArray();

            foreach (var c in chars)
            {
                if (char.IsDigit(c) == false)
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
