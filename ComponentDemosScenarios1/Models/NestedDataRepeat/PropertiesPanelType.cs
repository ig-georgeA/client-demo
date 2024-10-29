namespace ComponentDemosScenarios1.Models.NestedDataRepeat;

public class PropertiesPanelType
{
    public string Type { get; set; }
    public string Name { get; set; }
    public string Flex { get; set; }
    public string Title { get; set; }
    public ContentType[] Content { get; set; } = Array.Empty<ContentType>();
    public string Info { get; set; }
}
