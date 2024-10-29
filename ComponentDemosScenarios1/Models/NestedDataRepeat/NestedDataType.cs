namespace ComponentDemosScenarios1.Models.NestedDataRepeat;

public class NestedDataType
{
    public string Id { get; set; }
    public string Name { get; set; }
    public ComponentsType[] Components { get; set; } = Array.Empty<ComponentsType>();
    public string BaseLibraryId { get; set; }
    public string PackageName { get; set; }
    public double Platform { get; set; }
}
