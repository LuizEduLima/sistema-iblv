using AutoMapper;
using IBLV.Web.Api.Configurations;
using IBVL.Data.Repositories;
using IBVL.Domain.Core;
using IBVL.Domain.Core.Interfaces;
using IBVL.Domain.Interfaces;
using IBVL.Domain.Services;

namespace IBLV.Web.Api.Configurations
{
    public static class IndependencyInjectionConfig
    {

        public static void AddIndependecyConfig(this WebApplicationBuilder builder)
        {
            //Extesion methodo responsável por ID de todas as interfaces e classe que implmementam o IRepository
            builder.Services.AddInterfaces(typeof(IRepository));
            builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            builder.Services.AddScoped<IMembroRepository, MembroRepository>();
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

             builder.Services.AddScoped<IMembroDomainService, MembroDomainService>();
            //builder.Services.AddScoped<IUsuarioDomainService, MembroDomainService>();

            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}
