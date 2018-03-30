using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.mobile.public.menu.query
    /// </summary>
    public class AlipayMobilePublicMenuQueryRequest : IAopRequest<AlipayMobilePublicMenuQueryResponse>
    {
        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.mobile.public.menu.query";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            return parameters;
        }

        #endregion
    }
}
