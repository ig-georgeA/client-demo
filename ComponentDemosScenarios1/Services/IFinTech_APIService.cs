using ComponentDemosScenarios1.Models.FinTech_API;

namespace ComponentDemosScenarios1.FinTech_API
{
    public interface IFinTech_APIService
    {
        Task<Stock> GetStock(string? symbol = "PLCE");
        Task<List<Stock>> GetStockList();
        Task<List<StockData>> GetStockDataList(string? symbol = "UNH");
    }
}
