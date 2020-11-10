using System.Collections.Generic;

using CurrencyTrader.Contracts;

namespace CurrencyTrader
{
    public class SimpleTradeParser : ITradeParser
    {
        private readonly ITradeValidator tradeValidator;
        private readonly ITradeMapper tradeMapper;

        public SimpleTradeParser(ITradeValidator tradeValidator, ITradeMapper tradeMapper)
        {
            this.tradeValidator = tradeValidator;
            this.tradeMapper = tradeMapper;
        }

        /// <summary>
        /// Takes a list of strings containing trade data and converts this into a list of TradeRecord objects
        /// </summary>
        /// <param name="lines"> The strings containing the trade data, each string should contain one trade in format of "GBPUSD,1000,1.51"</param>
        /// <returns> A list of TradeRecords, one record for each trade </returns>

        public IEnumerable<TradeRecord> Parse(IEnumerable<string> tradeData)
        {
            var trades = new List<TradeRecord>();
            var lineCount = 1;
            foreach (var line in tradeData)
            {
                var fields = line.Split(new char[] { ',' });

                if (!tradeValidator.Validate(fields))
                {
                    continue;
                }

                var trade = tradeMapper.Map(fields);

                trades.Add(trade);

                lineCount++;
            }

            return trades;
        }
    }
}
