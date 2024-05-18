namespace DemoDependencyInjection.Service;

public class CompleteRemove : IComplete
{
    public string GetCompleteName(string name)
    {
        return $"Remove {name}";
    }
}