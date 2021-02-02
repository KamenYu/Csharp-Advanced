using System;
namespace Pizza.Common
{
    public static class DefaultErrorMsgs
    {
        public const string DoughErrorMsg = "Invalid type of dough.";
        public const string WeighErrorMsg = "Dough weight should be in the range [{0}..{1}].";
        public const string ToppingTypeErrorMsg = "Cannot place {0} on top of your pizza.";
        public const string ToppingWeightErrorMsg = "{0} weight should be in the range [{1}..{2}].";
        public const string PizzaNameErrorMsg = "Pizza name should be between {0} and {1} symbols.";
        public const string MaxToppingErrorMsg = "Number of toppings should be in range [{0}..{1}].";
    }
}
