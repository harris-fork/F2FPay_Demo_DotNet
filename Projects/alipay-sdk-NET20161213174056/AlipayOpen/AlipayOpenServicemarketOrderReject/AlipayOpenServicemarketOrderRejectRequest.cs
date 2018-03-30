using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.open.servicemarket.order.reject
    /// 服务商拒绝接单
    /// </summary>
    public class AlipayOpenServicemarketOrderRejectRequest : BizAopRequest<AlipayOpenServicemarketOrderRejectResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.open.servicemarket.order.reject";
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
