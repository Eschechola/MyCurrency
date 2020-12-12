using System.Net.Http;
using Newtonsoft.Json;
using MyCurrency.Data.DTO;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace MyCurrency.Data.Services
{
    public class QuotationApiService : IQuotationApiService
    {
        private readonly IConfiguration _configuration;
        private readonly IHttpClientFactory _httpClientFactory;

        public QuotationApiService(IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
        }

        private async Task<QuotationsDTO> GetQuotation(string url)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, url);

            var client = _httpClientFactory.CreateClient("quotation");
            var response = await client.SendAsync(request);

            var responseContent = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<List<QuotationsDTO>>(responseContent)[0];
        }


        public async Task<QuotationsDTO> GetArgentinianPesoQuotation()
        {
            var url = _configuration["API:Quotation:ArgentinianPeso"];
            return await GetQuotation(url);
        }

        public async Task<QuotationsDTO> GetDollarQuotation()
        {
            var url = _configuration["API:Quotation:Dollar"];
            return await GetQuotation(url);
        }

        public async Task<QuotationsDTO> GetEuroQuotation()
        {
            var url = _configuration["API:Quotation:Euro"];
            return await GetQuotation(url);
        }

        public async Task<QuotationsDTO> GetPoundSterlingQuotation()
        {
            var url = _configuration["API:Quotation:PoundSterling"];
            return await GetQuotation(url);
        }

        public async Task<QuotationsDTO> GetSwissFrancQuotation()
        {
            var url = _configuration["API:Quotation:SwissFranc"];
            return await GetQuotation(url);
        }

        public async Task<QuotationsDTO> GetYenQuotation()
        {
            var url = _configuration["API:Quotation:Yen"];
            return await GetQuotation(url);
        }

        public async Task<QuotationsDTO> GetBitcoinQuotation()
        {
            var url = _configuration["API:Quotation:Bitcoin"];
            return await GetQuotation(url);
        }
    }
}
