namespace ComponentDemosScenarios1.Models.FinTech_API;

public class Stock
{
    public string Id { get; set; }
    public string Company_name { get; set; }
    public string Stock_symbol { get; set; }
    public string Stock_name { get; set; }
    public string Stock_market_cap { get; set; }
    public string Stock_market { get; set; }
    public string Stock_industry { get; set; }
    public string Stock_sector { get; set; }
    public string Country { get; set; }
    public double Longitude { get; set; }
    public double Latitude { get; set; }
    public int Earnings { get; set; }
    public int Expenses { get; set; }
    public string Earnings_date { get; set; }
    public double Previous_close { get; set; }
    public double Day_range { get; set; }
    public double Year_range { get; set; }
    public int Avg_volume { get; set; }
    public double Pe_ratio { get; set; }
    public double Dividend_yield { get; set; }
    public string Img_url { get; set; }
}
