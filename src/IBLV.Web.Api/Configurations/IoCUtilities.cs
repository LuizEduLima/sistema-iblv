namespace IBLV.Web.Api.Configurations
{
    public static class IoCUtilities
    {
        public static IServiceCollection AddInterfaces(this IServiceCollection services, Type interfaceKey)
        {
            var allTypes = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes()).ToList();

            //
            var allInterfaces = allTypes
                .Where(x => !x.IsClass && x.GetInterfaces().Contains(interfaceKey)).Select(x => x).ToList();

            foreach (var interfaceType in allInterfaces)
            {
                var classe = allTypes.Where(x =>
                x.IsClass && !x.IsAbstract && x.GetInterfaces().Contains(interfaceKey)
                && x.GetInterfaces().Contains(interfaceType)).Select(x => x).FirstOrDefault();

                if (classe == null) continue;


                services.AddTransient(interfaceType, classe);
            }
            return services;
        }
    }


}
