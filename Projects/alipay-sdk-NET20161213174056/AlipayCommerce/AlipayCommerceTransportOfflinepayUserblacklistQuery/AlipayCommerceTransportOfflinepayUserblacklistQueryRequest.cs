using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.commerce.transport.offlinepay.userblacklist.query
    /// 脱机交易黑名单列表
    /// </summary>
    public class AlipayCommerceTransportOfflinepayUserblacklistQueryRequest : BizAopRequest<AlipayCommerceTransportOfflinepayUserblacklistQueryResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.commerce.transport.offlinepay.userblacklist.query";
        }

        public override IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("biz_content", this.BizContent);
            return parameters;
        }

        #endregion
    }
}
