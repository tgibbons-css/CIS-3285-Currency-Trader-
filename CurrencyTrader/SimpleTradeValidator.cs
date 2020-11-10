
using CurrencyTrader.Contracts;

namespace CurrencyTrader
{
    public class SimpleTradeValidator : ITradeValidator
    {
        private readonly ILogger logger;

        public SimpleTradeValidator(ILogger logger)
        {
            this.logger = logger;
        }

        /// <summary>
        /// Checks the formate on a single line in the trade file.
        /// </summary>
        /// <param name="fields"> The string must be split into three components before calling </param>
        /// <param name="currentLine"> This is the current line number in the file, used to report errors</param>
        /// <returns> true if all the checks pass </returns>
        public bool Validate(string[] tradeData)
        {
            if (tradeData.Length != 3)
            {
                logger.LogWarning("Line malformed. Only {0} field(s) found.", tradeData.Length);
                return false;
            }

            if (tradeData[0].Length != 6)
            {
                logger.LogWarning("Trade currencies malformed: '{0}'", tradeData[0]);
                return false;
            }

            int tradeAmount;
            if (!int.TryParse(tradeData[1], out tradeAmount))
            {
                logger.LogWarning("Trade not a valid integer: '{0}'", tradeData[1]);
                return false;
            }
            // added cases for boundaries for trade amount
            if (tradeAmount < 1000)
            {
                logger.LogWarning("Trade amount is below lower bound: '{0}'", tradeData[1]);
                return false;
            }
            if (tradeAmount > 100000)
            {
                logger.LogWarning("Trade amount is above upper bound: '{0}'", tradeData[1]);
                return false;
            }
            decimal tradePrice;
            if (!decimal.TryParse(tradeData[2], out tradePrice))
            {
                logger.LogWarning("Trade price not a valid decimal: '{0}'", tradeData[2]);
                return false;
            }

            return true;
        }
    }
}
