using ComponentDemosScenarios1.Models.IG_NorthwindAPI;

namespace ComponentDemosScenarios1.IG_NorthwindAPI
{
    public interface IIG_NorthwindAPIService
    {
        Task<List<CustomerDto>> GetCustomerDtoList();
        Task<CustomerDto> GetCustomerDto(string? id = "ALFKI");
        Task<List<OrderDto>> GetOrderDtoList(string? id = "ALFKI");
        Task<List<OrderDetailDto>> GetOrderDetailDtoList(int? id = 10248);
        Task<List<EmployeeDto>> GetEmployeeDtoList();
        Task<CustomerDto> DeleteCustomerDto(string? id);
        Task<CustomerDto> PutCustomerDto(object? data);
        Task<CustomerDtoPagedResultDto> GetCustomerDtoPagedResultDto(int pageIndex, int size, string orderBy);
    }
}
