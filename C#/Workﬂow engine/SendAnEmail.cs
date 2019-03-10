using System;

namespace ConsoleApp12
{
    public class SendAnEmail : IWorkflow
    {
        public void Execute(Flow flow)
        {
            Console.WriteLine("Send an email to the owner of the video notifying them that the video started processing.");
        }
    }
}
