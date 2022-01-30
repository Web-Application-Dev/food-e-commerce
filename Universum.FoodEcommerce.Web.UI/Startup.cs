using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Universum.FoodEcommerce.Application.Features;
using Universum.FoodEcommerce.Application.Interfaces;
using Universum.FoodEcommerce.Domain.Repositories;
using Universum.FoodEcommerce.Presistence;
using Universum.FoodEcommerce.Presistence.Repositories;

namespace Universum.FoodEcommerce.Web.UI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddRazorPages();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Food ECommerce", Version = "v1" });
            });

            services.AddDbContext<ApplicationDbContext>(options =>
                     options.UseSqlServer(Configuration.GetConnectionString("Database")));


            //repository registration
            services.AddScoped<IAddressRepository,  AddressRepository>();
            services.AddScoped<ICityRepository,  CityRepository>();
            services.AddScoped<IGenderRepository,  GenderRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IOrderStatusrepository, OrderStatusRepository>();
            services.AddScoped<IPhotoRepository,  PhotoRepository>();
            services.AddScoped<IProductRepository,  ProductRepository>();
            services.AddScoped<IProductTypeRepository,  ProductTypeRepository>();
            services.AddScoped<IRoleRepository,  RoleRepository>();
            services.AddScoped<IStateRepository,  StateRepository>();
            services.AddScoped<IUserRepository,  UserRepository>();

            //service registration
            services.AddScoped<IAddressService, AddressService>();
            services.AddScoped<ICityService, CityService>();
            services.AddScoped<IGenderService, GenderService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IOrderStatusService, OrderStatusService>();
            services.AddScoped<IPhotoService, PhotoService>();
            services.AddScoped<IProductServices, ProductServices>();
            services.AddScoped<IProductTypeService, ProductTypeService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IStateService, StateService>();
            services.AddScoped<IUserService, UserService>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseSwagger();
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action}/{id?}");
            });

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });
        }
    }
}
