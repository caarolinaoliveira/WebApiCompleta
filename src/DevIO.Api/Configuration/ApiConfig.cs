using AutoMapper;
using DevIO.Api.ViewModels;
using Dev.Business.Models;

namespace DevIO.Api.Configuration
{
    public static IServiceCollection WebApiConfig(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(Startup));
        return services;
    }

    
    public static IApplicationBuilder UseMvcConfiguration(this IApplicationBuilder app)
        {
            return app;
        }
    
}
