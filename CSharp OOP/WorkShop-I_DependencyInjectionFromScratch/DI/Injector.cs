using System;
using System.Linq;
using System.Reflection;
using DI.Attributes;
using DI.Containers;

namespace DI
{
    public class Injector
    {
        private IContainer container;

        public Injector(IContainer container)
        {
            this.container = container;
        }

        public TClass Inject<TClass>()
        {
            if (HasAttributeInject<TClass>() == false)
            {
                return (TClass)Activator.CreateInstance(typeof(TClass));
            }

            return CreateConstructorInjection<TClass>();
        }

        private TClass CreateConstructorInjection<TClass>()
        {
            ConstructorInfo[] constructors = typeof(TClass).GetConstructors();

            foreach (ConstructorInfo ctor in constructors)
            {
                if (ctor.GetCustomAttribute(typeof(Inject), true) == null)
                {
                    continue;
                }

                ParameterInfo[] parameters = ctor.GetParameters();
                object[] constructorObjects = new object[parameters.Length];
                int i = 0;

                foreach (ParameterInfo p in parameters)
                {
                    Type implementationType = container.GetMapping(p.ParameterType);

                    MethodInfo method = typeof(Injector).GetMethod("Inject");
                    method = method.MakeGenericMethod(implementationType);

                    object implementationInstance = method.Invoke(this, new object[] { });
                    constructorObjects[i++] = implementationInstance;
                }

                return (TClass)Activator
                    .CreateInstance(typeof(TClass),constructorObjects);
            }

            return default;
        }

        private bool HasAttributeInject<TClass>()
        {
            return typeof(TClass)
                .GetConstructors()
                .Any(c => c.GetCustomAttributes(typeof(Inject), true)
                .Any());
        }
    }
}
