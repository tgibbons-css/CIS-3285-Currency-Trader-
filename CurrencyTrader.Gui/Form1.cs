
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CurrencyTrader.AdoNet;
using CurrencyTrader.Contracts;

namespace CurrencyTrader.Gui
{
    public partial class Form1 : Form
    {
        TradeProcessor tradeProcessor;
        IEnumerable<string> lines;
        ILogger logger;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ILogger baseLogger = new LoggerConsole();
            logger = new LoggerGUI(lbStatus.Items, baseLogger);
            tradeProcessor = new TradeProcessor();
        }

        private void btnReadTrades_Click(object sender, EventArgs e)
        {
            //String tradeUrl = "http://faculty.css.edu/tgibbons/trades100.txt";
            string tradeUrl = txtTradeUrl.Text.ToString();
            ITradeDataProvider tradeDataProvider = new UrlTradeDataProvider(tradeUrl);
            IEnumerable<string> lines = tradeProcessor.ReadTrades(tradeDataProvider);
            foreach (string line in lines)
            {
                lbTradeLines.Items.Add(line);
            }
            txtStoreStatus.Text = "Trades NOT stored in database yet.";
        }

        private void btnParseTrades_Click(object sender, EventArgs e)
        {
            var tradeValidator = new SimpleTradeValidator(logger);
            var tradeMapper = new SimpleTradeMapper();
            var tradeParser = new SimpleTradeParser(tradeValidator, tradeMapper);
            int numTrades = tradeProcessor.ParseTrades(tradeParser, logger);
            txtNumTrades.Text = numTrades.ToString();
        }

        private void btnStoreTrades_Click(object sender, EventArgs e)
        {
            ITradeStorage tradeStorage = new AdoNetTradeStorage(logger);
            tradeProcessor.StoreTrades(tradeStorage);
            txtStoreStatus.Text = "Trades written to database.";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
