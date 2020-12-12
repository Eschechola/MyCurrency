using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyCurrency.Data.Entities;
using MyCurrency.Data.Services;

namespace MyCurrency.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public Quotation Quotation { get; set; }

        private readonly IQuotationService _quotationService;

        public IndexModel(IQuotationService quotationService)
        {
            _quotationService = quotationService;
            Quotation = _quotationService.GetTodayQuotation().Result;
        }
    }
}
