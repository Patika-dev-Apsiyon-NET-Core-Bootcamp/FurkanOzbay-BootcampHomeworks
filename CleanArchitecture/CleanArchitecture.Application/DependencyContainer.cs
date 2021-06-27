using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Infrastructure.Data.Context;
using CleanArchitecture.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CleanArchitecture.Application
{
    public static class DependencyContainer
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services,IConfiguration configuration)
        {
            //services.AddTransient  her çağırdığımızda birdaha newler ||  müsteri sepeti vs.
            //services.AddScoped    istekbaşına oluşturulur || repositoryler contextler
            //services.AddSingleton   uygulama kapanana kadar ayakta kalır || paylaşılan objeler için mesela connectionstring
            services.AddDbContext<BlogDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("Default")).UseLazyLoadingProxies());
            services.AddScoped<IBlogService, BlogService>();
            services.AddScoped<IBlogRepository, BlogRepository>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
