using Microsoft.VisualStudio.TestTools.UnitTesting;
using CurrencyTrader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CurrencyTrader.Contracts;

namespace CurrencyTrader.Tests
{
    [TestClass()]
    public class SimpleTradeMapperTests
    {
        [TestMethod()]
        public void TestCurrencyCode()
        {
            //Arrange
            var mapper = new SimpleTradeMapper();
            string[] strData = { "XXXYYY", "5000", "1.5" };
            //Act
            TradeRecord tradeRec = mapper.Map(strData);
            //Assert
            Assert.AreEqual(tradeRec.SourceCurrency, "XXX");
        }
    }
}