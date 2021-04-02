using System;
using System.Linq;
using System.Reflection;

using CommandPattern.Core.Contracts;

namespace CommandPattern.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] cmdArgs = args
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string result = string.Empty;

            Type type = Assembly
                .GetCallingAssembly()
                .GetTypes()
                .FirstOrDefault
                (n => n.Name.ToLower() == $"{cmdArgs[0]}Command".ToLower());

            //if (type == null)
            //{
            //    throw new ArgumentException("Command name is written wrong");
            //}

            ICommand instance = (ICommand)Activator.CreateInstance(type, new object[] { });

            result = instance.Execute(cmdArgs.Skip(1).ToArray());

            return result;
        }
    }
}

