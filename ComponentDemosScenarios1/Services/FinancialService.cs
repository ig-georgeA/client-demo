using System.Net.Http.Json;
using ComponentDemosScenarios1.Models.Financial;

namespace ComponentDemosScenarios1.Financial
{
    public class FinancialService: IFinancialService
    {
        private readonly HttpClient _http;

        public FinancialService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<SalesType>> GetSales()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("/static-data/financial-sales-type.json", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<SalesType>>().ConfigureAwait(false);
            }

            return new List<SalesType>();
        }

        public async Task<List<BoxOfficeRevenueType>> GetBoxOfficeRevenue()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("/static-data/financial-box-office-revenue-type.json", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<BoxOfficeRevenueType>>().ConfigureAwait(false);
            }

            return new List<BoxOfficeRevenueType>();
        }

        public async Task<List<GlobalElectricityDemandType>> GetGlobalElectricityDemand()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("/static-data/financial-global-electricity-demand-type.json", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<GlobalElectricityDemandType>>().ConfigureAwait(false);
            }

            return new List<GlobalElectricityDemandType>();
        }

        public async Task<List<TradingType>> GetTrading()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("/static-data/financial-trading-type.json", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<TradingType>>().ConfigureAwait(false);
            }

            return new List<TradingType>();
        }
    }
}
