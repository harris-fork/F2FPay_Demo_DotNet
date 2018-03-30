using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.ebpp.merchant.config.get
    /// </summary>
    public class AlipayEbppMerchantConfigGetRequest : IAopRequest<AlipayEbppMerchantConfigGetResponse>
    {
        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.ebpp.merchant.config.get";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            return parameters;
        }

        #endregion
    }
}
