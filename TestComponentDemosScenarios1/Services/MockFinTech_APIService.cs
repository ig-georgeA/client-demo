using ComponentDemosScenarios1.Models.FinTech_API;

namespace ComponentDemosScenarios1.FinTech_API
{
    public class MockFinTech_APIService : IFinTech_APIService
    {
        public Task<Stock> GetStock(string? symbol)
        {
            return Task.FromResult<Stock>(new());
        }

        public Task<List<Stock>> GetStockList()
        {
            return Task.FromResult<List<Stock>>(new());
        }

        public Task<List<StockData>> GetStockDataList(string? symbol)
        {
            return Task.FromResult<List<StockData>>(new());
        }
    }
}
