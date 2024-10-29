namespace ComponentDemosScenarios1.Models.NestedDataRepeat;

public class EditorInfoType
{
    public string FriendlyName { get; set; }
    public string Placeholder { get; set; }
    public bool IsRequired { get; set; }
    public bool IsVisible { get; set; }
    public bool IsDisabled { get; set; }
    public string EnumName { get; set; }
    public double Order { get; set; }
    public string PropertyEditor { get; set; }
    public string Section { get; set; }
    public bool Bindable { get; set; }
    public string IsShortVersion { get; set; }
    public string Tooltip { get; set; }
    public string FeatureName { get; set; }
    public string FeatureSubgroup { get; set; }
    public string FeatureOptionsName { get; set; }
    public string ItemSelector { get; set; }
    public string Info { get; set; }
    public bool ShowLabel { get; set; }
    public PropertyEditorSettingsType PropertyEditorSettings { get; set; }
}
