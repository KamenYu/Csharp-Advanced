using CommandPattern.Core.Contracts;

namespace CommandPattern.Commands
{
    public class HelloCommand : ICommand
    {
        // commands must be in Core folder
        public string Execute(string[] args)
        {
            return $"Hello, {string.Join(' ', args)}";
        }
    }
}
