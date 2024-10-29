namespace ComponentDemosScenarios1.Models.NestedDataRepeat;

public class ComponentsType
{
    public string Id { get; set; }
    public string Name { get; set; }
    public bool Resizable { get; set; }
    public string Module { get; set; }
    public string Theme { get; set; }
    public string Keywords { get; set; }
    public string Selector { get; set; }
    public string Group { get; set; }
    public LayoutRulesType LayoutRules { get; set; }
    public bool AllowAnyChildren { get; set; }
    public AllowedChildrenType[] AllowedChildren { get; set; } = Array.Empty<AllowedChildrenType>();
    public PropertiesType[] Properties { get; set; } = Array.Empty<PropertiesType>();
    public PropertiesPanelType[] PropertiesPanel { get; set; } = Array.Empty<PropertiesPanelType>();
    public ComponentDependenciesType[] ComponentDependencies { get; set; } = Array.Empty<ComponentDependenciesType>();
    public string LibraryId { get; set; }
    public string OutlineName { get; set; }
    public string Parent { get; set; }
    public bool Disabled { get; set; }
    public bool Hidden { get; set; }
    public string Description { get; set; }
    public string Content { get; set; }
    public double Version { get; set; }
    public string IconName { get; set; }
    public TemplatesType[] Templates { get; set; } = Array.Empty<TemplatesType>();
    public ZonesType[] Zones { get; set; } = Array.Empty<ZonesType>();
    public bool IsTogglable { get; set; }
    public bool IsAttachable { get; set; }
    public bool IsOverlay { get; set; }
    public bool IgnoreToggleAction { get; set; }
}
