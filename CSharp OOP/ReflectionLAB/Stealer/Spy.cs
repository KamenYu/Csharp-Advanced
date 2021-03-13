using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {
        public Spy()
        {
        }

        public string StealFieldInfo(string className, string[] fieldsToInvestigate)
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Class under investigation: {className}");

            Type type = Type.GetType(className);

            FieldInfo[] fields = type.GetFields(BindingFlags.NonPublic
                | BindingFlags.Instance
                | BindingFlags.Public
                | BindingFlags.Static);

            object instance = Activator.CreateInstance(type, new object[] { });

            foreach (var field in fields.Where(f => fieldsToInvestigate.Contains(f.Name)))
            {
                result.AppendLine($"{field.Name} = {field.GetValue(instance)}");
            }

            return result.ToString().Trim();
        }

        public string AnalyzeAcessModifiers(string className)
        {
            StringBuilder result = new StringBuilder();

            Type type = Type.GetType(className);

            FieldInfo[] fields = type.GetFields
                (BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static);

            MethodInfo[] publicMethods = type.GetMethods
                (BindingFlags.Public | BindingFlags.Instance);

            MethodInfo[] nonPublicMethods = type.GetMethods
                (BindingFlags.NonPublic | BindingFlags.Instance);

            foreach (FieldInfo field in fields)
            {
                result.AppendLine($"{field.Name} must be private!");
            }            

            foreach (MethodInfo nonPublicMethod in nonPublicMethods.Where(n => n.Name.StartsWith("get")))
            {
                result.AppendLine($"{nonPublicMethod.Name} have to be public!");
            }

            foreach (MethodInfo publicMethod in publicMethods.Where(n => n.Name.StartsWith("set")))
            {
                result.AppendLine($"{publicMethod.Name} have to be private!");
            }

            return result.ToString().Trim();
        }

        public string RevealPrivateMethods(string className)
        {
            Type type = Type.GetType(className);
            MethodInfo[] methods = type.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

            StringBuilder result = new StringBuilder();
            result.AppendLine($"All Private Methods of Class: {className}");
            result.AppendLine($"Base Class: {type.BaseType.Name}");

            foreach (MethodInfo method in methods)
            {
                result.AppendLine(method.Name);
            }

            return result.ToString().Trim();
        }

        public string CollectGettersAndSetters(string className)
        {
            StringBuilder result = new StringBuilder();
            Type type = Type.GetType(className);

            MethodInfo[] methods = type.GetMethods
                (BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);

            foreach (MethodInfo method in methods.Where(m => m.Name.StartsWith("get")))
            {
                result.AppendLine($"{method.Name} will return {method.ReturnType}");
            }

            foreach (MethodInfo method in methods.Where(m => m.Name.StartsWith("set")))
            {
                result.AppendLine($"{method.Name} will set field of {method.GetParameters().First().ParameterType}");
            }

            return result.ToString().Trim();
        }
    }
}
