using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ShopApp.Business.Abstract.Services;
using ShopApp.Business.Concrete.Services;
using ShopApp.DataAccess.Abstract.Repository;
using ShopApp.DataAccess.Abstract.UnitOfWork;
using ShopApp.DataAccess.Concrete;
using ShopApp.DataAccess.Concrete.ORM.EfCore.Repository;

namespace ShopApp.WebUI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            #region DbContext Injection
            services.AddDbContext<ShopContext>();
            #endregion

            #region UnitOfWork Injection
            services.AddSingleton<IUnitOfWork, EfCoreUnitOfWork>();
            #endregion

            #region Repository Injection
            services.AddTransient<IProductRepository, EfCoreProductRepository>();
            services.AddTransient<IOrderRepository, EfCoreOrderRepository>();
            services.AddTransient<IOrderLineRepository, EfCoreOrderLineRepository>();
            services.AddTransient<ICategoryRepository, EfCoreCategoryRepository>();
            #endregion

            #region Service Injection
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IOrderLineService, OrderLineService>();
            services.AddTransient<ICategoryService, CategoryService>();
            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
