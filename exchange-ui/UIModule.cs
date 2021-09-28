using System;
using System.Reflection;
using Autofac;

namespace exchange_ui
{
    public class UIModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var assembly = typeof(UIModule)
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
