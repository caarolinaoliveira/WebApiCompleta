using Microsoft.Extensions.DependencyInjection;
using Dev.Data.Context;
using Dev.Business.Interfaces;
using Dev.Data.Repository;

namespace DevIO.Api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<MeuDbContext>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            return services;
        }
    }
}