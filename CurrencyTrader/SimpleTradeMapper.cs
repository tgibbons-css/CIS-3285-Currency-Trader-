
using CurrencyTrader.Contracts;


namespace CurrencyTrader
{
    public class SimpleTradeMapper : ITradeMapper
    {
        /// <summary>
        /// Converts a string containing the trade data into a TradeRecord object
        /// </summary>
        /// <param name="fields"> The string must be split into three components before calling </param>
        /// <returns> A TradeRecord object containing the trade data</returns>
        public TradeRecord Map(string[] fields)
        {
            var sourceCurrencyCode = fields[0].Substring(0, 3);
            var destinationCurrencyCode = fields[0].Substring(3, 3);
            var tradeAmount = int.Parse(fields[1]);
            var tradePrice = decimal.Parse(fields[2]);

            var trade = new TradeRecord
            {
                SourceCurrency = sourceCurrencyCode,
                DestinationCurrency = destinationCurrencyCode,
                Lots = tradeAmount / LotSize,
                Price = tradePrice
            };

            return trade;
        }

        private static float LotSize = 100000f;
    }
}
