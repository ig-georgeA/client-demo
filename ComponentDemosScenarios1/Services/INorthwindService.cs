using ComponentDemosScenarios1.Models.Northwind;

namespace ComponentDemosScenarios1.Northwind
{
    public interface INorthwindService
    {
        Task<List<CategoriesType>> GetCategories();
    }
}
