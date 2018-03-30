using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.open.public.menu.query
    /// </summary>
    public class AlipayOpenPublicMenuQueryRequest : IAopRequest<AlipayOpenPublicMenuQueryResponse>
    {
        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.open.public.menu.query";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            return parameters;
        }

        #endregion
    }
}
