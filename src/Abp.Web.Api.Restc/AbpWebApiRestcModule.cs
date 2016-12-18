using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abp.Web.Api.Restc
{
    [DependsOn(typeof(AbpWebApiModule))]
    public class AbpWebApiRestcModule : AbpModule
    {
        public override void PostInitialize()
        {
            Configuration.Modules.AbpWebApi().HttpConfiguration.Filters.Add(new RestcFilter());
            base.PostInitialize();
        }
    }
}
