using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
//using HotChocolate.AspNetCore.Playground;
using Semana10.Interfaces;
using Semana10.Model;

namespace Semana10
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddGraphQLServer()
                    .AddQueryType<Product>();

            services.AddGraphQLServer()
           .AddQueryType<Customer>();

            services.AddHttpContextAccessor();

            services.AddSingleton<IProductService, ProductService>();
            services.AddSingleton<ICustomerService, CustomerService>();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

             //   app.UseGraphQLPlayground("/graphql");
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapGraphQL();
            });
        }
    }
}
