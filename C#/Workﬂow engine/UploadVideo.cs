using System;

namespace ConsoleApp12
{
    public class UploadVideo : IWorkflow
    {
        public void Execute(Flow flow)
        {
            Console.WriteLine("Upload a video to a cloud storage.");
        }
    }
}
