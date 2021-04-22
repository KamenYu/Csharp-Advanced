using System;
using System.Collections.Generic;

namespace DI.Containers
{
    public abstract class AbstractContainer : IContainer
    {
        private Dictionary<Type, Type> mappings;

        public AbstractContainer()
        {
            mappings = new Dictionary<Type, Type>();
        }

        public abstract void ConfigureServices();

        public void CreateMapping<TInterfaceType, TImplemetaionType>()
        {
            if (typeof(TInterfaceType).IsAssignableFrom(typeof(TImplemetaionType)) == false)
            {
                throw new ArgumentException($"{typeof(TInterfaceType).Name} is not assignable from {typeof(TImplemetaionType).Name}");
            }
            mappings[typeof(TInterfaceType)] = typeof(TImplemetaionType);
        }

        public Type GetMapping(Type interfaceType)
        {
            return mappings[interfaceType];
        }
    }
}
