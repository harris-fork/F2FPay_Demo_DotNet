using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.open.servicemarket.order.notify
    /// </summary>
    public class AlipayOpenServicemarketOrderNotifyRequest : IAopRequest<AlipayOpenServicemarketOrderNotifyResponse>
    {
        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.open.servicemarket.order.notify";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            return parameters;
        }

        #endregion
    }
}
