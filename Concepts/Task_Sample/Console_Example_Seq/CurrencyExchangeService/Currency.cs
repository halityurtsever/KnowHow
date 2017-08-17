
namespace Seq.CurrencyExchangeService
{
    public class Currency
    {
        //################################################################################
        #region Public Implementation

        public CurrencyType CurrencyType { get; set; }

        public string CurrencyName { get; set; }

        public int CurrencyUnit { get; set; }

        public decimal BuyingPrice { get; set; }

        public decimal SellingPrice { get; set; }

        #endregion
    }
}
