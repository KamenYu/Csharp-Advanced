namespace ChainOfResponsibilityPattern
{
    public class TeamLeadApprover : Approver
    {
        public override bool HandleRequest(int amount)
        {
            if (amount < 5)
            {
                return true;
            }
            else
            {
                return Next.HandleRequest(amount);
            }
        }
    }
}
