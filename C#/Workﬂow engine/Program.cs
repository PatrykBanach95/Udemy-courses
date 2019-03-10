using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
                              
        static void Main(string[] args)
        {
            var _WorkflowEngnine = new WorkflowEngine();
            _WorkflowEngnine.RegisterWorkflow(new UploadVideo());
            _WorkflowEngnine.RegisterWorkflow(new SendAnEmail());
            _WorkflowEngnine.RegisterWorkflow(new CallAWebService());
            _WorkflowEngnine.RegisterWorkflow(new ChangeTheStatus());
            _WorkflowEngnine.Run();
            Console.ReadLine();
        }
    }
}
