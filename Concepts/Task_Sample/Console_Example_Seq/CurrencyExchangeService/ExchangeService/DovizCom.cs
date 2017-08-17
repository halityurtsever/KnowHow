using System.Globalization;
using System.IO;
using System.Net;

namespace Seq.CurrencyExchangeService.ExchangeService
{
    internal class DovizCom : ExchangeServiceBase, IExchangeService
    {
        //################################################################################
        #region Constructor

        public DovizCom(string serviceName, string serviceUri) : base(serviceName, serviceUri)
        {
        }

        #endregion

        //################################################################################
        #region IExchangeService Implementation

        void IExchangeService.GetCurrencyData()
        {
            //create web request/response
            m_Stopwatch.Start();
            WebRequest request = WebRequest.Create(m_ServiceUri);
            request.Timeout = 10 * 1000; //10 secs
            WebResponse response = request.GetResponse();
            m_Stopwatch.Stop();

            using (Stream stream = response.GetResponseStream())
            {
                if (stream != null)
                {
                    using (StreamReader streamReader = new StreamReader(stream))
                    {
                        int currencyCount = 0;
                        while (!streamReader.EndOfStream)
                        {
                            var line = streamReader.ReadLine();
                            if (line != null
                                && currencyCount < 3
                                && line.Contains("data-buying")
                                && line.Contains("data-selling")
                                && line.Contains("data-code"))
                            {
                                string[] data = line.Split('\'');
                                Currency currency = new Currency();
                                switch (data[5])
                                {
                                    case "EUR":
                                        currency.CurrencyType = CurrencyType.EUR;
                                        currency.CurrencyName = "Euro";
                                        break;

                                    case "USD":
                                        currency.CurrencyType = CurrencyType.USD;
                                        currency.CurrencyName = "Dollar";
                                        break;

                                    case "BGN":
                                        currency.CurrencyType = CurrencyType.BGN;
                                        currency.CurrencyName = "Leva";
                                        break;

                                    default:
                                        continue;
                                }

                                currencyCount++;
                                currency.CurrencyUnit = 1;
                                currency.BuyingPrice = decimal.Parse(data[3], CultureInfo.InvariantCulture);
                                currency.SellingPrice = decimal.Parse(data[1], CultureInfo.InvariantCulture);

                                m_Currencies.Add(currency);
                            }
                        }
                    }
                }
            }
            PrintCurrencyData();
        }

        #endregion
    }
}
