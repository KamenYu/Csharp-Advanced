using System.Collections.Generic;
using CommandPattern.Commands;

namespace CommandPattern
{
    public class Calculator
    {
        private Stack<ICommand> commands;

        public Calculator()
        {
            commands = new Stack<ICommand>();
        }

        public decimal CurrentValue { get; set; }

        public void Execute(ICommand command)
        {
            CurrentValue = command.Execute(CurrentValue);
            commands.Push(command);
        }

        public void Undo(decimal levels)
        {
            for (int i = 0; i < levels; i++)
            {
                if (commands.Count > 0)
                {
                    CurrentValue = commands.Pop().UnExecute(CurrentValue);
                }
            }
        }
    }
}
