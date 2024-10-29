using System.Net.Http.Json;
using ComponentDemosScenarios1.Models.IG_NorthwindAPI;

namespace ComponentDemosScenarios1.IG_NorthwindAPI
{
    public class IG_NorthwindAPIService: IIG_NorthwindAPIService
    {
        private readonly HttpClient _http;

        public IG_NorthwindAPIService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<CustomerDto>> GetCustomerDtoList()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://data-northwind.indigo.design/Customers", UriKind.RelativeOrAbsolute));
            request.Headers.Add("Authorization", "Bearer <auth_value>");
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<CustomerDto>>().ConfigureAwait(false);
            }

            return new List<CustomerDto>();
        }

        public async Task<CustomerDto> GetCustomerDto(string? id = "ALFKI")
        {
            if (id == null)
            {
                return null;
            }

            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri($"https://data-northwind.indigo.design/Customers/{id}", UriKind.RelativeOrAbsolute));
            request.Headers.Add("Authorization", "Bearer <auth_value>");
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<CustomerDto>().ConfigureAwait(false);
            }

            return null;
        }

        public async Task<List<OrderDto>> GetOrderDtoList(string? id = "ALFKI")
        {
            if (id == null)
            {
                return new List<OrderDto>();
            }

            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri($"https://data-northwind.indigo.design/Customers/{id}/Orders", UriKind.RelativeOrAbsolute));
            request.Headers.Add("Authorization", "Bearer <auth_value>");
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<OrderDto>>().ConfigureAwait(false);
            }

            return new List<OrderDto>();
        }

        public async Task<List<OrderDetailDto>> GetOrderDetailDtoList(int? id = 10248)
        {
            if (id == null)
            {
                return new List<OrderDetailDto>();
            }

            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri($"https://data-northwind.indigo.design/Orders/{id}/Details", UriKind.RelativeOrAbsolute));
            request.Headers.Add("Authorization", "Bearer <auth_value>");
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<OrderDetailDto>>().ConfigureAwait(false);
            }

            return new List<OrderDetailDto>();
        }

        public async Task<List<EmployeeDto>> GetEmployeeDtoList()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://data-northwind.indigo.design/Employees", UriKind.RelativeOrAbsolute));
            request.Headers.Add("Authorization", "Bearer <auth_value>");
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<EmployeeDto>>().ConfigureAwait(false);
            }

            return new List<EmployeeDto>();
        }

        public async Task<CustomerDto> DeleteCustomerDto(string? id)
        {
            if (id == null)
            {
                return null;
            }

            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Delete, new Uri($"https://data-northwind.indigo.design/Customers/{id}", UriKind.RelativeOrAbsolute));
            request.Headers.Add("Authorization", "Bearer <auth_value>");
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<CustomerDto>().ConfigureAwait(false);
            }

            return null;
        }

        public async Task<CustomerDto> PutCustomerDto(object? data)
        {
            if (data == null)
            {
                return null;
            }

            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Put, new Uri("https://data-northwind.indigo.design/Customers", UriKind.RelativeOrAbsolute));
            request.Headers.Add("Authorization", "Bearer <auth_value>");
            request.Content = new StringContent(@"{
  ""customerId"": ""string"",
  ""companyName"": ""string"",
  ""contactName"": ""string"",
  ""contactTitle"": ""string"",
  ""address"": {
    ""street"": ""string"",
    ""city"": ""string"",
    ""region"": ""string"",
    ""postalCode"": ""string"",
    ""country"": ""string"",
    ""phone"": ""string""
  }
}", System.Text.Encoding.UTF8, "application/json");
            request.Content = JsonContent.Create(data);
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<CustomerDto>().ConfigureAwait(false);
            }

            return null;
        }

        public async Task<CustomerDtoPagedResultDto> GetCustomerDtoPagedResultDto(int pageIndex, int size, string orderBy)
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://data-northwind.indigo.design/Customers/GetCustomersWithPage", UriKind.RelativeOrAbsolute));
            var query = new FormUrlEncodedContent(new Dictionary<string, string>()
            {
                ["pageIndex"] = $"{pageIndex}",
                ["size"] = $"{size}",
                ["orderBy"] = $"{orderBy}",
            }).ReadAsStringAsync().Result;
            request.RequestUri = new UriBuilder(request.RequestUri) { Query = query }.Uri;
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<CustomerDtoPagedResultDto>().ConfigureAwait(false);
            }

            return null;
        }
    }
}
