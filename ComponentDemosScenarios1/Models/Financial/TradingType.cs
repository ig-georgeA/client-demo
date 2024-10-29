namespace ComponentDemosScenarios1.Models.Financial;

public class TradingType
{
    public string Category { get; set; }
    public string Type { get; set; }
    public double Spread { get; set; }
    public double OpenPrice { get; set; }
    public double Price { get; set; }
    public double Buy { get; set; }
    public double Sell { get; set; }
    public double Change { get; set; }
    public double ChangeP { get; set; }
    public double Volume { get; set; }
    public string Settlement { get; set; }
    public double OpenPriceDiff { get; set; }
    public double BuyDiff { get; set; }
    public double SellDiff { get; set; }
    public double StartYDiff { get; set; }
    public double HighYDiff { get; set; }
    public double LowYDiff { get; set; }
    public double HighDDiff { get; set; }
    public double LowDDiff { get; set; }
}
