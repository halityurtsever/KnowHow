using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Seq.CurrencyExchangeService.ExchangeService
{
    internal abstract class ExchangeServiceBase
    {
        //################################################################################
        #region Fields

        private readonly string m_ServiceName;
        protected readonly string m_ServiceUri;
        protected readonly IList<Currency> m_Currencies;
        protected readonly Stopwatch m_Stopwatch;

        #endregion

        //################################################################################
        #region Constructor
        protected ExchangeServiceBase(string serviceName, string serviceUri)
        {
            m_ServiceName = serviceName;
            m_ServiceUri = serviceUri;
            m_Currencies = new List<Currency>();
            m_Stopwatch = new Stopwatch();
        }

        #endregion

        //################################################################################
        #region Protected Implementation

        protected void PrintCurrencyData()
        {
            Console.WriteLine($"Data from: {m_ServiceName}");
            Console.WriteLine($"Data source: {m_ServiceUri}");
            Console.WriteLine($"Elapsed time: {m_Stopwatch.ElapsedMilliseconds:##,###} secs.");
            Console.WriteLine();
            foreach (var currency in m_Currencies)
            {
                Console.WriteLine($"-> {currency.CurrencyType}");
                Console.WriteLine($"   Buying: {currency.CurrencyUnit} {currency.CurrencyName} = {currency.BuyingPrice:##.####} Turkish Lira:");
                Console.WriteLine($"   Selling: {currency.CurrencyUnit} {currency.CurrencyName} = {currency.SellingPrice:##.####} Turkish Lira:");
                Console.WriteLine();
            }
            Console.WriteLine("-----------------------------------------------------------");
            m_Stopwatch.Reset();
        }

        #endregion
    }
}
