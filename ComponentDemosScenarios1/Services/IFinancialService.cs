using ComponentDemosScenarios1.Models.Financial;

namespace ComponentDemosScenarios1.Financial
{
    public interface IFinancialService
    {
        Task<List<SalesType>> GetSales();
        Task<List<BoxOfficeRevenueType>> GetBoxOfficeRevenue();
        Task<List<GlobalElectricityDemandType>> GetGlobalElectricityDemand();
        Task<List<TradingType>> GetTrading();
    }
}
