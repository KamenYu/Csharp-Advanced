using System;
using AbstractFatoryPattern.Apple;

namespace AbstractFatoryPattern.Factories
{
    public class AppleFactory :ITechnologyAbstractFactory
    {
        public IMobilePhone CreatePhone()
        {
            return new ApplePhone();
        }

        public ITablet CreateTablet()
        {
            return new AppleTablet();
        }
    }
}
