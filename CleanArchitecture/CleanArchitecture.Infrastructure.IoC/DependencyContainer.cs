using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Infrastructure.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CleanArchitecture.Infrastructure.IoC
{
    public class DependencyContainer
    {
        public void RegisterServices(IServiceCollection services)
        {
            //services.AddTransient  her çağırdığımızda birdaha newler ||  müsteri sepeti vs.
            //services.AddScoped       istekbaşına oluşturulur || repositoryler contextler
            //services.AddSingleton    uygulama kapanana kadar ayakta kalır || paylaşılan objeler için mesela connectionstring
            services.AddScoped<IBlogService, BlogService>(); 
            services.AddScoped<IBlogRepository, BlogRepository>();
        }
    }
}
