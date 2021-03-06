﻿using MediumGS.Repo.Abstract;
using MediumGS.Repo.Concrete;
using MediumGS.Service.Abstract;
using MediumGS.Service.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MediumGS.API.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            // [Singleton] which creates a single instance throughout the application. 
            //  It creates the instance for the first time and reuses the same object in the all calls.

            // [Scoped] lifetime services are created once per request within the scope.
            //  It is equivalent to Singleton in the current scope.
            //  eg. in MVC it creates 1 instance per each http request but uses the same instance in the other calls within the same web request.

            // [Transient] lifetime services are created each time they are requested.
            //  This lifetime works best for lightweight, stateless services.

            services.AddDbContext<TestContext>(options =>
                options.UseMySql(configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("MediumGS.Repo")));

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IPageContentService, PageContentService>();

            return services;
        }
    }
}
