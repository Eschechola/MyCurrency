using System.Threading.Tasks;
using MyCurrency.Data.Entities;
using MyCurrency.Data.Enum;

namespace MyCurrency.Data.Services
{
    public class QuotationService : IQuotationService
    {
        private readonly IQuotationApiService _quotationApiService;

        public QuotationService(IQuotationApiService quotationApiService)
        {
            _quotationApiService = quotationApiService;
        }

        public async Task<Quotation> GetTodayQuotation()
        {
            Quotation quotation = new Quotation();

            //Dolar
            var dollarQuotation = await _quotationApiService.GetDollarQuotation();
            quotation.SetQuotation(CurrencyType.Dollar, dollarQuotation.High);

            //Euro
            var euroQuotation = await _quotationApiService.GetEuroQuotation();
            quotation.SetQuotation(CurrencyType.Euro, euroQuotation.High);

            //Libra Esterlina
            var poundSterlingQuotation = await _quotationApiService.GetPoundSterlingQuotation();
            quotation.SetQuotation(CurrencyType.PoundSterling, poundSterlingQuotation.High);

            //Yen
            var yenQuotation = await _quotationApiService.GetYenQuotation();
            quotation.SetQuotation(CurrencyType.Yen, yenQuotation.High);

            //Franco Suiço
            var swissFranc = await _quotationApiService.GetSwissFrancQuotation();
            quotation.SetQuotation(CurrencyType.SwissFranc, swissFranc.High);

            //Peso Argentino
            var argentinianPeso = await _quotationApiService.GetArgentinianPesoQuotation();
            quotation.SetQuotation(CurrencyType.ArgentinianPeso, argentinianPeso.High);

            //Bitcoin
            var bitcoin = await _quotationApiService.GetBitcoinQuotation();
            quotation.SetQuotation(CurrencyType.Bitcoin, bitcoin.High);

            return quotation;
        }
    }
}
