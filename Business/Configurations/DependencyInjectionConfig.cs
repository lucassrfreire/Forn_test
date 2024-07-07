using Plamove.Business.Services.AvisoService;
using Plamove.Business.Services.FornecedorService;
using Playmove.Data.Interfaces;
using Playmove.Data.Repository;

namespace FornecedorAPI.Business.Helpers
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection AddResolveDependencies(this IServiceCollection services)
        {
            services.AddControllers()
                    .ConfigureApiBehaviorOptions(options =>
                    {
                        options.InvalidModelStateResponseFactory = ValidacaoCustomizada.RespostaCustomizada;
                    })
                    .AddXmlSerializerFormatters();

            services.AddScoped<IAvisoService, AvisoService>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IFornecedorService, FornecedorService>();
            services.AddScoped<ValidacaoCustomizada>();

            return services;
        }
    }
}
