using System;
using System.Linq;
using System.Reflection;

using Logger.Models.Common;
using Logger.Models.Contracts;

namespace Logger.Models.Factories
{
    public class LayoutFactory
    {
        public LayoutFactory()
        { }

        public ILayout CreateLayout(string layoutType)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            Type layoutT = assembly
                .GetTypes()
                .FirstOrDefault(t => t.Name.Equals(layoutType, StringComparison.InvariantCultureIgnoreCase));

            if (layoutT == null)
            {
                throw new InvalidOperationException
                    (GlobalConstants.InvalidLayoutType);
            }

            object[] ctorArgs = new object[] { };

            ILayout layout =
                (ILayout)Activator.CreateInstance(layoutT, BindingFlags.Public | BindingFlags.Instance, ctorArgs);


            return layout;
        }
    }
}
