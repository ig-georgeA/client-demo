namespace ComponentDemosScenarios1.Models.NestedDataRepeat;

public class PropertyEditorSettingsType
{
    public double MinValue { get; set; }
    public bool SupportsEmpty { get; set; }
    public string PropertyName { get; set; }
    public bool CheckedValue { get; set; }
    public bool UncheckedValue { get; set; }
    public string SelectAllLabel { get; set; }
    public string ClearAllLabel { get; set; }
    public string SummaryLabel { get; set; }
    public string SummaryValue { get; set; }
    public bool InvertValue { get; set; }
    public bool IncludeNestedFields { get; set; }
    public bool ShowClearAction { get; set; }
    public string AcceptType { get; set; }
}
