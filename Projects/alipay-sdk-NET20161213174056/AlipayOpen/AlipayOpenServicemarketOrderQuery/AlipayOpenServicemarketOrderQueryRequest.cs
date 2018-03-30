using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.open.servicemarket.order.query
    /// </summary>
    public class AlipayOpenServicemarketOrderQueryRequest : IAopRequest<AlipayOpenServicemarketOrderQueryResponse>
    {
        /// <summary>
        /// 用于服务商回查服务市场订单明细信息
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.open.servicemarket.order.query";
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
