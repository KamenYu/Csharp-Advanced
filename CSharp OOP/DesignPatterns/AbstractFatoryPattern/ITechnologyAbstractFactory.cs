using System;
namespace AbstractFatoryPattern
{
    public interface ITechnologyAbstractFactory
    {
        IMobilePhone CreatePhone();

        ITablet CreateTablet();
    }
}
