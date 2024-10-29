using System.Net.Http.Json;
using ComponentDemosScenarios1.Models.FinTech_API;

namespace ComponentDemosScenarios1.FinTech_API
{
    public class FinTech_APIService: IFinTech_APIService
    {
        private readonly HttpClient _http;

        public FinTech_APIService(HttpClient http)
        {
            _http = http;
        }

        public async Task<Stock> GetStock(string? symbol = "PLCE")
        {
            if (symbol == null)
            {
                return null;
            }

            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri($"https://fintechcloud.azurewebsites.net/stocks/{symbol}", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<Stock>().ConfigureAwait(false);
            }

            return null;
        }

        public async Task<List<Stock>> GetStockList()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://fintechcloud.azurewebsites.net/stocks", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<Stock>>().ConfigureAwait(false);
            }

            return new List<Stock>();
        }

        public async Task<List<StockData>> GetStockDataList(string? symbol = "UNH")
        {
            if (symbol == null)
            {
                return new List<StockData>();
            }

            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri($"https://fintechcloud.azurewebsites.net/stockprices/{symbol}", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<StockData>>().ConfigureAwait(false);
            }

            return new List<StockData>();
        }
    }
}
