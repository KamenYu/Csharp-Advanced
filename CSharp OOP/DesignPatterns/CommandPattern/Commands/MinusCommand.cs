using System;
namespace CommandPattern.Commands
{ 
    public class MinusCommand :Command
    {
        public MinusCommand(decimal valueToChange) : base(valueToChange)
        { }

        public override decimal Execute(decimal value)
        {
            return value - ValueToChange;
        }

        public override decimal UnExecute(decimal value)
        {
            return value + ValueToChange;
        }
    }
}
