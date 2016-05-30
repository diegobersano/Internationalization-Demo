using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Web.Mvc;
using Internacionalization.Infraestructure;

namespace Internacionalization.Controllers
{
    public abstract class BaseController : Controller
    {
        protected override IAsyncResult BeginExecuteCore(AsyncCallback callback, object state)
        {
            var cultureRoute = RouteData.Values["culture"] as string;

            var cultureDefinition = string.IsNullOrEmpty(cultureRoute)
                ? Thread.CurrentThread.CurrentCulture.Name.Split('-')
                : cultureRoute.Split('-');

            RouteData.Values["culture"] = cultureRoute = this.GetCulture(cultureDefinition);

            Thread.CurrentThread.CurrentCulture = new CultureInfo(cultureRoute);
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;

            return base.BeginExecuteCore(callback, state);
        }

        private string GetCulture(IReadOnlyList<string> cultureDefinition)
        {
            return cultureDefinition[0] == SupportedCulture.English
                ? SupportedCulture.English
                : SupportedCulture.Spanish;
        }
    }
}