using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.open.public.info.query
    /// </summary>
    public class AlipayOpenPublicInfoQueryRequest : IAopRequest<AlipayOpenPublicInfoQueryResponse>
    {
        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.open.public.info.query";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            return parameters;
        }

        #endregion
    }
}
