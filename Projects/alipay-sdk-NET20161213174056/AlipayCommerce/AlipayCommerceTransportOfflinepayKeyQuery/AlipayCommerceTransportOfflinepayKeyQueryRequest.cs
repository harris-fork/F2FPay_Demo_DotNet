using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.commerce.transport.offlinepay.key.query
    /// </summary>
    public class AlipayCommerceTransportOfflinepayKeyQueryRequest : IAopRequest<AlipayCommerceTransportOfflinepayKeyQueryResponse>
    {
        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.commerce.transport.offlinepay.key.query";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            return parameters;
        }

        #endregion
    }
}
