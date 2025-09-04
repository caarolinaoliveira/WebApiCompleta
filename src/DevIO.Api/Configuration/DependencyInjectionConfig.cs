using Microsoft.Extensions.DependencyInjection;
using Dev.Data.Context;
using Dev.Data.Repository;
using Dev.Business.Interfaces;
using Dev.Business.Services;
using Dev.Business.Notificacoes;
using Dev.Business.Models;
using DevIO.Api.Extensions;
using Microsoft.Extensions.Logging;
using DevIO.Api.Controllers;

namespace DevIO.Api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<MeuDbContext>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IFornecedorService, FornecedorService>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddScoped<IProdutoService, ProdutoService>();
            services.AddScoped<INotificador, Notificador>();
            services.AddScoped<IUser, AspNetUser>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            return services;
        }
    }
}
