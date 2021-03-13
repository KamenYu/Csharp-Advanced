using System;
namespace ReflectionAttributesDemo
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property, AllowMultiple = true)] // with '|' I can add more attr.targets
    public class AuthorAttribute : Attribute
    {
        // custom attributes can posses ctors, props, and fields
        // flags can be used as tags to derive the info used in attributes
        public AuthorAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
