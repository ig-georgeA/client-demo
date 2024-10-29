namespace ComponentDemosScenarios1.Models.NestedDataRepeat;

public class PropertiesType
{
    public string Id { get; set; }
    public string BasePropertyId { get; set; }
    public string Name { get; set; }
    public string ValueType { get; set; }
    public string DefaultValue { get; set; }
    public object EnumType { get; set; }
    public string PropertyType { get; set; }
    public string Mapping { get; set; }
    public EditorInfoType EditorInfo { get; set; }
}
