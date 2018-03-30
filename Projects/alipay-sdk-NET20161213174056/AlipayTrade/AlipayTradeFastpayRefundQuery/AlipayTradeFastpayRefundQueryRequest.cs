using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.trade.fastpay.refund.query
    /// </summary>
    public class AlipayTradeFastpayRefundQueryRequest : IAopRequest<AlipayTradeFastpayRefundQueryResponse>
    {
        /// <summary>
        /// 商户可使用该接口查询自已通过alipay.trade.refund提交的退款请求是否执行成功。
        /// </summary>
        public string BizContent { get; set; }

        #region IAopRequest Members

        public override string GetApiName()
        {
            return "alipay.trade.fastpay.refund.query";
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
