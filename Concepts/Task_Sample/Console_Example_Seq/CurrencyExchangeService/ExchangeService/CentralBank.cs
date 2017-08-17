using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Xml;

namespace Seq.CurrencyExchangeService.ExchangeService
{
    internal class CentralBank : ExchangeServiceBase, IExchangeService
    {
        //################################################################################
        #region Constructor

        public CentralBank(string serviceName, string serviceUri) : base(serviceName, serviceUri)
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

            XmlDocument xmlDocument = new XmlDocument();
            using (Stream stream = response.GetResponseStream())
            {
                if (stream != null)
                {
                    using (XmlReader xmlReader = XmlReader.Create(stream))
                    {
                        xmlDocument.Load(xmlReader);

                        var allCurrencies = xmlDocument.GetElementsByTagName("Currency");

                        foreach (XmlNode currentCurrency in allCurrencies)
                        {
                            if (currentCurrency.Attributes != null)
                            {
                                Currency currency = new Currency();
                                switch (currentCurrency.Attributes[2].Value)
                                {
                                    case "EUR":
                                        currency.CurrencyType = CurrencyType.EUR;
                                        break;

                                    case "USD":
                                        currency.CurrencyType = CurrencyType.USD;
                                        break;

                                    case "BGN":
                                        currency.CurrencyType = CurrencyType.BGN;
                                        break;

                                    default:
                                        continue;
                                }

                                var xmlNode = currentCurrency.ChildNodes.Item(0);
                                if (xmlNode != null) currency.CurrencyUnit = Convert.ToInt32(xmlNode.InnerText);

                                xmlNode = currentCurrency.ChildNodes.Item(2);
                                if (xmlNode != null) currency.CurrencyName = xmlNode.InnerText;

                                xmlNode = currentCurrency.ChildNodes.Item(3);
                                if (xmlNode != null)
                                    currency.BuyingPrice = decimal.Parse(
                                        xmlNode.InnerText,
                                        CultureInfo.InvariantCulture);

                                xmlNode = currentCurrency.ChildNodes.Item(4);
                                if (xmlNode != null)
                                    currency.SellingPrice = decimal.Parse(
                                        xmlNode.InnerText,
                                        CultureInfo.InvariantCulture);

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
