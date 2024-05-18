namespace DemoDependencyInjection.Service;

public class CompleteEdit : IComplete
{
    public string GetCompleteName(string name)
    {
        return $"Edit {name}";
    }
}