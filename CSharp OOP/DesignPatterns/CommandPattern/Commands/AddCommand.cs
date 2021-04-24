namespace CommandPattern.Commands
{
    public class AddCommand :Command
    {
        public AddCommand(decimal valueToChange) : base(valueToChange)
        { }

        public override decimal Execute(decimal value)
        {
            return value + ValueToChange;
        }

        public override decimal UnExecute(decimal value)
        {
            return value - ValueToChange;
        }
    }
}
