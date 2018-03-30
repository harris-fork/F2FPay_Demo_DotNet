using System;
using Aop.Api.Domain;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// alipay.trade.fastpay.refund.query
    /// 商户可使用该接口查询自已通过alipay.trade.refund提交的退款请求是否执行成功。
    /// </summary>
    public class AlipayTradeFastpayRefundQueryRequest : BizAopRequest<AlipayTradeFastpayRefundQueryResponse>
    {
        

        #region BizAopRequest Members

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
