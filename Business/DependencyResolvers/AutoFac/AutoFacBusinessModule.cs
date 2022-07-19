using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
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

            builder.RegisterType<SchoolManager>().As<ISchoolService>().SingleInstance();
            builder.RegisterType<EfSchoolDal>().As<ISchoolDal>().SingleInstance();

            builder.RegisterType<CityManager>().As<ICityService>().SingleInstance();
            builder.RegisterType<EfCityDal>().As<ICityDal>().SingleInstance();

            builder.RegisterType<DistrictManager>().As<IDistrictService>().SingleInstance();
            builder.RegisterType<EfDistrictDal>().As<IDistrictDal>().SingleInstance();















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
