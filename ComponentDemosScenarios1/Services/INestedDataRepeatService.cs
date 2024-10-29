using ComponentDemosScenarios1.Models.NestedDataRepeat;

namespace ComponentDemosScenarios1.NestedDataRepeat
{
    public interface INestedDataRepeatService
    {
        Task<NestedDataType> GetNestedData();
    }
}
