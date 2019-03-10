using System.Collections.Generic;

namespace ConsoleApp12
{
    public class WorkflowEngine
    {
        private readonly IList<IWorkflow> _IWorkflows;

        public WorkflowEngine()
        {
            _IWorkflows = new List<IWorkflow>();
        }
        public void Run()
        {
            foreach (var workflow in _IWorkflows)
                workflow.Execute(new Flow());
        }
        public void RegisterWorkflow(IWorkflow workflow)
        {
            _IWorkflows.Add(workflow);
        }
    }
}
