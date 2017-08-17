using Seq.CurrencyExchangeService.ExchangeService;

namespace Seq.CurrencyExchangeService
{
    class Program
    {
        static void Main()
        {
            IExchangeService centralBank = new CentralBank("Merkez Bankasi", "http://www.tcmb.gov.tr/kurlar/today.xml");
            centralBank.GetCurrencyData();

            IExchangeService dovizCom = new DovizCom("Doviz Com", "https://kur.doviz.com/");
            dovizCom.GetCurrencyData();
        }
    }
}
