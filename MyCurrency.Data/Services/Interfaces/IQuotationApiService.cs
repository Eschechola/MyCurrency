using MyCurrency.Data.DTO;
using System.Threading.Tasks;

namespace MyCurrency.Data.Services
{
    public interface IQuotationApiService
    {
        Task<QuotationsDTO> GetDollarQuotation();
        Task<QuotationsDTO> GetEuroQuotation();
        Task<QuotationsDTO> GetPoundSterlingQuotation();
        Task<QuotationsDTO> GetYenQuotation();
        Task<QuotationsDTO> GetSwissFrancQuotation();
        Task<QuotationsDTO> GetArgentinianPesoQuotation();
        Task<QuotationsDTO> GetBitcoinQuotation();
    }
}
