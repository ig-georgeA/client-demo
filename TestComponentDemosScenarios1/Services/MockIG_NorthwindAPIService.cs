using ComponentDemosScenarios1.Models.IG_NorthwindAPI;

namespace ComponentDemosScenarios1.IG_NorthwindAPI
{
    public class MockIG_NorthwindAPIService : IIG_NorthwindAPIService
    {
        public Task<List<CustomerDto>> GetCustomerDtoList()
        {
            return Task.FromResult<List<CustomerDto>>(new());
        }

        public Task<CustomerDto> GetCustomerDto(string? id)
        {
            return Task.FromResult<CustomerDto>(new());
        }

        public Task<List<OrderDto>> GetOrderDtoList(string? id)
        {
            return Task.FromResult<List<OrderDto>>(new());
        }

        public Task<List<OrderDetailDto>> GetOrderDetailDtoList(int? id)
        {
            return Task.FromResult<List<OrderDetailDto>>(new());
        }

        public Task<List<EmployeeDto>> GetEmployeeDtoList()
        {
            return Task.FromResult<List<EmployeeDto>>(new());
        }

        public Task<CustomerDto> DeleteCustomerDto(string? id)
        {
            return Task.FromResult<CustomerDto>(new());
        }

        public Task<CustomerDto> PutCustomerDto(object? data)
        {
            return Task.FromResult<CustomerDto>(new());
        }

        public Task<CustomerDtoPagedResultDto> GetCustomerDtoPagedResultDto(int pageIndex, int size, string orderBy)
        {
            return Task.FromResult<CustomerDtoPagedResultDto>(new());
        }
    }
}
