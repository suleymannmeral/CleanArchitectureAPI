﻿
using System.Reflection;

namespace CleanArchitecture.WebApi.Configurations;

public static class DependencyInjection
{
    public static IServiceCollection InstalLService(
        this IServiceCollection services ,
        IConfiguration configuration,
        params Assembly[] assemblies)
    {
        IEnumerable<IServiceInstaller> serviceInstallers = assemblies
            .SelectMany(s => s.DefinedTypes)
            .Where(IsAssignableToType<IServiceInstaller>)
            .Select(Activator.CreateInstance)
            .Cast<IServiceInstaller>();

        foreach (IServiceInstaller serviceInstaller in serviceInstallers)
        {
            serviceInstaller.Install(services,configuration);

        }
        return services;

        static bool IsAssignableToType<T>(TypeInfo typeInfo)
            => typeof(T).IsAssignableFrom(typeInfo) &&
            !typeInfo.IsInterface &&
            !typeInfo.IsAbstract;


    }
}
