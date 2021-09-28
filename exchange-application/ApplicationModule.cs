using System;
using System.Reflection;
using Autofac;
using ex_domain;

namespace exchange_application
{
    public class ApplicationModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var assembly = typeof(ApplicationModule)
                .GetTypeInfo()
                .Assembly;

            builder.RegisterAssemblyTypes(assembly)
                    .Where(
                       t => t.Name.EndsWith("Service") ||
                       t.Name.EndsWith("Repository") ||
                       t.Name.EndsWith("Sender"))
               .AsImplementedInterfaces();
        }
    }
}
