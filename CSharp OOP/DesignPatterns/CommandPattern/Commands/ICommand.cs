using System;
namespace CommandPattern.Commands
{
    public interface ICommand
    {
        decimal Execute(decimal value);

        decimal UnExecute(decimal value);
    }
}
