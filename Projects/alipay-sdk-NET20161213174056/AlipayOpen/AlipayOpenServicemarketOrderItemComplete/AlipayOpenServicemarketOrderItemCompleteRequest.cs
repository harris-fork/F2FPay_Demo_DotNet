using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.open.servicemarket.order.item.complete
    /// 服务商完成订单内单个明细实施操作
    /// </summary>
    public class AlipayOpenServicemarketOrderItemCompleteRequest : BizAopRequest<AlipayOpenServicemarketOrderItemCompleteResponse>
    {
        

        #region BizAopRequest Members

        public override string GetApiName()
        {
            return "alipay.open.servicemarket.order.item.complete";
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
