namespace AttributesValidationDemo
{
    public static class Validator
    {
        public static bool Validate(Person person)
        {
            var allProperties = person.GetType()
                .GetProperties();

            foreach (var currentProperty in allProperties)
            {
                var rangeAttribute = currentProperty
                    .GetCustomAttributes(typeof(RangeAttribute), true);


                var currentPropertyValue = currentProperty.GetValue(person); // -10

                foreach (var att in rangeAttribute)
                {
                    bool isValid = ((RangeAttribute)att).IsValid((int)currentPropertyValue);

                    if (isValid)
                    {
                        return true;
                    }
                }
            }


            return false;
        }
    }
}
