namespace ComponentDemosScenarios1.Models.IG_NorthwindAPI;

public class CustomerDtoPagedResultDto
{
    public CustomerDto[] Items { get; set; } = Array.Empty<CustomerDto>();
    public int TotalRecordsCount { get; set; }
    public int PageSize { get; set; }
    public int PageNumber { get; set; }
    public int TotalPages { get; set; }
}
