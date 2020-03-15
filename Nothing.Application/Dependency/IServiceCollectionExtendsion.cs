using Microsoft.Extensions.DependencyInjection;
using Nothing.Application.Repository.LanguageRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nothing.Application.Dependency
{
    public static class IServiceCollectionExtendsion
    {
        public static IServiceCollection AddExamp(this IServiceCollection services)
        {
            services.AddScoped<ILanguageRepository, LanguageRepository>();
            return services;
        }
    }
}
