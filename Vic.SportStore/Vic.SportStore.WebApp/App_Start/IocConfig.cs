using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vic.SportStore.Domain.Concrete;
using Vic.SportStore.Domain.Abstract;
using Vic.SportStore.WebApp.Abstract;
using Vic.SportStore.WebApp.Concrete;

namespace Vic.SportStore.WebApp
{
    public class IocConfig
    {
        public static void ConfigIoc()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly).PropertiesAutowired();

            builder.RegisterInstance<IProductsRepository>(new EFProductRepository()).PropertiesAutowired();

            builder
                .RegisterInstance<IOrderProcessor>(new EmailOrderProcessor(new EmailSettings()))
                .PropertiesAutowired();

            builder.RegisterInstance<IAuthProvider>(new FormsAuthProvider())
                .PropertiesAutowired();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }
    }
}