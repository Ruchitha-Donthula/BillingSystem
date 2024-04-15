using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Filters;

namespace BillingSystemServices.Filters
{
    public class ExceptionHandlingFilter : ExceptionFilterAttribute
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(ExceptionHandlingFilter));

        public override void OnException(HttpActionExecutedContext context)
        {
            Log.Error("Exception occurred:", context.Exception);
            base.OnException(context);
        }
    }
}