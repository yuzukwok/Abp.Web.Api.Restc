using Abp.Modules;
using Abp.Web.Api.Restc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Sample.App_Start
{
    [DependsOn(typeof(AbpWebApiRestcModule))]
    public class samplemodule: AbpModule
    {
        public override void Initialize()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            base.Initialize();
        }
    }
}