using System;
namespace ChainOfResponsibilityPattern
{
    public class CTO :Approver
    { 
        public override bool HandleRequest(int amount)
        {
            if (amount < 900)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
