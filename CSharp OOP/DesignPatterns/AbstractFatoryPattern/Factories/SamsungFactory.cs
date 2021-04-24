using AbstractFatoryPattern.Samsung;

namespace AbstractFatoryPattern.Factories
{
    public class SamsungFactory :ITechnologyAbstractFactory
    {
        public IMobilePhone CreatePhone()
        {
            return new SamsungPhone();
        }

        public ITablet CreateTablet()
        {
            return new SamsungTablet();
        }
    }
}
