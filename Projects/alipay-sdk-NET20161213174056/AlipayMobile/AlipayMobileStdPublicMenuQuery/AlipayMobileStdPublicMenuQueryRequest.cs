using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.mobile.std.public.menu.query
    /// </summary>
    public class AlipayMobileStdPublicMenuQueryRequest : IAopRequest<AlipayMobileStdPublicMenuQueryResponse>
    {
        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.mobile.std.public.menu.query";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            return parameters;
        }

        #endregion
    }
}
