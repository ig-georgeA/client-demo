namespace ComponentDemosScenarios1.Models.NestedDataRepeat;

public class ZonesType
{
    public string ZoneTag { get; set; }
    public string DropArea { get; set; }
    public bool AllSelectorsAllowed { get; set; }
    public object[] AllowedSelectors { get; set; } = Array.Empty<object>();
    public object[] DisallowedSelectors { get; set; } = Array.Empty<object>();
    public bool IgnoreChildrenMargin { get; set; }
    public InitializationType[] Initialization { get; set; } = Array.Empty<InitializationType>();
    public string AllowEmpty { get; set; }
}
