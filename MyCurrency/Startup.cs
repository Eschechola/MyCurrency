using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyCurrency.Data.Services;
using System;

namespace MyCurrency
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();

            services.AddControllersWithViews()
             .AddRazorRuntimeCompilation();

            //Services
            services.AddScoped<IQuotationService, QuotationService>();
            services.AddScoped<IQuotationApiService, QuotationApiService>();

            //Configuration
            services.AddSingleton(di => Configuration);

            services.AddHttpClient("quotation", q =>
            {
                q.BaseAddress = new Uri(Configuration["API:Quotation:Base"]);
                q.DefaultRequestHeaders.Add("accept", "application/json");
            });
        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
