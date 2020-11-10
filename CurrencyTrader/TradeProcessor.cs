
using CurrencyTrader.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace CurrencyTrader
{
    public class TradeProcessor
    {
        private IEnumerable<string> lines;
        private IEnumerable<TradeRecord> trades;

        public IEnumerable<string> ReadTrades(ITradeDataProvider tradeDataProvider)
        {
            lines = tradeDataProvider.GetTradeData();
            return lines;
        }
        public int ParseTrades(ITradeParser tradeParser, ILogger logger)
        {
            trades = tradeParser.Parse(lines);
            logger.LogInfo("Parsed " + trades.Count().ToString() + " trades sucessfully.");
            return trades.Count();
        }
        public void StoreTrades(ITradeStorage tradeStorage)
        {
            tradeStorage.Persist(trades);
        }

        public void ProcessTrades(ITradeDataProvider tradeDataProvider, ITradeParser tradeParser, ITradeStorage tradeStorage)
        {
            lines = tradeDataProvider.GetTradeData();
            trades = tradeParser.Parse(lines);
            tradeStorage.Persist(trades);
        }

    }
}
