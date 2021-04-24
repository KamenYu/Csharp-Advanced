using System;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Approver teamLead = new TeamLeadApprover();
            Approver cto = new CTO();

            teamLead.SetNext(cto);

            Console.WriteLine(teamLead.HandleRequest(4));
            Console.WriteLine(teamLead.HandleRequest(400));
            Console.WriteLine(teamLead.HandleRequest(4000));
        }
    }
}
