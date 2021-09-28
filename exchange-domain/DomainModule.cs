using System;
using System.Reflection;
using Autofac;

namespace exchange_domain
{
    public class DomainModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var assembly = typeof(DomainModule)
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
