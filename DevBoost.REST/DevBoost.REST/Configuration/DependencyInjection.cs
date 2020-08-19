using DevBoost.REST.Domain.Repository;
using DevBoost.REST.Domain.Services;
using DevBoost.REST.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevBoost.REST.Configuration
{
    public static class DependencyInjection
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<IServiceAluno, ServiceAluno>();
            services.AddScoped<IRepositoryAluno, RepositoryAluno>();
            return services;
        }
    }
}
