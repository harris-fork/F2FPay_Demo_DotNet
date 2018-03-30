using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.mobile.public.menu.get
    /// </summary>
    public class AlipayMobilePublicMenuGetRequest : IAopRequest<AlipayMobilePublicMenuGetResponse>
    {
        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.mobile.public.menu.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            return parameters;
        }

        #endregion
    }
}
