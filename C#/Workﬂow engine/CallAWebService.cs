using System;

namespace ConsoleApp12
{
    public class CallAWebService : IWorkflow
    {
        public void Execute(Flow flow)
        {
            Console.WriteLine("Call a web service provided by a third-party video encoding service to tell them you have a video ready for encoding.");
        }
    }
}
