using System.Collections.Generic;
using System.Reflection;

namespace ValidationAttributes
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            var props = obj.GetType().GetProperties();

            foreach (PropertyInfo prop in props)
            {
                IEnumerable<MyValidationAttribute> customAttributes = prop
                    .GetCustomAttributes<MyValidationAttribute>();

                foreach (MyValidationAttribute myValidationAttribute in customAttributes)
                {
                    bool result = myValidationAttribute.IsValid(prop.GetValue(obj));

                    if (result == false)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
