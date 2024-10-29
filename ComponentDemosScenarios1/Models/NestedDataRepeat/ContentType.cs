namespace ComponentDemosScenarios1.Models.NestedDataRepeat;

public class ContentType
{
    public string Type { get; set; }
    public string Name { get; set; }
    public string Flex { get; set; }
    public string Title { get; set; }
    public Content1Type[] Content { get; set; } = Array.Empty<Content1Type>();
}
