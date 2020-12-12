using MyCurrency.Data.Entities;
using System.Threading.Tasks;

namespace MyCurrency.Data.Services
{
    public interface IQuotationService
    {
        Task<Quotation> GetTodayQuotation();
    }
}
