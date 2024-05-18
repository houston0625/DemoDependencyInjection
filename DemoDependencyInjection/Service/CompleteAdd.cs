namespace DemoDependencyInjection.Service;

public class CompleteAdd: IComplete
{
    public string GetCompleteName(string name)
    {
        return $"Add {name}";
    }
}