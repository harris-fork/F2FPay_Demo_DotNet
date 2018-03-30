using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.open.public.label.query
    /// </summary>
    public class AlipayOpenPublicLabelQueryRequest : IAopRequest<AlipayOpenPublicLabelQueryResponse>
    {
        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.open.public.label.query";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            return parameters;
        }

        #endregion
    }
}
