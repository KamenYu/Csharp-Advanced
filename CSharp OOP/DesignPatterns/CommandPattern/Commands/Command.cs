using System;
namespace CommandPattern.Commands
{
    public abstract class Command :ICommand
    {
        public Command(decimal value)
        {
            ValueToChange = value;
        }

        public decimal ValueToChange { get; set; }

        public abstract decimal Execute(decimal value);

        public abstract decimal UnExecute(decimal value);       
    }
}
