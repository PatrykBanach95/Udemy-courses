using System;

namespace ConsoleApp12
{
    public class ChangeTheStatus : IWorkflow
    {
        public void Execute(Flow flow)
        {
            Console.WriteLine("Change the status of the video record in the database to “Processing”.");
        }
    }
}
