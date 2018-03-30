using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.open.servicemarket.order.item.cancel
    /// </summary>
    public class AlipayOpenServicemarketOrderItemCancelRequest : IAopRequest<AlipayOpenServicemarketOrderItemCancelResponse>
    {
        /// <summary>
        /// 服务订单明细实施项单项取消
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.open.servicemarket.order.item.cancel";
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
