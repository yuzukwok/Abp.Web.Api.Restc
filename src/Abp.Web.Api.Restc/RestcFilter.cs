using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace Abp.Web.Api.Restc
{
    public class RestcFilter : IActionFilter
    {
        public bool AllowMultiple
        {
            get { return true; }
        }

        public  Task<HttpResponseMessage> ExecuteActionFilterAsync(HttpActionContext actionContext, CancellationToken cancellationToken, Func<Task<HttpResponseMessage>> continuation)
        {
            if (actionContext.Request.Headers.Accept.Where(p => p.MediaType.Contains("javascript")||p.MediaType.Contains("json")).Count() == 0 &&
                actionContext.Request.RequestUri.AbsolutePath.StartsWith("/api")) {
                //如果是ajax请求和/api 请求，则使用restc
            
                HttpResponseMessage res = new HttpResponseMessage(System.Net.HttpStatusCode.OK);
                res.Content = new StringContent(Abp.Web.Api.Restc.Properties.Resources.index,Encoding.UTF8, "text/html");
                return Task.FromResult<HttpResponseMessage>(res);

            }
            return continuation();
         }
    }
}
