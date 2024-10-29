using ComponentDemosScenarios1.Models.NestedDataRepeat;

namespace ComponentDemosScenarios1.NestedDataRepeat
{
    public class MockNestedDataRepeatService : INestedDataRepeatService
    {
        public Task<NestedDataType> GetNestedData()
        {
            return Task.FromResult<NestedDataType>(new());
        }
    }
}
