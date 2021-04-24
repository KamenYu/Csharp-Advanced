using System;
using CommandPattern.Commands;

namespace CommandPattern
{
    public class User
    {
        public User(Calculator calculator)
        {
            Calculator = calculator;
        }

        public Calculator Calculator { get; set; }

        public void Calculate(string sign, decimal value)
        {
            switch (sign)
            {
                case "+": Calculator.Execute(new AddCommand(value));
                    break;
                case "-":
                    Calculator.Execute(new MinusCommand(value));
                    break;
                case "*":
                    Calculator.Execute(new MultiplyCommand(value));
                    break;
                case"/":
                    Calculator.Execute(new DivideCommand(value));
                    break;
                default: break;
            }
        }
    }
}
