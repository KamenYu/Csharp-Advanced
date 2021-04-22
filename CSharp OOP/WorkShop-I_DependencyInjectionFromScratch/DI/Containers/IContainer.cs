using System;
namespace DI.Containers
{
    public interface IContainer // like serviceConfigurator
    {
        void ConfigureServices();

        void CreateMapping<TInterfaceType, TImplemetaionType>();

        Type GetMapping(Type interfaceType);
    }
}
