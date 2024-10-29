namespace ComponentDemosScenarios1.Models.NestedDataRepeat;

public class InitializationType
{
    public string Name { get; set; }
    public bool Locked { get; set; }
    public string Selector { get; set; }
    public string DefaultLayout { get; set; }
    public object[] Children { get; set; } = Array.Empty<object>();
    public DefaultPropValuesType[] DefaultPropValues { get; set; } = Array.Empty<DefaultPropValuesType>();
}
