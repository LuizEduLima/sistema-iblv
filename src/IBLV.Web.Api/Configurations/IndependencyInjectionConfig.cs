using IBLV.Web.Api.Configurations;
using IBVL.Domain.Core.Interfaces;

namespace IBLV.Web.Api.Configurations
{
    public static class IndependencyInjectionConfig
    {

        public static void AddIndependecyConfig(this WebApplicationBuilder builder)
        {
            //Extesion methodo responsável por ID de todas as interfaces e classe que implmementam o IRepository
            builder.Services.AddInterfaces(typeof(IRepository));
        }
    }
}
