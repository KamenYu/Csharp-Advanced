using System;
namespace DI.Attributes
{
    [AttributeUsage(AttributeTargets.Constructor)]
    public class Inject : Attribute
    { }
}
