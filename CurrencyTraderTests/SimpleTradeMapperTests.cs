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
        public void TestCurrencySourceCurrency()
        {
            //Arrange
            var mapper = new SimpleTradeMapper();
            string[] strData = { "XXXYYY", "5000", "1.5" };
            //Act
            TradeRecord tradeRec = mapper.Map(strData);
            //Assert
            Assert.AreEqual(tradeRec.SourceCurrency, "XXX");
        }

        [TestMethod()]
        public void TestCurrencyDestinationCurrency()
        {
            //Arrange
            var mapper = new SimpleTradeMapper();
            string[] strData = { "XXXYYY", "5000", "1.5" };
            //Act
            TradeRecord tradeRec = mapper.Map(strData);
            //Assert
            Assert.AreEqual(tradeRec.DestinationCurrency, "YYY");
        }

        [TestMethod()]
        public void TestLotSize()
        {
            //Arrange
            float LotSize = 100000f;
            float tradeAmount = 5000;
            string tradeAmountString = "5000";
            var mapper = new SimpleTradeMapper();
            string[] strData = { "XXXYYY", tradeAmountString, "1.5" };
            //Act
            TradeRecord tradeRec = mapper.Map(strData);
            //Assert
            
            Assert.AreEqual(tradeRec.Lots, tradeAmount / LotSize);
        }

        [TestMethod()]
        public void TestPrice()
        {
            //Arrange
            Decimal price = 1.99M;
            string priceString = "1.99";
            var mapper = new SimpleTradeMapper();
            string[] strData = { "XXXYYY", "5000", priceString };
            //Act
            TradeRecord tradeRec = mapper.Map(strData);
            //Assert
            Assert.AreEqual(tradeRec.Price, price);
        }
    }
}