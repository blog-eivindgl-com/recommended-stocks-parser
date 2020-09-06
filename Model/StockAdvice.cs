namespace DNBMarketsAAParser.Model
{
    public class StockAdvice
    {
        public string Ticker { get; set; }
        public string Name { get; set; }
        public string Advice { get; set; }
        public string Responsible { get; set; }
        public decimal CurrentPrice { get; set; }
        public decimal TargetPrice { get; set; }
    }
}