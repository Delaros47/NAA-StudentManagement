using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Utilities.Interceptors;

namespace Business.DependencyResolvers.AutoFac
{
    public class AutoFacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {



















            #region Comment
            /*
             * Here below just goes to and check all Assembly it has an aspect or not if it has it will invoke all of it first of all
             */
            #endregion
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }
    }
}
