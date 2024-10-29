using ComponentDemosScenarios1.Models.Northwind;

namespace ComponentDemosScenarios1.Northwind
{
    public class MockNorthwindService : INorthwindService
    {
        public Task<List<CategoriesType>> GetCategories()
        {
            return Task.FromResult<List<CategoriesType>>(new());
        }
    }
}
