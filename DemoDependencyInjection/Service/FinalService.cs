using DemoDependencyInjection.Models;

namespace DemoDependencyInjection.Service
{
    public class FinalService(
        CompleteAdd completeAdd,
        CompleteRemove completeRemove,
        CompleteEdit completeEdit)
    {
        private readonly Dictionary<ActionMode, IComplete> _completeLookUp = new()
        {
            { ActionMode.Add, completeAdd },
            { ActionMode.Remove, completeRemove},
            { ActionMode.Edit, completeEdit },
        };

        public string ExecutionEngineException(ActionMode actionMode, string name)
        {
            var completeService = _completeLookUp[actionMode];
            return completeService.GetCompleteName(name);
        }
    }
}
