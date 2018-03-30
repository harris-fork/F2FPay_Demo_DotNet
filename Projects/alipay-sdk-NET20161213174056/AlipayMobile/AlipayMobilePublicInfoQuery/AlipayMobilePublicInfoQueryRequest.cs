using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.mobile.public.info.query
    /// </summary>
    public class AlipayMobilePublicInfoQueryRequest : IAopRequest<AlipayMobilePublicInfoQueryResponse>
    {
        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.mobile.public.info.query";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            return parameters;
        }

        #endregion
    }
}
